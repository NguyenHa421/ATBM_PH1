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
        public View_InfoAssignment()
        {
            InitializeComponent();
            LoadComboBox();
            LoadGrid();
        }
        private void LoadComboBox()
        {
            cbB_semester.Items.Add(1);
            cbB_semester.Items.Add(2);
            cbB_semester.Items.Add(3);
            List<ProgramDTO> list = ProgramDAO.Instance.GetProgramList();
            foreach (ProgramDTO p in list)
                cbB_program.Items.Add(p.programName);
        }
        private void LoadGrid()
        {
            dtGrid_assignment.DataSource = assignmentList;
            assignmentList.DataSource = AssignmentDAO.Instance.GetAssignmentList();
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
            OpenChildForm(new PhanHe2.Update_Assignment());
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            PhanHe2.Confirm_Delete confirm_Delete = new PhanHe2.Confirm_Delete();
            confirm_Delete.ShowDialog();
        }

        private void pic_refresh_U_Click(object sender, EventArgs e)
        {
            assignmentList.DataSource = AssignmentDAO.Instance.GetAssignmentList();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int semester = Int32.Parse(cbB_semester.SelectedValue.ToString());
            int year = Int32.Parse(tb_year.Text);
            string programName = cbB_program.SelectedValue.ToString();
            assignmentList.DataSource = AssignmentDAO.Instance.SearchAssignment(semester, year, programName);
        }
    }
}
