using ATBM_PhanHe1.DAO;
using ATBM_PhanHe1.DTO;
using System;
using System.Collections;
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
    public partial class Update_Register : Form
    {
        string curRole;
        public Update_Register(string studentID, string courseID, int semester, int year, string programID, string curRole)
        {
            InitializeComponent();
            this.curRole = curRole;
            Load(studentID, year);
            LoadComboBox(courseID, semester, programID);
        }
        private void Load(string studentID, int year)
        {
            StudentDTO student = StudentDAO.Instance.GetStudentByID(studentID);
            tb_namestudent.Text = student.studentName;
            tb_idstudent.Text = studentID;
            tb_year.Text = year.ToString();
        }
        private void LoadComboBox(string courseID, int semester, string programID)
        {
            cbB_semester.Items.Add("null");
            cbB_semester.Items.Add("1");
            cbB_semester.Items.Add("2");
            cbB_semester.Items.Add("3");
            for (int i =0; i <= 3; i++)
                if( i == semester)
                    cbB_semester.SelectedIndex = i;
            List<ProgramDTO> program = ProgramDAO.Instance.GetProgramList();
            List<CourseDTO> course = CourseDAO.Instance.GetCourseList();
            for (int i = 0; i < program.Count; i++)
            {
                cbB_idprogram.Items.Add(program[i].programID);
                cbB_nameprogram.Items.Add(program[i].programName);
                if (program[i].programID == programID)
                {
                    cbB_idprogram.SelectedIndex = i;
                    cbB_nameprogram.SelectedIndex = i;
                }
            }
            for (int i = 0; i < course.Count; i++)
            {
                cbB_idcourses.Items.Add(course[i].courseID);
                cbB_nameCourses.Items.Add(course[i].courseName);
                if (course[i].courseID == courseID)
                {
                    cbB_idcourses.SelectedIndex = i;
                    cbB_nameCourses.SelectedIndex = i;
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int semester = 0;
            int year = 0;
            int practice = 0, process = 0, final = 0, finalfinal = 0;
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
            if (tb_practice.Text != "")
            {
                try
                {
                    practice = int.Parse(tb_practice.Text);
                    if (practice < 0 || practice > 10)
                    {
                        MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Điểm không hợp lệ!", "Lỗi");
                }
            }

            if (tb_process.Text != "")
            {
                try
                {
                    process = int.Parse(tb_process.Text);
                    if (process < 0 || process > 10)
                    {
                        MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Điểm không hợp lệ!", "Lỗi");
                }
            }
            if (tb_final.Text != "")
            {
                try
                {
                    final = int.Parse(tb_final.Text);
                    if (final < 0 || final > 10)
                    {
                        MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Điểm không hợp lệ!", "Lỗi");
                }
            }
            if (tb_finalfinal.Text != "")
            {
                try
                {
                    finalfinal = int.Parse(tb_finalfinal.Text);
                    if (finalfinal < 0 || finalfinal > 10)
                    {
                        MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Điểm không hợp lệ!", "Lỗi");
                }
            }


            try
            {
                RegisterDAO.Instance.UpdateRegister(tb_idstudent.Text, cbB_idcourses.Text, semester, year, cbB_idprogram.Text, practice, process, final, finalfinal);
                PhanHe2.Success success = new PhanHe2.Success();
                success.ShowDialog();
            }   
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật không thành công!", "Lỗi");
                return;
            }

            
        }
    }
}
