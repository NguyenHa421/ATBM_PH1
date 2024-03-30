using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_PhanHe1.Interface
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }
        private void CloseAllFormsExceptFirst()
        {
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            for (int i = 1; i < forms.Length; i++)
            {
                forms[i].Close();
            }
        }
        private void Homepage_Load_1(object sender, EventArgs e)
        {

        }

        private void QLur_button_Click(object sender, EventArgs e)
        {
            Interface.User_Role user_Role = new Interface.User_Role();
            this.Hide();
            user_Role.ShowDialog();
            this.Show();
        }

        private void QLQ_button_Click(object sender, EventArgs e)
        {
            Interface.Permission permission = new Interface.Permission();
            this.Hide();
            permission.ShowDialog();
            this.Show();
        }

        private void pic_logout_Click(object sender, EventArgs e)
        {
            CloseAllFormsExceptFirst();
        }
    }
}
