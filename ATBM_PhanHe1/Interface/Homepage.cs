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
    public partial class Homepage : Form
    {
        BindingSource userList = new BindingSource();
        public Homepage()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            dtGrid_user.DataSource = userList;
            userList.DataSource = UserDAO.Instance.GetUserList();
        }
        private void CloseAllFormsExceptFirst()
        {
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            for (int i = 1; i < forms.Length; i++)
            {
                forms[i].Close();
            }
        }
        private void btn_qlur_Click(object sender, EventArgs e)
        {
            Interface.User_Role user_Role = new Interface.User_Role();
            this.Hide();
            user_Role.ShowDialog();
            this.Show();
        }

        private void btn_qlq_Click(object sender, EventArgs e)
        {
            Interface.Permission permission = new Interface.Permission();
            this.Hide();
            permission.ShowDialog();
            this.Show();
        }
        private void pic_logout_Click(object sender, EventArgs e)
        {
            CloseAllFormsExceptFirst();
        }

        private void btn_search_user_Click(object sender, EventArgs e)
        {
            userList.DataSource = UserDAO.Instance.SearchUser(tb_search_user.Text);
        }

        private void pic_refresh_U_Click(object sender, EventArgs e)
        {
            userList.DataSource = UserDAO.Instance.GetUserList();
        }
    }
}
