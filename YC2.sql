ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
--chuyen container
ALTER SESSION SET CONTAINER = CDB$ROOT;
--SHOW CON_NAME
--default user cua OLS
ALTER USER lbacsys IDENTIFIED BY lbacsys ACCOUNT UNLOCK;
--chuyen container
ALTER SESSION SET CONTAINER = XEPDB1;
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
CONN lbacsys/lbacsys@//localhost:1521/XEPDB1
BEGIN
    SA_SYSDBA.CREATE_POLICY
    (policy_name => 'QLThongBao',
    column_name => 'LabelCol');
END;
/
--tao level
CONN lbacsys/lbacsys@//localhost:1521/XEPDB1
BEGIN
    SA_COMPONENTS.CREATE_LEVEL
    (policy_name => 'QLThongBao',
    level_num => 9000,
    short_name => 'TK',
    long_name => 'TruongKhoa');
    
    SA_COMPONENTS.CREATE_LEVEL
    (policy_name => 'QLThongBao',
    level_num => 7000,
    short_name => 'TDV',
    long_name => 'TruongDonVi');
    
    SA_COMPONENTS.CREATE_LEVEL
    (policy_name => 'QLThongBao',
    level_num => 5000,
    short_name => 'GV',
    long_name => 'GiangVien');
    
    SA_COMPONENTS.CREATE_LEVEL
    (policy_name => 'QLThongBao',
    level_num => 4000,
    short_name => 'GVu',
    long_name => 'GiaoVu');
    
    SA_COMPONENTS.CREATE_LEVEL
    (policy_name => 'QLThongBao',
    level_num => 3000,
    short_name => 'NV',
    long_name => 'NhanVien');
    
    SA_COMPONENTS.CREATE_LEVEL
    (policy_name => 'QLThongBao',
    level_num => 1000,
    short_name => 'SV',
    long_name => 'SinhVien');
END;

--tao compartment
CONN lbacsys/lbacsys@//localhost:1521/XEPDB1
BEGIN
    SA_COMPONENTS.CREATE_COMPARTMENT
    (policy_name => 'QLThongBao',
    comp_num => 900,
    short_name => 'HTTT',
    long_name => 'He thong thong tin');
    
    SA_COMPONENTS.CREATE_COMPARTMENT
    (policy_name => 'QLThongBao',
    comp_num => 700,
    short_name => 'CNPM',
    long_name => 'Cong nghe phan mem');
    
    SA_COMPONENTS.CREATE_COMPARTMENT
    (policy_name => 'QLThongBao',
    comp_num => 500,
    short_name => 'KHMT',
    long_name => 'Khoa hoc may tinh');
    
    SA_COMPONENTS.CREATE_COMPARTMENT
    (policy_name => 'QLThongBao',
    comp_num => 400,
    short_name => 'CNTT',
    long_name => 'Cong nghe thong tin');
    
    SA_COMPONENTS.CREATE_COMPARTMENT
    (policy_name => 'QLThongBao',
    comp_num => 300,
    short_name => 'TGMT',
    long_name => 'Thi giac may tinh');
    
    SA_COMPONENTS.CREATE_COMPARTMENT
    (policy_name => 'QLThongBao',
    comp_num => 100,
    short_name => 'MMT',
    long_name => 'Mang may tinh');
END;

--tao cac group
CONN lbacsys/lbacsys@//localhost:1521/XEPDB1
BEGIN
    SA_COMPONENTS.CREATE_GROUP
    (policy_name => 'QlThongBao',
    group_num => 60,
    short_name => 'cs1',
    long_name => 'Co so 1');
    
    SA_COMPONENTS.CREATE_GROUP
    (policy_name => 'QlThongBao',
    group_num => 30,
    short_name => 'cs2',
    long_name => 'Co so 2');
END;

--tao cac label cho yeu cau a, b, c
CONN lbacsys/lbacsys@//localhost:1521/XEPDB1
BEGIN
    --a. nhan cho truong khoa
    SA_LABEL_ADMIN.CREATE_LABEL
    (policy_name => 'QLThongBao',
    label_tag => 9100,
    label_value => 'TK:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2');
    
    --b. nhan cho truong bo mon o cs2
    SA_LABEL_ADMIN.CREATE_LABEL
    (policy_name => 'QLThongBao',
    label_tag => 7200,
    label_value => 'TDV:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2');
    
    --c. nhan cho giao vu
    SA_LABEL_ADMIN.CREATE_LABEL
    (policy_name => 'QLThongBao',
    label_tag => 4300,
    label_value => 'GVu:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2');
END;
--tao user admin
DROP USER admin CASCADE;
CREATE USER admin IDENTIFIED BY group12;
--grant cac quyen can thiet cho user admin
GRANT CREATE SESSION TO admin;
GRANT ALL PRIVILEGES TO admin;
CONN lbacsys/lbacsys
BEGIN
    SA_USER_ADMIN.SET_USER_PRIVS
    (policy_name => 'QLThongBao',
    user_name => 'admin',
    privileges => 'FULL,PROFILE_ACCESS');
END;

SELECT username, common
FROM DBA_USERS 
WHERE USERNAME = 'ADMIN';

GRANT EXECUTE ON sa_components TO admin WITH GRANT OPTION;
GRANT EXECUTE ON sa_user_admin TO admin WITH GRANT OPTION;
GRANT EXECUTE ON sa_user_admin TO admin WITH GRANT OPTION;
GRANT EXECUTE ON sa_label_admin TO admin WITH GRANT OPTION;
GRANT EXECUTE ON sa_policy_admin TO admin WITH GRANT OPTION;
GRANT EXECUTE ON sa_audit_admin  TO admin WITH GRANT OPTION;
GRANT LBAC_DBA TO admin;
GRANT EXECUTE ON sa_sysdba TO admin;
GRANT EXECUTE ON to_lbac_data_label TO admin;
GRANT QLThongBao_DBA TO admin;

ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE;