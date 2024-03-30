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
            string query = "select role, count(owner) as nOfOwner from role_tab_privs group by role";
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
            string query = string.Format("select role, count(owner) as nOfOwner from role_tab_privs where lower(role) like lower('%{0}%') group by role", roleName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                RoleDTO role = new RoleDTO(row);
                list.Add(role);
            }
            return list;
        }
    }
}
