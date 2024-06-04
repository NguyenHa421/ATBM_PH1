using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DTO
{
    public class ProgramDTO
    {
        public string programID { get; set; }
        public string programName { get; set; }
        
        public ProgramDTO(string programID, string programName)
        {
            this.programID = programID;
            this.programName = programName;
        }
        public ProgramDTO(DataRow row)
        {
            this.programID = row["MACT"].ToString();
            this.programName = row["TENCT"].ToString();
        }
    }
}
