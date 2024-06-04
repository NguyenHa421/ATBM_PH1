using ATBM_PhanHe1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DAO
{
    public class StudentDAO
    {
        private static StudentDAO instance;
        public static StudentDAO Instance
        {
            get { if (instance == null) instance = new StudentDAO(); return StudentDAO.instance; }
            private set { StudentDAO.instance = value; }
        }
        private StudentDAO() { }
        public List<StudentDTO> GetStudentList()
        {
            List<StudentDTO> list = new List<StudentDTO>();
            string query = "select * from tb_sinhvien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                StudentDTO student = new StudentDTO(row);
                list.Add(student);
            }
            return list;
        }
        public List<StudentDTO> SearchStudent(string searchID, string searchName)
        {
            List<StudentDTO> result = new List<StudentDTO>();
            string query = string.Format("select * from tb_sinhvien where lower(MASV) like lower('%{0}%') and lower(HOTEN) like lower('%{1}%')", searchID, searchName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                StudentDTO student = new StudentDTO(row);
                result.Add(student);
            }
            return result;
        }
    }
}
