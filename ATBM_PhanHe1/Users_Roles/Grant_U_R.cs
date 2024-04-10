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
    public partial class Grant_U_R : Form

    {
        BindingSource roleList = new BindingSource();
        BindingSource userroletList = new BindingSource();
        public Grant_U_R(string userName)
        {
            InitializeComponent();
            tb_user.Text = userName;
            Load();
        }
        private void Load()
        {
            cbB_listRole.DataSource = roleList;
            roleList.DataSource = RoleDAO.Instance.ListRole_CbB();
            cbB_listRole.DisplayMember = "ROLE";
        }
        private void Load_Grid()
        {
            dtGrid_UserRole.DataSource = userroletList;
            userroletList.DataSource = UserDAO.Instance.ListUserRole_Table(tb_user.Text);
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_View_Click(object sender, EventArgs e)
        {
            Load_Grid();
        }

        private void btn_grant_Click(object sender, EventArgs e)
        {
            string userName = tb_user.Text;
            string roleName = cbB_listRole.Text;
            int adminOption = cB_grant.Checked ? 1 : 0;
            try
            {
                UserDAO.Instance.Grant_Role_To_User(userName, roleName, adminOption);
                MessageBox.Show("Cấp quyền thành công", "Thông báo");
            }
            catch (OracleException oe)
            {
                MessageBox.Show(oe.Message, "Lỗi");
            }
            Load_Grid();
        }

        private void bt_revoke_Click(object sender, EventArgs e)
        {
            string userName = tb_user.Text;
            string roleName = cbB_listRole.Text;
            try
            {
                UserDAO.Instance.Revoke_Role_From_User(userName, roleName);
                MessageBox.Show("Thu hồi thành công", "Thông báo");
            }
            catch (OracleException oe)
            {
                MessageBox.Show(oe.Message, "Lỗi");
            }
            Load_Grid();
        }
    }
}
