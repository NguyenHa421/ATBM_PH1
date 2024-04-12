using ATBM_PhanHe1.DAO;
using ATBM_PhanHe1.DTO;
using Oracle.ManagedDataAccess.Client;
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
        BindingSource privsGridSource = new BindingSource();
        public Grant_U(string userName)
        {
            InitializeComponent();
            tb_user.Text = userName;
            LoadComboBox();
            dtGrid_privs.DataSource = privsGridSource;
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
            LoadGrid();
            LoadColumns();
        }
        private void LoadGrid()
        {
            privsGridSource.DataSource = UserDAO.Instance.GetUserPrivsOnTable(tb_user.Text, cbB_table.Text);
        }
        private void LoadColumns()
        {
            cbB_column.DataSource = columnList;
            columnList.DataSource = Table_ColumnDAO.Instance.GetListColumn(cbB_table.Text);
            cbB_column.DisplayMember = "COLUMN_NAME";
        }

        private void bt_grant_Click(object sender, EventArgs e)
        {
            int grantOption = cB_grant.Checked ? 1 : 0;
            List<string> privs = new List<string>();
            foreach (var checkedItem in clb_Privs.CheckedItems)
                privs.Add(checkedItem.ToString());
            if (privs.Count > 0)
            {
                try
                {
                    if (cB_allCol.Checked)
                        UserDAO.Instance.GrantPrivToUser(tb_user.Text, privs, grantOption, cbB_table.Text);
                    else
                        UserDAO.Instance.GrantPrivToUser(tb_user.Text, privs, grantOption, cbB_table.Text, cbB_column.Text);
                    MessageBox.Show("Cấp quyền thành công", "Thông báo");
                }
                catch (OracleException oe)
                {
                    MessageBox.Show(oe.Message, "Lỗi");
                }
            }
            LoadGrid();
        }

        private void cB_allCol_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_allCol.Checked)
                cbB_column.Enabled = false;
            else
                cbB_column.Enabled = true;
        }

        private void bt_View_Click(object sender, EventArgs e)
        {
            privsGridSource.DataSource = UserDAO.Instance.GetUserPrivsAll(tb_user.Text);
        }
    }
}
