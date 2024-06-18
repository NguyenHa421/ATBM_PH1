using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DTO
{
    public class AuditDTO
    {
        public string userName { get; set; }
        public DateTime time { get; set; }
        public string owner { get; set; }
        public string table { get; set; }
        public string action { get; set; }
        public AuditDTO(string userName, DateTime time, string owner, string table, string action)
        {
            this.userName = userName;  
            this.time = time;
            this.owner = owner;
            this.table = table;
            this.action = action;
        }
        public AuditDTO(DataRow row)
        {
            this.userName = row["USERNAME"].ToString();
            this.time = (DateTime)row["TIMESTAMP"];
            this.owner = row["OWNER"].ToString();
            this.table = row["OBJ_NAME"].ToString();
            this.action = row["ACTION_NAME"].ToString();
        }
    }
}
