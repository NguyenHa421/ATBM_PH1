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
            LoadList();
        }
        void LoadList()
        {
            userList.DataSource = UserDAO.Instance.GetUserList();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
