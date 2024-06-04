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
        public List<AssignmentDTO> SearchAssignment(int semester,int year,string programName)
        {
            List<AssignmentDTO> result = new List<AssignmentDTO>();
            string query = string.Format("select admin.tb_phancong.* from admin.tb_phancong, admin.tb_chuongtrinh where admin.tb_phancong.MACT = admin.tb_chuongtrinh.MACT and HK = {0} and NAM = {1} and TENCT = '{2}'", semester, year, programName);
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
