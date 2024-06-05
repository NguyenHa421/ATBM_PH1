using ATBM_PhanHe1.DAO;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ATBM_PhanHe1.Home_Login
{
    public partial class Login : Form
    {
        public static string User { get; set; }
        public static string Pass { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            User = tB_name.Text.ToString();
            Pass = tB_pass.Text.ToString();
            try
            {
                //Interface.Homepage homepage = new Interface.Homepage();
                //PhanHe2.View_InfoRegister newForm = new PhanHe2.View_InfoRegister();
                //this.Hide();
                //newForm.ShowDialog();
                //this.Show();
                PhanHe2.MainBase mainBase = new PhanHe2.MainBase();
                this.Hide();
                mainBase.ShowDialog();
                this.Show();
            }
            catch (OracleException oe)
            {
                MessageBox.Show(oe.Message, "Lỗi");
            }
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
