using ATBM_PhanHe1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DAO
{
    public class CourseDAO
    {
        private static CourseDAO instance;
        public static CourseDAO Instance
        {
            get { if (instance == null) instance = new CourseDAO(); return CourseDAO.instance; }
            private set { CourseDAO.instance = value; }
        }
        private CourseDAO() { }
        public List<CourseDTO> GetCourseList()
        {
            List<CourseDTO> list = new List<CourseDTO>();
            string query = "select * from admin.tb_hocphan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                CourseDTO course = new CourseDTO(row);
                list.Add(course);
            }
            return list;
        }
        public List<CourseDTO> SearchCourse(string searchKey)
        {
            List<CourseDTO> result = new List<CourseDTO>();
            string query = string.Format("select * from admin.tb_hocphan where lower(TENHP) like lower('%{0}%')", searchKey);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                CourseDTO course = new CourseDTO(row);
                result.Add(course);
            }
            return result;
        }
        public CourseDTO GetCourseByID(string courseID)
        {
            string query = string.Format("select * from admin.tb_hocphan where lower(MAHP) like lower('%{0}%')", courseID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            CourseDTO result = new CourseDTO(data.Rows[0]);
            return result;
        }
        public void AddCource(string  courseId, string courceName, int credits, int lectureNum, int practicalNum, int maxStudent, string unitID)
        {
            string query = string.Format("insert into admin.tb_HOCPHAN values('{0}','{1}',{2},{3},{4},{5},'{6}')", courseId, courceName, credits, lectureNum, practicalNum, maxStudent, unitID);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public bool UpdateCourse(string id, string name, int credit, int theory, int practice, int maxStudent, string unitID)
        {
            string query = string.Format("update tb_hocphan set TENHP = {0}, SOTC = {1}, STLT = {2}, STTH = {3}, SOSVTD = {4}, MADV = '{5}' where MAHP = '{6}'", name, credit, theory, practice, maxStudent, unitID, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
