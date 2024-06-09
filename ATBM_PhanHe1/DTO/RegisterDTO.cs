using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DTO
{
    public class RegisterDTO
    {
        public string studentID { get; set; }
        public string studentName { get; set; } = string.Empty;
        public string lecturerID { get; set; }
        public string lecturerName { get; set; } = string.Empty;
        public string courseID { get; set; }
        public string courseName { get; set; } = string.Empty;
        public int semester { get; set; }
        public int year { get; set; }
        public string programID { get; set; }
        public string programName { get; set; } = string.Empty;
        public int practice { get; set; }
        public int process { get; set; }
        public int final { get; set; }
        public int finalfinal { get; set; }

        public RegisterDTO(string studentID, string studentName, string lecturerID, string lecturerName, string courseID, string courseName, int semester, int year, string programID, string programName, int practice, int process, int final, int finalfinal)
        {
            this.studentID = studentID;
            this.studentName = studentName;
            this.lecturerID = lecturerID;
            this.lecturerName = lecturerName;
            this.courseID = courseID;
            this.courseName = courseName;
            this.semester = semester;
            this.year = year;
            this.programID = programID;
            this.programName = programName;
            this.practice = practice;
            this.process = process;
            this.final = final;
            this.finalfinal = finalfinal;
        }
        public RegisterDTO(DataRow row)
        {
            this.studentID = row["MASV"].ToString();
            this.studentName = row["HOTENSV"].ToString();
            this.lecturerID = row["MAGV"].ToString();
            this.lecturerName = row["HOTENGV"].ToString();
            this.courseID = row["MAHP"].ToString();
            this.courseName = row["TENHP"].ToString();
            this.semester = Decimal.ToInt32((decimal)row["HK"]);
            this.year = Decimal.ToInt32((decimal)row["NAM"]);
            this.programID = row["MACT"].ToString();
            this.programName = row["TENCT"].ToString();
            this.practice = Decimal.ToInt32((decimal)row["DIEMTH"]);
            this.process = Decimal.ToInt32((decimal)row["DIEMQT"]);
            this.final = Decimal.ToInt32((decimal)row["DIEMCK"]);
            this.finalfinal = Decimal.ToInt32((decimal)row["DIEMTK"]);

        }
    }
}
