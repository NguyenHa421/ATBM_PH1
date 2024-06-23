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

namespace ATBM_PhanHe1.PhanHe2
{
    public partial class Add_Personnel : Form
    {
        BindingSource unitList = new BindingSource();
        public Add_Personnel()
        {
            InitializeComponent();
            Load_Auto_ID();
            Load();
        }
        private void Load_Auto_ID()
        {
            tb_id.Text = PersonelDAO.Instance.GetIDAuto();
        }
        private void Load()
        {
            cbB_unit.DataSource = unitList;
            unitList.DataSource = UnitDAO.Instance.GetListUnit();
            cbB_unit.DisplayMember = "TENDV";

        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_name.Text;
            string gender = cbB_gender.Text;
            DateTime birth = tb_birth.Value;
            string phone = tb_phone.Text;
            int allowance = int.Parse(tb_allowance.Text);
            string role = cbB_role.Text;
            string unit = UnitDAO.Instance.GetIDUnit(cbB_unit.Text);

            if (tb_phone.Text.Length != 10 || !tb_phone.Text.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0!", "Lỗi");
                return;
            }
            try
            {
                PersonelDAO.Instance.Add_Staff(id, name, gender, birth, allowance, phone, role, unit);
                PhanHe2.Success success = new PhanHe2.Success();
                success.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thêm", "Lỗi");
                return;
            }
        }
    }
}
