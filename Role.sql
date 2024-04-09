ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

--TAO ROLE
CREATE OR REPLACE PROCEDURE create_role(role_name IN VARCHAR2)
AUTHID CURRENT_USER
AS
BEGIN 
    EXECUTE IMMEDIATE 'CREATE ROLE '|| role_name;
    EXCEPTION 
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Role da ton tai');
        RAISE;
END;
/
--XOA ROLE
CREATE OR REPLACE PROCEDURE drop_role(role_name IN VARCHAR2)
AUTHID CURRENT_USER
AS
BEGIN
    EXECUTE IMMEDIATE 'DROP ROLE '||role_name;
    EXCEPTION
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Role khong ton tai');
        RAISE;
END;
/

--PHAN QUYEN CHO ROLE
CREATE OR REPLACE PROCEDURE grant_privilege_to_role (role_name IN VARCHAR2, privilege_name IN VARCHAR2, table_name IN VARCHAR2)
as
BEGIN
    EXECUTE IMMEDIATE ('GRANT '||privilege_name|| ' ON '||table_name||' TO '||role_name);
end;
/
begin
    grant_privilege_to_role ('C##TEST42', 'INSERT', 'TB_SINHVIEN');
end;
select d.role, p.table_name, p.column_name, p.privilege from dba_roles d left join role_tab_privs p on p.role = d.role where d.role = 'C##TEST42';
--THU HOI QUYEN CUA ROLE
CREATE OR REPLACE PROCEDURE revoke_privilege_to_role (role_name IN VARCHAR2, privilege_name IN VARCHAR2, table_name IN VARCHAR2)
AS
BEGIN
    EXECUTE IMMEDIATE ('REVOKE '||privilege_name|| 'ON '||table_name||' FROM '||role_name);
END;

/

--XEM QUYEN ROLE
CREATE OR REPLACE PROCEDURE view_priv_role (role_name IN VARCHAR2, cur OUT sys_refcursor)
AS
    tmp_count INT;
BEGIN
    SELECT COUNT(*) INTO tmp_count FROM session_roles;
    IF(tmp_count != 0) THEN
        OPEN cur FOR SELECT * FROM role_tab_privs WHERE ROLE = role_name; 
    ELSE 
        DBMS_OUTPUT.PUT_LINE('Role khong ton tai');
    END IF;
END;

