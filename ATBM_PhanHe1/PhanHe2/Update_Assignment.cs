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
    public partial class Update_Assignment : Form
    {
        public Update_Assignment(string courseID, string lecturerID, string semester, string year, string programID)
        {
            InitializeComponent();
            Load(courseID, semester, year, programID);
            LoadComboBox(lecturerID);
        }
        private void Load(string courseID, string semester, string year, string programID)
        {
            CourseDTO course = CourseDAO.Instance.GetCourseByID(courseID);
            ProgramDTO program = ProgramDAO.Instance.GetProgramByID(programID);
            tb_courseID.Text = courseID;
            tb_courseName.Text = course.courseName;
            tb_semester.Text = semester;
            tb_year.Text = year;
            tb_programID.Text = programID;
            tb_programName.Text = program.programName;
        }
        private void LoadComboBox(string lecturerID)
        {
            List<PersonelDTO> list = PersonelDAO.Instance.RegistrarGetListLecturer();
            for (int i = 0; i < list.Count; i++)
            {
                cbB_lecturerID.Items.Add(list[i].personelID);
                cbB_lecturerName.Items.Add(list[i].personelName);
                if (list[i].personelID == lecturerID)
                {
                    cbB_lecturerID.SelectedIndex = i;
                    cbB_lecturerName.SelectedIndex = i;
                }
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            PhanHe2.Success success = new PhanHe2.Success();
            success.ShowDialog();
        }

        private void cbB_lecturerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_lecturerName.SelectedIndex = cbB_lecturerID.SelectedIndex;
        }

        private void cbB_lecturerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_lecturerID.SelectedIndex = cbB_lecturerName.SelectedIndex;
        }
    }
}
