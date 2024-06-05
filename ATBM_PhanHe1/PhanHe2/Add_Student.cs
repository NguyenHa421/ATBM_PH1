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
    public partial class Add_Student : Form
    {
        BindingSource programList = new BindingSource();
        BindingSource majorList = new BindingSource();
        public Add_Student()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            cbB_program.DataSource = programList;
            programList.DataSource = ProgramDAO.Instance.GetListProgram();
            cbB_program.DisplayMember = "TENCT";

            cbB_major.DataSource = majorList;
            majorList.DataSource = MajorDAO.Instance.GetListMajor();
            cbB_major.DisplayMember = "TENNGANH";
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
