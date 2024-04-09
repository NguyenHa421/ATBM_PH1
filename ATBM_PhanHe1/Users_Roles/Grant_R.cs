using ATBM_PhanHe1.DAO;
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
    public partial class Grant_R : Form
    {
        BindingSource tableList = new BindingSource();
        BindingSource columnList = new BindingSource();
        BindingSource roletableList = new BindingSource();
        public Grant_R()
        {
            InitializeComponent();
            tb_user.Text = Interface.Permission.SelectedGrantRole;
            Load();
        }
        private void Load()
        {
            cbB_Tables.DataSource = tableList;
            tableList.DataSource = Table_ColumnDAO.Instance.GetListTable();
            cbB_Tables.DisplayMember = "TABLE_NAME";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbB_Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_Column.DataSource = columnList;
            columnList.DataSource = Table_ColumnDAO.Instance.GetListColumn(cbB_Tables.Text);
            cbB_Column.DisplayMember = "COLUMN_NAME";
        }

        private void Load_Grid()
        {
            dtGrid_role_table.DataSource = roletableList;
            roletableList.DataSource = RoleDAO.Instance.ListRole_Table(tb_user.Text, cbB_Tables.Text);
        }
        private void bt_View_Click(object sender, EventArgs e)
        {
            Load_Grid();
        }

        private void bt_grant_Click(object sender, EventArgs e)
        {
            string role_name = tb_user.Text;
            string table_name = cbB_Tables.Text;
            string column_name = cbB_Column.Text;
            List<string> privs = new List<string>();
            foreach (var checkedItem in clb_Role.CheckedItems)
                privs.Add(checkedItem.ToString());

            if (privs.Count > 0)
            {
                try
                {
                    if (cB_allCol.Checked)
                        RoleDAO.Instance.Grant_Role(role_name, privs, table_name);
                    else
                        RoleDAO.Instance.Grant_Role(role_name, privs, table_name, column_name);
                    MessageBox.Show("Cấp quyền thành công", "Thông báo");
                }
                catch (OracleException oe)
                {
                    MessageBox.Show(oe.Message, "Lỗi");
                }
            }
            Load_Grid();
            
        }

       
    }
}
