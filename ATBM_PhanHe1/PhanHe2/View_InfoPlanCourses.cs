using ATBM_PhanHe1.DAO;
using ATBM_PhanHe1.DTO;
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
    public partial class View_InfoPlanCourses : Form
    {
        BindingSource planCoursesList = new BindingSource();
        int clickedRow = 0;
        List<PlanCoursesDTO> planCourses = PlanCoursesDAO.Instance.GetPlanCoursesList();
        public View_InfoPlanCourses()
        {
            InitializeComponent();
            UpdateInterface();
            LoadComboBox();
            LoadGrid();
        }
        private void UpdateInterface()
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
        private void LoadComboBox()
        {
            cbB_semester.Items.Add("null");
            cbB_semester.Items.Add("1");
            cbB_semester.Items.Add("2");
            cbB_semester.Items.Add("3");
            cbB_semester.SelectedIndex = 0;
            cbB_program.Items.Add("null");
            List<ProgramDTO> list = ProgramDAO.Instance.GetProgramList();
            foreach (ProgramDTO p in list)
                cbB_program.Items.Add(p.programName);
            cbB_program.SelectedIndex = 0;
        }
        private void LoadGrid()
        {
            dtGrid_planCourses.DataSource = planCoursesList;
            planCoursesList.DataSource = PlanCoursesDAO.Instance.GetPlanCoursesList();
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
            OpenChildForm(new PhanHe2.Add_PlanCourses());
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (clickedRow < 0)
                return;
            OpenChildForm(new PhanHe2.Update_PlanCourses(planCourses[clickedRow].courseID, planCourses[clickedRow].semester, planCourses[clickedRow].year, planCourses[clickedRow].programID));
        }

        private void pic_refresh_U_Click(object sender, EventArgs e)
        {
            planCoursesList.DataSource = PlanCoursesDAO.Instance.GetPlanCoursesList();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int semester = 0;
            int year = 0;
            if (cbB_semester.SelectedItem.ToString() != "null")
                semester = int.Parse(cbB_semester.SelectedItem.ToString());
            if (tb_year.Text != "")
            {
                try
                {
                    year = int.Parse(tb_year.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Năm không hợp lệ!", "Lỗi");
                }
            }
            string programName = cbB_program.SelectedItem.ToString();
            planCoursesList.DataSource = PlanCoursesDAO.Instance.SearchPlanCourses(semester, year, programName);
        }
        private void dtGrid_planCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                clickedRow = e.RowIndex;
            }
        }
    }
}
