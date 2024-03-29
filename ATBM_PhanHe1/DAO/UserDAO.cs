using ATBM_PhanHe1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string query = "select* from all_users";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                UserDTO user = new UserDTO(row);
                list.Add(user);
            }
            return list;
        }

    }
}
