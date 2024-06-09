using ATBM_PhanHe1.DTO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DAO
{
    public class RegisterDAO
    {
        private static RegisterDAO instance;
        public static RegisterDAO Instance
        {
            get { if (instance == null) instance = new RegisterDAO(); return RegisterDAO.instance; }
            private set { RegisterDAO.instance = value; }
        }
        private RegisterDAO() { }
        public List<RegisterDTO> GetRegisterList()
        {
            List<RegisterDTO> list = new List<RegisterDTO>();
            string query = "select dk.*, ns.HOTEN as HOTENGV, sv.HOTEN as HOTENSV, hp.TENHP, ct.TENCT from admin.tb_dangky dk, admin.tb_sinhvien sv, admin.tb_nhansu ns, admin.tb_hocphan hp, admin.tb_chuongtrinh ct where dk.MAGV = ns.MANV and dk.MASV = sv.MASV and dk.MAHP = hp.MAHP and dk.MACT = ct.MACT";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                RegisterDTO register = new RegisterDTO(row);
                list.Add(register);
            }
            return list;
        }
        public List<RegisterDTO> GetLecturerRegisterList()
        {
            List<RegisterDTO> list = new List<RegisterDTO>();
            string query = "select dk.*, ns.HOTEN as HOTENGV, sv.HOTEN as HOTENSV, hp.TENHP, ct.TENCT from admin.uv_gvxemdangky dk, admin.tb_sinhvien sv, admin.uv_nvxemthongtin ns, admin.tb_hocphan hp, admin.tb_chuongtrinh ct where dk.MAGV = ns.MANV and dk.MASV = sv.MASV and dk.MAHP = hp.MAHP and dk.MACT = ct.MACT";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                RegisterDTO register = new RegisterDTO(row);
                list.Add(register);
            }
            return list;
        }
        public List<RegisterDTO> GetRegistrarRegisterList()
        {
            List<RegisterDTO> list = new List<RegisterDTO>();
            string query = "select dk.*, null as HOTENGV, sv.HOTEN as HOTENSV, hp.TENHP, ct.TENCT from admin.tb_dangky dk, admin.tb_sinhvien sv, admin.tb_hocphan hp, admin.tb_chuongtrinh ct where dk.MAHP = hp.MAHP and dk.MASV = sv.MASV and dk.MACT = ct.MACT";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                RegisterDTO register = new RegisterDTO(row);
                list.Add(register);
            }
            return list;
        }
        public List<RegisterDTO> GetUnitChiefRegisterList()
        {
            List<RegisterDTO> list = new List<RegisterDTO>();
            string query = "select dk.*, hp.TENHP, ct.TENCT from admin.uv_xemdangky dk, admin.tb_hocphan hp, admin.tb_chuongtrinh ct where dk.MAHP = hp.MAHP and dk.MACT = ct.MACT";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                RegisterDTO register = new RegisterDTO(row);
                list.Add(register);
            }
            return list;
        }
        public List<RegisterDTO> GetStudentRegisterList()
        {
            List<RegisterDTO> list = new List<RegisterDTO>();
            string query = "select dk.*, null as HOTENGV, sv.HOTEN as HOTENSV, hp.TENHP, ct.TENCT from admin.tb_dangky dk, admin.tb_sinhvien sv, admin.tb_hocphan hp, admin.tb_chuongtrinh ct where dk.MAHP = hp.MAHP and dk.MASV = sv.MASV and dk.MACT = ct.MACT";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                RegisterDTO register = new RegisterDTO(row);
                list.Add(register);
            }
            return list;
        }
        public List<RegisterDTO> SearchRegister(int semester, int year, string programName)
        {
            List<RegisterDTO> result = new List<RegisterDTO>();
            string query = "select dk.*, ns.HOTEN as HOTENGV, sv.HOTEN as HOTENSV, hp.TENHP, ct.TENCT from admin.tb_dangky dk, admin.tb_sinhvien sv, admin.tb_nhansu ns, admin.tb_hocphan hp, admin.tb_chuongtrinh ct where dk.MAGV = ns.MANV and dk.MASV = sv.MASV and dk.MAHP = hp.MAHP and dk.MACT = ct.MACT";
            if (semester > 0)
                query += string.Format(" and HK = {0}", semester);
            if (year > 0)
                query += string.Format(" and NAM = {0}", year);
            if (programName != "null")
                query += string.Format(" and TENCT = '{0}'", programName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                RegisterDTO register = new RegisterDTO(row);
                result.Add(register);
            }
            return result;
        }
        public List<RegisterDTO> SearchLecturerRegister(int semester, int year, string programName)
        {
            List<RegisterDTO> result = new List<RegisterDTO>();
            string query = "select dk.*, ns.HOTEN as HOTENGV, sv.HOTEN as HOTENSV, hp.TENHP, ct.TENCT from admin.uv_gvxemdangky dk, admin.tb_sinhvien sv, admin.uv_nvxemthongtin ns, admin.tb_hocphan hp, admin.tb_chuongtrinh ct where dk.MAGV = ns.MANV and dk.MASV = sv.MASV and dk.MAHP = hp.MAHP and dk.MACT = ct.MACT";
            if (semester > 0)
                query += string.Format(" and HK = {0}", semester);
            if (year > 0)
                query += string.Format(" and NAM = {0}", year);
            if (programName != "null")
                query += string.Format(" and TENCT = '{0}'", programName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                RegisterDTO register = new RegisterDTO(row);
                result.Add(register);
            }
            return result;
        }
        public List<RegisterDTO> SearchRegistrarRegister(int semester, int year, string programName)
        {
            List<RegisterDTO> result = new List<RegisterDTO>();
            string query = "select dk.*, null as HOTENGV, sv.HOTEN as HOTENSV, hp.TENHP, ct.TENCT from admin.tb_dangky dk, admin.tb_sinhvien sv, admin.tb_hocphan hp, admin.tb_chuongtrinh ct where dk.MAHP = hp.MAHP and dk.MASV = sv.MASV and dk.MACT = ct.MACT";
            if (semester > 0)
                query += string.Format(" and HK = {0}", semester);
            if (year > 0)
                query += string.Format(" and NAM = {0}", year);
            if (programName != "null")
                query += string.Format(" and TENCT = '{0}'", programName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                RegisterDTO register = new RegisterDTO(row);
                result.Add(register);
            }
            return result;
        }
        public List<RegisterDTO> SearchUnitChiefRegister(int semester, int year, string programName)
        {
            List<RegisterDTO> result = new List<RegisterDTO>();
            string query = "select dk.*, hp.TENHP, ct.TENCT from admin.uv_xemdangky dk, admin.tb_hocphan hp, admin.tb_chuongtrinh ct where dk.MAHP = hp.MAHP and dk.MACT = ct.MACT";
            if (semester > 0)
                query += string.Format(" and HK = {0}", semester);
            if (year > 0)
                query += string.Format(" and NAM = {0}", year);
            if (programName != "null")
                query += string.Format(" and TENCT = '{0}'", programName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                RegisterDTO register = new RegisterDTO(row);
                result.Add(register);
            }
            return result;
        }
        public List<RegisterDTO> SearchStudentRegister(int semester, int year, string programName)
        {
            List<RegisterDTO> result = new List<RegisterDTO>();
            string query = "select dk.*, null as HOTENGV, sv.HOTEN as HOTENSV, hp.TENHP, ct.TENCT from admin.tb_dangky dk, admin.tb_sinhvien sv, admin.tb_hocphan hp, admin.tb_chuongtrinh ct where dk.MAHP = hp.MAHP and dk.MASV = sv.MASV and dk.MACT = ct.MACT";
            if (semester > 0)
                query += string.Format(" and HK = {0}", semester);
            if (year > 0)
                query += string.Format(" and NAM = {0}", year);
            if (programName != "null")
                query += string.Format(" and TENCT = '{0}'", programName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                RegisterDTO register = new RegisterDTO(row);
                result.Add(register);
            }
            return result;
        }
        public bool UpdateRegister(string studentID , string courseID, int semester, int year, string programID, int practice, int process, int final, int finalfinal)
        {
            string query = string.Format("begin admin.USP_CAPNHATDIEMSV('{0}', '{1}', {2}, {3}, '{4}', {5}, {6}, {7}, {8}); end;",studentID, courseID, semester, year, programID, practice, process, final, finalfinal);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteRegisterByID(string id)
        {
            string query = string.Format("begin delete from admin.tb_nhansu where MANV = {0}; end;", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
            
        }
       
        public PersonelDTO GetPersonelByID(string personelID)
        {
            string query = string.Format("select * from admin.tb_nhansu where lower(MANV) like lower('%{0}%')", personelID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            PersonelDTO result = new PersonelDTO(data.Rows[0]);
            return result;
        }
    }
}
