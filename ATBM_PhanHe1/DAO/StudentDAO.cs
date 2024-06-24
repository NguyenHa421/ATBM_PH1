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
            string query = "select * from admin.tb_sinhvien";
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
            string query = string.Format("select * from admin.tb_sinhvien where lower(MASV) like lower('%{0}%') and lower(HOTEN) like lower('%{1}%')", searchID, searchName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                StudentDTO student = new StudentDTO(row);
                result.Add(student);
            }
            return result;
        }
        public StudentDTO GetStudentByID(string studentID)
        {
            string query = string.Format("select * from admin.tb_sinhvien where lower(MASV) like lower('%{0}%')", studentID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            StudentDTO result = new StudentDTO(data.Rows[0]);
            return result;
        }
        public string GetGenderStudent(string id)
        {
            string query = $"SELECT PHAI FROM ADMIN.TB_SINHVIEN WHERE MASV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string GetBirthStudent(string id)
        {
            string query = $"SELECT TO_CHAR(NGSINH, 'DD/MM/YYYY') FROM ADMIN.TB_SINHVIEN WHERE MASV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string GetBirthStudent2(string id)
        {
            string query = $"SELECT NGSINH FROM ADMIN.TB_SINHVIEN WHERE MASV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string GetPhoneStudent(string id)
        {
            string query = $"SELECT DT FROM ADMIN.TB_SINHVIEN WHERE MASV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string GetAddressStudent(string id)
        {
            string query = $"SELECT DCHI FROM ADMIN.TB_SINHVIEN WHERE MASV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string GetProgramStudent(string id)
        {
            string query = $"SELECT ct.TENCT FROM ADMIN.TB_SINHVIEN sv JOIN ADMIN.TB_CHUONGTRINH ct ON sv.MACT = ct.MACT WHERE sv.MASV = '{id}'";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string GetMajorStudent(string id)
        {
            string query = $"SELECT n.TENNGANH FROM ADMIN.TB_SINHVIEN sv JOIN ADMIN.TB_NGANH n ON sv.MANGANH = n.MANGANH WHERE sv.MASV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string GetCreditStudent(string id)
        {
            string query = $"SELECT SOTCTL FROM ADMIN.TB_SINHVIEN WHERE MASV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string GetGPAStudent(string id)
        {
            string query = $"SELECT DTBTL FROM ADMIN.TB_SINHVIEN WHERE MASV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string GetIDAuto(string Program)
        {
            string query = $"SELECT ADMIN.CREATE_IDSTUDENT('{Program}') FROM DUAL";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { Program });
            return result.ToString();
        }
        public bool Add_Student(string id, string name, string gender, DateTime birth, string addr, string phone, string program, string major, int credit, float gpa)
        {
            string query = $"INSERT INTO ADMIN.TB_SINHVIEN(MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES ('{id}', '{name}', '{gender}', TO_DATE('{birth.ToString("yyyy-MM-dd")}', 'YYYY-MM-DD'), '{addr}', '{phone}', '{program}', '{major}', '{credit}', '{gpa}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Update_Student(string id, string name, string gender, DateTime birth, string addr, string phone, string program, string major, int credit, float gpa)
        {
            string query = $"UPDATE ADMIN.TB_SINHVIEN SET HOTEN = ('{name}'), PHAI = ('{gender}'), NGSINH = TO_DATE('{birth.ToString("yyyy-MM-dd")}', 'YYYY-MM-DD'), DCHI = ('{addr}'), DT = ('{phone}'), MACT = ('{program}'), MANGANH = ('{major}'), SOTCTL = ('{credit}'), DTBTL = ('{gpa}') WHERE MASV = ('{id}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Update_SelfStudent(string id, string addr, string phone)
        {
            string query = $"UPDATE ADMIN.TB_SINHVIEN SET DCHI = ('{addr}'), DT = ('{phone}') WHERE MASV = ('{id}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
