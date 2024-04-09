using ATBM_PhanHe1.DTO;
using System.Data;
using System.Data.Common;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ATBM_PhanHe1.DAO
{
    public class RoleDAO
    {
        private static RoleDAO instance;
        public static RoleDAO Instance
        {
            get { if (instance == null) instance = new RoleDAO(); return RoleDAO.instance; }
            private set { RoleDAO.instance = value; }
        }
        private RoleDAO() { }
        public List<RoleDTO> GetRoleList()
        {
            List<RoleDTO> list = new List<RoleDTO>();
            string query = "select d.role_id, d.role, count(p.owner) as nOfOwner from dba_roles d left join role_tab_privs p on p.role = d.role group by d.role_id, d.role";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                RoleDTO role = new RoleDTO(row);
                list.Add(role);
            }
            return list;
        }
        public List<RoleDTO> SearchRole(string roleName)
        {
            List<RoleDTO> list = new List<RoleDTO>();
            string query = string.Format("select d.role_id, d.role, count(p.owner) as nOfOwner from dba_roles d left join role_tab_privs p on p.role = d.role where lower(d.role) like lower('%{0}%') group by d.role_id, d.role", roleName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                RoleDTO role = new RoleDTO(row);
                list.Add(role);
            }
            return list;
        }
        public bool Add_Role(string name)
        {
            string query = $"begin create_role ('{name}');end;";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Delete_Role(string name)
        {
            string query = $"begin drop_role ('{name}');end;";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        
        public DataTable ListRole_Table(string roleName, string tableName)
        {
            return DataProvider.Instance.ExecuteQuery($"select d.role, p.table_name, p.column_name, p.privilege from dba_roles d left join role_tab_privs p on p.role = d.role where lower(d.role) like lower('%{roleName}%') and lower(p.table_name) like lower('%{tableName}%')");
        }
        
        public bool Grant_Role(string role_name, List<string> privs, string table_name)
        {
            string privStr = "";
            foreach (string str in privs)
                privStr += str + ",";
            privStr = privStr.Remove(privStr.Length - 1);
            string query = $"begin grant_privilege_to_role('{role_name}','{privStr}','{table_name}');end;";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Grant_Role(string role_name, List<string> privs, string table_name, string column_name)
        {
            string privStr = "";
            foreach (string str in privs)
            {
                privStr += str;
                if (str == "Update" || str == "Insert")
                    privStr += "(" + column_name + ")";
                privStr += ",";
            }
            privStr = privStr.Remove(privStr.Length - 1);
            string query = $"begin grant_privilege_to_role('{role_name}','{privStr}','{table_name}');end;";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Revoke_Role(string role_name, List<string> privs, string table_name)
        {
            string privStr = "";
            foreach (string str in privs)
                privStr += str + ",";
            privStr = privStr.Remove(privStr.Length - 1);
            string query = $"begin revoke_privilege_to_role('{role_name}','{privStr}','{table_name}');end;";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
