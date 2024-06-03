using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DTO
{
    public class PersonelDTO
    {
        public string personelID { get; set; }
        public string personelName { get; set; }
        public string gender { get; set; }
        public DateTime birthday { get; set; }
        public int allowance { get; set; }
        public string role { get; set; }
        public string unitID { get; set; }
        public PersonelDTO(string personelID, string personelName, string gender, DateTime birthday, int allowance, string role, string unitID)
        {
            this.personelID = personelID;
            this.personelName = personelName;
            this.gender = gender;
            this.birthday = birthday;
            this.allowance = allowance;
            this.role = role;
            this.unitID = unitID;
        }
        public PersonelDTO(DataRow row)
        {
            this.personelID = row["MANV"].ToString();
            this.personelName = row["HOTEN"].ToString();
            this.gender = row["PHAI"].ToString();
            this.birthday = (DateTime)row["NGSINH"];
            this.allowance = (int)row["PHUCAP"];
            this.role = row["VAITRO"].ToString();
            this.unitID = row["MADV"].ToString();
        }
    }
}
