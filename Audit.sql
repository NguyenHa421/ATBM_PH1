--kiem tra gia tri audit_trail
SHOW PARAMETER AUDIT_TRAIL;
--neu gia tri cua audit_trail khong phai DB thi thuc hien cac cau lenh sau de cap nhat
--ALTER SYSTEM SET AUDIT_TRAIL=DB SCOPE=SPFILE;
--SHUTDOWN IMMEDIATE;
--STARTUP;
-------------------------------------------------
--su dung standard audit ghi nhat ky select, insert cua moi user tren bang tb_hocphan
AUDIT SELECT, INSERT ON ADMIN.TB_HOCPHAN BY ACCESS;
--thuc hien cau lenh select bang nhieu user khac nhau
CONN NV091/NV091
SELECT * FROM ADMIN.TB_HOCPHAN;
--
CONN NV107/NV107
SELECT * FROM ADMIN.TB_HOCPHAN;
--xem nhat ky audit
SELECT * FROM DBA_AUDIT_TRAIL WHERE obj_name = 'TB_HOCPHAN';

/
BEGIN
     DBMS_FGA.DROP_POLICY(
     OBJECT_SCHEMA =>'ADMIN',
     OBJECT_NAME =>'TB_DANGKY',
     POLICY_NAME =>'FGA_CHECK_SCORE_UPDATE');
EXCEPTION
    WHEN OTHERS THEN
        NULL;
END;
/
--su dung fine-grained audit ghi nhat ky update cua moi user tren bang tb_dangky
BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema   => 'ADMIN',
    object_name     => 'TB_DANGKY',
    policy_name     => 'FGA_CHECK_SCORE_UPDATE',
    audit_condition => 'SYS_CONTEXT(''USERENV'', ''SESSION_USER'') NOT IN (SELECT MANV FROM ADMIN.UV_XEMGIANGVIEN)',
    statement_types => 'UPDATE',
    audit_column    => 'DIEMTH, DIEMQT, DIEMCK, DIEMTK'
  );
END;
/
conn NV052/NV052;
BEGIN
  UPDATE ADMIN.TB_DANGKY
  SET DIEMTH = 9, DIEMQT = 9, DIEMCK = 9, DIEMTK = 9
  WHERE MASV = 'SV127123' AND MAHP = 'HP21' AND NAMHOC = 2024 AND HOCKY = 3 AND LOP = 'CLC';
END;

/
BEGIN
     DBMS_FGA.DROP_POLICY(
     OBJECT_SCHEMA =>'ADMIN',
     OBJECT_NAME =>'TB_NHANSU',
     POLICY_NAME =>'FGA_CHECK_PHUCAP_SELECT');
EXCEPTION
    WHEN OTHERS THEN
        NULL;
END;
/
--su dung fine-grained audit ghi nhat ky ??c phu cap nguoi khac tren bang TB_NHANSU
BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema   => 'ADMIN',
    object_name     => 'TB_NHANSU',
    policy_name     => 'FGA_CHECK_PHUCAP_SELECT',
    audit_condition => 'MANV != SYS_CONTEXT(''USERENV'', ''SESSION_USER'')',
    audit_column    => 'PHUCAP',
    statement_types => 'SELECT',
    enable =>TRUE
);
END;
/

conn NV107/NV107;
SELECT * FROM ADMIN.TB_NHANSU WHERE MANV = 'NV053';
/

SELECT * FROM DBA_FGA_AUDIT_TRAIL;