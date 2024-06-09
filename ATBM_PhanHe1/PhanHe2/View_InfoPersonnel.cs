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
    public partial class View_InfoPersonnel : Form
    {
        BindingSource personelList = new BindingSource();
        private string clickedPersonnelID = "";
        public View_InfoPersonnel()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            dtGrid_personel.DataSource = personelList;
            personelList.DataSource = PersonelDAO.Instance.GetPersonelList();
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
            OpenChildForm(new Add_Personnel());
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (clickedPersonnelID != "")
            {
                string Staffid = clickedPersonnelID;
                clickedPersonnelID = "";
                OpenChildForm(new PhanHe2.Update_Personnel(Staffid));
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                PersonelDAO.Instance.DeletePersonelByID(clickedPersonnelID);
                PhanHe2.Success success = new PhanHe2.Success();
                success.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xoá nhân viên này!", "Lỗi");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            personelList.DataSource = PersonelDAO.Instance.SearchPersonel(tb_name.Text);
        }

        private void pic_refresh_U_Click(object sender, EventArgs e)
        {
            personelList.DataSource = PersonelDAO.Instance.GetPersonelList();
        }

        private void dtGrid_personel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dtGrid_personel.Rows[e.RowIndex].Cells[0];
                clickedPersonnelID = cell.Value.ToString();
            }
        }
    }
}
