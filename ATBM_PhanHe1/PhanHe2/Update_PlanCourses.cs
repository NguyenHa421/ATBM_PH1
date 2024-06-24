using ATBM_PhanHe1.DAO;
using ATBM_PhanHe1.DTO;
using System.Linq;

namespace ATBM_PhanHe1.PhanHe2
{
    public partial class Update_PlanCourses : Form
    {
       
        public Update_PlanCourses(string courseID, int semester, int year, string programID)
        {
            InitializeComponent();
            LoadComboBox();
            Load(courseID, semester, year, programID);
        }
        private void LoadComboBox()
        {
            cbB_year.Items.Add("2022");
            cbB_year.Items.Add("2023");
            cbB_year.Items.Add("2024");
            cbB_year.Items.Add("2025");
        }
        private void Load(string courseID, int semester, int year, string programID)
        {
            CourseDTO course = CourseDAO.Instance.GetCourseByID(courseID);
            ProgramDTO program = ProgramDAO.Instance.GetProgramByID(programID);
            tb_idcourse.Text = courseID;
            tb_namecourse.Text = course.courseName;
            cbB_semester.Text = semester.ToString();
            cbB_year.Text = year.ToString();
            tb_idprogram.Text = programID;
            tb_nameprogram.Text = program.programName;
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            using (Confirm_Update confirm = new Confirm_Update())
            {
                if (confirm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PlanCoursesDAO.Instance.UpdatePlanCourses(tb_idcourse.Text, cbB_semester.Text, cbB_year.Text, tb_idprogram.Text);
                    }
                    catch (Exception ex)
                    {
                        if (e.ToString().Contains("FK_ KHMO_PHANCONG"))
                        {
                            MessageBox.Show("Kế hoạch môn học này đang được phân công, không thể cập nhật!", "Lỗi");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công", "Lỗi");
                            return;
                        }
                    }
                    PhanHe2.Success success = new PhanHe2.Success();
                    success.ShowDialog();
                }
            }
        }
       
    }
}
