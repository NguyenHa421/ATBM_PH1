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
    public partial class Homepage_Others : Form
    {
        public Homepage_Others()
        {
            InitializeComponent();
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

        private void bt_info_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanHe2.ViewInfo_Personnel());
        }

        private void bt_student_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanHe2.View_InfoStudent());
        }

        private void bt_unit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanHe2.View_InfoUnit());
        }

        private void bt_course_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanHe2.View_InfoCourses());
        }

        private void bt_plan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanHe2.View_InfoPlanCourses());
        }

        private void bt_assign_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanHe2.View_InfoAssignment());
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanHe2.View_InfoRegister());
        }
    }
}
