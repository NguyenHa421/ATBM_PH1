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
--THU HOI QUYEN CUA ROLE
CREATE OR REPLACE PROCEDURE revoke_privilege_to_role (role_name IN VARCHAR2, privilege_name IN VARCHAR2, table_name IN VARCHAR2)
AS
BEGIN
    EXECUTE IMMEDIATE ('REVOKE '||privilege_name|| ' ON '||table_name||' FROM '||role_name);
END;
/
--CAP ROLE CHO USER 
CREATE OR REPLACE PROCEDURE grant_role_to_user (user_name IN VARCHAR2, role_name IN VARCHAR2, withAdminOption IN NUMBER)
as
BEGIN
    IF withAdminOption = 0 THEN
        EXECUTE IMMEDIATE ('GRANT '||role_name|| ' TO '||user_name);
    ELSE
        EXECUTE IMMEDIATE ('GRANT '||role_name|| ' TO '||user_name||' WITH ADMIN OPTION');
    END IF;
end;
/
--THU HOI ROLE CHO USER
CREATE OR REPLACE PROCEDURE revoke_role_to_user (user_name IN VARCHAR2, role_name IN VARCHAR2)
AS
BEGIN
    EXECUTE IMMEDIATE ('REVOKE '||role_name||' FROM '||user_name);
END;
/