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
    public partial class Update_Assignment : Form
    {
        public Update_Assignment()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            PhanHe2.Success success = new PhanHe2.Success();
            success.ShowDialog();
        }
    }
}
