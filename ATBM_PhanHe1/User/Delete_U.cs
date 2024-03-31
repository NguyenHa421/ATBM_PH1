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
    public partial class Delete_U : Form
    {
        public Delete_U(string userName)
        {
            InitializeComponent();
            tb_name.Text = userName;
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (tb_name.Text != "")
                UserDAO.Instance.DeleteUser(tb_name.Text);
            this.Close();
        }
    }
}
