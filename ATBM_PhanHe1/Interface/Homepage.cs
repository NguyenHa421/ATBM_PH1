using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATBM_PhanHe1.DAO;
using ATBM_PhanHe1.DTO;
using static System.Windows.Forms.DataFormats;

namespace ATBM_PhanHe1.Interface
{
    public partial class Homepage : Form
    {
        BindingSource userList = new BindingSource();
        public Homepage()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            dtGrid_main.DataSource = userList;
            userList.DataSource = UserDAO.Instance.GetUserList();
        }
        private void pic_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            userList.DataSource = UserDAO.Instance.SearchUser(tb_search.Text);
        }
        private void btn_qlur_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Role newForm = new User_Role();
            newForm.ShowDialog();
            this.Close();
        }
        private void btn_qlq_Click(object sender, EventArgs e)
        {
            this.Hide();
            Permission newForm = new Permission();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
