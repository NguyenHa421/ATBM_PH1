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
    public partial class Update_Courses : Form
    {
        public Update_Courses(string courseID)
        {
            InitializeComponent();
            Load(courseID);
        }
        private void Load(string courseID)
        {
            CourseDTO course = CourseDAO.Instance.GetCourseByID(courseID);
            LoadTextbox(course);
            LoadComboBox(course.unitID);
        }
        private void LoadTextbox(CourseDTO course)
        {
            tb_id.Text = course.courseID;
            tb_name.Text = course.courseName;
            tb_credit.Text = course.credits.ToString();
            tb_theory.Text = course.lectureNum.ToString();
            tb_practice.Text = course.practicalNum.ToString();
            tb_maxstudent.Text = course.maxStudent.ToString();
        }
        private void LoadComboBox(string unitID)
        {
            List<UnitDTO> units = UnitDAO.Instance.GetUnitList();
            for (int i = 0; i < units.Count; i++)
            {
                cbB_idunit.Items.Add(units[i].unitID);
                cbB_unit.Items.Add(units[i].unitName);
                if (units[i].unitID == unitID)
                {
                    cbB_idunit.SelectedIndex = i;
                    cbB_unit.SelectedIndex = i;
                }
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int credit, theory, practice, maxStudent;
            try
            {
                credit = int.Parse(tb_credit.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số tín chỉ không hợp lệ!", "Lỗi");
                return;
            }
            try
            {
                theory = int.Parse(tb_theory.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số tiết lý thuyết không hợp lệ!", "Lỗi");
                return;
            }
            try
            {
                practice = int.Parse(tb_practice.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số tiết thực hành không hợp lệ!", "Lỗi");
                return;
            }
            try
            {
                maxStudent = int.Parse(tb_maxstudent.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số sinh viên tối đa không hợp lệ!", "Lỗi");
                return;
            }
            using (Confirm_Update confirm = new Confirm_Update())
            {
                if (confirm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        CourseDAO.Instance.UpdateCourse(tb_id.Text, tb_name.Text, credit, theory, practice, maxStudent, cbB_idunit.SelectedItem.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cập nhật không thành công!", "Lỗi");
                        return;
                    }
                    PhanHe2.Success success = new PhanHe2.Success();
                    success.ShowDialog();
                }
            }
        } 
        private void cbB_idunit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_unit.SelectedIndex = cbB_idunit.SelectedIndex;
        }

        private void cbB_unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_idunit.SelectedIndex = cbB_unit.SelectedIndex;
        }
    }
}
