using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;


namespace ATBM_PhanHe1.PhanHe2
{
    public partial class MainBase : Form
    {
        public MainBase()
        {
            InitializeComponent();
            OpenChildForm(new PhanHe2.Homepage_Staff());
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
        private void tb_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void pic_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
