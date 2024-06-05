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
    public partial class Add_Student : Form
    {
        BindingSource programList = new BindingSource();
        BindingSource majorList = new BindingSource();
        public Add_Student()
        {
            InitializeComponent();
            Load_Auto_ID("Chinh quy");

            Load();
        }
        private void Load_Auto_ID(string program)
        {
            string id_program = ProgramDAO.Instance.GetIDProgram(program);
            tb_id.Text = StudentDAO.Instance.GetIDAuto(id_program);
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

        private void cbB_program_SelectedIndexChanged(object sender, EventArgs e)
        {
            string program = cbB_program.Text;
            Load_Auto_ID(program);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_name.Text;
            string gender = cbB_gender.Text;
            DateTime birth = tb_birth.Value;
            string addr = tb_addr.Text;
            string phone = tb_phone.Text;
            string program = ProgramDAO.Instance.GetIDProgram(cbB_program.Text);
            string major = MajorDAO.Instance.GetIDMajor(cbB_major.Text);
            int credit = 0;
            float GPA = 0;
            try
            {
                StudentDAO.Instance.Add_Student(id, name, gender, birth.Date, addr, phone, program, major, credit, GPA);
                PhanHe2.Success success = new PhanHe2.Success();
                success.ShowDialog();
            }
            catch (OracleException oe)
            {
                MessageBox.Show(oe.Message, "Lỗi");
            }
        }
    }
}
