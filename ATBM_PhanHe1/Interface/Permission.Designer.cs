namespace ATBM_PhanHe1.Interface
{
    partial class Permission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permission));
            btn_search_role = new Button();
            tb_search_role = new TextBox();
            dtGrid_role = new DataGridView();
            panel6 = new Panel();
            pic_search_role = new PictureBox();
            tabPage2 = new TabPage();
            btn_revoke_role = new Button();
            btn_grant_role = new Button();
            tb_search_user = new TextBox();
            pic_search_user = new PictureBox();
            dtGrid_user = new DataGridView();
            button2 = new Button();
            btn_grant_user = new Button();
            panel5 = new Panel();
            tbCtrl_main = new TabControl();
            tabPage1 = new TabPage();
            btn_revoke_user = new Button();
            btn_role = new Button();
            btn_search_user = new Button();
            pn_main = new Panel();
            lab_qlq = new Label();
            label4 = new Label();
            pic_logout = new PictureBox();
            pn_qlq = new Panel();
            label3 = new Label();
            pn_qlur = new Panel();
            label2 = new Label();
            pn_dstk = new Panel();
            pic_khtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtGrid_role).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_search_role).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_search_user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_user).BeginInit();
            panel5.SuspendLayout();
            tbCtrl_main.SuspendLayout();
            tabPage1.SuspendLayout();
            pn_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logout).BeginInit();
            pn_qlq.SuspendLayout();
            pn_qlur.SuspendLayout();
            pn_dstk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_khtn).BeginInit();
            SuspendLayout();
            // 
            // btn_search_role
            // 
            btn_search_role.BackColor = Color.White;
            btn_search_role.BackgroundImage = (Image)resources.GetObject("btn_search_role.BackgroundImage");
            btn_search_role.FlatAppearance.BorderSize = 0;
            btn_search_role.FlatStyle = FlatStyle.Flat;
            btn_search_role.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_search_role.ForeColor = SystemColors.Window;
            btn_search_role.Location = new Point(591, 13);
            btn_search_role.Name = "btn_search_role";
            btn_search_role.Size = new Size(91, 38);
            btn_search_role.TabIndex = 11;
            btn_search_role.Text = "Tìm kiếm";
            btn_search_role.UseVisualStyleBackColor = false;
            // 
            // tb_search_role
            // 
            tb_search_role.BackColor = Color.WhiteSmoke;
            tb_search_role.BorderStyle = BorderStyle.None;
            tb_search_role.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_search_role.Location = new Point(52, 9);
            tb_search_role.Name = "tb_search_role";
            tb_search_role.PlaceholderText = "Nhập tên người dùng...";
            tb_search_role.Size = new Size(510, 23);
            tb_search_role.TabIndex = 1;
            // 
            // dtGrid_role
            // 
            dtGrid_role.BackgroundColor = Color.WhiteSmoke;
            dtGrid_role.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_role.Location = new Point(6, 61);
            dtGrid_role.Name = "dtGrid_role";
            dtGrid_role.RowHeadersWidth = 51;
            dtGrid_role.Size = new Size(676, 318);
            dtGrid_role.TabIndex = 17;
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(tb_search_role);
            panel6.Controls.Add(pic_search_role);
            panel6.Location = new Point(6, 13);
            panel6.Name = "panel6";
            panel6.Size = new Size(567, 38);
            panel6.TabIndex = 12;
            // 
            // pic_search_role
            // 
            pic_search_role.Image = Properties.Resources.Search1;
            pic_search_role.Location = new Point(3, 5);
            pic_search_role.Name = "pic_search_role";
            pic_search_role.Size = new Size(43, 30);
            pic_search_role.SizeMode = PictureBoxSizeMode.Zoom;
            pic_search_role.TabIndex = 0;
            pic_search_role.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(249, 240, 240);
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(btn_revoke_role);
            tabPage2.Controls.Add(btn_grant_role);
            tabPage2.Controls.Add(dtGrid_role);
            tabPage2.Controls.Add(panel6);
            tabPage2.Controls.Add(btn_search_role);
            tabPage2.ForeColor = Color.Black;
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(693, 441);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Role";
            // 
            // btn_revoke_role
            // 
            btn_revoke_role.BackColor = Color.White;
            btn_revoke_role.BackgroundImage = Properties.Resources.button_round1;
            btn_revoke_role.FlatAppearance.BorderSize = 0;
            btn_revoke_role.FlatStyle = FlatStyle.Flat;
            btn_revoke_role.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_revoke_role.ForeColor = SystemColors.Window;
            btn_revoke_role.Location = new Point(552, 393);
            btn_revoke_role.Name = "btn_revoke_role";
            btn_revoke_role.Size = new Size(130, 38);
            btn_revoke_role.TabIndex = 19;
            btn_revoke_role.Text = "Thu hồi quyền";
            btn_revoke_role.UseVisualStyleBackColor = false;
            // 
            // btn_grant_role
            // 
            btn_grant_role.BackColor = Color.White;
            btn_grant_role.BackgroundImage = Properties.Resources.button_round1;
            btn_grant_role.FlatAppearance.BorderSize = 0;
            btn_grant_role.FlatStyle = FlatStyle.Flat;
            btn_grant_role.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_grant_role.ForeColor = SystemColors.Window;
            btn_grant_role.Location = new Point(280, 393);
            btn_grant_role.Name = "btn_grant_role";
            btn_grant_role.Size = new Size(130, 38);
            btn_grant_role.TabIndex = 18;
            btn_grant_role.Text = "Cấp quyền";
            btn_grant_role.UseVisualStyleBackColor = false;
            // 
            // tb_search_user
            // 
            tb_search_user.BackColor = Color.WhiteSmoke;
            tb_search_user.BorderStyle = BorderStyle.None;
            tb_search_user.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_search_user.Location = new Point(52, 9);
            tb_search_user.Name = "tb_search_user";
            tb_search_user.PlaceholderText = "Nhập tên người dùng...";
            tb_search_user.Size = new Size(510, 23);
            tb_search_user.TabIndex = 1;
            // 
            // pic_search_user
            // 
            pic_search_user.Image = Properties.Resources.Search1;
            pic_search_user.Location = new Point(3, 5);
            pic_search_user.Name = "pic_search_user";
            pic_search_user.Size = new Size(43, 30);
            pic_search_user.SizeMode = PictureBoxSizeMode.Zoom;
            pic_search_user.TabIndex = 0;
            pic_search_user.TabStop = false;
            // 
            // dtGrid_user
            // 
            dtGrid_user.BackgroundColor = Color.WhiteSmoke;
            dtGrid_user.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_user.Location = new Point(6, 61);
            dtGrid_user.Name = "dtGrid_user";
            dtGrid_user.RowHeadersWidth = 51;
            dtGrid_user.Size = new Size(676, 318);
            dtGrid_user.TabIndex = 10;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(202, 393);
            button2.Name = "button2";
            button2.Size = new Size(0, 0);
            button2.TabIndex = 7;
            button2.Text = "Tạo user";
            button2.UseVisualStyleBackColor = false;
            // 
            // btn_grant_user
            // 
            btn_grant_user.BackColor = Color.White;
            btn_grant_user.BackgroundImage = Properties.Resources.button_round1;
            btn_grant_user.FlatAppearance.BorderSize = 0;
            btn_grant_user.FlatStyle = FlatStyle.Flat;
            btn_grant_user.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_grant_user.ForeColor = SystemColors.Window;
            btn_grant_user.Location = new Point(10, 393);
            btn_grant_user.Name = "btn_grant_user";
            btn_grant_user.Size = new Size(130, 38);
            btn_grant_user.TabIndex = 6;
            btn_grant_user.Text = "Cấp quyền";
            btn_grant_user.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(tb_search_user);
            panel5.Controls.Add(pic_search_user);
            panel5.Location = new Point(6, 13);
            panel5.Name = "panel5";
            panel5.Size = new Size(567, 38);
            panel5.TabIndex = 5;
            // 
            // tbCtrl_main
            // 
            tbCtrl_main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbCtrl_main.Controls.Add(tabPage1);
            tbCtrl_main.Controls.Add(tabPage2);
            tbCtrl_main.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCtrl_main.Location = new Point(24, 49);
            tbCtrl_main.Name = "tbCtrl_main";
            tbCtrl_main.SelectedIndex = 0;
            tbCtrl_main.Size = new Size(701, 477);
            tbCtrl_main.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(237, 248, 243);
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(btn_revoke_user);
            tabPage1.Controls.Add(btn_role);
            tabPage1.Controls.Add(dtGrid_user);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(btn_grant_user);
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(btn_search_user);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(693, 441);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "User";
            // 
            // btn_revoke_user
            // 
            btn_revoke_user.BackColor = Color.White;
            btn_revoke_user.BackgroundImage = Properties.Resources.button_round1;
            btn_revoke_user.FlatAppearance.BorderSize = 0;
            btn_revoke_user.FlatStyle = FlatStyle.Flat;
            btn_revoke_user.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_revoke_user.ForeColor = SystemColors.Window;
            btn_revoke_user.Location = new Point(552, 393);
            btn_revoke_user.Name = "btn_revoke_user";
            btn_revoke_user.Size = new Size(130, 38);
            btn_revoke_user.TabIndex = 12;
            btn_revoke_user.Text = "Thu hồi quyền";
            btn_revoke_user.UseVisualStyleBackColor = false;
            // 
            // btn_role
            // 
            btn_role.BackColor = Color.White;
            btn_role.BackgroundImage = Properties.Resources.button_round1;
            btn_role.FlatAppearance.BorderSize = 0;
            btn_role.FlatStyle = FlatStyle.Flat;
            btn_role.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_role.ForeColor = SystemColors.Window;
            btn_role.Location = new Point(280, 393);
            btn_role.Name = "btn_role";
            btn_role.Size = new Size(130, 38);
            btn_role.TabIndex = 11;
            btn_role.Text = "Cấp role";
            btn_role.UseVisualStyleBackColor = false;
            // 
            // btn_search_user
            // 
            btn_search_user.BackColor = Color.White;
            btn_search_user.BackgroundImage = Properties.Resources.button_round2;
            btn_search_user.FlatAppearance.BorderSize = 0;
            btn_search_user.FlatStyle = FlatStyle.Flat;
            btn_search_user.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_search_user.ForeColor = SystemColors.Window;
            btn_search_user.Location = new Point(591, 13);
            btn_search_user.Name = "btn_search_user";
            btn_search_user.Size = new Size(91, 38);
            btn_search_user.TabIndex = 4;
            btn_search_user.Text = "Tìm kiếm";
            btn_search_user.UseVisualStyleBackColor = false;
            // 
            // pn_main
            // 
            pn_main.BackColor = SystemColors.Window;
            pn_main.Controls.Add(tbCtrl_main);
            pn_main.Controls.Add(lab_qlq);
            pn_main.Location = new Point(220, 54);
            pn_main.Name = "pn_main";
            pn_main.Size = new Size(739, 536);
            pn_main.TabIndex = 11;
            // 
            // lab_qlq
            // 
            lab_qlq.AutoSize = true;
            lab_qlq.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lab_qlq.Location = new Point(267, 15);
            lab_qlq.Name = "lab_qlq";
            lab_qlq.Size = new Size(191, 31);
            lab_qlq.TabIndex = 0;
            lab_qlq.Text = "QUẢN LÝ QUYỀN";
            lab_qlq.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(30, 23);
            label4.Name = "label4";
            label4.Size = new Size(149, 28);
            label4.TabIndex = 0;
            label4.Text = "Quản lý quyền";
            // 
            // pic_logout
            // 
            pic_logout.Image = Properties.Resources.Exit;
            pic_logout.Location = new Point(902, 9);
            pic_logout.Name = "pic_logout";
            pic_logout.Size = new Size(43, 36);
            pic_logout.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logout.TabIndex = 15;
            pic_logout.TabStop = false;
            // 
            // pn_qlq
            // 
            pn_qlq.BackColor = Color.FromArgb(177, 213, 246);
            pn_qlq.Controls.Add(label4);
            pn_qlq.Location = new Point(0, 408);
            pn_qlq.Name = "pn_qlq";
            pn_qlq.Size = new Size(220, 76);
            pn_qlq.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 23);
            label3.Name = "label3";
            label3.Size = new Size(184, 28);
            label3.TabIndex = 0;
            label3.Text = "Quản lý User/Role";
            // 
            // pn_qlur
            // 
            pn_qlur.BackColor = Color.FromArgb(42, 107, 167);
            pn_qlur.Controls.Add(label3);
            pn_qlur.Location = new Point(0, 331);
            pn_qlur.Name = "pn_qlur";
            pn_qlur.Size = new Size(220, 76);
            pn_qlur.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(7, 23);
            label2.Name = "label2";
            label2.Size = new Size(205, 28);
            label2.TabIndex = 0;
            label2.Text = "Danh sách tài khoản";
            // 
            // pn_dstk
            // 
            pn_dstk.BackColor = Color.FromArgb(42, 107, 167);
            pn_dstk.Controls.Add(label2);
            pn_dstk.Location = new Point(0, 254);
            pn_dstk.Name = "pn_dstk";
            pn_dstk.Size = new Size(220, 76);
            pn_dstk.TabIndex = 13;
            // 
            // pic_khtn
            // 
            pic_khtn.Image = Properties.Resources.logo2;
            pic_khtn.Location = new Point(28, 28);
            pic_khtn.Name = "pic_khtn";
            pic_khtn.Size = new Size(170, 155);
            pic_khtn.SizeMode = PictureBoxSizeMode.Zoom;
            pic_khtn.TabIndex = 12;
            pic_khtn.TabStop = false;
            // 
            // Permission
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 107, 167);
            ClientSize = new Size(957, 590);
            Controls.Add(pn_main);
            Controls.Add(pic_logout);
            Controls.Add(pn_qlq);
            Controls.Add(pn_qlur);
            Controls.Add(pn_dstk);
            Controls.Add(pic_khtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Permission";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Permission";
            ((System.ComponentModel.ISupportInitialize)dtGrid_role).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_search_role).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_search_user).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_user).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tbCtrl_main.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            pn_main.ResumeLayout(false);
            pn_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logout).EndInit();
            pn_qlq.ResumeLayout(false);
            pn_qlq.PerformLayout();
            pn_qlur.ResumeLayout(false);
            pn_qlur.PerformLayout();
            pn_dstk.ResumeLayout(false);
            pn_dstk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_khtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_search_role;
        private TextBox tb_search_role;
        private DataGridView dtGrid_role;
        private Panel panel6;
        private PictureBox pic_search_role;
        private TabPage tabPage2;
        private TextBox tb_search_user;
        private PictureBox pic_search_user;
        private DataGridView dtGrid_user;
        private Button button2;
        private Button btn_grant_user;
        private Panel panel5;
        private TabControl tbCtrl_main;
        private TabPage tabPage1;
        private Button btn_search_user;
        private Panel pn_main;
        private Label lab_qlq;
        private Label label4;
        private PictureBox pic_logout;
        private Panel pn_qlq;
        private Label label3;
        private Panel pn_qlur;
        private Label label2;
        private Panel pn_dstk;
        private PictureBox pic_khtn;
        private Button btn_revoke_role;
        private Button btn_grant_role;
        private Button btn_revoke_user;
        private Button btn_role;
    }
}