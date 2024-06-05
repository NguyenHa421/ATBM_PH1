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
    public partial class Update_Info_Personnel : Form
    {
        public Update_Info_Personnel()
        {
            InitializeComponent();
        }

        private void lb_Info_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            PhanHe2.Success success = new PhanHe2.Success();
            success.ShowDialog();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
