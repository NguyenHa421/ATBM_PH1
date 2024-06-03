using ATBM_PhanHe1.DAO;
using ATBM_PhanHe1.DTO;
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
    public partial class Add_Courses : Form
    {
        public Add_Courses()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            List<UnitDTO> unitList = UnitDAO.Instance.GetUnitList();
            List<string> unitID = new List<string>();
            List<string> unitName = new List<string>();
            foreach (UnitDTO unit in unitList)
            {
                unitID.Add(unit.unitID);
                unitName.Add(unit.unitName);
            }
            cbB_idunit.DataSource = unitID;
            cbB_unit.DataSource = unitName;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbB_idunit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_unit.SelectedIndex = cbB_idunit.SelectedIndex;
        }

        private void cbB_unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbB_idunit.SelectedIndex = cbB_unit.SelectedIndex;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            CourseDAO.Instance.AddCource(tb_id.Text, tb_name.Text, int.Parse(tb_credit.Text), int.Parse(tb_theory.Text), int.Parse(tb_practice.Text), int.Parse(tb_maxstudent.Text), cbB_idunit.SelectedValue.ToString());
            this.Close();
        }
    }
}
