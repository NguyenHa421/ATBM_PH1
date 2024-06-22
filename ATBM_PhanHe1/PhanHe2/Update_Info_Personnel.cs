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

namespace ATBM_PhanHe1.PhanHe2
{
    public partial class Update_Info_Personnel : Form
    {
        public Update_Info_Personnel()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            tb_id.Text = Home_Login.Login.User;
            tb_name.Text = UserDAO.Instance.GetNameOther(tb_id.Text);
            tb_phone.Text = PersonelDAO.Instance.GetPhoneStaff(tb_id.Text);
        }
        private void lb_Info_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string newphone = tb_newphone.Text;
            string phone = tb_phone.Text;
            if (tb_newphone.Text.Length != 10 || !tb_newphone.Text.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi");
                return;
            }
            if (newphone == "")
            {
                newphone = phone;
            }
            try
            {
                PersonelDAO.Instance.Update_SelfStaff(newphone);
                PhanHe2.Success success = new PhanHe2.Success();
                success.ShowDialog();
            }
            catch (OracleException oe)
            {
                MessageBox.Show(oe.Message, "Lỗi");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
