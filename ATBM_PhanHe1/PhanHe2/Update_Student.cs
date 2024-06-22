using ATBM_PhanHe1.DAO;
using Oracle.ManagedDataAccess.Client;
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
            Load_Info();
        }
        private void Load_Info()
        {
            tb_name.Text = UserDAO.Instance.GetNameStudent(tb_id.Text);
            cbB_gender.Text = StudentDAO.Instance.GetGenderStudent(tb_id.Text);
            tb_birth.Text = StudentDAO.Instance.GetBirthStudent2(tb_id.Text);
            tb_phone.Text = StudentDAO.Instance.GetPhoneStudent(tb_id.Text);
            tb_address.Text = StudentDAO.Instance.GetAddressStudent(tb_id.Text);
            cbB_program.Text = StudentDAO.Instance.GetProgramStudent(tb_id.Text);
            cbB_major.Text = StudentDAO.Instance.GetMajorStudent(tb_id.Text);
            tb_credit.Text = StudentDAO.Instance.GetCreditStudent(tb_id.Text);
            tb_GPA.Text = StudentDAO.Instance.GetGPAStudent(tb_id.Text);
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_name.Text;
            string gender = cbB_gender.Text;
            DateTime birth = tb_birth.Value;
            string addr = tb_address.Text;
            string program = ProgramDAO.Instance.GetIDProgram(cbB_program.Text);
            string major = MajorDAO.Instance.GetIDMajor(cbB_major.Text);
            int credit = int.Parse(tb_credit.Text);
            float GPA = float.Parse(tb_GPA.Text);

            if (tb_phone.Text.Length != 10 || !tb_phone.Text.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi");
                return;
            }

            using (Confirm_Update confirm = new Confirm_Update())
            {
                if (confirm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StudentDAO.Instance.Update_Student(id, name, gender, birth.Date, addr, tb_phone.Text, program, major, credit, GPA);
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
    }
}
