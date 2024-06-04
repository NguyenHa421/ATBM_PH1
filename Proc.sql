CREATE OR REPLACE PROCEDURE find_role(user_name IN VARCHAR2)
AUTHID CURRENT_USER
AS
    v_role VARCHAR2(50);
BEGIN 
    IF v_role IS NULL THEN
        SELECT 'Sinh vien' INTO v_role FROM ADMIN.TB_SINHVIEN WHERE MASV = user_name;
    END IF;
    
    IF v_role IS NULL THEN
        SELECT VAITRO INTO v_role FROM ADMIN.TB_NHANSU WHERE MANV = user_name;
    END IF;
    
    IF v_role IS NULL THEN
        SELECT 'He thong' INTO v_role FROM dba_users WHERE username = user_name;
    END IF;
END;
/
CALL FIND_ROLE('SV126109');
CALL FIND_ROLE('NV100');

CREATE OR REPLACE PROCEDURE find_name(user_id IN VARCHAR2)
AUTHID CURRENT_USER
AS
    name_student VARCHAR2(100);
BEGIN 
    SELECT HOTEN INTO name_student FROM ADMIN.TB_SINHVIEN WHERE MASV = user_id;
    IF name_student IS NULL THEN
        DBMS_OUTPUT.put_line('Khong ton tai');
    ELSE
        DBMS_OUTPUT.put_line(name_student);
    END IF;
END;
/
CALL find_name('SV120238');
SET SERVEROUTPUT ON;
