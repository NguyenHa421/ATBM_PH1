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
    public partial class Update_Unit : Form
    {
        BindingSource headList = new BindingSource();
        public Update_Unit(string UnitID)
        {
            InitializeComponent();
            tb_id.Text = UnitID;
            Load();
            Load_Info();
        }
        private void Load_Info()
        {
            tb_name.Text = UnitDAO.Instance.GetNameUnitByID(tb_id.Text);
            tb_nameheadUnit.Text = UnitDAO.Instance.GetNameHeadByID(tb_id.Text);
            cbB_unitHead.Text = UnitDAO.Instance.GetIDHeadByID(tb_id.Text);
        }
        private void Load()
        {
            cbB_unitHead.DataSource = headList;
            headList.DataSource = PersonelDAO.Instance.GetListBecomeHead();
            cbB_unitHead.DisplayMember = "MANV";
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_name.Text;
            string unitHead = cbB_unitHead.Text;
            using (Confirm_Update confirm = new Confirm_Update())
            {
                if (confirm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        UnitDAO.Instance.Update_Unit(id, name, unitHead);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể cập nhật!", "Lỗi");
                        return;
                    }
                    PhanHe2.Success success = new PhanHe2.Success();
                    success.ShowDialog();
                }
            }
        }

        private void cbB_unitHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_nameheadUnit.Text = PersonelDAO.Instance.GetNameHeadByIDHead(cbB_unitHead.Text);
        }
    }
}
