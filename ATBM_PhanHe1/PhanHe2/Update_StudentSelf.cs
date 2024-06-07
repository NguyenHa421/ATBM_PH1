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
using System.Xml.Linq;

namespace ATBM_PhanHe1.PhanHe2
{
    public partial class Update_StudentSelf : Form
    {
        public Update_StudentSelf()
        {
            InitializeComponent();
            tb_id.Text = Home_Login.Login.User;
            Load_Info();
        }
        private void Load_Info()
        {
            tb_name.Text = UserDAO.Instance.GetNameStudent(tb_id.Text);
            tb_phone.Text = StudentDAO.Instance.GetPhoneStudent(tb_id.Text);
            tb_addr.Text = StudentDAO.Instance.GetAddressStudent(tb_id.Text);
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string newaddr = tb_newaddress.Text;
            string newphone = tb_newphone.Text;
            string phone = tb_phone.Text;
            string addr = tb_addr.Text;
            if (newaddr == "")
            {
                newaddr = addr;
            }
            if (newphone == "")
            {
                newphone = phone;
            }
            using (Confirm_Update confirm = new Confirm_Update())
            {
                if (confirm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StudentDAO.Instance.Update_SelfStudent(id, newaddr, newphone);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cập nhật không thành công!", "Lỗi");
                        return;
                    }
                    PhanHe2.Success success = new PhanHe2.Success();
                    success.ShowDialog();
                }
            }
        }
    }
}