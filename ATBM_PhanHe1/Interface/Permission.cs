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
        public Permission()
        {
            InitializeComponent();
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

        private void QLur_button_Click(object sender, EventArgs e)
        {
            Interface.User_Role user_Role = new Interface.User_Role();
            this.Hide();
            user_Role.ShowDialog();
            this.Show();
        }

        private void DSTK_button_Click(object sender, EventArgs e)
        {
            Interface.Homepage homepage = new Interface.Homepage();
            this.Hide();
            homepage.ShowDialog();
            this.Show();
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
