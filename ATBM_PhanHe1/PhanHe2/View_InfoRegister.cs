using ATBM_PhanHe1.DAO;
using ATBM_PhanHe1.DTO;
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
    public partial class View_InfoRegister : Form
    {
        BindingSource registerList = new BindingSource();
        private string clickedRegister = "";
        public View_InfoRegister()
        {
            InitializeComponent();
            if (UserDAO.Instance.GetRole(Home_Login.Login.User) == "Sinh vien")
            {
                btn_Update.Enabled = false;
            }
            if (UserDAO.Instance.GetRole(Home_Login.Login.User) == "Truong khoa")
            {
                btn_Add.Enabled = false;
                btn_delete.Enabled = false;
            }
            if (UserDAO.Instance.GetRole(Home_Login.Login.User) == "Giang vien")
            {
                btn_Add.Enabled = false;
                btn_delete.Enabled = false;
            }
            if (UserDAO.Instance.GetRole(Home_Login.Login.User) == "Giao vu")
            {
                btn_Update.Enabled = false;
            }
            if (UserDAO.Instance.GetRole(Home_Login.Login.User) == "Truong don vi")
            {
                btn_Add.Enabled = false;
                btn_delete.Enabled = false;
            }
            LoadComboBox();
            LoadGrid();
        }
        private void LoadComboBox()
        {
            cbB_semester.Items.Add("null");
            cbB_semester.Items.Add("1");
            cbB_semester.Items.Add("2");
            cbB_semester.Items.Add("3");
            cbB_semester.SelectedIndex = 0;
            cbB_program.Items.Add("null");
            List<ProgramDTO> list = ProgramDAO.Instance.GetProgramList();
            foreach (ProgramDTO p in list)
                cbB_program.Items.Add(p.programName);
            cbB_program.SelectedIndex = 0;
        }
        private void LoadGrid()
        {
            dtGrid_register.DataSource = registerList;
            registerList.DataSource = RegisterDAO.Instance.GetRegisterList();
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanHe2.Add_Register());
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanHe2.Update_Register());
        }
        private void dG_Register_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dG_Register.Rows[e.RowIndex].Cells[0];
                clickedRegister = cell.Value.ToString();
            }
        }
        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (clickedRegister != "")
            {
                string register_id = clickedRegister;
                clickedRegister = "";
                try
                {
                    PhanHe2.Confirm_Delete confirm_Delete = new PhanHe2.Confirm_Delete(register_id);
                    confirm_Delete.ShowDialog();
                }
                catch (OracleException oe)
                {
                    MessageBox.Show(oe.Message, "Lỗi");
                }
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int semester = 0;
            int year = 0;
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
            string programName = cbB_program.SelectedItem.ToString();
            registerList.DataSource = RegisterDAO.Instance.SearchRegister(semester, year, programName);
        }

        private void pic_refresh_U_Click(object sender, EventArgs e)
        {
            registerList.DataSource = RegisterDAO.Instance.GetRegisterList();
        }
    }
}
