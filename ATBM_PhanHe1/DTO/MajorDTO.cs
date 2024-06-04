using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DTO
{
    public class MajorDTO
    {
        public string majorID { get; set; }
        public string majorName { get; set; }

        public MajorDTO(string programID, string programName)
        {
            this.majorID = programID;
            this.majorName = programName;
        }
        public MajorDTO(DataRow row)
        {
            this.majorID = row["MANGANH"].ToString();
            this.majorName = row["TENNGANH"].ToString();
        }
    }
}
