using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DTO
{
    public class UserDTO
    {
        public string userName { get; set; }
        public string userID { get; set; }
        public DateOnly created {  get; set; }
        public bool common { get; set; }
        public UserDTO(string userName, string userID, DateOnly created, bool common)
        {
            this.userName = userName;
            this.userID = userID;
            this.created = created;
            this.common = common;
        }
        public UserDTO(DataRow row)
        {
            this.userName = row["USERNAME"].ToString();
            this.userID = row["USER_ID"].ToString();
            this.created = (DateOnly)row["CREATED"];
            this.common = Convert.ToBoolean(row["COMMON"]);
        }
    }
}
