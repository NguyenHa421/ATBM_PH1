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
CONN lbacsys/lbacsys@//localhost:1521/XEPDB1
BEGIN
    SA_SYSDBA.DROP_POLICY
    (policy_name => 'QLThongBao');
END;
/
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
/
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
/
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
/
--tao cac label cho yeu cau a, b, c va cho thong bao t1 t2 t3 t4 t5 t6
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
    
    --d. nhan cho thong bao t1
    SA_LABEL_ADMIN.CREATE_LABEL
    (policy_name => 'QLThongBao',
    label_tag => 7100,
    label_value => 'TDV::CS1,CS2');
    
    --e. nhan cho thong bao t2
    SA_LABEL_ADMIN.CREATE_LABEL
    (policy_name => 'QLThongBao',
    label_tag => 1100,
    label_value => 'SV:HTTT:CS1');
    
    --f. nhan cho thong bao t3
    SA_LABEL_ADMIN.CREATE_LABEL
    (policy_name => 'QLThongBao',
    label_tag => 7300,
    label_value => 'TDV:KHMT:CS1');
    
    --g. nhan cho thong bao t4
    SA_LABEL_ADMIN.CREATE_LABEL
    (policy_name => 'QLThongBao',
    label_tag => 7400,
    label_value => 'TDV:KHMT:CS1,CS2');
    
    --h. nhan cho thong bao t5
    SA_LABEL_ADMIN.CREATE_LABEL
    (policy_name => 'QLThongBao',
    label_tag => 5100,
    label_value => 'GV:HTTT:CS1,CS2');
    
    --h. nhan cho thong bao t6
    SA_LABEL_ADMIN.CREATE_LABEL
    (policy_name => 'QLThongBao',
    label_tag => 1200,
    label_value => 'SV::CS2');
    
    --h. nhan cho thong bao t7
    SA_LABEL_ADMIN.CREATE_LABEL
    (policy_name => 'QLThongBao',
    label_tag => 9200,
    label_value => 'TK::CS1,CS2');
END;
/
--Drop user admin truoc
DROP USER admin CASCADE;
--Gan quyen can thiet cho lbacsys
GRANT CREATE USER TO lbacsys;
--tao user admin
CONN lbacsys/lbacsys@//localhost:1521/XEPDB1
CREATE USER admin IDENTIFIED BY group12;

--grant cac quyen can thiet cho user admin
GRANT CREATE SESSION TO admin;
GRANT ALL PRIVILEGES TO admin;

CONN lbacsys/lbacsys@//localhost:1521/XEPDB1
BEGIN
    SA_USER_ADMIN.SET_USER_PRIVS
    (policy_name => 'QLThongBao',
    user_name => 'admin',
    privileges => 'FULL,PROFILE_ACCESS');
END;
/
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
/
--tao bang thong bao
CONN admin/group12@//localhost:1521/XEPDB1;
CREATE TABLE admin.THONGBAO
(
    MaTB VARCHAR2(50) PRIMARY KEY,
    NoiDung VARCHAR2(4000),
    LabelCol NUMBER(10)
);

--them cac dong du lieu
CONN admin/group12@//localhost:1521/XEPDB1;
INSERT INTO admin.THONGBAO(MaTB,NoiDung) VALUES('T1','Thong bao danh cho tat ca truong don vi');
INSERT INTO admin.THONGBAO(MaTB,NoiDung) VALUES('T2','Thong bao danh cho sinh vien thuoc nganh HTTT hoc o co so 1');
INSERT INTO admin.THONGBAO(MaTB,NoiDung) VALUES('T3','Thong bao danh cho truong bo mon KHMT o co so 1');
INSERT INTO admin.THONGBAO(MaTB,NoiDung) VALUES('T4','Thong bao danh cho truong bo mon KHMT o co so 1 va co so 2');
INSERT INTO admin.THONGBAO(MaTB,NoiDung) VALUES('T5','Thong bao danh cho giang vien bo mon HTTT o co so 1 va co so 2');
INSERT INTO admin.THONGBAO(MaTB,NoiDung) VALUES('T6','Thong bao danh cho toan bo sinh vien o co so 2');
INSERT INTO admin.THONGBAO(MaTB,NoiDung) VALUES('T7','Thong bao danh cho truong khoa o co so 2');

--them label cho cac dong du lieu
CONN admin/group12@//localhost:1521/XEPDB1;
UPDATE admin.THONGBAO
SET LabelCol = char_to_label('QLThongBao','TDV::CS1,CS2')
WHERE MaTB = 'T1';

UPDATE admin.THONGBAO
SET LabelCol = char_to_label('QLThongBao','SV:HTTT:CS1')
WHERE MaTB = 'T2';

UPDATE admin.THONGBAO
SET LabelCol = char_to_label('QLThongBao','TDV:KHMT:CS1')
WHERE MaTB = 'T3';

UPDATE admin.THONGBAO
SET LabelCol = char_to_label('QLThongBao','TDV:KHMT:CS1,CS2')
WHERE MaTB = 'T4';

UPDATE admin.THONGBAO
SET LabelCol = char_to_label('QLThongBao','GV:HTTT:CS1,CS2')
WHERE MaTB = 'T5';

UPDATE admin.THONGBAO
SET LabelCol = char_to_label('QLThongBao','SV::CS2')
WHERE MaTB = 'T6';

UPDATE admin.THONGBAO
SET LabelCol = char_to_label('QLThongBao','TK::CS1,CS2')
WHERE MaTB = 'T7';
/
--ap dung OLS
CONN admin/group12@//localhost:1521/XEPDB1
BEGIN
    SA_POLICY_ADMIN.APPLY_TABLE_POLICY
    (policy_name => 'QLThongBao',
    schema_name => 'admin',
    table_name => 'THONGBAO',
    table_optionS => 'READ_CONTROL');
END;
/
--xoa user truoc khi tao
DROP USER truongkhoa CASCADE;
DROP USER truongdonvi CASCADE;
DROP USER giaovu CASCADE;

--tao user de test
CONN admin/group12@//localhost:1521/XEPDB1
CREATE USER svcs2 IDENTIFIED BY svcs2;
GRANT CREATE SESSION TO svcs2;
GRANT SELECT ON admin.THONGBAO TO svcs2;

CREATE USER truongkhoa IDENTIFIED BY truongkhoa;
GRANT CREATE SESSION TO truongkhoa;
GRANT SELECT ON admin.THONGBAO TO truongkhoa;

CREATE USER truongdonvi IDENTIFIED BY truongdonvi;
GRANT CREATE SESSION TO truongdonvi;
GRANT SELECT ON admin.THONGBAO TO truongdonvi;

CREATE USER giaovu IDENTIFIED BY giaovu;
GRANT CREATE SESSION TO giaovu;
GRANT SELECT ON admin.THONGBAO TO giaovu;
/
--gan nhan cho user test
CONN admin/group12@//localhost:1521/XEPDB1
BEGIN
    SA_USER_ADMIN.SET_USER_LABELS
    (policy_name => 'QLThongBao',
    user_name => 'svcs2',
    max_read_label => 'SV:MMT:CS2',
    def_label => 'SV:MMT:CS2',
    row_label => 'SV:MMT:CS2');

    SA_USER_ADMIN.SET_USER_LABELS
    (policy_name => 'QLThongBao',
    user_name => 'truongkhoa',
    max_read_label => 'TK:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2',
    def_label => 'TK:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2',
    row_label => 'TK:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2');
    
    SA_USER_ADMIN.SET_USER_LABELS
    (policy_name => 'QLThongBao',
    user_name => 'truongdonvi',
    max_read_label => 'TDV:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2',
    def_label => 'TDV:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2',
    row_label => 'TDV:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2');
    
    SA_USER_ADMIN.SET_USER_LABELS
    (policy_name => 'QLThongBao',
    user_name => 'giaovu',
    max_read_label => 'GVu:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2',
    def_label => 'GVu:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2',
    row_label => 'GVu:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2');
END;
/
ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE;