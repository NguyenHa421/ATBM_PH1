using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DTO
{
    public class CourseDTO
    {
        public string courseID { get; set; }
        public string courseName { get; set; }
        public int credits { get; set; }
        public int lectureNum { get; set; }
        public int practicalNum { get; set; }
        public int maxStudent {  get; set; }
        public string unitID { get; set; }
        public CourseDTO(string courseID, string courseName, int credits, int lectureNum, int practicalNum, int maxStudent, string unitID)
        {
            this.courseID = courseID;
            this.courseName = courseName;
            this.credits = credits;
            this.lectureNum = lectureNum;
            this.practicalNum = practicalNum;
            this.maxStudent = maxStudent;
            this.unitID = unitID;
        }
        public CourseDTO(DataRow row)
        {
            this.courseID = row["MAHP"].ToString();
            this.courseName = row["TENHP"].ToString();
            this.credits = Decimal.ToInt32((decimal)row["SOTC"]);
            this.lectureNum = Decimal.ToInt32((decimal)row["STLT"]);
            this.practicalNum = Decimal.ToInt32((decimal)row["STTH"]);
            this.maxStudent = Decimal.ToInt32((decimal)row["SOSVTD"]);
            this.unitID = row["MADV"].ToString();
        }
    }
}
