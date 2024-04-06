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
            string query = "begin drop_user('" + userName + "'); end;";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
