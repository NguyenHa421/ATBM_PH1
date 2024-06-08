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
    public partial class Add_Assignment : Form
    {
        string unitID;
        public Add_Assignment(string curRole)
        {
            InitializeComponent();
            GetUnitID(curRole);
            LoadComboBox(unitID);
        }
        private void GetUnitID(string curRole)
        {
            if (curRole == "Truong don vi")
            {
                unitID = UserDAO.Instance.GetUnitChiefUnitID(Home_Login.Login.User);
            }
            else
            {
                unitID = "DV01";
            }
        }
        private void LoadComboBox(string unitID)
        {
            List<CourseDTO> courses = CourseDAO.Instance.GetCourseByUnitID(unitID);
            foreach (CourseDTO course in courses)
            {
                cbB_idcourses.Items.Add(course.courseID);
                cbB_nameCourses.Items.Add(course.courseName);
            }
            List<ProgramDTO> programs = ProgramDAO.Instance.GetProgramList();
            foreach (ProgramDTO program in programs)
            {
                cbB_idprogram.Items.Add(program.programID);
                cbB_nameprograme.Items.Add(program.programName);
            }
            List<PersonelDTO> lecturers = PersonelDAO.Instance.GetListLecturer();
            foreach (PersonelDTO lecturer in lecturers)
            {
                cbB_idlecture.Items.Add(lecturer.personelID);
                cbB_namelecture.Items.Add(lecturer.personelName);
            }
            cbB_semester.Items.Add("1");
            cbB_semester.Items.Add("2");
            cbB_semester.Items.Add("3");
            cbB_idcourses.SelectedIndex = 0;
            cbB_idlecture.SelectedIndex = 0;
            cbB_idprogram.SelectedIndex = 0;
            cbB_nameCourses.SelectedIndex = 0;
            cbB_namelecture.SelectedIndex = 0;
            cbB_nameprograme.SelectedIndex = 0;
            cbB_semester.SelectedIndex = 0;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbB_idcourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_nameCourses.SelectedIndex = cbB_idcourses.SelectedIndex;
        }

        private void cbB_nameCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_idcourses.SelectedIndex = cbB_nameCourses.SelectedIndex;
        }

        private void cbB_idprogram_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_nameprograme.SelectedIndex = cbB_idprogram.SelectedIndex;
        }

        private void cbB_nameprograme_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_idprogram.SelectedIndex = cbB_nameprograme.SelectedIndex;
        }

        private void cbB_idlecture_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_namelecture.SelectedIndex = cbB_idlecture.SelectedIndex;
        }

        private void cbB_namelecture_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_idlecture.SelectedIndex = cbB_namelecture.SelectedIndex;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_year.Text != "")
            {
                int year;
                try
                {
                    year = int.Parse(tb_year.Text);
                }
                catch(Exception)
                {
                    MessageBox.Show("Năm không hợp lệ!", "Lỗi");
                    return;
                }
                try
                {
                    AssignmentDAO.Instance.UnitChiefAddAssignment(cbB_idcourses.Text, cbB_semester.Text, year, cbB_idprogram.Text, cbB_idlecture.Text);
                }
                catch(Exception ex)
                {
                    string exString = ex.ToString();
                    if (exString.Contains("fk_KHMO_PHANCONG")) 
                    {
                        MessageBox.Show("Không có lịch mở học phần này!", "Lỗi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Năm không thể bỏ trống!", "Lỗi");
            }
        }
    }
}
