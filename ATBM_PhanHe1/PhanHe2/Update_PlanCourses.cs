using ATBM_PhanHe1.DAO;
using ATBM_PhanHe1.DTO;
using System.Linq;

namespace ATBM_PhanHe1.PhanHe2
{
    public partial class Update_PlanCourses : Form
    {
        List<ProgramDTO> listP = ProgramDAO.Instance.GetProgramList();
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
            for (int i = 0; i < listP.Count; i++)
            {
                cbB_idprogram.Items.Add(listP[i].programID);
                cbB_nameprogram.Items.Add(listP[i].programName);
            }
        }
        string oldsemester, oldyear, oldprogram;
        private void Load(string courseID, int semester, int year, string programID)
        {
            CourseDTO course = CourseDAO.Instance.GetCourseByID(courseID);
            ProgramDTO program = ProgramDAO.Instance.GetProgramByID(programID);
            tb_idcourse.Text = courseID;
            tb_namecourse.Text = course.courseName;
            cbB_semester.Text = semester.ToString();
            oldsemester = semester.ToString();
            cbB_year.Text = year.ToString();
            oldyear = year.ToString();
            cbB_idprogram.Text = programID;
            oldprogram = programID.ToString();
            cbB_nameprogram.Text = program.programName;
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
                        PlanCoursesDAO.Instance.UpdatePlanCourses(tb_idcourse.Text, cbB_semester.Text, cbB_year.Text, cbB_idprogram.Text, oldsemester, oldyear, oldprogram);
                    }
                    catch (Exception ex)
                    {
                        if (ex.ToString().Contains("ADMIN.FK_KHMO_PHANCONG"))
                        {
                            MessageBox.Show("Kế hoạch môn học này đang được phân công, không thể cập nhật!", "Lỗi");
                            return;
                        }
                        else
                        {
                            MessageBox.Show(ex.Message, "Lỗi");
                            return;
                        }
                    }
                    PhanHe2.Success success = new PhanHe2.Success();
                    success.ShowDialog();
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
    }
}
