using ATBM_PhanHe1.DAO;
using ATBM_PhanHe1.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_PhanHe1.Interface
{
    public partial class Audit : Form
    {
        BindingSource userList = new BindingSource();
        public Audit()
        {
            InitializeComponent();
            LoadGrid();
            LoadcbB();
        }
        private void LoadGrid()
        {
            dtGrid_user.DataSource = userList;
            userList.DataSource = AuditDAO.Instance.GetAuditList();
        }

        private void LoadcbB()
        {
            //cbB_table.Items.Add("Chọn bảng");
            //cbB_table.SelectedIndex = 0;
            cbB_table.Items.Add("Null");
            DataTable tables = Table_ColumnDAO.Instance.GetListTable();
            foreach (DataRow table in tables.Rows)
            {
                cbB_table.Items.Add(table["TABLE_NAME"].ToString());
            }
            cbB_table.SelectedIndex = 0;

        }

        private void pic_refresh_U_Click(object sender, EventArgs e)
        {
            userList.DataSource = AuditDAO.Instance.GetAuditList();
        }

        private void btn_search_user_Click(object sender, EventArgs e)
        {
            userList.DataSource = AuditDAO.Instance.SearchAudit(tb_search_user.Text, cbB_table.Text);
        }
        private void CloseAllFormsExceptFirst()
        {
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            for (int i = 1; i < forms.Length; i++)
            {
                forms[i].Close();
            }
        }
        private void btn_dstk_Click(object sender, EventArgs e)
        {
            Interface.Homepage hompage = new Interface.Homepage();
            this.Hide();
            hompage.ShowDialog();
            this.Show();
        }

        private void btn_qlur_Click(object sender, EventArgs e)
        {
            Interface.User_Role user_Role = new Interface.User_Role();
            this.Hide();
            user_Role.ShowDialog();
            this.Show();
        }

        private void btn_qlq_Click(object sender, EventArgs e)
        {
            Interface.Permission permission = new Interface.Permission();
            this.Hide();
            permission.ShowDialog();
            this.Show();
        }

        private void pic_logout_Click(object sender, EventArgs e)
        {
            CloseAllFormsExceptFirst();
        }
    }
}
