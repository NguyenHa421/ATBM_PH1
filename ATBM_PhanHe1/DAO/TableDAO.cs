using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }
        public string[] tables = {"DangKy","PhanCong","KHmo","HocPhan","SinhVien","Nganh","DonVi","NhanSu"};
        public List<string> GetColumns(string tableName)
        {
            List<string> columns = new List<string>();
            string query = "select column_name from all_tab_columns where table_name='" + tableName +"';";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
                columns.Add(row["column_name"].ToString());
            return (columns);
        }
    }
}
