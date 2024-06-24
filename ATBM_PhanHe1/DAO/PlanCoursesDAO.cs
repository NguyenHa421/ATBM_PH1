using ATBM_PhanHe1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DAO
{
    public class PlanCoursesDAO
    {
        private static PlanCoursesDAO instance;
        public static PlanCoursesDAO Instance
        {
            get { if (instance == null) instance = new PlanCoursesDAO(); return PlanCoursesDAO.instance; }
            private set { PlanCoursesDAO.instance = value; }
        }
        private PlanCoursesDAO() { }
        public List<PlanCoursesDTO> GetPlanCoursesList()
        {
            List<PlanCoursesDTO> list = new List<PlanCoursesDTO>();
            string query = "select kh.*, hp.TENHP, ct.TENCT from admin.tb_khmo kh, admin.tb_hocphan hp, admin.tb_chuongtrinh ct where kh.MAHP = hp.MAHP and kh.MACT = ct.MACT";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                PlanCoursesDTO course = new PlanCoursesDTO(row);
                list.Add(course);
            }
            return list;
        }
        public List<PlanCoursesDTO> SearchPlanCourses(int semester, int year, string programName)
        {
            List<PlanCoursesDTO> result = new List<PlanCoursesDTO>();
            string query = "select kh.*, hp.TENHP, ct.TENCT from admin.tb_khmo kh, admin.tb_hocphan hp, admin.tb_chuongtrinh ct where kh.MAHP = hp.MAHP and kh.MACT = ct.MACT";
            if (semester > 0)
                query += string.Format(" and HK = {0}", semester);
            if (year > 0)
                query += string.Format(" and NAM = {0}", year);
            if (programName != "null")
                query += string.Format(" and TENCT = '{0}'", programName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                PlanCoursesDTO PlanCourses = new PlanCoursesDTO(row);
                result.Add(PlanCourses);
            }
            return result;
        }
        public bool UpdatePlanCourses(string courseID, string semester, string year, string programID, string oldsemester, string oldyear, string oldprogramid)
        {
            string query = string.Format("update admin.tb_khmo set HK = '{0}', NAM = '{1}', MACT = '{2}' where MAHP = '{3}' and HK = '{4}' and NAM = '{5}' and MACT = '{6}'", semester, year, programID, courseID, oldsemester, oldyear, oldprogramid);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public void AddPlanCourses(string courseID, string semester, string year, string programID)
        {
            string query = string.Format("insert into admin.tb_khmo values('{0}','{1}','{2}','{3}')", courseID, semester, year, programID);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public List<string> GetPlanCourseIDByProgram(string programID)
        {
            List<string> result = new List<string>();
            string query = string.Format("select distinct mahp from admin.tb_khmo where mact = '{0}'", programID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                result.Add(row["MAHP"].ToString());
            }
            return result;
        }
    }
}
