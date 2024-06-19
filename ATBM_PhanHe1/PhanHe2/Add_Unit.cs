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
    public partial class Add_Unit : Form
    {
        BindingSource headList = new BindingSource();

        public Add_Unit()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            cbB_unitHead.DataSource = headList;
            headList.DataSource = PersonelDAO.Instance.GetListBecomeHead();
            cbB_unitHead.DisplayMember = "MANV";
        }
        private void Add_Unit_Load(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbB_unitHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_nameheadUnit.Text = PersonelDAO.Instance.GetNameHeadByIDHead(cbB_unitHead.Text);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_name.Text;
            string unitHead = cbB_unitHead.Text;
            try
            {
                UnitDAO.Instance.Add_Unit(id, name, unitHead);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thêm!", "Lỗi");
                return;
            }
            PhanHe2.Success success = new PhanHe2.Success();
            success.ShowDialog();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
