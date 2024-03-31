using ATBM_PhanHe1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_PhanHe1.User
{
    public partial class Create_U : Form
    {
        public Create_U()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            UserDAO.Instance.CreateUser(tb_user.Text,tb_pass.Text);
            this.Close();
        }
    }
}
