using ATBM_PhanHe1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DAO
{
    public class ProgramDAO
    {
        private static ProgramDAO instance;
        public static ProgramDAO Instance
        {
            get { if (instance == null) instance = new ProgramDAO(); return ProgramDAO.instance; }
            private set { ProgramDAO.instance = value; }
        }
        private ProgramDAO() { }
        public List<ProgramDTO> GetProgramList()
        {
            List<ProgramDTO> result = new List<ProgramDTO>();
            string query = "select * from admin.tb_chuongtrinh";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                ProgramDTO program = new ProgramDTO(row);
                result.Add(program);
            }
            return result;
        }
        public ProgramDTO GetProgramByID(string programID)
        {
            string query = string.Format("select * from admin.tb_chuongtrinh where MACT = '{0}'", programID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            ProgramDTO result = new ProgramDTO(data.Rows[0]);
            return result;
        }
    }
}
