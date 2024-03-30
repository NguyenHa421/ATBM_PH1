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
        public string roleName { get; set; }
        public int nOfOwner { get; set; }
        public RoleDTO(string roleName, int nOfOwner)
        {
            this.roleName = roleName;
            this.nOfOwner = nOfOwner;
        }
        public RoleDTO(DataRow row)
        {
            this.roleName = row["role"].ToString();
            this.nOfOwner = Convert.ToInt32(row["nOfOwner"]);
        }
    }
}
