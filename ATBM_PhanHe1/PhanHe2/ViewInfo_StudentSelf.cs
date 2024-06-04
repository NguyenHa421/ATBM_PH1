using ATBM_PhanHe1.DAO;
using ATBM_PhanHe1.DTO;
using ATBM_PhanHe1.Home_Login;
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
    public partial class ViewInfo_StudentSelf : Form
    {
        public ViewInfo_StudentSelf()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            StudentDTO curStudent = StudentDAO.Instance.GetStudentByID(Login.User);
            ProgramDTO curProgram = ProgramDAO.Instance.GetProgramByID(curStudent.programID);
            MajorDTO curMajor = MajorDAO.Instance.GetMajorByID(curStudent.majorID);
            tb_id.Text = curStudent.studentID;
            tb_name.Text = curStudent.studentName;
            tb_birth.Text = curStudent.birthday.ToString();
            tb_credits.Text = curStudent.credits.ToString();
            tb_gender.Text = curStudent.gender;
            tb_gpa.Text = curStudent.gpa.ToString();
            tb_major.Text = curMajor.majorName;
            tb_phone.Text = curStudent.phone;
            tb_program.Text = curProgram.programName;
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanHe2.Update_StudentSelf());
        }
    }
}
