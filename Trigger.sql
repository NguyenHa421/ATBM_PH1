
--Tao user, cap quyen cho sinh vien moi
CREATE OR REPLACE TRIGGER grant_connect_on_insert_student
AFTER INSERT ON ADMIN.TB_SINHVIEN
FOR EACH ROW
DECLARE 
    v_password NVARCHAR2(10);
    pragma autonomous_transaction;
BEGIN
  -- Dynamically construct password based on student ID (assuming unique)
    v_password := :NEW.MASV;
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
  -- Execute immediate statements to create user and grant privileges
    EXECUTE IMMEDIATE 'CREATE USER '|| v_password||' IDENTIFIED BY ' || v_password;
    EXECUTE IMMEDIATE 'GRANT CONNECT TO '||v_password;
    EXECUTE IMMEDIATE 'GRANT RL_SINHVIEN TO '||v_password;
END;
/
--Tao user, cap quyen cho nhan vien moi
CREATE OR REPLACE TRIGGER grant_connect_on_insert_staff
AFTER INSERT ON ADMIN.TB_NHANSU
FOR EACH ROW
DECLARE 
    v_role NVARCHAR2(50);
    v_user NVARCHAR2(10);
    pragma autonomous_transaction;
BEGIN
  -- Dynamically construct password based on student ID (assuming unique)
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    v_user := :NEW.MANV;
    v_role := :NEW.VAITRO;
  -- Execute immediate statements to create user and grant privileges
    EXECUTE IMMEDIATE 'CREATE USER '|| v_user||' IDENTIFIED BY ' || v_user;
    EXECUTE IMMEDIATE 'GRANT CONNECT TO '||v_user;
    IF v_role = 'Nhan vien co ban' THEN
        EXECUTE IMMEDIATE 'GRANT RL_NHANVIENCOBAN TO '||v_user;
    ELSIF v_role = 'Giang vien' THEN
        EXECUTE IMMEDIATE 'GRANT RL_NHANVIENCOBAN TO '||v_user;
        EXECUTE IMMEDIATE 'GRANT RL_GIANGVIEN TO '||v_user;
    ELSIF v_role = 'Giao vu' THEN
        EXECUTE IMMEDIATE 'GRANT RL_NHANVIENCOBAN TO '||v_user;
        EXECUTE IMMEDIATE 'GRANT RL_GIAOVU TO '||v_user;
    END IF;
END;
/
--Thay doi truong don vi trong bang don vi
CREATE OR REPLACE TRIGGER update_unithead_null
BEFORE UPDATE ON ADMIN.TB_NHANSU
FOR EACH ROW
DECLARE 
    v_role NVARCHAR2(50);
BEGIN
    v_role := :NEW.VAITRO;
    IF v_role = 'Truong don vi' THEN
        UPDATE ADMIN.TB_DONVI
        SET TRGDV = NULL
        WHERE MADV = :NEW.MADV;
    END IF;
END;
/
--Xoa user cua nhan vien neu xoa nhan vien do
CREATE OR REPLACE TRIGGER employee_login_delete
BEFORE DELETE ON ADMIN.TB_NHANSU
FOR EACH ROW
DECLARE 
    v_user NVARCHAR2(10);
    pragma autonomous_transaction;
BEGIN
    v_user := :OLD.MANV;
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE 'DROP USER ' || v_user || ' CASCADE';
END;
/
--Doi quyen cho nhan vien khi truong khoa cap nhat
CREATE OR REPLACE TRIGGER revoke_connect_on_update_staff
BEFORE UPDATE ON ADMIN.TB_NHANSU
FOR EACH ROW
DECLARE 
    v_user NVARCHAR2(10);
    v_oldrole NVARCHAR2(10);
    pragma autonomous_transaction;
BEGIN
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
  -- Dynamically construct password based on student ID (assuming unique)
    v_user := :NEW.MANV;
    v_oldrole := :OLD.VAITRO;
    --Thu hoi quyen cu
    IF v_oldrole != :NEW.VAITRO THEN
        IF v_oldrole = 'Nhan vien co ban' THEN
            EXECUTE IMMEDIATE 'REVOKE RL_NHANVIENCOBAN FROM ' || v_user;
        ELSIF v_oldrole = 'Giang vien' THEN
            EXECUTE IMMEDIATE 'REVOKE RL_NHANVIENCOBAN FROM ' || v_user;
            EXECUTE IMMEDIATE 'REVOKE RL_GIANGVIEN FROM ' || v_user;
        ELSIF v_oldrole = 'Giao vu' THEN
            EXECUTE IMMEDIATE 'REVOKE RL_NHANVIENCOBAN FROM ' || v_user;
            EXECUTE IMMEDIATE 'REVOKE RL_GIAOVU FROM ' || v_user;
        ELSE
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.UV_NVXEMTHONGTIN FROM ' || v_user;
            EXECUTE IMMEDIATE 'REVOKE EXECUTE ON ADMIN.USP_CHINHSODT FROM ' || v_user;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.TB_SINHVIEN FROM ' || v_user;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.TB_DONVI FROM ' || v_user;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.TB_HOCPHAN FROM ' || v_user;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.TB_KHMO FROM ' || v_user;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.UV_GVXEMPHANCONG FROM ' || v_user;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.UV_GVXEMDANGKY FROM ' || v_user;
            EXECUTE IMMEDIATE 'REVOKE EXECUTE ON ADMIN.USP_CAPNHATDIEMSV FROM ' || v_user;
            EXECUTE IMMEDIATE 'REVOKE SELECT, INSERT, DELETE, UPDATE ON ADMIN.UV_TDVXEMPHANCONG FROM ' || v_user;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.UV_TDVXEMPHANCONG2 FROM ' || v_user;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.UV_XEMDANGKY FROM ' || v_user;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.TB_CHUONGTRINH FROM ' || v_user;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.TB_NGANH FROM ' || v_user;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.UV_XEMGIANGVIEN FROM ' || v_user;
        END IF;
    END IF;
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
END;
/
--Doi quyen cho nhan vien khi truong khoa cap nhat
CREATE OR REPLACE TRIGGER change_connect_on_update_staff
AFTER UPDATE ON ADMIN.TB_NHANSU
FOR EACH ROW
DECLARE 
    v_role NVARCHAR2(50);
    v_user NVARCHAR2(10);
    v_olduser NVARCHAR2(10);
    v_unit NVARCHAR2(5);
    pragma autonomous_transaction;
BEGIN
  -- Dynamically construct password based on student ID (assuming unique)
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    v_user := :NEW.MANV;
    v_role := :NEW.VAITRO;
    v_unit := :NEW.MADV;
    IF v_role != :OLD.VAITRO THEN
    --Cap quyen moi
        IF v_role = 'Truong don vi' THEN
            SELECT MANV INTO v_olduser FROM ADMIN.TB_NHANSU WHERE VAITRO = 'Truong don vi' AND MADV = v_unit;
            --Thu hoi quyen truong don vi cua user cu
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.UV_NVXEMTHONGTIN FROM ' || v_olduser;
            EXECUTE IMMEDIATE 'REVOKE EXECUTE ON ADMIN.USP_CHINHSODT FROM ' || v_olduser;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.TB_SINHVIEN FROM ' || v_olduser;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.TB_DONVI FROM ' || v_olduser;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.TB_HOCPHAN FROM ' || v_olduser;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.TB_KHMO FROM ' || v_olduser;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.UV_GVXEMPHANCONG FROM ' || v_olduser;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.UV_GVXEMDANGKY FROM ' || v_olduser;
            EXECUTE IMMEDIATE 'REVOKE EXECUTE ON ADMIN.USP_CAPNHATDIEMSV FROM ' || v_olduser;
            EXECUTE IMMEDIATE 'REVOKE SELECT, INSERT, DELETE, UPDATE ON ADMIN.UV_TDVXEMPHANCONG FROM ' || v_olduser;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.UV_TDVXEMPHANCONG2 FROM ' || v_olduser;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.UV_XEMDANGKY FROM ' || v_olduser;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.TB_CHUONGTRINH FROM ' || v_olduser;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.TB_NGANH FROM ' || v_olduser;
            EXECUTE IMMEDIATE 'REVOKE SELECT ON ADMIN.UV_XEMGIANGVIEN FROM ' || v_olduser;
            --Cap quyen lai cho user moi cap nhat
            EXECUTE IMMEDIATE 'GRANT SELECT ON ADMIN.UV_NVXEMTHONGTIN TO ' || v_user;
            EXECUTE IMMEDIATE 'GRANT EXECUTE ON ADMIN.USP_CHINHSODT TO ' || v_user;
            EXECUTE IMMEDIATE 'GRANT SELECT ON ADMIN.TB_SINHVIEN TO ' || v_user;
            EXECUTE IMMEDIATE 'GRANT SELECT ON ADMIN.TB_DONVI TO ' || v_user;
            EXECUTE IMMEDIATE 'GRANT SELECT ON ADMIN.TB_HOCPHAN TO ' || v_user;
            EXECUTE IMMEDIATE 'GRANT SELECT ON ADMIN.TB_KHMO TO ' || v_user;
            EXECUTE IMMEDIATE 'GRANT SELECT ON ADMIN.UV_GVXEMPHANCONG TO ' || v_user;
            EXECUTE IMMEDIATE 'GRANT SELECT ON ADMIN.UV_GVXEMDANGKY TO ' || v_user;
            EXECUTE IMMEDIATE 'GRANT EXECUTE ON ADMIN.USP_CAPNHATDIEMSV TO ' || v_user;
            EXECUTE IMMEDIATE 'GRANT SELECT, INSERT, DELETE, UPDATE ON ADMIN.UV_TDVXEMPHANCONG TO ' || v_user;
            EXECUTE IMMEDIATE 'GRANT SELECT ON ADMIN.UV_TDVXEMPHANCONG2 TO ' || v_user;
            EXECUTE IMMEDIATE 'GRANT SELECT ON ADMIN.UV_XEMDANGKY TO ' ||v_user;
            EXECUTE IMMEDIATE 'GRANT SELECT ON ADMIN.TB_CHUONGTRINH TO ' || v_user;
            EXECUTE IMMEDIATE 'GRANT SELECT ON ADMIN.TB_NGANH TO ' || v_user;
            EXECUTE IMMEDIATE 'GRANT SELECT ON ADMIN.UV_XEMGIANGVIEN TO ' || v_user;
            
            --Cap quyen lai cho truong don vi cu thanh giang vien
            EXECUTE IMMEDIATE 'GRANT RL_NHANVIENCOBAN TO '||v_olduser;
            EXECUTE IMMEDIATE 'GRANT RL_GIANGVIEN TO ' || v_olduser;
            
            --Update lai truong don vi
            UPDATE ADMIN.TB_DONVI
            SET TRGDV = v_user
            WHERE MADV = :NEW.MADV;
        ELSE
            IF v_role = 'Nhan vien co ban' THEN
                EXECUTE IMMEDIATE 'GRANT RL_NHANVIENCOBAN TO '||v_user;
            ELSIF v_role = 'Giang vien' THEN
                EXECUTE IMMEDIATE 'GRANT RL_NHANVIENCOBAN TO '||v_user;
                EXECUTE IMMEDIATE 'GRANT RL_GIANGVIEN TO '||v_user;
            ELSE
                EXECUTE IMMEDIATE 'GRANT RL_NHANVIENCOBAN TO '||v_user;
                EXECUTE IMMEDIATE 'GRANT RL_GIAOVU TO '||v_user;
            END IF;
        END IF;
    END IF;
END;
/
--Tao nhan vien moi
CONN NV107/NV107;
INSERT INTO ADMIN.TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) 
VALUES ('NV108', 'Nguyen An', 'Male', TO_DATE('1970-1-1', 'YYYY-MM-DD'), 20000, '0144016021', 'Giao vu', 'DV01');
--Kiem tra kha nang xem thong tin cua rl_nhan vien co ban
CONN NV108/NV108;
SELECT * FROM ADMIN.UV_NVXEMTHONGTIN;
-- Kiem tra kha nang cap nhat sinh vien cua rl_giao vu
CONN NV108/NV108;
UPDATE ADMIN.TB_SINHVIEN SET HOTEN = 'Nguyen Ha' WHERE MASV = 'SV120238';
-- Kiem tra cap nhat
SELECT * FROM ADMIN.TB_SINHVIEN WHERE MASV = 'SV120238';
-- Thay doi role cua NV108
CONN NV107/NV107;
UPDATE ADMIN.TB_NHANSU SET VAITRO = 'Giang vien' WHERE MANV = 'NV108';

select * from DBA_ROLE_PRIVS where grantee = 'NV108';

--Kiem tra vai tro moi
CONN NV108/NV108;
SELECT * FROM ADMIN.UV_NVXEMTHONGTIN;
-- Kiem tra lai kha nang cap nhat sinh vien cua rl_giao vu
CONN NV108/NV108;
UPDATE ADMIN.TB_SINHVIEN SET HOTEN = 'Nguyen Thu Ha' WHERE MASV = 'SV120238';
-- Kiem tra cap nhat
SELECT * FROM ADMIN.TB_SINHVIEN WHERE MASV = 'SV120238';
--Thu hoi thu cong
REVOKE RL_GIAOVU FROM NV108;
REVOKE RL_NHANVIENCOBAN FROM NV108;
--Xoa nhan vien NV108, tu dong xoa user
CONN NV107/NV107;
DELETE FROM ADMIN.TB_NHANSU WHERE MANV = 'NV108';
--Xoa thu cong user 108
DROP USER NV108;

CONN ADMIN/group12;

ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;