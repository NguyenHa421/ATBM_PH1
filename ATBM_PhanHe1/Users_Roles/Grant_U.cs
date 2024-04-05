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
        public Grant_U(string userName)
        {
            InitializeComponent();
            tb_user.Text = userName;
            LoadComboBox();
        }
        private void LoadComboBox()
        {
            for (int i = 0; i < TableDAO.Instance.tables.Length; i++)
                cbB_table.Items.Add(TableDAO.Instance.tables[i]);
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
            cbB_column.Items.Clear();
            List<string> columns = TableDAO.Instance.GetColumns(cbB_table.Text);
            for (int i = 0;i < columns.Count;i++)
                cbB_column.Items.Add(columns[i]);
        }
    }
}
