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
        private void btn_revoke_user_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Users_Roles.Revorke_U());
        }

        private void btn_grant_user_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Users_Roles.Grant_U());
        }

        private void btn_revoke_role_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Users_Roles.Revorke_R());
        }

        private void btn_grant_role_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Users_Roles.Grant_R());
        }

        private void btn_role_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Users_Roles.Grant_U_R());
        }
    }
}
