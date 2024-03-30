using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DTO
{
    public class UserRoleDTO
    {
        public string userName { get; set; }
        public int nOfRole { get; set; }
        public UserRoleDTO(string userName, int nOfRole)
        {
            this.userName = userName;
            this.nOfRole = nOfRole;
        }
        public UserRoleDTO(DataRow row)
        {
            this.userName = row["grantee"].ToString();
            this.nOfRole = Convert.ToInt32(row["nOfRole"]);
        }
    }
}
