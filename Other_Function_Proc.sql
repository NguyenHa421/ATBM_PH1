--Tao id tu dong cho sinh vien
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
CONN ADMIN/group12;

--Tao user, cap quyen cho sinh vien moi
