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
    v_user := :NEW.MANV;
    v_role := :NEW.VAITRO;
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
  -- Execute immediate statements to create user and grant privileges
    EXECUTE IMMEDIATE 'CREATE USER '|| v_user||' IDENTIFIED BY ' || v_user;
    EXECUTE IMMEDIATE 'GRANT CONNECT TO '||v_user;
    IF v_role = 'Nhan vien co ban' THEN
        EXECUTE IMMEDIATE 'GRANT RL_NHANVIENCOBAN TO '||v_user;
    ELSIF v_role = 'Giang vien' THEN
        EXECUTE IMMEDIATE 'GRANT RL_NHANVIENCOBAN TO '||v_user;
        EXECUTE IMMEDIATE 'GRANT RL_GIANGVIEN TO '||v_user;
    ELSE
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

--Doi quyen cho nhan vien khi truong khoa cap nhat
CREATE OR REPLACE TRIGGER change_connect_on_update_staff
AFTER UPDATE ON ADMIN.TB_NHANSU
FOR EACH ROW
DECLARE 
    v_role NVARCHAR2(50);
    v_user NVARCHAR2(10);
    v_olduser NVARCHAR2(10);
    v_oldrole NVARCHAR2(10);
    v_unit NVARCHAR2(5);
    pragma autonomous_transaction;
BEGIN
  -- Dynamically construct password based on student ID (assuming unique)
    v_user := :NEW.MANV;
    v_role := :NEW.VAITRO;
    v_unit := :NEW.MADV;
    v_oldrole := :OLD.VAITRO;
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE 'REVOKE ALL PRIVILEGES FROM ' || v_user;
    IF v_role = 'Truong don vi' THEN
        SELECT MANV INTO v_olduser FROM ADMIN.TB_NHANSU WHERE VAITRO = 'Truong don vi' AND MADV = v_unit;
        EXECUTE IMMEDIATE 'REVOKE ALL PRIVILEGES FROM ' || v_olduser;
        --Cap quyen lai cho user moi cap nhat
        EXECUTE IMMEDIATE 'GRANT CONNECT TO ' || v_user;
        EXECUTE IMMEDIATE 'EXEC USP_GANQUYEN_NVCB (' || v_user || ')';
        EXECUTE IMMEDIATE 'EXEC USP_GANQUYEN_GV (' || v_user || ')';
        EXECUTE IMMEDIATE 'GRANT SELECT, INSERT, DELETE, UPDATE ON UV_TDVXEMPHANCONG TO ' || v_user;
        EXECUTE IMMEDIATE 'GRANT SELECT ON UV_TDVXEMPHANCONG2 TO ' || v_user;
        EXECUTE IMMEDIATE 'GRANT SELECT ON UV_XEMDANGKY TO ' ||v_user;
        EXECUTE IMMEDIATE 'GRANT SELECT ON ADMIN.TB_CHUONGTRINH TO ' || v_user;
        EXECUTE IMMEDIATE 'GRANT SELECT ON ADMIN.TB_NGANH TO ' || v_user;
        EXECUTE IMMEDIATE 'GRANT SELECT ON UV_XEMGIANGVIEN TO ' || v_user;
        
        --Cap quyen lai cho truong don vi cu thanh giang vien
        EXECUTE IMMEDIATE 'GRANT CONNECT TO ' || v_olduser;
        EXECUTE IMMEDIATE 'GRANT RL_GIANGVIEN TO ' || v_olduser;
        --Update lai truong don vi
        UPDATE ADMIN.TB_DONVI
        SET TRGDV = v_user
        WHERE MADV = :NEW.MADV;
    ELSE
        IF v_role = 'Nhan vien co ban' THEN
            EXECUTE IMMEDIATE 'GRANT RL_NHANVIENCOBAN TO '||v_user;
        ELSIF v_role = 'Giang vien' THEN
            EXECUTE IMMEDIATE 'GRANT RL_GIANGVIEN TO '||v_user;
        ELSE
            EXECUTE IMMEDIATE 'GRANT RL_GIAOVU TO '||v_user;
        END IF;
    END IF;
END;
/
