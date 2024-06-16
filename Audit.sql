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


--su dung standard audit ghi nhat ky insert, delete cua moi user tren bang tb_nhansu
AUDIT INSERT, DELETE, UPDATE ON ADMIN.TB_SINHVIEN BY ACCESS;
--thuc hien cau lenh update bang nhieu user khac nhau
CONN NV091/NV091
UPDATE ADMIN.TB_SINHVIEN
SET DT = '0392748534'
WHERE MASV = 'SV120221';
--xem nhat ky audit
SELECT * FROM DBA_AUDIT_TRAIL WHERE obj_name = 'TB_SINHVIEN';


--su dung standard audit ghi nhat ky insert, delete cua moi user tren view UV_TKXEMPHANCONG
AUDIT INSERT, DELETE, UPDATE ON ADMIN.UV_TKXEMPHANCONG BY ACCESS;
--thuc hien cau lenh update bang nhieu user khac nhau
CONN NV107/NV107
UPDATE ADMIN.UV_TKXEMPHANCONG
SET MAGV = 'NV053'
WHERE MAHP = 'HP08'
AND HK = '1';
--xem nhat ky audit
SELECT * FROM DBA_AUDIT_TRAIL WHERE obj_name = 'UV_TKXEMPHANCONG';


--su dung standard audit ghi nhat ky insert, delete cua moi user tren procedure USP_CHINHSODT
AUDIT EXECUTE ON ADMIN.USP_CHINHSODT BY ACCESS;
--thuc hien cau lenh update bang nhieu user khac nhau
CONN NV011/NV011
BEGIN
    admin.USP_CHINHSODT('0393456932');
END;

--xem nhat ky audit
SELECT * FROM DBA_AUDIT_TRAIL WHERE obj_name = 'USP_CHINHSODT';



CREATE OR REPLACE FUNCTION CHECK_USER RETURN NUMBER
AS
  v_count NUMBER;
BEGIN
  SELECT COUNT(*)
  INTO v_count
  FROM ADMIN.UV_XEMGIANGVIEN
  WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');
  
  IF v_count = 0 THEN
    RETURN 1;
  ELSE
    RETURN 0;
  END IF;
END;


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
    audit_condition => 'CHECK_USER = 1',
    statement_types => 'UPDATE',
    audit_column    => 'DIEMTH, DIEMQT, DIEMCK, DIEMTK'
  );
END;
/

conn NV107/NV107;
BEGIN
    admin.USP_CAPNHATDIEMSV('SV127123', 'HP21', 3, 2024, 'CLC', 8, 8, 8, 8);
END;
/
SELECT * FROM DBA_FGA_AUDIT_TRAIL;

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
--su dung fine-grained audit ghi nhat ky doc phu cap nguoi khac tren bang TB_NHANSU
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

