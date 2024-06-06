using ATBM_PhanHe1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DAO
{
    public class AssignmentDAO
    {
        private static AssignmentDAO instance;
        public static AssignmentDAO Instance
        {
            get { if (instance == null) instance = new AssignmentDAO(); return AssignmentDAO.instance; }
            private set { AssignmentDAO.instance = value; }
        }
        private AssignmentDAO() { }
        public List<AssignmentDTO> GetAssignmentList()
        {
            List<AssignmentDTO> list = new List<AssignmentDTO>();
            string query = "select pc.*, ns.HOTEN, hp.TENHP, ct.TENCT from admin.tb_phancong pc, admin.tb_nhansu ns, admin.tb_hocphan hp, admin.tb_chuongtrinh ct where pc.MAGV = ns.MANV and pc.MAHP = hp.MAHP and pc.MACT = ct.MACT";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AssignmentDTO course = new AssignmentDTO(row);
                list.Add(course);
            }
            return list;
        }
        public List<AssignmentDTO> GetLecturerAssignmentList()
        {
            List<AssignmentDTO> list = new List<AssignmentDTO>();
            string query = "select pc.*, ns.HOTEN, hp.TENHP, ct.TENCT from admin.uv_gvxemphancong pc, admin.uv_nvxemthongtin ns, admin.tb_hocphan hp, admin.tb_chuongtrinh ct where pc.MAGV = ns.MANV and pc.MAHP = hp.MAHP and pc.MACT = ct.MACT";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AssignmentDTO course = new AssignmentDTO(row);
                list.Add(course);
            }
            return list;
        }
        public List<AssignmentDTO> GetRegistrarAssignmentList()
        {
            List<AssignmentDTO> list = new List<AssignmentDTO>();
            string query = "select pc.*, null as HOTEN, hp.TENHP, ct.TENCT from admin.tb_phancong pc, admin.tb_hocphan hp, admin.tb_chuongtrinh ct where pc.MAHP = hp.MAHP and pc.MACT = ct.MACT";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AssignmentDTO course = new AssignmentDTO(row);
                list.Add(course);
            }
            return list;
        }
        public List<AssignmentDTO> SearchAssignment(int semester,int year,string programName)
        {
            List<AssignmentDTO> result = new List<AssignmentDTO>();
            string query = "select pc.*, ns.HOTEN, hp.TENHP, ct.TENCT from admin.tb_phancong pc, admin.tb_nhansu ns, admin.tb_hocphan hp, admin.tb_chuongtrinh ct where pc.MAGV = ns.MANV and pc.MAHP = hp.MAHP and pc.MACT = ct.MACT";
            if (semester > 0)
                query += string.Format(" and HK = {0}", semester);
            if (year > 0)
                query += string.Format(" and NAM = {0}", year);
            if (programName != "null")
                query += string.Format(" and TENCT = '{0}'", programName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AssignmentDTO assignment = new AssignmentDTO(row);
                result.Add(assignment);
            }
            return result;
        }
    }
}
