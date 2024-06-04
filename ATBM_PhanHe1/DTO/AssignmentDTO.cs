using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DTO
{
    public class AssignmentDTO
    {
        public string lecturerID {  get; set; }
        public string lecturerName { get; set; } = string.Empty;
        public string courseID { get; set; }
        public string courseName { get; set; } = string.Empty;
        public int semester {  get; set; }
        public int year { get; set; }
        public string programID { get; set; }
        public string programName { get; set; } = string.Empty;
        public AssignmentDTO(string lecturerID, string courseID, int semester, int year, string programID)
        {
            this.lecturerID = lecturerID;
            this.courseID = courseID;
            this.semester = semester;
            this.year = year;
            this.programID = programID;
        }
        public AssignmentDTO(DataRow row)
        {
            this.lecturerID = row["MAGV"].ToString();
            this.courseID = row["MAHP"].ToString();
            this.semester = Decimal.ToInt32((decimal)row["HK"]);
            this.year = Decimal.ToInt32((decimal)row["NAM"]);
            this.programID = row["MACT"].ToString();
        }
    }
}
