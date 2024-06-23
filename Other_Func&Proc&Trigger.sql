--Tao tai khoan, cap quyen cho sinh vien khi tao mot sinh vien moi
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
--Tao tai khoan, cap quyen cho nhan vien khi tao mot nhan vien moi
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
--Xoa tai khoan cua nhan vien neu xoa nhan vien do
CREATE OR REPLACE TRIGGER employee_login_delete
AFTER DELETE ON ADMIN.TB_NHANSU
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
--Cap quyen cho giang vien duoc de bat len lam truong don vi moi khi tao don vi moi
CREATE OR REPLACE TRIGGER grant_connect_on_insert_unit
AFTER INSERT ON ADMIN.TB_DONVI
FOR EACH ROW
DECLARE 
    v_user NVARCHAR2(10);
    v_unit NVARCHAR2(10);
    pragma autonomous_transaction;
BEGIN 
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
-- Dynamically construct password based on student ID (assuming unique)
    v_user := :NEW.TRGDV;
    v_unit := :NEW.MADV;
    EXECUTE IMMEDIATE 'REVOKE RL_NHANVIENCOBAN FROM ' || v_user;
    EXECUTE IMMEDIATE 'REVOKE RL_GIANGVIEN FROM ' || v_user;
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
    UPDATE ADMIN.UV_XEMGIANGVIEN SET VAITRO = 'Truong don vi' WHERE MANV = v_user;
    COMMIT;
    UPDATE ADMIN.UV_XEMGIANGVIEN SET MADV = v_unit WHERE MANV = v_user;
    COMMIT;
END;
/
--Khi cap nhat truong don vi cua mot don vi, truong don vi cu se tro thanh giang vien, giang vien duoc 
--de bat len lam truong don vi, cap quyen va thu hoi quyen cho 2 user tren
CREATE OR REPLACE TRIGGER grant_TDV_on_update_unit
AFTER UPDATE ON ADMIN.TB_DONVI
FOR EACH ROW
DECLARE 
    v_user NVARCHAR2(10);
    v_olduser NVARCHAR2(10);
    v_unit NVARCHAR2(10);
    pragma autonomous_transaction;
BEGIN
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    -- Dynamically construct password based on student ID (assuming unique)
    v_user := :NEW.TRGDV;
    v_olduser := :OLD.TRGDV;
    v_unit := :NEW.MADV;
    IF v_user != v_olduser THEN
        EXECUTE IMMEDIATE 'REVOKE RL_NHANVIENCOBAN FROM ' || v_user;
        EXECUTE IMMEDIATE 'REVOKE RL_GIANGVIEN FROM ' || v_user;
        
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
        
        EXECUTE IMMEDIATE 'GRANT RL_NHANVIENCOBAN TO ' || v_olduser;
        EXECUTE IMMEDIATE 'GRANT RL_GIANGVIEN TO ' || v_olduser;
        UPDATE ADMIN.UV_XEMGIANGVIEN SET VAITRO = 'Giang vien' WHERE MANV = v_olduser;
        COMMIT;
        UPDATE ADMIN.UV_XEMGIANGVIEN SET VAITRO = 'Truong don vi' WHERE MANV = v_user;
        COMMIT;
        UPDATE ADMIN.UV_XEMGIANGVIEN SET MADV = v_unit WHERE MANV = v_user;
        COMMIT;
    END IF;
END;
/

--Tao id tu dong tang cho sinh vien
CONN ADMIN/group12;
CREATE OR REPLACE FUNCTION CREATE_IDSTUDENT(p_MACT IN VARCHAR2)
RETURN NVARCHAR2
IS
    ID NVARCHAR2(10);
    ID_pre NVARCHAR2(6);
    ID_suff NUMBER(4);
    last_student_id NVARCHAR2(10);
BEGIN
    IF p_MACT = 'CQ' THEN
        ID_pre := 'SV120';
    ELSIF p_MACT = 'CLC' THEN
        ID_pre := 'SV127';
    ELSIF p_MACT = 'CTTT' THEN
        ID_pre := 'SV125';
    ELSIF p_MACT = 'VP' THEN
        ID_pre := 'SV126';
    END IF;
    
    SELECT MASV INTO last_student_id
    FROM ADMIN.TB_SINHVIEN
    WHERE MACT = p_MACT
    ORDER BY TO_NUMBER(SUBSTR(MASV, -3)) DESC
    FETCH FIRST 1 ROWS ONLY;
    
    IF last_student_id IS NULL THEN
        ID_suff := '000';
    ELSE
        ID_suff := TO_NUMBER(SUBSTR(last_student_id, -3)) + 1;
    END IF;
    ID := ID_pre || LPAD(TO_CHAR(ID_suff), 3, '0');
    RETURN ID;
END CREATE_IDSTUDENT;
/
GRANT EXECUTE ON ADMIN.CREATE_IDSTUDENT TO RL_GIAOVU;
/

--Tao id tu dong tang cho nhan vien
CONN ADMIN/group12;
CREATE OR REPLACE FUNCTION CREATE_IDSTAFF
RETURN NVARCHAR2
IS
    ID NVARCHAR2(10);
    ID_pre NVARCHAR2(6);
    ID_suff NUMBER(4);
    last_staff_id NVARCHAR2(10);
BEGIN
    ID_pre := 'NV';
    SELECT MANV INTO last_staff_id
    FROM ADMIN.TB_NHANSU
    ORDER BY TO_NUMBER(SUBSTR(MANV, -3)) DESC
    FETCH FIRST 1 ROWS ONLY;
    
    IF last_staff_id IS NULL THEN
        ID_suff := '000';
    ELSE
        ID_suff := TO_NUMBER(SUBSTR(last_staff_id, -3)) + 1;
    END IF;
    ID := ID_pre || LPAD(TO_CHAR(ID_suff), 3, '0');
    RETURN ID;
END CREATE_IDSTAFF;
/
GRANT EXECUTE ON ADMIN.CREATE_IDSTAFF TO NV107;
/
