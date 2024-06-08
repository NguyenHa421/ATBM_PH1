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
        int clickedRow = -1;
        List<AssignmentDTO> assignments;

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
                btn_delete.Enabled = false;
            }
            else if (curRole == "Giao vu")
            {
                btn_delete.Enabled= false;
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
            dtGrid_assignment.DataSource = assignmentList;
            switch(curRole)
            {
                case "Giang vien":
                    assignments = AssignmentDAO.Instance.GetLecturerAssignmentList();
                    break;
                case "Giao vu":
                    assignments = AssignmentDAO.Instance.GetRegistrarAssignmentList();
                    break;
                case "Truong don vi":
                    assignments = AssignmentDAO.Instance.GetUnitChiefAssignmentList();
                    break;
                default:
                    assignments = AssignmentDAO.Instance.GetDepartmentHeadAssignmentList();
                    break;
            }
            assignmentList.DataSource = assignments;
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
            OpenChildForm(new PhanHe2.Add_Assignment(curRole));
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (clickedRow < 0)
                return;
            if ((curRole == "Giao vu" || curRole == "Truong khoa") && assignments[clickedRow].unitName != "Van phong khoa")
            {
                MessageBox.Show("Chỉ được chỉnh sửa phân công của Văn phòng khoa!", "Lỗi");
                return;
            }
            OpenChildForm(new PhanHe2.Update_Assignment(assignments[clickedRow].courseID, assignments[clickedRow].semester, assignments[clickedRow].year, assignments[clickedRow].programID, assignments[clickedRow].lecturerID, curRole));
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (clickedRow < 0)
                return;
            if (curRole == "Truong khoa" && assignments[clickedRow].unitName != "Van phong khoa")
            {
                MessageBox.Show("Chỉ được xoá phân công của Văn phòng khoa!", "Lỗi");
                return;
            }
            using (Confirm_Delete confirm = new Confirm_Delete())
            {
                if (confirm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (curRole == "Truong don vi")
                            AssignmentDAO.Instance.UnitChiefDeleteAssignment(assignments[clickedRow].courseID, assignments[clickedRow].semester, assignments[clickedRow].year, assignments[clickedRow].programID, assignments[clickedRow].lecturerID);
                        else if (curRole == "Truong khoa")
                            AssignmentDAO.Instance.DepartmentHeadDeleteAssignment(assignments[clickedRow].courseID, assignments[clickedRow].semester, assignments[clickedRow].year, assignments[clickedRow].programID, assignments[clickedRow].lecturerID);
                    }
                    catch (Exception ex)
                    {
                        string exString = ex.ToString();
                        if (exString.Contains("14 NGAY"))
                            MessageBox.Show("Không thể xoá phân công sau 14 ngày!", "Lỗi");
                        else
                            MessageBox.Show("Xoá không thành công!", "Lỗi");
                        return;
                    }
                    PhanHe2.Success success = new PhanHe2.Success();
                    success.ShowDialog();
                }
            }
        }

        private void pic_refresh_U_Click(object sender, EventArgs e)
        {
            switch (curRole)
            {
                case "Giang vien":
                    assignments = AssignmentDAO.Instance.GetLecturerAssignmentList();
                    break;
                case "Giao vu":
                    assignments = AssignmentDAO.Instance.GetRegistrarAssignmentList();
                    break;
                case "Truong don vi":
                    assignments = AssignmentDAO.Instance.GetUnitChiefAssignmentList();
                    break;
                default:
                    assignments = AssignmentDAO.Instance.GetDepartmentHeadAssignmentList();
                    break;
            }
            assignmentList.DataSource = assignments;
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
            switch (curRole)
            {
                case "Giang vien":
                    assignments = AssignmentDAO.Instance.LecturerSearchAssignment(semester, year, programName);
                    break;
                case "Giao vu":
                    assignments = AssignmentDAO.Instance.RegistrarSearchAssignment(semester, year, programName);
                    break;
                case "Truong don vi":
                    assignments = AssignmentDAO.Instance.UnitChiefSearchAssignment(semester, year, programName);
                    break;
                default:
                    assignments = AssignmentDAO.Instance.DepartmentHeadSearchAssignment(semester, year, programName);
                    break;
            }
            assignmentList.DataSource = assignments;
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
