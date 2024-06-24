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
        string curRole;
        string curUser;
        int clickedRow = 0;
        List<RegisterDTO> registers;
        public View_InfoRegister()
        {
            InitializeComponent();
            curRole = UserDAO.Instance.GetRole(Home_Login.Login.User);
            curUser = Home_Login.Login.User;
            UpdateInterface();
            LoadComboBox();
            LoadGrid();
        }
        private void UpdateInterface()
        {
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
            if (curRole == "Giang vien")
                registers = RegisterDAO.Instance.GetLecturerRegisterList();
            else if (curRole == "Giao vu")
            {
                registers = RegisterDAO.Instance.GetRegistrarRegisterList();
            }
            else if (curRole == "Truong don vi")
            {
                registers = RegisterDAO.Instance.GetUnitChiefRegisterList();
            }  
            else if (curRole == "Sinh vien")
            {
                registers = RegisterDAO.Instance.GetStudentRegisterList();
            }
            else
                registers = RegisterDAO.Instance.GetRegisterList();
            registerList.DataSource = registers;
            if (curRole == "Sinh vien")
                dtGrid_register.Columns["lecturerName"].Visible = false;

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
            OpenChildForm(new PhanHe2.Add_Register(curUser));
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (clickedRow >= 0)
            {
                OpenChildForm(new PhanHe2.Update_Register(registers[clickedRow].studentID, registers[clickedRow].courseID, registers[clickedRow].semester, registers[clickedRow].year, registers[clickedRow].programID, curRole, registers[clickedRow].practice , registers[clickedRow].process, registers[clickedRow].final, registers[clickedRow].finalfinal ));
            }
        }
        private void bt_delete_Click(object sender, EventArgs e)
        {
            using (Confirm_Delete confirm = new Confirm_Delete())
            {
                if (confirm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        RegisterDAO.Instance.DeleteRegister(registers[clickedRow].studentID, registers[clickedRow].courseID, registers[clickedRow].semester, registers[clickedRow].year, registers[clickedRow].programID, registers[clickedRow].lecturerID);
                    }
                    catch (Exception ex)
                    {
                        string exString = ex.ToString();
                            MessageBox.Show("Không trong thời gian hiệu chỉnh!", "Lỗi");
                        return;
                    }
                    PhanHe2.Success success = new PhanHe2.Success();
                    success.ShowDialog();
                }
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                clickedRow = e.RowIndex;
            }
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
            if (curRole == "Giang vien")
                registers = RegisterDAO.Instance.SearchLecturerRegister(semester, year, programName);
            else if (curRole == "Giao vu")
            {
                registers = RegisterDAO.Instance.SearchRegistrarRegister(semester, year, programName);
                dtGrid_register.Columns["lecturerName"].Visible = false;
            }
            else if (curRole == "Truong don vi")
            {
                registers = RegisterDAO.Instance.SearchUnitChiefRegister(semester, year, programName);
            }
            else if (curRole == "Sinh vien")
            {
                registers = RegisterDAO.Instance.SearchStudentRegister(semester, year, programName);
                dtGrid_register.Columns["lecturerName"].Visible = false;
            }
            else
                    registers = RegisterDAO.Instance.SearchRegister(semester, year, programName);
            registerList.DataSource = registers;
            if (curRole == "Sinh vien")
                dtGrid_register.Columns["lecturerName"].Visible = false;
        }

        private void pic_refresh_U_Click(object sender, EventArgs e)
        {
            if (curRole == "Giang vien")
                registers = RegisterDAO.Instance.GetLecturerRegisterList();
            else if (curRole == "Giao vu")
            {
                registers = RegisterDAO.Instance.GetRegistrarRegisterList();
                dtGrid_register.Columns["lecturerName"].Visible = false;
            }
            else if (curRole == "Truong don vi")
            {
                registers = RegisterDAO.Instance.GetUnitChiefRegisterList();
            }
            else if (curRole == "Sinh vien")
            {
                registers = RegisterDAO.Instance.GetStudentRegisterList();
                dtGrid_register.Columns["lecturerName"].Visible = false;
            }
            else
                registers = RegisterDAO.Instance.GetRegisterList();
            registerList.DataSource = registers;
            if (curRole == "Sinh vien")
                dtGrid_register.Columns["lecturerName"].Visible = false;
        }
    }
}
