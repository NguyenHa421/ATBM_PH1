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
    public partial class View_InfoCourses : Form
    {
        BindingSource courseList = new BindingSource();
        string clickedCourse = "";
        public View_InfoCourses()
        {
            InitializeComponent();
            Load_Form();
            Load();
        }
        private void Load_Form()
        {
            if (UserDAO.Instance.GetRole(Home_Login.Login.User) == "Sinh vien")
            {
                btn_Add.Enabled = false;
                btn_Update.Enabled = false;
            }
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
        }
        private void Load()
        {
            dtGrid_course.DataSource = courseList;
            courseList.DataSource = CourseDAO.Instance.GetCourseList();
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Add_Courses());
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (clickedCourse != "")
                OpenChildForm(new Update_Courses(clickedCourse));
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            courseList.DataSource = CourseDAO.Instance.SearchCourse(tb_name.Text);
        }

        private void pic_refresh_U_Click(object sender, EventArgs e)
        {
            courseList.DataSource = CourseDAO.Instance.GetCourseList();
        }

        private void dtGrid_course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dtGrid_course.Rows[e.RowIndex].Cells[0];
                clickedCourse = cell.Value.ToString();
            }
        }
    }
}
