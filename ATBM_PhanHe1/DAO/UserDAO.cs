using ATBM_PhanHe1.DTO;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ATBM_PhanHe1.DAO
{
    public class UserDAO
    {
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return UserDAO.instance; }
            private set { UserDAO.instance = value; }
        }
        private UserDAO() { }
        public List<UserDTO> GetUserList()
        {
            List<UserDTO> list = new List<UserDTO>();
            string query = "select * from all_users";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                UserDTO user = new UserDTO(row);
                list.Add(user);
            }
            return list;
        }
        public List<UserRoleDTO> GetUserWithPrivs()
        {
            List<UserRoleDTO> list = new List<UserRoleDTO>();
            string query = "select username,count(granted_role) as nOfRole from all_users, dba_role_privs where username = grantee(+) group by username";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                UserRoleDTO user = new UserRoleDTO(row);
                list.Add(user);
            }
            return list;
        }
        public List<UserPrivsDTO> GetUserPrivsOnTable(string userName, string tableName)
        {
            List<UserPrivsDTO> list = new List<UserPrivsDTO>();
            string query = $"select grantee,table_name,privilege,grantable from dba_tab_privs where grantee = '{userName}' and table_name = '{tableName}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                UserPrivsDTO priv = new UserPrivsDTO(row);
                list.Add(priv);
            }
            data.Rows.Clear();
            query = $"select grantee,table_name,column_name,privilege,grantable from dba_col_privs where grantee = '{userName}' and table_name = '{tableName}'";
            data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                UserPrivsDTO priv = new UserPrivsDTO(row);
                list.Add(priv);
            }
            return list;
        }
        public List<UserDTO> SearchUser(string userName)
        {
            List<UserDTO> list = new List<UserDTO>();
            string query = string.Format("select * from all_users where lower(username) like lower('%{0}%')", userName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                UserDTO user = new UserDTO(row);
                list.Add(user);
            }
            return list;
        }
        public List<UserRoleDTO> SearchUserRole(string userName)
        {
            List<UserRoleDTO> list = new List<UserRoleDTO>();
            string query = string.Format("select grantee, count(granted_role) as nOfRole from dba_role_privs where lower(grantee) like lower('%{0}%') group by grantee",userName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                UserRoleDTO user = new UserRoleDTO(row);
                list.Add(user);
            }
            return list;
        }
        public void CreateUser(string userId, string password)
        {
            string query = $"begin create_user('{userId}','{password}'); end;";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void DeleteUser(string userName)
        {
            string query = $"begin drop_user('{userName}'); end;";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void GrantPrivToUser(string userName, List<string> privs, int grantOption, string tableName)
        {
            string privStr = "";
            foreach (string str in privs)
                privStr+=str + ",";
            privStr = privStr.Remove(privStr.Length - 1);
            string query;
            query = $"begin grant_privilege_to_user('{userName}','{privStr}','{tableName}',{grantOption}); end;";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void GrantPrivToUser(string userName, List<string> privs, int grantOption, string tableName, string column)
        {
            string privStr = "";
            foreach (string str in privs)
            {
                privStr += str;
                if (str == "Update")
                    privStr += "(" + column + ")";
                privStr += ",";
            }            
            privStr = privStr.Remove(privStr.Length - 1);
            string query = $"begin grant_privilege_to_user('{userName}','{privStr}','{tableName}',{grantOption}); end;";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void RevokePrivs(string userName, List<string> privs, string tableName)
        {
            string privStr = "";
            foreach (string str in privs)
                privStr += str + ",";
            privStr = privStr.Remove(privStr.Length - 1);
            string query = $"begin revoke_privilege_to_user('{userName}','{privStr}','{tableName}'); end;";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void ChangePassword(string userName, string password)
        {
            string query = $"begin change_password('{userName}','{password}'); end;";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public DataTable ListUserRole_Table(string userName)
        {
            return DataProvider.Instance.ExecuteQuery($"select grantee, granted_role, admin_option from dba_role_privs where lower(grantee) like lower('%{userName}%')");
        }
        public bool Grant_Role_To_User(string user_name, string role_name, int AdminOption)
        {
            string query = $"begin grant_role_to_user('{user_name}','{role_name}',{AdminOption});end;";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Revoke_Role_From_User(string user_name, string role_name)
        {
            string query = $"begin revoke_role_to_user('{user_name}','{role_name}');end;";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
