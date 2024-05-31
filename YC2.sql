--SHOW CON_NAME
--chuyen container
ALTER SESSION SET CONTAINER = XEPDB1;
--default user cua OLS
ALTER USER lbacsys IDENTIFIED BY lbacsys ACCOUNT UNLOCK;
--cau hinh va kich hoat OLS
EXEC LBACSYS.CONFIGURE_OLS;
EXEC LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS;
--xoa policy truoc khi tao
CONN lbacsys/lbacsys
BEGIN
    SA_SYSDBA.DROP_POLICY
    (policy_name => 'QLThongBao');
END;
--tao policy
CONN lbacsys/lbacsys
BEGIN
    SA_SYSDBA.CREATE_POLICY
    (policy_name => 'QLThongBao',
    column_name => 'LabelCol');
END;

SELECT CON_ID, NAME, OPEN_MODE FROM V$PDBS;