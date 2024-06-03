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

namespace ATBM_PhanHe1.PhanHe2
{
    public partial class View_InfoUnit : Form
    {
        BindingSource unitList = new BindingSource();
        public View_InfoUnit()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            dtGrid_unit.DataSource = unitList;
            unitList.DataSource = UnitDAO.Instance.GetUnitList();
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
            OpenChildForm(new Add_Unit());
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Update_Unit());
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            unitList.DataSource = UnitDAO.Instance.SearchUnit(tb_name.Text);
        }
        private void pic_refresh_U_Click(object sender, EventArgs e)
        {
            unitList.DataSource = UnitDAO.Instance.GetUnitList();
        }
    }
}
