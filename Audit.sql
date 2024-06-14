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