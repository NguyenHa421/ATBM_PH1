conn ADMIN/group12
-- CS#4: 
-- YC1

CREATE OR REPLACE PROCEDURE USP_GANQUYEN_NVCB
(user_name VARCHAR2)
AS
BEGIN
    EXECUTE IMMEDIATE ('GRANT SELECT ON ADMIN.UV_NVXEMTHONGTIN TO '||user_name);
    EXECUTE IMMEDIATE ('GRANT EXECUTE ON ADMIN.USP_CHINHSODT TO '||user_name);
    EXECUTE IMMEDIATE ('GRANT SELECT ON ADMIN.TB_SINHVIEN TO '||user_name);
    EXECUTE IMMEDIATE ('GRANT SELECT ON ADMIN.TB_DONVI TO '||user_name);
    EXECUTE IMMEDIATE ('GRANT SELECT ON ADMIN.TB_HOCPHAN TO '||user_name);
    EXECUTE IMMEDIATE ('GRANT SELECT ON ADMIN.TB_KHMO TO '||user_name);
END;
/
EXEC USP_GANQUYEN_NVCB('NV101');
EXEC USP_GANQUYEN_NVCB('NV102');
EXEC USP_GANQUYEN_NVCB('NV103');
EXEC USP_GANQUYEN_NVCB('NV104');
EXEC USP_GANQUYEN_NVCB('NV105');
EXEC USP_GANQUYEN_NVCB('NV106');
/
CREATE OR REPLACE PROCEDURE USP_GANQUYEN_GV
(user_name VARCHAR2)
AS
BEGIN
    EXECUTE IMMEDIATE ('GRANT SELECT ON UV_GVXEMPHANCONG TO '||user_name);
    EXECUTE IMMEDIATE ('GRANT SELECT ON UV_GVXEMDANGKY TO '||user_name);
    EXECUTE IMMEDIATE ('GRANT EXECUTE ON USP_CAPNHATDIEMSV TO '||user_name);
END;
/
EXEC USP_GANQUYEN_GV('NV101');
EXEC USP_GANQUYEN_GV('NV102');
EXEC USP_GANQUYEN_GV('NV103');
EXEC USP_GANQUYEN_GV('NV104');
EXEC USP_GANQUYEN_GV('NV105');
EXEC USP_GANQUYEN_GV('NV106');

-- YC2
/
CREATE OR REPLACE VIEW UV_TDVXEMPHANCONG AS
    SELECT *
    FROM TB_PHANCONG
    WHERE MaHP IN (
                SELECT HP.MaHP 
                FROM TB_HOCPHAN HP, TB_DONVI DV
                WHERE HP.MADV = DV.MADV
                AND DV.TRGDV = SYS_CONTEXT('USERENV', 'SESSION_USER'));
                
GRANT INSERT, DELETE, UPDATE ON UV_TDVXEMPHANCONG TO NV101;
GRANT INSERT, DELETE, UPDATE ON UV_TDVXEMPHANCONG TO NV102;
GRANT INSERT, DELETE, UPDATE ON UV_TDVXEMPHANCONG TO NV103;
GRANT INSERT, DELETE, UPDATE ON UV_TDVXEMPHANCONG TO NV104;
GRANT INSERT, DELETE, UPDATE ON UV_TDVXEMPHANCONG TO NV105;
GRANT INSERT, DELETE, UPDATE ON UV_TDVXEMPHANCONG TO NV106;

-- YC3
CREATE OR REPLACE VIEW UV_TDVXEMPHANCONG2 AS
    SELECT PC.*, NS.HOTEN
    FROM TB_PHANCONG PC, TB_NHANSU NS
    WHERE PC.MAGV = NS.MANV
    AND MaHP IN (
                SELECT HP.MaHP 
                FROM TB_HOCPHAN HP, TB_DONVI DV
                WHERE HP.MADV = DV.MADV
                AND DV.TRGDV = SYS_CONTEXT('USERENV', 'SESSION_USER'));
                
GRANT SELECT ON UV_TDVXEMPHANCONG2 TO NV101;
GRANT SELECT ON UV_TDVXEMPHANCONG2 TO NV102;
GRANT SELECT ON UV_TDVXEMPHANCONG2 TO NV103;
GRANT SELECT ON UV_TDVXEMPHANCONG2 TO NV104;
GRANT SELECT ON UV_TDVXEMPHANCONG2 TO NV105;
GRANT SELECT ON UV_TDVXEMPHANCONG2 TO NV106;

/
-- CS#5
--YC1
EXEC USP_GANQUYEN_NVCB('NV101');
EXEC USP_GANQUYEN_GV('NV107');

-- YC2
CREATE OR REPLACE VIEW UV_TKXEMPHANCONG AS
    SELECT *
    FROM TB_PHANCONG
    WHERE MaHP IN (
                SELECT HP.MaHP 
                FROM TB_HOCPHAN HP, TB_DONVI DV
                WHERE HP.MADV = DV.MADV
                AND DV.TENDV = 'Van phong khoa');
/

CREATE OR REPLACE TRIGGER UTR_DEL_PHANCONG
BEFORE DELETE
ON TB_PHANCONG
FOR EACH ROW
BEGIN
    DELETE FROM TB_DANGKY
    WHERE MAGV = :OLD.MAGV
    AND MAHP = :OLD.MAHP
    AND HK = :OLD.HK
    AND NAM = :OLD.NAM
    AND MACT = :OLD.MACT;
END; 
/
CREATE OR REPLACE TRIGGER UTR_UPD_PHANCONG
BEFORE UPDATE
ON TB_PHANCONG
FOR EACH ROW
BEGIN
    UPDATE TB_DANGKY
    SET MAGV = :NEW.MAGV,
        MAHP = :NEW.MAHP,
        HK = :NEW.HK,
        NAM = :NEW.NAM,
        MACT = :NEW.MACT
    WHERE MAGV = :OLD.MAGV
    AND MAHP = :OLD.MAHP
    AND HK = :OLD.HK
    AND NAM = :OLD.NAM
    AND MACT = :OLD.MACT;
END;

/

GRANT SELECT, INSERT, DELETE, UPDATE ON ADMIN.UV_TKXEMPHANCONG TO NV107;
/
-- YV3
GRANT SELECT, INSERT, DELETE, UPDATE ON ADMIN.TB_NHANSU TO NV107;
-- YC4 ????????????
/
GRANT SELECT ANY TABLE TO NV107

-- CS#6

/
-- fun1
CREATE OR REPLACE FUNCTION SV_FUN1
 (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2)
RETURN VARCHAR2
AS
    p_user VARCHAR2(100);
    return_value VARCHAR2(100); 
BEGIN
    SELECT SYS_CONTEXT('USERENV', 'SESSION_USER') INTO p_user FROM DUAL;
    IF SUBSTR(p_user,0,1) != 'N' THEN
        return_value := 'MASV = SYS_CONTEXT(''USERENV'', ''SESSION_USER'')';
    ELSE
        return_value := '1 = 1';
    END IF;
    RETURN return_value;
END;

/
BEGIN
    DBMS_RLS.DROP_POLICY(
     OBJECT_SCHEMA =>'ADMIN',
     OBJECT_NAME =>'TB_SINHVIEN',
     POLICY_NAME =>'SV_1');
EXCEPTION
    WHEN OTHERS THEN
        NULL;
END;
/
BEGIN
     DBMS_RLS.ADD_POLICY(
     OBJECT_SCHEMA =>'ADMIN',
     OBJECT_NAME =>'TB_SINHVIEN',
     POLICY_NAME =>'SV_1',
     POLICY_FUNCTION=>'SV_FUN1',
     STATEMENT_TYPES=>'SELECT'
 );
EXCEPTION
    WHEN OTHERS THEN
        NULL;
END;
/
GRANT SELECT ON TB_SINHVIEN TO RL_SINHVIEN;

/
BEGIN
    DBMS_RLS.DROP_POLICY(
     OBJECT_SCHEMA =>'ADMIN',
     OBJECT_NAME =>'TB_SINHVIEN',
     POLICY_NAME =>'SV_2');
EXCEPTION
    WHEN OTHERS THEN
        NULL;
END;
/
BEGIN
     DBMS_RLS.ADD_POLICY(
     OBJECT_SCHEMA =>'ADMIN',
     OBJECT_NAME =>'TB_SINHVIEN',
     POLICY_NAME =>'SV_2',
     POLICY_FUNCTION=>'SV_FUN1',
     STATEMENT_TYPES=>'UPDATE',
     SEC_RELEVANT_COLS => 'DCHI, DT',
     UPDATE_CHECK => TRUE
 );
EXCEPTION
    WHEN OTHERS THEN
        NULL;
END;
/
GRANT UPDATE ON TB_SINHVIEN TO RL_SINHVIEN;

-- fun 2
CREATE OR REPLACE FUNCTION SV_FUN2
 (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2)
RETURN VARCHAR2
AS
    p_user VARCHAR2(100);
    return_value VARCHAR2(100); 
BEGIN
    SELECT SYS_CONTEXT('USERENV', 'SESSION_USER') INTO p_user FROM DUAL;
    IF SUBSTR(p_user,0,1) != 'N' THEN
        return_value := ' MAHP IN (  SELECT MAHP 
                                     FROM ADMIN.TB_KHMO)';
    ELSE
        return_value := '1 = 1';
    END IF;
    RETURN return_value;
END; 
/
-- fun3
CREATE OR REPLACE FUNCTION SV_FUN3
 (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2)
RETURN VARCHAR2
AS
    p_user VARCHAR2(100);
    return_value VARCHAR2(100); 
BEGIN
    SELECT SYS_CONTEXT('USERENV', 'SESSION_USER') INTO p_user FROM DUAL;
    IF SUBSTR(p_user,0,1) != 'N' THEN
        return_value := ' MACT IN (  SELECT MACT
                                    FROM ADMIN.TB_SINHVIEN)';
    ELSE
        return_value := '1 = 1';
    END IF;
    RETURN return_value;
END; 
/

BEGIN
    DBMS_RLS.DROP_POLICY(
     OBJECT_SCHEMA =>'ADMIN',
     OBJECT_NAME =>'TB_HOCPHAN',
     POLICY_NAME =>'SV_3');
EXCEPTION
    WHEN OTHERS THEN
        NULL;
END;
/
BEGIN
     DBMS_RLS.ADD_POLICY(
     OBJECT_SCHEMA =>'ADMIN',
     OBJECT_NAME =>'TB_HOCPHAN',
     POLICY_NAME =>'SV_3',
     POLICY_FUNCTION=>'SV_FUN2',
     STATEMENT_TYPES=>'SELECT'
 );
EXCEPTION
    WHEN OTHERS THEN
        NULL;
END;
/
GRANT SELECT ON TB_HOCPHAN TO RL_SINHVIEN;
GRANT SELECT ON TB_KHMO TO RL_SINHVIEN;

/
BEGIN
    DBMS_RLS.DROP_POLICY(
     OBJECT_SCHEMA =>'ADMIN',
     OBJECT_NAME =>'TB_KHMO',
     POLICY_NAME =>'SV_4');
EXCEPTION
    WHEN OTHERS THEN
        NULL;
END;
/
BEGIN
     DBMS_RLS.ADD_POLICY(
     OBJECT_SCHEMA =>'ADMIN',
     OBJECT_NAME =>'TB_KHMO',
     POLICY_NAME =>'SV_4',
     POLICY_FUNCTION=>'SV_FUN3',
     STATEMENT_TYPES=>'SELECT',
     UPDATE_CHECK => TRUE
 );
EXCEPTION
    WHEN OTHERS THEN
        NULL;
END;
/

CREATE OR REPLACE FUNCTION SV_FUN4 (
    schema_name IN VARCHAR2,
    table_name IN VARCHAR2)
RETURN VARCHAR2 AS
    v_hocky NUMBER;
    v_ngaybatdau DATE;
    v_nam NUMBER;
    p_user VARCHAR2(100);
    return_value VARCHAR2(2000); 
BEGIN
    SELECT SYS_CONTEXT('USERENV', 'SESSION_USER') INTO p_user FROM DUAL;
    IF SUBSTR(p_user,0,1) != 'N' THEN
        IF TO_NUMBER(TO_CHAR(SYSDATE, 'MM')) BETWEEN 1 AND 4 THEN
            v_hocky := 1;
            v_ngaybatdau := TO_DATE(TO_CHAR(SYSDATE, 'YYYY') || '-01-01', 'YYYY-MM-DD');
        ELSIF TO_NUMBER(TO_CHAR(SYSDATE, 'MM')) BETWEEN 5 AND 8 THEN
            v_hocky := 2;
            v_ngaybatdau := TO_DATE(TO_CHAR(SYSDATE, 'YYYY') || '-05-01', 'YYYY-MM-DD');
        ELSE
            v_hocky := 3;
            v_ngaybatdau := TO_DATE(TO_CHAR(SYSDATE, 'YYYY') || '-09-01', 'YYYY-MM-DD');
        END IF;
        v_nam := TO_NUMBER(TO_CHAR(SYSDATE,'YYYY'));
        return_value :=  '  MASV = SYS_CONTEXT(''USERENV'', ''SESSION_USER'') 
                            AND HK = ' || v_hocky || '
                            AND NAM = ' || v_nam || '
                            AND SYSDATE <= TO_DATE( '''|| TO_CHAR(v_ngaybatdau, 'YYYY-MM-DD') ||''' , ''YYYY-MM-DD'') + 14';
    ELSE
        return_value := '1 = 1';
    END IF;
    
    RETURN return_value;
END;
/
BEGIN
    DBMS_RLS.DROP_POLICY(
     OBJECT_SCHEMA =>'ADMIN',
     OBJECT_NAME =>'TB_DANGKY',
     POLICY_NAME =>'SV_5'
);
EXCEPTION
    WHEN OTHERS THEN
        NULL;
END;
/
BEGIN
     DBMS_RLS.ADD_POLICY(
     OBJECT_SCHEMA =>'ADMIN',
     OBJECT_NAME =>'TB_DANGKY',
     POLICY_NAME =>'SV_5',
     POLICY_FUNCTION=>'SV_FUN4',
     STATEMENT_TYPES=>'DELETE'
 );
EXCEPTION
    WHEN OTHERS THEN
        NULL;
END;
/
BEGIN
    DBMS_RLS.DROP_POLICY(
     OBJECT_SCHEMA =>'ADMIN',
     OBJECT_NAME =>'TB_DANGKY',
     POLICY_NAME =>'SV_7'
);
EXCEPTION
    WHEN OTHERS THEN
        NULL;
END;
/
BEGIN
     DBMS_RLS.ADD_POLICY(
     OBJECT_SCHEMA =>'ADMIN',
     OBJECT_NAME =>'TB_DANGKY',
     POLICY_NAME =>'SV_7',
     POLICY_FUNCTION=>'SV_FUN4',
     STATEMENT_TYPES=>'INSERT',
     UPDATE_CHECK=>TRUE
 );
EXCEPTION
    WHEN OTHERS THEN
        NULL;
END;
/
GRANT SELECT, INSERT, DELETE ON TB_DANGKY TO RL_SINHVIEN
/

BEGIN
    DBMS_RLS.DROP_POLICY(
     OBJECT_SCHEMA =>'ADMIN',
     OBJECT_NAME =>'TB_DANGKY',
     POLICY_NAME =>'SV_6');
EXCEPTION
    WHEN OTHERS THEN
        NULL;
END;
/
BEGIN
     DBMS_RLS.ADD_POLICY(
     OBJECT_SCHEMA =>'ADMIN',
     OBJECT_NAME =>'TB_DANGKY',
     POLICY_NAME =>'SV_6',
     POLICY_FUNCTION=>'SV_FUN1',
     STATEMENT_TYPES=>'SELECT'
 );
EXCEPTION
    WHEN OTHERS THEN
        NULL;
END;
--Mot so quyen khac
--Giao vu co the xem bang chuong trinh, bang nganh:
GRANT SELECT ON ADMIN.TB_CHUONGTRINH TO RL_GIAOVU;
GRANT SELECT ON ADMIN.TB_NGANH TO RL_GIAOVU;
