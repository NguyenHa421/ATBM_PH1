--kiem tra gia tri audit_trail
SHOW PARAMETER AUDIT_TRAIL;
--neu gia tri cua audit_trail khong phai DB thi thuc hien cac cau lenh sau de cap nhat
--ALTER SYSTEM SET AUDIT_TRAIL=DB SCOPE=SPFILE;
--SHUTDOWN IMMEDIATE;
--STARTUP;
-------------------------------------------------
--su dung standard audit ghi nhat ky select, insert cua moi user tren bang tb_hocphan
AUDIT SELECT, INSERT ON ADMIN.TB_HOCPHAN BY ACCESS;

--su dung standard audit ghi nhat ky insert, delete cua moi user tren bang tb_nhansu
AUDIT INSERT, DELETE, UPDATE ON ADMIN.TB_SINHVIEN BY ACCESS;

--su dung standard audit ghi nhat ky insert, delete cua moi user tren view UV_TKXEMPHANCONG
AUDIT INSERT, DELETE, UPDATE ON ADMIN.UV_TKXEMPHANCONG BY ACCESS;
--su dung standard audit ghi nhat ky insert, delete cua moi user tren procedure USP_CHINHSODT
AUDIT EXECUTE ON ADMIN.USP_CHINHSODT BY ACCESS;

-- Proc kiem tra nguoi dung phai la Giang vien khong
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
-- Xoa chinh sach neu ton tai
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

-- Xoa chinh sach neu ton tai
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

