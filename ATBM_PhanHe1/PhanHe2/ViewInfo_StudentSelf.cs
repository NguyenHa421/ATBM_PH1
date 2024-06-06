using ATBM_PhanHe1.DAO;
using ATBM_PhanHe1.DTO;
using ATBM_PhanHe1.Home_Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_PhanHe1.PhanHe2
{
    public partial class ViewInfo_StudentSelf : Form
    {
        public ViewInfo_StudentSelf()
        {
            InitializeComponent();
            Load_Info();
        }
        private void Load_Info()
        {
            tb_id.Text = Home_Login.Login.User;
            tb_name.Text = UserDAO.Instance.GetNameStudent(tb_id.Text);
            tb_gender.Text = StudentDAO.Instance.GetGenderStudent(tb_id.Text);
            tb_birth.Text = StudentDAO.Instance.GetBirthStudent(tb_id.Text);
            tb_phone.Text = StudentDAO.Instance.GetPhoneStudent(tb_id.Text);
            tb_addr.Text = StudentDAO.Instance.GetAddressStudent(tb_id.Text);
            tb_program.Text = StudentDAO.Instance.GetProgramStudent(tb_id.Text);
            tb_major.Text = StudentDAO.Instance.GetMajorStudent(tb_id.Text);
            tb_credits.Text = StudentDAO.Instance.GetCreditStudent(tb_id.Text);
            tb_gpa.Text = StudentDAO.Instance.GetGPAStudent(tb_id.Text);
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
            pn_parents.Controls.Add(childForm);
            pn_parents.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanHe2.Update_StudentSelf());
        }

        private void pic_refresh_U_Click(object sender, EventArgs e)
        {
            Load_Info();
        }
    }
}
