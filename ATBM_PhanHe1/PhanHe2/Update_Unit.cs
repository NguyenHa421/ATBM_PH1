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
            Load_Info();
            Load();
        }
        private void Load_Info()
        {
            tb_name.Text = UserDAO.Instance.GetNameStudent(tb_id.Text);
            cbB_unitHead.Text = StudentDAO.Instance.GetProgramStudent(tb_id.Text);
        }
        private void Load()
        {
            //cbB_unitHead.DataSource = headList;
            //headList.DataSource = ProgramDAO.Instance.GetListProgram();
            //cbB_unitHead.DisplayMember = "TENCT";
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
            try
            {
                PhanHe2.Success success = new PhanHe2.Success();
                success.ShowDialog();
            }
            catch (OracleException oe)
            {
                MessageBox.Show(oe.Message, "Lỗi");
            }
        }
    }
}
