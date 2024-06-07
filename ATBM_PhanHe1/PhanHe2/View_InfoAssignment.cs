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
    public partial class View_InfoAssignment : Form
    {
        BindingSource assignmentList = new BindingSource();
        string curRole;
        int clickedRow;

        public View_InfoAssignment()
        {
            InitializeComponent();
            curRole = UserDAO.Instance.GetRole(Home_Login.Login.User);
            UpdateInterface();
            LoadComboBox();
            LoadGrid();
        }
        private void UpdateInterface()
        {
            if (curRole == "Giang vien")
            {
                btn_Add.Enabled = false;
                btn_Update.Enabled = false;
                bt_delete.Enabled = false;
            }
            /*if (curRole == "Giao vu")
            {
                btn_Update.Enabled = false;
            }*/
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
            dtGrid_assignment.DataSource = assignmentList;
            if (curRole == "Giang vien")
                assignmentList.DataSource = AssignmentDAO.Instance.GetLecturerAssignmentList();
            else if (curRole == "Giao vu")
            {
                assignmentList.DataSource = AssignmentDAO.Instance.GetRegistrarAssignmentList();
            }
            else
                assignmentList.DataSource = AssignmentDAO.Instance.GetAssignmentList();
            dtGrid_assignment.Columns["courseID"].Visible = false;
            dtGrid_assignment.Columns["programID"].Visible = false;
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
            OpenChildForm(new PhanHe2.Add_Assignment());
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dtGrid_assignment.Rows[clickedRow].Cells[0];
            string lecturerID = cell.Value.ToString();
            cell = dtGrid_assignment.Rows[clickedRow].Cells[2];
            string courseID = cell.Value.ToString();
            cell = dtGrid_assignment.Rows[clickedRow].Cells[4];
            string semester = cell.Value.ToString();
            cell = dtGrid_assignment.Rows[clickedRow].Cells[5];
            string year = cell.Value.ToString();
            cell = dtGrid_assignment.Rows[clickedRow].Cells[6];
            string programID = cell.Value.ToString();
            OpenChildForm(new PhanHe2.Update_Assignment(courseID, lecturerID, semester, year, programID));
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            PhanHe2.Success success = new PhanHe2.Success();
            success.ShowDialog();
        }

        private void pic_refresh_U_Click(object sender, EventArgs e)
        {
            if (curRole == "Giang vien")
                assignmentList.DataSource = AssignmentDAO.Instance.GetLecturerAssignmentList();
            else if (curRole == "Giao vu")
            {
                assignmentList.DataSource = AssignmentDAO.Instance.GetRegistrarAssignmentList();
            }

            else
                assignmentList.DataSource = AssignmentDAO.Instance.GetAssignmentList();
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
                    return;
                }
            }
            string programName = cbB_program.SelectedItem.ToString();
            if (curRole == "Giang vien")
                assignmentList.DataSource = AssignmentDAO.Instance.LecturerSearchAssignment(semester, year, programName);
            else if (curRole == "Giao vu")
                assignmentList.DataSource = AssignmentDAO.Instance.RegistrarSearchAssignment(semester, year, programName);
            else
                assignmentList.DataSource = AssignmentDAO.Instance.SearchAssignment(semester, year, programName);
        }

        private void dtGrid_assignment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                clickedRow = e.RowIndex;
            }
        }
    }
}
