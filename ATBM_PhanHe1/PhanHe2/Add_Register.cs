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
    public partial class Add_Register : Form
    {
        string curRole;
        public Add_Register(string studentID)
        {
            InitializeComponent();
            Load(studentID);
            LoadComboBox();
        }
        private void Load(string studentID)
        {
            curRole = UserDAO.Instance.GetRole(Home_Login.Login.User);
            if (curRole == "Sinh vien")
            {
                tb_idstudent.Text = studentID;
                tb_namestudent.Text = StudentDAO.Instance.GetStudentByID(studentID).studentName;
            }
        }
        private void LoadComboBox()
        {
            List<CourseDTO> courses = CourseDAO.Instance.GetCourseList();
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
            cbB_semester.Items.Add("1");
            cbB_semester.Items.Add("2");
            cbB_semester.Items.Add("3");
            cbB_idcourses.SelectedIndex = 0;
            cbB_idprogram.SelectedIndex = 0;
            cbB_nameCourses.SelectedIndex = 0;
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

        private void cbB_nameprograme_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_idprogram.SelectedIndex = cbB_nameprograme.SelectedIndex;
        }

        private void cbB_idprogram_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_nameprograme.SelectedIndex = cbB_idprogram.SelectedIndex;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int year = 0;
            int semester = 0;
            if (cbB_semester.SelectedItem.ToString() != "null")
                semester = int.Parse(cbB_semester.SelectedItem.ToString());
            if (tb_year.Text != "")
            {
                try
                {
                    year = int.Parse(tb_year.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Năm không hợp lệ!", "Lỗi");
                    return;
                }
                try
                {
                    RegisterDAO.Instance.AddRegister(tb_idstudent.Text, cbB_idcourses.Text, semester, year, cbB_idprogram.Text);
                    PhanHe2.Success success = new PhanHe2.Success();
                    success.ShowDialog();
                }
                catch (Exception ex)
                {
                    string exString = ex.ToString();
                    if (exString.Contains("fk_mahp_DANGKY"))
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

        private void tb_idstudent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tb_namestudent.Text = StudentDAO.Instance.GetStudentByID(tb_idstudent.Text).studentName;
            }
            catch (Exception)
            {
                tb_namestudent.Text = "";
                return;
            }
        }
    }
}
