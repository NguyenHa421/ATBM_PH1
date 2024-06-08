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
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;


namespace ATBM_PhanHe1.PhanHe2
{
    public partial class MainBase : Form
    {
        public MainBase()
        {
            InitializeComponent();
            Load_Form();
        }
        private void Load_Form()
        {
            if (UserDAO.Instance.GetRole(Home_Login.Login.User) == "Sinh vien")
            {
                tb_Name.Text = UserDAO.Instance.GetNameStudent(Home_Login.Login.User);
                OpenChildForm(new PhanHe2.Homepage_Student());
            }
            else if (UserDAO.Instance.GetRole(Home_Login.Login.User) == "Nhan vien co ban")
            {
                tb_Name.Text = UserDAO.Instance.GetNameOther(Home_Login.Login.User);
                OpenChildForm(new PhanHe2.Homepage_Staff());
            }
            else if (UserDAO.Instance.GetRole(Home_Login.Login.User) == "Truong khoa")
            {
                tb_Name.Text = UserDAO.Instance.GetNameOther(Home_Login.Login.User);
                OpenChildForm(new PhanHe2.Homepage_Dean());
            }
            else
            {
                tb_Name.Text = UserDAO.Instance.GetNameOther(Home_Login.Login.User);
                OpenChildForm(new PhanHe2.Homepage_Others());
            }
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
        private void pic_logout_Click(object sender, EventArgs e)
        {
            using (Confirm_Logout confirm = new Confirm_Logout())
            {
                if (confirm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đăng xuất không thành công!", "Lỗi");
                        return;
                    }
                    
                }
            }
        }
    }
}
