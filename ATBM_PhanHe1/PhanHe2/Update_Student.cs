using ATBM_PhanHe1.DAO;
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
    public partial class Update_Student : Form
    {
        BindingSource programList = new BindingSource();
        BindingSource majorList = new BindingSource();
        public Update_Student(string student_id)
        {
            InitializeComponent();
            Load();
            tb_id.Text = student_id;
            tb_name.Text = UserDAO.Instance.GetNameStudent(student_id);
            cbB_gender.Text = StudentDAO.Instance.GetGenderStudent(student_id);
            tb_birth.Text = StudentDAO.Instance.GetBirthStudent(student_id);
            tb_phone.Text = StudentDAO.Instance.GetPhoneStudent(student_id);
            tb_address.Text = StudentDAO.Instance.GetAddressStudent(student_id);
            cbB_program.Text = StudentDAO.Instance.GetProgramStudent(student_id);
            cbB_major.Text = StudentDAO.Instance.GetMajorStudent(student_id);
            tb_credit.Text = StudentDAO.Instance.GetCreditStudent(student_id);
            tb_GPA.Text = StudentDAO.Instance.GetGPAStudent(student_id);
        }
        private void Load()
        {
            cbB_program.DataSource = programList;
            programList.DataSource = ProgramDAO.Instance.GetListProgram();
            cbB_program.DisplayMember = "TENCT";

            cbB_major.DataSource = majorList;
            majorList.DataSource = MajorDAO.Instance.GetListMajor();
            cbB_major.DisplayMember = "TENNGANH";
        }
        private void lb_phone_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            PhanHe2.Confirm_Update confirm_Update = new PhanHe2.Confirm_Update();
            confirm_Update.ShowDialog();
        }
    }
}
