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
        }
        private void Load(string studentID)
        {
            LoadStudent(studentID);
            LoadProgram();
            LoadCourse();
            LoadSemester();
        }
        private void LoadStudent(string studentID)
        {
            curRole = UserDAO.Instance.GetRole(Home_Login.Login.User);
            if (curRole == "Sinh vien")
            {
                cbB_studentId.Items.Add(studentID);
                StudentDTO curStudent = StudentDAO.Instance.GetStudentByID(studentID);
                cbB_studentName.Items.Add(curStudent.studentName);
                cbB_studentId.SelectedIndex = 0;
                cbB_studentName.SelectedIndex = 0;
                cbB_studentId.DropDownStyle = ComboBoxStyle.DropDownList;
                cbB_studentName.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                List<StudentDTO> students = StudentDAO.Instance.GetStudentList();
                foreach (StudentDTO student in students)
                {
                    cbB_studentId.Items.Add(student.studentID);
                    cbB_studentName.Items.Add(student.studentName);
                }
                cbB_studentId.SelectedIndex = 0;
                cbB_studentName.SelectedIndex = 0;
            }
        }
        private void LoadCourse()
        {
            cbB_idcourses.Items.Clear();
            cbB_nameCourses.Items.Clear();
            List<string> coursesID = PlanCoursesDAO.Instance.GetPlanCourseIDByProgram(tb_programId.Text);
            foreach (string courseID in coursesID)
            {
                cbB_idcourses.Items.Add(courseID);
                CourseDTO course = CourseDAO.Instance.GetCourseByID(courseID);
                cbB_nameCourses.Items.Add(course.courseName);
            }
            cbB_idcourses.SelectedIndex = 0;
            cbB_nameCourses.SelectedIndex = 0;
        }
        private void LoadSemester()
        {
            cbB_semester.Items.Add("1");
            cbB_semester.Items.Add("2");
            cbB_semester.Items.Add("3");
            cbB_semester.SelectedIndex = 0;
        }
        private void LoadProgram()
        {
            tb_programName.Text = StudentDAO.Instance.GetProgramStudent(cbB_studentId.Text);
            tb_programId.Text = ProgramDAO.Instance.GetIDProgram(tb_programName.Text);
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
                    if (RegisterDAO.Instance.AddRegister(cbB_studentId.Text, cbB_idcourses.Text, semester, year, tb_programId.Text))
                    {
                        PhanHe2.Success success = new PhanHe2.Success();
                        success.ShowDialog();
                    }                
                }
                catch (Exception ex)
                {
                    string exString = ex.ToString();
                    if (exString.Contains("FK_MAHP_DANGKY"))
                    {
                        MessageBox.Show("Không có lịch mở học phần này!", "Lỗi");
                    }
                    else if (exString.Contains("14 NGAY"))
                    {
                        MessageBox.Show("Không thể hiệu chỉnh đăng ký học phần sau 14 ngày kể từ ngày bắt đầu học kỳ!", "Lỗi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Năm không thể bỏ trống!", "Lỗi");
            }

        }
        private void cbB_studentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_studentName.SelectedIndex = cbB_studentId.SelectedIndex;
            LoadProgram();
            LoadCourse();
        }

        private void cbB_studentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_studentId.SelectedIndex = cbB_studentName.SelectedIndex;
            LoadProgram();
            LoadCourse();
        }
    }
}
