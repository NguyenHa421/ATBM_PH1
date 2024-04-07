ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

--TAO USER
CREATE OR REPLACE PROCEDURE create_user(user_name IN VARCHAR2, pass IN VARCHAR2)
AUTHID CURRENT_USER
AS
BEGIN 
    EXECUTE IMMEDIATE 'CREATE USER ' || user_name || ' IDENTIFIED BY ' || pass;
    EXCEPTION 
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('User da ton tai');
        RAISE;
END;
/
--XOA USER
CREATE OR REPLACE PROCEDURE drop_user(user_name IN VARCHAR2)
AUTHID CURRENT_USER
AS
BEGIN
    EXECUTE IMMEDIATE 'DROP USER '||user_name;
    EXCEPTION
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('User khong ton tai');
        RAISE;
END;
/

--PHAN QUYEN CHO USER
CREATE OR REPLACE PROCEDURE grant_privilege_to_user (user_name IN VARCHAR2, privilege_name IN VARCHAR2, table_name IN VARCHAR2,withGrantOption IN NUMBER)
as
BEGIN
    IF withGrantOption = 0 THEN
        EXECUTE IMMEDIATE ('GRANT '||privilege_name|| ' ON '||table_name||' TO '||user_name);
    ELSE
        EXECUTE IMMEDIATE ('GRANT '||privilege_name|| ' ON '||table_name||' TO '||user_name||' WITH GRANT OPTION');
    END IF;
end;
/

--THU HOI QUYEN CUA ROLE
CREATE OR REPLACE PROCEDURE revoke_privilege_to_user (user_name IN VARCHAR2, privilege_name IN VARCHAR2, table_name IN VARCHAR2)
AS
BEGIN
    EXECUTE IMMEDIATE ('REVOKE '||privilege_name||' ON '||table_name||' FROM '||user_name);
END;
/

--DOI MAT KHAU CUA USER
CREATE OR REPLACE PROCEDURE change_password (user_name IN VARCHAR2, password IN VARCHAR2)
AS
BEGIN
    EXECUTE IMMEDIATE ('ALTER USER '||user_name||' IDENTIFIED BY '||password);
END;
/