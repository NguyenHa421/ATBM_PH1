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
using static System.Windows.Forms.DataFormats;

namespace ATBM_PhanHe1.Interface
{
    public partial class User_Role : Form
    {
        BindingSource userList = new BindingSource();
        BindingSource roleList = new BindingSource();
        private string clickedUser = "";
        public static string SelectedDeleteName { get; set; }
        public User_Role()
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

        private void btn_search_user_Click(object sender, EventArgs e)
        {
            userList.DataSource = UserDAO.Instance.SearchUserRole(tb_search_user.Text);
        }

        private void btn_search_role_Click(object sender, EventArgs e)
        {
            roleList.DataSource = RoleDAO.Instance.SearchRole(tb_search_role.Text);
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Parent_panel.Controls.Add(childForm);
            Parent_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void CloseAllFormsExceptFirst()
        {
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            for (int i = 1; i < forms.Length; i++)
            {
                forms[i].Close();
            }
        }
        private void pic_logout_Click(object sender, EventArgs e)
        {
            CloseAllFormsExceptFirst();
        }

        private void btn_create_user_Click(object sender, EventArgs e)
        {
            OpenChildForm(new User.Create_U());
            userList.DataSource = UserDAO.Instance.GetUserWithPrivs();
        }

        private void dtGrid_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dtGrid_user.Rows[e.RowIndex].Cells[0];
                clickedUser = cell.Value.ToString();
            }
        }

        private void btn_delete_user_Click(object sender, EventArgs e)
        {
            if (clickedUser != "")
            {
                string userName = clickedUser;
                clickedUser = "";
                OpenChildForm(new User.Delete_U(userName));
                userList.DataSource = UserDAO.Instance.GetUserWithPrivs();
            }
        }

        private void btn_create_role_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Role.Create_R());
            roleList.DataSource = RoleDAO.Instance.GetRoleList();
        }

        private void btn_delete_role_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Role.Delete_R());
            roleList.DataSource = RoleDAO.Instance.GetRoleList();
        }

        private void btn_update_user_Click(object sender, EventArgs e)
        {
            OpenChildForm(new User.Update_U(clickedUser));
        }

        private void btn_dstk_Click(object sender, EventArgs e)
        {
            Interface.Homepage hompage = new Interface.Homepage();
            this.Hide();
            hompage.ShowDialog();
            this.Show();
        }

        private void btn_qlq_Click(object sender, EventArgs e)
        {
            Interface.Permission permission = new Interface.Permission();
            this.Hide();
            permission.ShowDialog();
            this.Show();
        }

        private void pic_refresh_U_Click(object sender, EventArgs e)
        {
            userList.DataSource = UserDAO.Instance.GetUserWithPrivs();
        }

        private void pic_refresh_Click(object sender, EventArgs e)
        {
            roleList.DataSource = RoleDAO.Instance.GetRoleList();
        }
        private void dtGrid_role_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string name = dtGrid_role[e.ColumnIndex, e.RowIndex].Value.ToString();
                SelectedDeleteName = name;
            }
        }
    }
}
