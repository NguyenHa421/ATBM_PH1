using ATBM_PhanHe1.DAO;
using Oracle.ManagedDataAccess.Client;
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
    public partial class Update_U : Form
    {
        public Update_U(string userName)
        {
            InitializeComponent();
            tb_user.Text = userName;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                UserDAO.Instance.ChangePassword(tb_user.Text, tb_pass.Text);
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
            }
            catch (OracleException oe)
            {
                MessageBox.Show(oe.Message, "Lỗi");
            }
            this.Close();
        }
    }
}
