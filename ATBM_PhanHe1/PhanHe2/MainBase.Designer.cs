namespace ATBM_PhanHe1.PhanHe2
{
    partial class MainBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pn_main = new Panel();
            pn_parents = new Panel();
            pic_khtn = new PictureBox();
            lb_hello = new Label();
            tb_Name = new TextBox();
            pic_logout = new PictureBox();
            pn_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_khtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_logout).BeginInit();
            SuspendLayout();
            // 
            // pn_main
            // 
            pn_main.BackColor = Color.FromArgb(42, 107, 167);
            pn_main.BackgroundImage = Properties.Resources.Bg_hp2;
            pn_main.Controls.Add(pn_parents);
            pn_main.Location = new Point(12, 116);
            pn_main.Name = "pn_main";
            pn_main.Size = new Size(933, 462);
            pn_main.TabIndex = 5;
            // 
            // pn_parents
            // 
            pn_parents.BackColor = Color.White;
            pn_parents.Location = new Point(17, 18);
            pn_parents.Name = "pn_parents";
            pn_parents.Size = new Size(895, 425);
            pn_parents.TabIndex = 0;
            // 
            // pic_khtn
            // 
            pic_khtn.Image = Properties.Resources.logo2;
            pic_khtn.Location = new Point(12, 9);
            pic_khtn.Name = "pic_khtn";
            pic_khtn.Size = new Size(106, 102);
            pic_khtn.SizeMode = PictureBoxSizeMode.Zoom;
            pic_khtn.TabIndex = 6;
            pic_khtn.TabStop = false;
            // 
            // lb_hello
            // 
            lb_hello.AutoSize = true;
            lb_hello.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_hello.ForeColor = Color.White;
            lb_hello.Location = new Point(139, 13);
            lb_hello.Name = "lb_hello";
            lb_hello.Size = new Size(96, 28);
            lb_hello.TabIndex = 11;
            lb_hello.Text = "Xin chào, ";
            // 
            // tb_Name
            // 
            tb_Name.BackColor = Color.FromArgb(42, 107, 167);
            tb_Name.BorderStyle = BorderStyle.None;
            tb_Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Name.ForeColor = Color.White;
            tb_Name.Location = new Point(229, 12);
            tb_Name.Name = "tb_Name";
            tb_Name.PlaceholderText = "Full Name";
            tb_Name.Size = new Size(335, 27);
            tb_Name.TabIndex = 12;
            tb_Name.TextChanged += tb_Name_TextChanged;
            // 
            // pic_logout
            // 
            pic_logout.Image = Properties.Resources.Exit;
            pic_logout.Location = new Point(902, 13);
            pic_logout.Name = "pic_logout";
            pic_logout.Size = new Size(43, 36);
            pic_logout.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logout.TabIndex = 13;
            pic_logout.TabStop = false;
            pic_logout.Click += pic_logout_Click;
            // 
            // MainBaseStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 107, 167);
            ClientSize = new Size(957, 590);
            Controls.Add(pic_logout);
            Controls.Add(tb_Name);
            Controls.Add(lb_hello);
            Controls.Add(pn_main);
            Controls.Add(pic_khtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainBaseStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomepageBaseStaff";
            pn_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_khtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_logout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pn_main;
        private PictureBox pic_khtn;
        private Label lb_hello;
        private TextBox tb_Name;
        private Panel pn_parents;
        private PictureBox pic_logout;
    }
}