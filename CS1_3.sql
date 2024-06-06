ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

GRANT CREATE VIEW TO ADMIN; 
GRANT CREATE ANY PROCEDURE TO ADMIN; 
GRANT EXECUTE ANY PROCEDURE TO ADMIN; 
--Thuc thi tren sys

CALL Drop_OldRole('RL_NHANVIENCOBAN');
CALL Drop_OldRole('RL_GIANGVIEN');
CALL Drop_OldRole('RL_GIAOVU');
/
--Tao role RL_NHANVIENCOBAN va them user vao role
CREATE ROLE RL_NHANVIENCOBAN;
EXEC USP_ADDUSRMEM ('RL_NHANVIENCOBAN', 'Nhan vien co ban');

--Tao role RL_GIANGVIEN
CREATE ROLE RL_GIANGVIEN;
--Them user vao role: Giang vien co quyen nhu Nhan vien co ban va quyen cua rieng minh
EXEC USP_ADDUSRMEM ('RL_NHANVIENCOBAN', 'Giang vien');
EXEC USP_ADDUSRMEM ('RL_GIANGVIEN', 'Giang vien');
/
--Tao role RL_GIAOVU
CREATE ROLE RL_GIAOVU;
--Them user vao role: Giang vien co quyen nhu Nhan vien co ban va quyen cua rieng minh
EXEC USP_ADDUSRMEM ('RL_NHANVIENCOBAN', 'Giao vu');
EXEC USP_ADDUSRMEM ('RL_GIAOVU', 'Giao vu');
/

--CS#1:
CONN ADMIN/group12;
--Tao view xem thong tin chinh minh trong quan he NHANSU
CREATE OR REPLACE VIEW UV_NVXEMTHONGTIN
AS
    SELECT *
    FROM ADMIN.TB_NHANSU
    WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');
/
--tao proc chinh sua DT cua chinh minh
CREATE OR REPLACE PROCEDURE USP_CHINHSODT (p_DT NVARCHAR2)
AS
BEGIN
    UPDATE ADMIN.TB_NHANSU
    SET DT = p_DT
    WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');
END;
/
--Cap quyen xem thong tin ca nhan va chinh sua so dt
GRANT SELECT ON ADMIN.UV_NVXEMTHONGTIN TO RL_NHANVIENCOBAN;
GRANT EXECUTE ON ADMIN.USP_CHINHSODT TO RL_NHANVIENCOBAN;

/
--Cap quyen Xem thong tin cua tat ca SV, DV, HP, KHMO
GRANT SELECT ON ADMIN.TB_SINHVIEN TO RL_NHANVIENCOBAN;
GRANT SELECT ON ADMIN.TB_DONVI TO RL_NHANVIENCOBAN;
GRANT SELECT ON ADMIN.TB_HOCPHAN TO RL_NHANVIENCOBAN;
GRANT SELECT ON ADMIN.TB_KHMO TO RL_NHANVIENCOBAN;
/

--CS#2:
CONN ADMIN/group12;
--Tao view xem phan cong giang day lien quan den minh
CREATE OR REPLACE VIEW UV_GVXEMPHANCONG
AS
    SELECT *
    FROM ADMIN.TB_PHANCONG
    WHERE MAGV = SYS_CONTEXT('USERENV', 'SESSION_USER');
/
--Tao view xem bang DANGKY lien quan den lop hoc phan duoc phan cong
CREATE OR REPLACE VIEW UV_GVXEMDANGKY
AS
    SELECT MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK
    FROM ADMIN.TB_DANGKY
    WHERE MAGV = SYS_CONTEXT('USERENV', 'SESSION_USER');
/
--Tao proc Cap nhat cac truong diem so (trong TB_DANGKY) cua SV co tham gia lop hoc phan duoc phan cong
CREATE OR REPLACE PROCEDURE USP_CAPNHATDIEMSV
(p_masv NVARCHAR2, p_mahp NVARCHAR2, p_hk NUMBER, p_nam NUMBER, p_mact NVARCHAR2,
p_diemTH NUMBER, p_diemQT NUMBER, p_diemCK NUMBER, p_diemTK NUMBER)
IS
BEGIN
    UPDATE ADMIN.TB_DANGKY
    SET DIEMTH = p_diemTH, DIEMQT = p_diemQT, DIEMCK = p_diemCK, DIEMTK = p_diemTK
    WHERE MAGV = SYS_CONTEXT('USERENV', 'SESSION_USER')
        AND MASV = p_masv 
        AND MAHP = p_mahp 
        AND HK = p_hk 
        AND NAM = p_nam 
        AND MACT = p_mact;
END;
/
--Cap quyen xem thong tin va cap nhat diem
GRANT SELECT ON UV_GVXEMPHANCONG TO RL_GIANGVIEN;
GRANT SELECT ON UV_GVXEMDANGKY TO RL_GIANGVIEN;
GRANT EXECUTE ON USP_CAPNHATDIEMSV TO RL_GIANGVIEN;
/

--CS#3:
--Cap quyen xem, them moi hoac cap nhat tren bang SV, DV, HP, KHMo cho RL_GIAOVU
GRANT SELECT, INSERT, UPDATE ON ADMIN.TB_SINHVIEN TO RL_GIAOVU;
GRANT SELECT, INSERT, UPDATE ON ADMIN.TB_DONVI TO RL_GIAOVU;
GRANT SELECT, INSERT, UPDATE ON ADMIN.TB_HOCPHAN TO RL_GIAOVU;
GRANT SELECT, INSERT, UPDATE ON ADMIN.TB_KHMO TO RL_GIAOVU;
/
--Tao trigger chinh sua phan cong do "Van phong khoa" phu trach phan cong
CREATE OR REPLACE TRIGGER UTR_CHINGSUAPHANCONG
BEFORE UPDATE ON ADMIN.TB_PHANCONG
FOR EACH ROW
DECLARE 
    v_tenDV NVARCHAR2(100);
BEGIN
    SELECT D.TENDV INTO v_tenDV
    FROM ADMIN.TB_DONVI D 
    JOIN ADMIN.TB_NHANSU N ON D.MADV = N.MADV
    WHERE N.MANV = :OLD.MAGV;
    
    IF v_tenDV != 'Van phong khoa' THEN
        RAISE_APPLICATION_ERROR(-20001, 'CHI CAP NHAT TREN DU LIEU DO VAN PHONG KHOA PHU TRACH');
    END IF;    
END;
/
--Cap quyen xem tren toan bo TB_PHANCONG va quyen chinh sua
GRANT SELECT, UPDATE ON ADMIN.TB_PHANCONG TO RL_GIAOVU;
/
--Tao trigger xoa hoac them DL tren TB_DANGKY trong thoi gian hieu chinh
--thoi gian hieu chinh khong qua 14 ngay so voi ngay bat dau hoc ky
CREATE OR REPLACE TRIGGER UTR_XOA_THEMDANGKY
BEFORE INSERT OR DELETE ON ADMIN.TB_DANGKY
FOR EACH ROW
DECLARE
    v_hk_start DATE;
    v_current DATE;
    v_hk NUMBER;
    v_nam NUMBER;
BEGIN
    v_current := SYSDATE;
    IF INSERTING THEN
        v_hk := :NEW.HK;
        v_nam := :NEW.NAM;
    ELSIF DELETING THEN
        v_hk := :OLD.HK;
        v_nam := :OLD.NAM;
    ELSE
        RAISE_APPLICATION_ERROR(-20003, 'CHI CHO PHEP INSERT HOAC DELETE.');
    END IF;
    IF v_hk = 1 THEN
        v_hk_start := TO_DATE('01-01-' || v_nam, 'DD-MM-YYYY');
    ELSIF v_hk = 2 THEN
        v_hk_start := TO_DATE('01-05-' || v_nam, 'DD-MM-YYYY');
    ELSIF v_hk = 3 THEN
        v_hk_start := TO_DATE('01-09-' || v_nam, 'DD-MM-YYYY');
    ELSE
        RAISE_APPLICATION_ERROR(-20002, 'HOC KY KHONG HOP LE.');
    END IF;
    IF v_current > v_hk_start + 14 THEN
        RAISE_APPLICATION_ERROR(-20002, 'KHONG THE HIEU CHINH DANG KY HOC PHAN SAU 14 NGAY TU NGAY BAT DAU HOC KY.');
    END IF;
END;
/
--Cap quyen xem, them va xoa tren TB_DANGKY cho RL_GIAOVU
GRANT SELECT, INSERT, DELETE ON ADMIN.TB_DANGKY TO RL_GIAOVU;
/
--Tao view cho giao vu xem ma va ho ten cua nhan su (phuc vu cac quyen cua giao vu)
CREATE OR REPLACE VIEW UV_GIAOVUXEMNHANSU
AS
SELECT MANV, HOTEN FROM ADMIN.TB_NHANSU;
/
--Cap view cho giao vu
GRANT SELECT ON UV_GIAOVUXEMNHANSU TO RL_GIAOVU;

