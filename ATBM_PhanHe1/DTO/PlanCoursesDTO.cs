using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DTO
{
    public class PlanCoursesDTO
    {
        public string courseID { get; set; }
        public string courseName { get; set; } = string.Empty;
        public int semester { get; set; }
        public int year { get; set; }
        public string programID { get; set; }
        public string programName { get; set; } = string.Empty;
        public PlanCoursesDTO(string lecturerID, string lecturerName, string courseID, string courseName, int semester, int year, string programID, string programName)
        {
            this.courseID = courseID;
            this.courseName = courseName;
            this.semester = semester;
            this.year = year;
            this.programID = programID;
            this.programName = programName;
        }
        public PlanCoursesDTO(DataRow row)
        {
            this.courseID = row["MAHP"].ToString();
            this.courseName = row["TENHP"].ToString();
            this.semester = Decimal.ToInt32((decimal)row["HK"]);
            this.year = Decimal.ToInt32((decimal)row["NAM"]);
            this.programID = row["MACT"].ToString();
            this.programName = row["TENCT"].ToString();
        }
    }
}
