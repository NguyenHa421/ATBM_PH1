using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_PhanHe1.Home_Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            Interface.Homepage homepage = new Interface.Homepage();
            this.Hide();
            homepage.ShowDialog();
            this.Show();

        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
