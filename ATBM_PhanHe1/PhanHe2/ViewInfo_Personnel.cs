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
    public partial class ViewInfo_Personnel : Form
    {
        public ViewInfo_Personnel()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            tb_id.Text = Home_Login.Login.User;
            tb_name.Text = UserDAO.Instance.GetNameOther(tb_id.Text);
            tb_birth.Text = PersonelDAO.Instance.GetBirthStaff(tb_id.Text);
            tb_gender.Text = PersonelDAO.Instance.GetGenderStaff(tb_id.Text);
            tb_phone.Text = PersonelDAO.Instance.GetPhoneStaff(tb_id.Text);
            tb_allowance.Text = PersonelDAO.Instance.GetGenderStaff(tb_id.Text);
            tb_role.Text = PersonelDAO.Instance.GetRoleStaff(tb_id.Text);
            tb_id_unit.Text = PersonelDAO.Instance.GetIDUnitStaff(tb_id.Text);
            tb_name_unit.Text = PersonelDAO.Instance.GetUnitStaff(tb_id.Text);
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
            OpenChildForm(new PhanHe2.Update_Info_Personnel());
        }

        private void pic_refresh_U_Click(object sender, EventArgs e)
        {
            Load();
        }
    }
}
