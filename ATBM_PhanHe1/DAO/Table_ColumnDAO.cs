using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace ATBM_PhanHe1.DAO
{
    public class Table_ColumnDAO
    {
        private static Table_ColumnDAO instance;
        public static Table_ColumnDAO Instance {
            get { if (instance == null) instance = new Table_ColumnDAO(); return Table_ColumnDAO.instance; }
            private set { Table_ColumnDAO.instance = value; }
        }
        private Table_ColumnDAO() { }
        public DataTable GetListTable()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT table_name FROM user_tables WHERE table_name LIKE 'TB_%'");
        }
        
        public DataTable GetListColumn(string tableName)
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("SELECT * FROM USER_TAB_COLUMNS WHERE table_name = ('{0}')", tableName));
        }
    }
}
