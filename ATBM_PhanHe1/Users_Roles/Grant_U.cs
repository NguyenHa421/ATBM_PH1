using ATBM_PhanHe1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ATBM_PhanHe1.Users_Roles
{
    public partial class Grant_U : Form
    {
        BindingSource tableList = new BindingSource();
        BindingSource columnList = new BindingSource();
        public Grant_U(string userName)
        {
            InitializeComponent();
            tb_user.Text = userName;
            LoadComboBox();
        }
        private void LoadComboBox()
        {
            cbB_table.DataSource = tableList;
            tableList.DataSource = Table_ColumnDAO.Instance.GetListTable();
            cbB_table.DisplayMember = "TABLE_NAME";
        }
        
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbB_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadColumns();
        }
        private void LoadColumns()
        {
            cbB_column.DataSource = columnList;
            columnList.DataSource = Table_ColumnDAO.Instance.GetListColumn(cbB_table.Text);
            cbB_column.DisplayMember = "COLUMN_NAME";
        }
    }
}
