using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DTO
{
    public class RoleDTO
    {
        public int roleID { get; set; }
        public string roleName { get; set; }
        public int nOfOwner { get; set; }
        public RoleDTO(int roleID, string roleName, int nOfOwner)
        {
            this.roleID = roleID;
            this.roleName = roleName;
            this.nOfOwner = nOfOwner;
        }
        public RoleDTO(DataRow row)
        {
            this.roleID = Convert.ToInt32(row["role_id"]);
            this.roleName = row["role"].ToString();
            this.nOfOwner = Convert.ToInt32(row["nOfOwner"]);
        }
    }
}
