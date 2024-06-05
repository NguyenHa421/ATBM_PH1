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
    public partial class View_InfoRegister : Form
    {
        private string clickedRegister = "";
        public View_InfoRegister()
        {
            InitializeComponent();
            if (UserDAO.Instance.GetRole(Home_Login.Login.User) == "Sinh vien")
            {
                btn_Update.Enabled = false;
            }
            if (UserDAO.Instance.GetRole(Home_Login.Login.User) == "Truong khoa")
            {
                btn_Add.Enabled = false;
                btn_delete.Enabled = false;
            }
            if (UserDAO.Instance.GetRole(Home_Login.Login.User) == "Giang vien")
            {
                btn_Add.Enabled = false;
                btn_delete.Enabled = false;
            }
            if (UserDAO.Instance.GetRole(Home_Login.Login.User) == "Giao vu")
            {
                btn_Update.Enabled = false;
            }
            if (UserDAO.Instance.GetRole(Home_Login.Login.User) == "Truong don vi")
            {
                btn_Add.Enabled = false;
                btn_delete.Enabled = false;
            }
            Load();
        }
        private void Load()
        {

        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_parents.Controls.Add(childForm);
            pn_parents.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanHe2.Add_Register());
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanHe2.Update_Register());
        }
        private void dG_Register_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dG_Register.Rows[e.RowIndex].Cells[0];
                clickedRegister = cell.Value.ToString();
            }
        }
        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (clickedRegister != "")
            {
                string register_id = clickedRegister;
                clickedRegister = "";
                try
                {
                    PhanHe2.Confirm_Delete confirm_Delete = new PhanHe2.Confirm_Delete(register_id);
                    confirm_Delete.ShowDialog();
                }
                catch (OracleException oe)
                {
                    MessageBox.Show(oe.Message, "Lỗi");
                }
            }
        }
    }
}
