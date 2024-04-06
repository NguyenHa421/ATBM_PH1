using ATBM_PhanHe1.DTO;
using System.Data;

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
    }
}
