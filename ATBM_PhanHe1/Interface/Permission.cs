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

namespace ATBM_PhanHe1.Interface
{
    public partial class Permission : Form
    {
        BindingSource userList = new BindingSource();
        BindingSource roleList = new BindingSource();
        public Permission()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            dtGrid_user.DataSource = userList;
            dtGrid_role.DataSource = roleList;
            userList.DataSource = UserDAO.Instance.GetUserWithPrivs();
            roleList.DataSource = RoleDAO.Instance.GetRoleList();
        }

        private void pic_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_search_user_Click(object sender, EventArgs e)
        {
            userList.DataSource = UserDAO.Instance.SearchUserRole(tb_search_user.Text);
        }

        private void btn_search_role_Click(object sender, EventArgs e)
        {
            roleList.DataSource = RoleDAO.Instance.SearchRole(tb_search_role.Text);
        }

        private void btn_dstk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage newForm = new Homepage();
            newForm.ShowDialog();
            this.Close();
        }
        private void btn_qlur_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Role newForm = new User_Role();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
