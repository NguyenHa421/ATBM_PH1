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
    public partial class Confirm_Delete : Form
    {
        string delete_id;
        public Confirm_Delete(string id)
        {
            InitializeComponent();
            delete_id = id;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "View_InfoRegister")
                    {
                        RegisterDAO.Instance.DeleteRegisterByID(delete_id);
                        this.Close();
                        PhanHe2.Success success = new Success();
                        success.ShowDialog();
                    }
                }
                //RegisterDAO.Instance.DeleteRegisterByID(delete_id);
                //this.Close();
                //PhanHe2.Success success = new Success();
                //success.ShowDialog();
            }
            catch (OracleException oe)
            {
                MessageBox.Show(oe.Message, "Lỗi");
            }
           
        }
    }
}
