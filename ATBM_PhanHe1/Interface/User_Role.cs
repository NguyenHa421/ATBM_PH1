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
    public partial class User_Role : Form
    {
        public User_Role()
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
        private void DSTK_button_Click(object sender, EventArgs e)
        {
            Interface.Homepage homepage = new Interface.Homepage();
            this.Hide();
            homepage.ShowDialog();
            this.Show();
        }

        private void QLQ_button_Click(object sender, EventArgs e)
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

        private void btn_create_user_Click(object sender, EventArgs e)
        {
            OpenChildForm(new User.Create_U());
        }

        private void btn_delete_user_Click(object sender, EventArgs e)
        {
            OpenChildForm(new User.Delete_U());
        }

        private void btn_create_role_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Role.Create_R());
        }

        private void btn_delete_role_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Role.Delete_R());
        }

        private void btn_update_user_Click(object sender, EventArgs e)
        {
            OpenChildForm(new User.Update_U());
        }

        private void btn_update_role_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Role.Update_R());
        }
    }
}
