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

namespace ATBM_PhanHe1.PhanHe2
{
    public partial class View_InfoStudent : Form
    {
        BindingSource studentList = new BindingSource();
        public View_InfoStudent()
        {
            InitializeComponent();
            if (UserDAO.Instance.GetRole(Home_Login.Login.User) == "Nhan vien co ban")
            {
                btn_Add.Enabled = false;
                btn_Update.Enabled = false;
            }
            if (UserDAO.Instance.GetRole(Home_Login.Login.User) == "Truong khoa")
            {
                btn_Add.Enabled = false;
                btn_Update.Enabled = false;
            }
            if (UserDAO.Instance.GetRole(Home_Login.Login.User) == "Giang vien")
            {
                btn_Add.Enabled = false;
                btn_Update.Enabled = false;
            }
            if (UserDAO.Instance.GetRole(Home_Login.Login.User) == "Truong don vi")
            {
                btn_Add.Enabled = false;
                btn_Update.Enabled = false;
            }
            Load();
        }
        private void Load()
        {
            dtGrid_student.DataSource = studentList;
            studentList.DataSource = StudentDAO.Instance.GetStudentList();
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

        private void btn_Back_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanHe2.Update_Student());
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanHe2.Add_Student());
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            studentList.DataSource = StudentDAO.Instance.SearchStudent(tb_id.Text, tb_name.Text);
        }

        private void pic_refresh_U_Click(object sender, EventArgs e)
        {
            studentList.DataSource = StudentDAO.Instance.GetStudentList();
        }
    }
}
