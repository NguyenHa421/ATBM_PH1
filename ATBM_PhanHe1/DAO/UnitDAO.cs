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
            string query = "select * from admin.tb_donvi";
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
            string query = string.Format("select * from admin.tb_donvi where lower(TENDV) like lower('%{0}%')", searchKey);
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
            string query = string.Format("select * from admin.tb_donvi where lower(TENDV) like lower('%{0}%')", unitName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            UnitDTO unit = new UnitDTO(data.Rows[0]);
            return unit;
        }
        public UnitDTO GetUnitByID(string unitID)
        {
            string query = string.Format("select * from admin.tb_donvi where lower(MADV) like lower('%{0}%')", unitID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            UnitDTO unit = new UnitDTO(data.Rows[0]);
            return unit;
        }
        public DataTable GetListUnit()
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("SELECT * FROM ADMIN.TB_DONVI"));
        }
        public string GetIDUnit(string name_unit)
        {
            string query = $"SELECT MADV FROM ADMIN.TB_DONVI WHERE TENDV = ('{name_unit}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { name_unit });
            return result.ToString();
        }
        public string GetNameUnitByID(string id_unit)
        {
            string query = $"SELECT TENDV FROM ADMIN.TB_DONVI WHERE MADV = ('{id_unit}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id_unit });
            return result.ToString();
        }
        public string GetNameHeadByID(string id_unit)
        {
            string query = $"SELECT n.HOTEN FROM ADMIN.TB_DONVI tb JOIN ADMIN.UV_XEMGIANGVIEN n ON tb.TRGDV = n.MANV WHERE tb.MADV = ('{id_unit}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id_unit });
            return result != null ? result.ToString() : null;
        }
        public string GetIDHeadByID(string id_unit)
        {
            string query = $"SELECT n.MANV FROM ADMIN.TB_DONVI tb JOIN ADMIN.UV_XEMGIANGVIEN n ON tb.TRGDV = n.MANV WHERE tb.MADV = ('{id_unit}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id_unit });
            return result != null ? result.ToString() : null;
        }
        public bool Update_Unit(string id, string name, string head)
        {
            string query = $"UPDATE ADMIN.TB_DONVI SET TENDV = ('{name}'), TRGDV = ('{head}') WHERE MADV = ('{id}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Add_Unit(string id, string name)
        {
            string query = $"INSERT INTO ADMIN.TB_DONVI (MADV, TENDV) VALUES ('{id}', '{name}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
   
}
