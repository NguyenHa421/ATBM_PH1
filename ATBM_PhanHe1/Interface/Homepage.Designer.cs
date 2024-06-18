namespace ATBM_PhanHe1.Interface
{
    partial class Homepage
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
            pic_refresh_U = new PictureBox();
            dtGrid_user = new DataGridView();
            panel5 = new Panel();
            tb_search_user = new TextBox();
            pic_search_user = new PictureBox();
            btn_search_user = new Button();
            lab_dstk = new Label();
            pic_khtn = new PictureBox();
            pn_dstk = new Panel();
            btn_dstk = new Button();
            pic_logout = new PictureBox();
            pn_qlur = new Panel();
            btn_qlur = new Button();
            pn_qlq = new Panel();
            btn_qlq = new Button();
            btn_xnk = new Button();
            pn_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_refresh_U).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_user).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_search_user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_khtn).BeginInit();
            pn_dstk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logout).BeginInit();
            pn_qlur.SuspendLayout();
            pn_qlq.SuspendLayout();
            SuspendLayout();
            // 
            // pn_main
            // 
            pn_main.BackColor = SystemColors.Window;
            pn_main.Controls.Add(pic_refresh_U);
            pn_main.Controls.Add(dtGrid_user);
            pn_main.Controls.Add(panel5);
            pn_main.Controls.Add(btn_search_user);
            pn_main.Controls.Add(lab_dstk);
            pn_main.Location = new Point(192, 40);
            pn_main.Margin = new Padding(3, 2, 3, 2);
            pn_main.Name = "pn_main";
            pn_main.Size = new Size(647, 402);
            pn_main.TabIndex = 0;
            // 
            // pic_refresh_U
            // 
            pic_refresh_U.Image = Properties.Resources.refresh_buttons;
            pic_refresh_U.Location = new Point(491, 57);
            pic_refresh_U.Margin = new Padding(3, 2, 3, 2);
            pic_refresh_U.Name = "pic_refresh_U";
            pic_refresh_U.Size = new Size(43, 29);
            pic_refresh_U.SizeMode = PictureBoxSizeMode.Zoom;
            pic_refresh_U.TabIndex = 24;
            pic_refresh_U.TabStop = false;
            pic_refresh_U.Click += pic_refresh_U_Click;
            // 
            // dtGrid_user
            // 
            dtGrid_user.BackgroundColor = Color.WhiteSmoke;
            dtGrid_user.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_user.Location = new Point(27, 96);
            dtGrid_user.Margin = new Padding(3, 2, 3, 2);
            dtGrid_user.Name = "dtGrid_user";
            dtGrid_user.RowHeadersWidth = 51;
            dtGrid_user.Size = new Size(592, 292);
            dtGrid_user.TabIndex = 23;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(tb_search_user);
            panel5.Controls.Add(pic_search_user);
            panel5.Location = new Point(27, 58);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(459, 29);
            panel5.TabIndex = 22;
            // 
            // tb_search_user
            // 
            tb_search_user.BackColor = Color.WhiteSmoke;
            tb_search_user.BorderStyle = BorderStyle.None;
            tb_search_user.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_search_user.Location = new Point(46, 4);
            tb_search_user.Margin = new Padding(3, 2, 3, 2);
            tb_search_user.Name = "tb_search_user";
            tb_search_user.PlaceholderText = "Nhập tên người dùng...";
            tb_search_user.Size = new Size(409, 19);
            tb_search_user.TabIndex = 1;
            // 
            // pic_search_user
            // 
            pic_search_user.Image = Properties.Resources.Search1;
            pic_search_user.Location = new Point(3, 2);
            pic_search_user.Margin = new Padding(3, 2, 3, 2);
            pic_search_user.Name = "pic_search_user";
            pic_search_user.Size = new Size(38, 22);
            pic_search_user.SizeMode = PictureBoxSizeMode.Zoom;
            pic_search_user.TabIndex = 0;
            pic_search_user.TabStop = false;
            // 
            // btn_search_user
            // 
            btn_search_user.BackColor = Color.White;
            btn_search_user.BackgroundImage = Properties.Resources.button_round2;
            btn_search_user.FlatAppearance.BorderSize = 0;
            btn_search_user.FlatStyle = FlatStyle.Flat;
            btn_search_user.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_search_user.ForeColor = SystemColors.Window;
            btn_search_user.Location = new Point(539, 57);
            btn_search_user.Margin = new Padding(3, 2, 3, 2);
            btn_search_user.Name = "btn_search_user";
            btn_search_user.Size = new Size(80, 28);
            btn_search_user.TabIndex = 21;
            btn_search_user.Text = "Tìm kiếm";
            btn_search_user.UseVisualStyleBackColor = false;
            btn_search_user.Click += btn_search_user_Click;
            // 
            // lab_dstk
            // 
            lab_dstk.AutoSize = true;
            lab_dstk.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lab_dstk.Location = new Point(203, 11);
            lab_dstk.Name = "lab_dstk";
            lab_dstk.Size = new Size(220, 25);
            lab_dstk.TabIndex = 1;
            lab_dstk.Text = "DANH SÁCH THỐNG KÊ";
            lab_dstk.TextAlign = ContentAlignment.TopCenter;
            // 
            // pic_khtn
            // 
            pic_khtn.Image = Properties.Resources.logo2;
            pic_khtn.Location = new Point(24, 21);
            pic_khtn.Margin = new Padding(3, 2, 3, 2);
            pic_khtn.Name = "pic_khtn";
            pic_khtn.Size = new Size(149, 116);
            pic_khtn.SizeMode = PictureBoxSizeMode.Zoom;
            pic_khtn.TabIndex = 1;
            pic_khtn.TabStop = false;
            // 
            // pn_dstk
            // 
            pn_dstk.BackColor = Color.FromArgb(177, 213, 246);
            pn_dstk.Controls.Add(btn_dstk);
            pn_dstk.Location = new Point(0, 190);
            pn_dstk.Margin = new Padding(3, 2, 3, 2);
            pn_dstk.Name = "pn_dstk";
            pn_dstk.Size = new Size(192, 57);
            pn_dstk.TabIndex = 2;
            // 
            // btn_dstk
            // 
            btn_dstk.BackColor = Color.FromArgb(177, 213, 246);
            btn_dstk.FlatAppearance.BorderColor = Color.FromArgb(177, 213, 246);
            btn_dstk.FlatAppearance.BorderSize = 0;
            btn_dstk.FlatStyle = FlatStyle.Flat;
            btn_dstk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dstk.ForeColor = Color.Black;
            btn_dstk.Location = new Point(0, 7);
            btn_dstk.Margin = new Padding(3, 2, 3, 2);
            btn_dstk.Name = "btn_dstk";
            btn_dstk.Size = new Size(191, 42);
            btn_dstk.TabIndex = 5;
            btn_dstk.Text = "Danh sách tài khoản";
            btn_dstk.UseVisualStyleBackColor = false;
            // 
            // pic_logout
            // 
            pic_logout.Image = Properties.Resources.Exit;
            pic_logout.Location = new Point(789, 7);
            pic_logout.Margin = new Padding(3, 2, 3, 2);
            pic_logout.Name = "pic_logout";
            pic_logout.Size = new Size(38, 27);
            pic_logout.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logout.TabIndex = 3;
            pic_logout.TabStop = false;
            pic_logout.Click += pic_logout_Click;
            // 
            // pn_qlur
            // 
            pn_qlur.BackColor = Color.FromArgb(42, 107, 167);
            pn_qlur.Controls.Add(btn_qlur);
            pn_qlur.Location = new Point(0, 248);
            pn_qlur.Margin = new Padding(3, 2, 3, 2);
            pn_qlur.Name = "pn_qlur";
            pn_qlur.Size = new Size(192, 57);
            pn_qlur.TabIndex = 3;
            // 
            // btn_qlur
            // 
            btn_qlur.BackColor = Color.FromArgb(42, 107, 167);
            btn_qlur.FlatAppearance.BorderColor = Color.FromArgb(177, 213, 246);
            btn_qlur.FlatAppearance.BorderSize = 0;
            btn_qlur.FlatStyle = FlatStyle.Flat;
            btn_qlur.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_qlur.ForeColor = Color.Transparent;
            btn_qlur.Location = new Point(1, 8);
            btn_qlur.Margin = new Padding(3, 2, 3, 2);
            btn_qlur.Name = "btn_qlur";
            btn_qlur.Size = new Size(191, 42);
            btn_qlur.TabIndex = 6;
            btn_qlur.Text = "Quản lý User/Role";
            btn_qlur.UseVisualStyleBackColor = false;
            btn_qlur.Click += btn_qlur_Click;
            // 
            // pn_qlq
            // 
            pn_qlq.BackColor = Color.FromArgb(42, 107, 167);
            pn_qlq.Controls.Add(btn_qlq);
            pn_qlq.Location = new Point(0, 306);
            pn_qlq.Margin = new Padding(3, 2, 3, 2);
            pn_qlq.Name = "pn_qlq";
            pn_qlq.Size = new Size(192, 57);
            pn_qlq.TabIndex = 4;
            // 
            // btn_qlq
            // 
            btn_qlq.BackColor = Color.FromArgb(42, 107, 167);
            btn_qlq.FlatAppearance.BorderColor = Color.FromArgb(177, 213, 246);
            btn_qlq.FlatAppearance.BorderSize = 0;
            btn_qlq.FlatStyle = FlatStyle.Flat;
            btn_qlq.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_qlq.ForeColor = Color.Transparent;
            btn_qlq.Location = new Point(1, 8);
            btn_qlq.Margin = new Padding(3, 2, 3, 2);
            btn_qlq.Name = "btn_qlq";
            btn_qlq.Size = new Size(191, 42);
            btn_qlq.TabIndex = 7;
            btn_qlq.Text = "Quản lý quyền";
            btn_qlq.UseVisualStyleBackColor = false;
            btn_qlq.Click += btn_qlq_Click;
            // 
            // btn_xnk
            // 
            btn_xnk.BackColor = Color.FromArgb(42, 107, 167);
            btn_xnk.FlatAppearance.BorderColor = Color.FromArgb(177, 213, 246);
            btn_xnk.FlatAppearance.BorderSize = 0;
            btn_xnk.FlatStyle = FlatStyle.Flat;
            btn_xnk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xnk.ForeColor = Color.Transparent;
            btn_xnk.Location = new Point(1, 367);
            btn_xnk.Margin = new Padding(3, 2, 3, 2);
            btn_xnk.Name = "btn_xnk";
            btn_xnk.Size = new Size(191, 42);
            btn_xnk.TabIndex = 8;
            btn_xnk.Text = "Xem nhật ký";
            btn_xnk.UseVisualStyleBackColor = false;
            btn_xnk.Click += btn_xnk_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 107, 167);
            ClientSize = new Size(837, 442);
            Controls.Add(btn_xnk);
            Controls.Add(pn_qlq);
            Controls.Add(pn_qlur);
            Controls.Add(pic_logout);
            Controls.Add(pn_dstk);
            Controls.Add(pic_khtn);
            Controls.Add(pn_main);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Người Dùng";
            pn_main.ResumeLayout(false);
            pn_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_refresh_U).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_user).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_search_user).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_khtn).EndInit();
            pn_dstk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_logout).EndInit();
            pn_qlur.ResumeLayout(false);
            pn_qlq.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_main;
        private PictureBox pic_khtn;
        private Panel pn_dstk;
        private PictureBox pic_logout;
        private Panel pn_qlur;
        private Panel pn_qlq;
        private Panel panel5;
        private Button btn_dstk;
        private Button btn_qlur;
        private Button btn_qlq;
        private Label lab_dstk;
        private PictureBox pic_refresh_U;
        private DataGridView dtGrid_user;
        private TextBox tb_search_user;
        private PictureBox pic_search_user;
        private Button btn_search_user;
        private Button btn_xnk;
    }
}