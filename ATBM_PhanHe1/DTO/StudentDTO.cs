using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DTO
{
    public class StudentDTO
    {
        public string studentID {  get; set; }
        public string studentName { get; set; }
        public string gender { get; set; }
        public DateTime birthday { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string programID { get; set; }
        public string majorID { get; set; }
        public int credits { get; set; }
        public double gpa { get; set; }
        public StudentDTO(string studentID, string studentName, string gender, DateTime birthday, string address, string phone, string programID, string majorID, int credits, double gpa)
        {
            this.studentID = studentID;
            this.studentName = studentName;
            this.gender = gender;
            this.birthday = birthday;
            this.address = address;
            this.phone = phone;
            this.programID = programID;
            this.majorID = majorID;
            this.credits = credits;
            this.gpa = gpa;
        }
        public StudentDTO(DataRow row)
        {
            this.studentID = row["MASV"].ToString();
            this.studentName = row["HOTEN"].ToString();
            this.gender = row["PHAI"].ToString();
            this.birthday = (DateTime)row["NGSINH"];
            this.address = row["DCHI"].ToString();
            this.phone = row["DT"].ToString();
            this.programID = row["MACT"].ToString();
            this.majorID = row["MANGANH"].ToString();
            this.credits = Decimal.ToInt32((decimal)row["SOTCTL"]);
            this.gpa = Decimal.ToDouble((decimal)row["DTBTL"]);
        }
    }
}
