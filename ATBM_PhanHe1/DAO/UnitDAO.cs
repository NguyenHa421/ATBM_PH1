using ATBM_PhanHe1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DAO
{
    public class UnitDAO
    {
        private static UnitDAO instance;
        public static UnitDAO Instance
        {
            get { if (instance == null) instance = new UnitDAO(); return UnitDAO.instance; }
            private set { UnitDAO.instance = value; }
        }
        private UnitDAO() { }
        public List<UnitDTO> GetUnitList()
        {
            List<UnitDTO> list = new List<UnitDTO>();
            string query = "select * from tb_donvi";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                UnitDTO unit = new UnitDTO(row);
                list.Add(unit);
            }
            return list;
        }
        public List<UnitDTO> SearchUnit(string searchKey)
        {
            List<UnitDTO> result = new List<UnitDTO>();
            string query = string.Format("select * from tb_donvi where lower(TENDV) like lower('%{0}%')", searchKey);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                UnitDTO unit = new UnitDTO(row);
                result.Add(unit);
            }
            return result;
        }
        public UnitDTO GetUnitByName(string unitName)
        {
            string query = string.Format("select * from tb_donvi where lower(TENDV) like lower('%{0}%')", unitName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            UnitDTO unit = new UnitDTO(data.Rows[0]);
            return unit;
        }
        public UnitDTO GetUnitByID(string unitID)
        {
            string query = string.Format("select * from tb_donvi where lower(MADV) like lower('%{0}%')", unitID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            UnitDTO unit = new UnitDTO(data.Rows[0]);
            return unit;
        }
    }
}
