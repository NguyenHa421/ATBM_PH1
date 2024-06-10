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
    public partial class Update_Personnel : Form
    {
        BindingSource unitList = new BindingSource();

        public Update_Personnel(string staff_id)
        {
            InitializeComponent();
            tb_id.Text = staff_id;
            Load();
            Load_Info();
        }
        private void Load()
        {
            cbB_unit.DataSource = unitList;
            unitList.DataSource = UnitDAO.Instance.GetListUnit();
            cbB_unit.DisplayMember = "TENDV";
        }
        private void Load_Info()
        {
            tb_name.Text = PersonelDAO.Instance.HeadGetNameStaff(tb_id.Text);
            tb_birth.Text = PersonelDAO.Instance.HeadGetBirthStaff2(tb_id.Text);
            cbB_gender.Text = PersonelDAO.Instance.HeadGetGenderStaff(tb_id.Text);
            tb_phone.Text = PersonelDAO.Instance.HeadGetPhoneStaff(tb_id.Text);
            tb_allowance.Text = PersonelDAO.Instance.HeadGetAllowanceStaff(tb_id.Text);
            cbB_role.Text = PersonelDAO.Instance.HeadGetRoleStaff(tb_id.Text);
            cbB_unit.Text = PersonelDAO.Instance.HeadGetUnitStaff(tb_id.Text);
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_name.Text;
            string gender = cbB_gender.Text;
            DateTime birth = tb_birth.Value;
            string phone = tb_phone.Text;
            int allowance = int.Parse(tb_allowance.Text);
            string role = cbB_role.Text;
            string unit = UnitDAO.Instance.GetIDUnit(cbB_unit.Text);
            using (Confirm_Update confirm = new Confirm_Update())
            {
                if (confirm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PersonelDAO.Instance.Update_Staff(id, name, gender, birth.Date, allowance, phone, role, unit);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                        return;
                    }
                    PhanHe2.Success success = new PhanHe2.Success();
                    success.ShowDialog();
                }
            }
        }
    }
}
