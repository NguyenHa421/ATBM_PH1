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
            string query = "select * from hocphan";
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
            string query = string.Format("select * from hocphan where lower(TENHP) like lower('%{0}%')", searchKey);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                CourseDTO course = new CourseDTO(row);
                result.Add(course);
            }
            return result;
        }
    }
}
