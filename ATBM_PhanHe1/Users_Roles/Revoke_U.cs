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

namespace ATBM_PhanHe1.Users_Roles
{
    public partial class Revoke_U : Form
    {
        BindingSource tableList = new BindingSource();
        BindingSource privGridSource = new BindingSource();
        public Revoke_U(string userName)
        {
            InitializeComponent();
            tb_user.Text = userName;
            dtGrid_priv.DataSource = privGridSource;
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
            LoadGrid();
        }
        private void LoadGrid()
        {
            privGridSource.DataSource = UserDAO.Instance.GetUserPrivsOnTable(tb_user.Text, cbB_Tables.Text);
        }

        private void bt_revoke_Click(object sender, EventArgs e)
        {
            List<string> privs = new List<string>();
            foreach (var checkedItem in clb_privs.CheckedItems)
                privs.Add(checkedItem.ToString());
            if (privs.Count > 0)
            {
                try
                {
                    UserDAO.Instance.RevokePrivs(tb_user.Text, privs, cbB_Tables.Text);
                    MessageBox.Show("Thu hồi quyền thành công", "Thông báo");
                }
                catch (OracleException oe)
                {
                    MessageBox.Show(oe.Message, "Lỗi");
                }
            }
            LoadGrid();
        }
    }
}
