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
            foreach (UnitDTO unit in unitList)
            {
                cbB_idunit.Items.Add(unit.unitID);
                cbB_unit.Items.Add(unit.unitName);
            }
            cbB_idunit.SelectedIndex = 0;
            cbB_unit.SelectedIndex = 0;
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
            if (tb_id.Text != "" && tb_name.Text != "" && tb_credit.Text != "" && tb_theory.Text != "" && tb_practice.Text != "" && tb_maxstudent.Text != "") 
            {
                int credits, theory, practice, maxStudent;
                try
                {
                    credits = int.Parse(tb_credit.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Số tín chỉ không hợp lệ!", "Lỗi");
                    return;
                }
                try
                {
                    theory = int.Parse(tb_theory.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Số tiết lý thuyết không hợp lệ!", "Lỗi");
                    return;
                }
                try
                {
                    practice = int.Parse(tb_practice.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Số tiết thực hành không hợp lệ!", "Lỗi");
                    return;
                }
                try
                {
                    maxStudent = int.Parse(tb_maxstudent.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Số sinh viên tối đa không hợp lệ!", "Lỗi");
                    return;
                }
                CourseDAO.Instance.AddCource(tb_id.Text,tb_name.Text,credits,theory, practice, maxStudent, cbB_idunit.Text);
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!", "Lỗi");
                return;
            }
            PhanHe2.Success success = new PhanHe2.Success();
            success.ShowDialog();
        }
    }
}
