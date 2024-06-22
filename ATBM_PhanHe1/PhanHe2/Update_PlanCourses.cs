using ATBM_PhanHe1.DAO;
using ATBM_PhanHe1.DTO;

namespace ATBM_PhanHe1.PhanHe2
{
    public partial class Update_PlanCourses : Form
    {
        List<CourseDTO> listC = CourseDAO.Instance.GetCourseList();
        List<ProgramDTO> listP = ProgramDAO.Instance.GetProgramList();
        public Update_PlanCourses(string courseID, int semester, int year, string programID)
        {
            InitializeComponent();
            LoadComboBox();
            Load(courseID, semester, year, programID);
            cbB_idcourses.SelectedIndexChanged += cbB_idcourses_SelectedIndexChanged;
            cbB_nameCourses.SelectedIndexChanged += cbB_nameCourses_SelectedIndexChanged;
            cbB_idprogram.SelectedIndexChanged += cbB_idprogram_SelectedIndexChanged;
            cbB_nameprogram.SelectedIndexChanged += cbB_nameprogram_SelectedIndexChanged;
        }
        private void LoadComboBox()
        {
            for (int i = 0; i < listC.Count; i++)
            {
                cbB_idcourses.Items.Add(listC[i].courseID);
                cbB_nameCourses.Items.Add(listC[i].courseName);
            }

            cbB_year.Items.Add("2022");
            cbB_year.Items.Add("2023");
            cbB_year.Items.Add("2024");
            cbB_year.Items.Add("2025");

            for (int i = 0; i < listP.Count; i++)
            {
                cbB_idprogram.Items.Add(listP[i].programID);
                cbB_nameprogram.Items.Add(listP[i].programName);
            }
        }
        private void Load(string courseID, int semester, int year, string programID)
        {
            CourseDTO course = CourseDAO.Instance.GetCourseByID(courseID);
            ProgramDTO program = ProgramDAO.Instance.GetProgramByID(programID);
            int idx = -1;
            idx = cbB_idcourses.FindString(courseID);
            cbB_idcourses.SelectedIndex = idx;
            idx = cbB_nameCourses.FindString(course.courseName);
            cbB_nameCourses.SelectedIndex = idx;
            idx = cbB_semester.FindString(semester.ToString());
            cbB_semester.SelectedIndex = idx;
            idx = cbB_year.FindString(year.ToString());
            cbB_year.SelectedIndex = idx;
            idx = cbB_idprogram.FindString(programID);
            cbB_idprogram.SelectedIndex = idx;
            idx = cbB_nameprogram.FindString(program.programName);
            cbB_nameprogram.SelectedIndex = idx;
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                PlanCoursesDAO.Instance.UpdatePlanCourses(cbB_idcourses.SelectedItem.ToString(), cbB_semester.SelectedItem.ToString(), cbB_year.SelectedItem.ToString(), cbB_idprogram.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật không thành công!", "Lỗi");
                return;
            }
            PhanHe2.Success success = new PhanHe2.Success();
            success.ShowDialog();
        }
        private void cbB_nameCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbB_nameCourses.SelectedItem != null)
            {
                var selectedName = cbB_nameCourses.Text;
                var selectedCourse = listC.FirstOrDefault(s => s.courseName == selectedName);
                if (selectedCourse != null)
                {
                    cbB_idcourses.Text = selectedCourse.courseID;
                }
            }
        }
        private void cbB_idcourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbB_idcourses.SelectedItem != null)
            {
                var selectedID = cbB_idcourses.Text;
                var selectedCourse = listC.FirstOrDefault(s => s.courseID == selectedID);
                if (selectedCourse != null)
                {
                    cbB_nameCourses.Text = selectedCourse.courseName;
                }
            }
        }
        private void cbB_nameprogram_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbB_nameprogram.SelectedItem != null)
            {
                var selectedName = cbB_nameprogram.Text;
                var selectedProgram = listP.FirstOrDefault(s => s.programName == selectedName);
                if (selectedProgram != null)
                {
                    cbB_idprogram.Text = selectedProgram.programID;
                }
            }
        }
        private void cbB_idprogram_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbB_idprogram.SelectedItem != null)
            {
                var selectedID = cbB_idprogram.Text;
                var selectedProgram = listP.FirstOrDefault(s => s.programID == selectedID);
                if (selectedProgram != null)
                {
                    cbB_nameprogram.Text = selectedProgram.programName;
                }
            }
        }
    }
}
