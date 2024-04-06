﻿using ATBM_PhanHe1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_PhanHe1.Users_Roles
{
    public partial class Grant_R : Form
    {
        BindingSource tableList = new BindingSource();
        BindingSource columnList = new BindingSource();
        public Grant_R(string userName)
        {
            InitializeComponent();
            tb_user.Text = userName;
            Load();
        }
        private void Load()
        {
            cbB_Tables.DataSource = tableList;
            tableList.DataSource = Table_ColumnDAO.Instance.GetListTable();
            cbB_Tables.DisplayMember = "TABLE_NAME";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbB_Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_Column.DataSource = columnList;
            columnList.DataSource = Table_ColumnDAO.Instance.GetListColumn(cbB_Tables.Text);
            cbB_Column.DisplayMember = "COLUMN_NAME";
        }
    }
}
