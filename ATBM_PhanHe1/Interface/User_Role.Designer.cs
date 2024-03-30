namespace ATBM_PhanHe1.Interface
{
    partial class User_Role
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
            pn_dstk = new Panel();
            label2 = new Label();
            pic_khtn = new PictureBox();
            pn_qlur = new Panel();
            label3 = new Label();
            pic_logout = new PictureBox();
            pn_qlq = new Panel();
            label4 = new Label();
            lab_ttur = new Label();
            pn_main = new Panel();
            tbCtrl_main = new TabControl();
            tabPage1 = new TabPage();
            dtGrid_user = new DataGridView();
            btn_update_user = new Button();
            btn_delete_user = new Button();
            btn_create_user = new Button();
            btn_inspect_user = new Button();
            panel5 = new Panel();
            tb_search_user = new TextBox();
            pic_search_user = new PictureBox();
            btn_search_user = new Button();
            tabPage2 = new TabPage();
            dtGrid_role = new DataGridView();
            btn_update_role = new Button();
            btn_delete_role = new Button();
            btn_create_role = new Button();
            btn_inspect_role = new Button();
            panel6 = new Panel();
            tb_search_role = new TextBox();
            pic_search_role = new PictureBox();
            btn_search_role = new Button();
            pn_dstk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_khtn).BeginInit();
            pn_qlur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logout).BeginInit();
            pn_qlq.SuspendLayout();
            pn_main.SuspendLayout();
            tbCtrl_main.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrid_user).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_search_user).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrid_role).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_search_role).BeginInit();
            SuspendLayout();
            // 
            // pn_dstk
            // 
            pn_dstk.BackColor = Color.FromArgb(42, 107, 167);
            pn_dstk.Controls.Add(label2);
            pn_dstk.Location = new Point(0, 254);
            pn_dstk.Name = "pn_dstk";
            pn_dstk.Size = new Size(220, 76);
            pn_dstk.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(7, 21);
            label2.Name = "label2";
            label2.Size = new Size(205, 28);
            label2.TabIndex = 0;
            label2.Text = "Danh sách tài khoản";
            // 
            // pic_khtn
            // 
            pic_khtn.Image = Properties.Resources.logo2;
            pic_khtn.Location = new Point(28, 28);
            pic_khtn.Name = "pic_khtn";
            pic_khtn.Size = new Size(170, 155);
            pic_khtn.SizeMode = PictureBoxSizeMode.Zoom;
            pic_khtn.TabIndex = 6;
            pic_khtn.TabStop = false;
            // 
            // pn_qlur
            // 
            pn_qlur.BackColor = Color.FromArgb(177, 213, 246);
            pn_qlur.Controls.Add(label3);
            pn_qlur.Location = new Point(0, 331);
            pn_qlur.Name = "pn_qlur";
            pn_qlur.Size = new Size(220, 76);
            pn_qlur.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(14, 21);
            label3.Name = "label3";
            label3.Size = new Size(184, 28);
            label3.TabIndex = 0;
            label3.Text = "Quản lý User/Role";
            // 
            // pic_logout
            // 
            pic_logout.Image = Properties.Resources.Exit;
            pic_logout.Location = new Point(902, 9);
            pic_logout.Name = "pic_logout";
            pic_logout.Size = new Size(43, 36);
            pic_logout.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logout.TabIndex = 9;
            pic_logout.TabStop = false;
            pic_logout.Click += pic_logout_Click;
            // 
            // pn_qlq
            // 
            pn_qlq.BackColor = Color.FromArgb(42, 107, 167);
            pn_qlq.Controls.Add(label4);
            pn_qlq.Location = new Point(0, 408);
            pn_qlq.Name = "pn_qlq";
            pn_qlq.Size = new Size(220, 76);
            pn_qlq.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 21);
            label4.Name = "label4";
            label4.Size = new Size(149, 28);
            label4.TabIndex = 0;
            label4.Text = "Quản lý quyền";
            // 
            // lab_ttur
            // 
            lab_ttur.AutoSize = true;
            lab_ttur.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lab_ttur.Location = new Point(227, 13);
            lab_ttur.Name = "lab_ttur";
            lab_ttur.Size = new Size(275, 31);
            lab_ttur.TabIndex = 0;
            lab_ttur.Text = "THÔNG TIN USER - ROLE";
            lab_ttur.TextAlign = ContentAlignment.TopCenter;
            // 
            // pn_main
            // 
            pn_main.BackColor = SystemColors.Window;
            pn_main.Controls.Add(tbCtrl_main);
            pn_main.Controls.Add(lab_ttur);
            pn_main.Location = new Point(220, 54);
            pn_main.Name = "pn_main";
            pn_main.Size = new Size(739, 536);
            pn_main.TabIndex = 5;
            // 
            // tbCtrl_main
            // 
            tbCtrl_main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbCtrl_main.Controls.Add(tabPage1);
            tbCtrl_main.Controls.Add(tabPage2);
            tbCtrl_main.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCtrl_main.Location = new Point(24, 47);
            tbCtrl_main.Name = "tbCtrl_main";
            tbCtrl_main.SelectedIndex = 0;
            tbCtrl_main.Size = new Size(701, 477);
            tbCtrl_main.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(237, 248, 243);
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(dtGrid_user);
            tabPage1.Controls.Add(btn_update_user);
            tabPage1.Controls.Add(btn_delete_user);
            tabPage1.Controls.Add(btn_create_user);
            tabPage1.Controls.Add(btn_inspect_user);
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
            // dtGrid_user
            // 
            dtGrid_user.BackgroundColor = Color.WhiteSmoke;
            dtGrid_user.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_user.Location = new Point(6, 59);
            dtGrid_user.Name = "dtGrid_user";
            dtGrid_user.RowHeadersWidth = 51;
            dtGrid_user.Size = new Size(676, 318);
            dtGrid_user.TabIndex = 10;
            // 
            // btn_update_user
            // 
            btn_update_user.BackColor = Color.White;
            btn_update_user.BackgroundImage = Properties.Resources.button_round2;
            btn_update_user.FlatAppearance.BorderSize = 0;
            btn_update_user.FlatStyle = FlatStyle.Flat;
            btn_update_user.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_update_user.ForeColor = SystemColors.Window;
            btn_update_user.Location = new Point(591, 391);
            btn_update_user.Name = "btn_update_user";
            btn_update_user.Size = new Size(91, 38);
            btn_update_user.TabIndex = 9;
            btn_update_user.Text = "Chỉnh sửa";
            btn_update_user.UseVisualStyleBackColor = false;
            // 
            // btn_delete_user
            // 
            btn_delete_user.BackColor = Color.White;
            btn_delete_user.BackgroundImage = Properties.Resources.button_round2;
            btn_delete_user.FlatAppearance.BorderSize = 0;
            btn_delete_user.FlatStyle = FlatStyle.Flat;
            btn_delete_user.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_delete_user.ForeColor = SystemColors.Window;
            btn_delete_user.Location = new Point(402, 391);
            btn_delete_user.Name = "btn_delete_user";
            btn_delete_user.Size = new Size(91, 38);
            btn_delete_user.TabIndex = 8;
            btn_delete_user.Text = "Xóa user";
            btn_delete_user.UseVisualStyleBackColor = false;
            // 
            // btn_create_user
            // 
            btn_create_user.BackColor = Color.White;
            btn_create_user.BackgroundImage = Properties.Resources.button_round2;
            btn_create_user.FlatAppearance.BorderSize = 0;
            btn_create_user.FlatStyle = FlatStyle.Flat;
            btn_create_user.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_create_user.ForeColor = SystemColors.Window;
            btn_create_user.Location = new Point(202, 391);
            btn_create_user.Name = "btn_create_user";
            btn_create_user.Size = new Size(91, 38);
            btn_create_user.TabIndex = 7;
            btn_create_user.Text = "Tạo user";
            btn_create_user.UseVisualStyleBackColor = false;
            // 
            // btn_inspect_user
            // 
            btn_inspect_user.BackColor = Color.White;
            btn_inspect_user.BackgroundImage = Properties.Resources.button_round2;
            btn_inspect_user.FlatAppearance.BorderSize = 0;
            btn_inspect_user.FlatStyle = FlatStyle.Flat;
            btn_inspect_user.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_inspect_user.ForeColor = SystemColors.Window;
            btn_inspect_user.Location = new Point(10, 391);
            btn_inspect_user.Name = "btn_inspect_user";
            btn_inspect_user.Size = new Size(91, 38);
            btn_inspect_user.TabIndex = 6;
            btn_inspect_user.Text = "Xem";
            btn_inspect_user.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(tb_search_user);
            panel5.Controls.Add(pic_search_user);
            panel5.Location = new Point(6, 11);
            panel5.Name = "panel5";
            panel5.Size = new Size(567, 38);
            panel5.TabIndex = 5;
            // 
            // tb_search_user
            // 
            tb_search_user.BackColor = Color.WhiteSmoke;
            tb_search_user.BorderStyle = BorderStyle.None;
            tb_search_user.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_search_user.Location = new Point(52, 7);
            tb_search_user.Name = "tb_search_user";
            tb_search_user.PlaceholderText = "Nhập tên người dùng...";
            tb_search_user.Size = new Size(510, 23);
            tb_search_user.TabIndex = 1;
            // 
            // pic_search_user
            // 
            pic_search_user.Image = Properties.Resources.Search1;
            pic_search_user.Location = new Point(3, 3);
            pic_search_user.Name = "pic_search_user";
            pic_search_user.Size = new Size(43, 30);
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
            btn_search_user.Location = new Point(591, 11);
            btn_search_user.Name = "btn_search_user";
            btn_search_user.Size = new Size(91, 38);
            btn_search_user.TabIndex = 4;
            btn_search_user.Text = "Tìm kiếm";
            btn_search_user.UseVisualStyleBackColor = false;
            btn_search_user.Click += btn_search_user_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(249, 240, 240);
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(dtGrid_role);
            tabPage2.Controls.Add(btn_update_role);
            tabPage2.Controls.Add(btn_delete_role);
            tabPage2.Controls.Add(btn_create_role);
            tabPage2.Controls.Add(btn_inspect_role);
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
            // dtGrid_role
            // 
            dtGrid_role.BackgroundColor = Color.WhiteSmoke;
            dtGrid_role.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_role.Location = new Point(6, 59);
            dtGrid_role.Name = "dtGrid_role";
            dtGrid_role.RowHeadersWidth = 51;
            dtGrid_role.Size = new Size(676, 318);
            dtGrid_role.TabIndex = 17;
            // 
            // btn_update_role
            // 
            btn_update_role.BackColor = Color.White;
            btn_update_role.BackgroundImage = Properties.Resources.button_round2;
            btn_update_role.FlatAppearance.BorderSize = 0;
            btn_update_role.FlatStyle = FlatStyle.Flat;
            btn_update_role.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_update_role.ForeColor = SystemColors.Window;
            btn_update_role.Location = new Point(591, 391);
            btn_update_role.Name = "btn_update_role";
            btn_update_role.Size = new Size(91, 38);
            btn_update_role.TabIndex = 16;
            btn_update_role.Text = "Chỉnh sửa";
            btn_update_role.UseVisualStyleBackColor = false;
            // 
            // btn_delete_role
            // 
            btn_delete_role.BackColor = Color.White;
            btn_delete_role.BackgroundImage = Properties.Resources.button_round2;
            btn_delete_role.FlatAppearance.BorderSize = 0;
            btn_delete_role.FlatStyle = FlatStyle.Flat;
            btn_delete_role.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_delete_role.ForeColor = SystemColors.Window;
            btn_delete_role.Location = new Point(402, 391);
            btn_delete_role.Name = "btn_delete_role";
            btn_delete_role.Size = new Size(91, 38);
            btn_delete_role.TabIndex = 15;
            btn_delete_role.Text = "Xóa role";
            btn_delete_role.UseVisualStyleBackColor = false;
            // 
            // btn_create_role
            // 
            btn_create_role.BackColor = Color.White;
            btn_create_role.BackgroundImage = Properties.Resources.button_round2;
            btn_create_role.FlatAppearance.BorderSize = 0;
            btn_create_role.FlatStyle = FlatStyle.Flat;
            btn_create_role.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_create_role.ForeColor = SystemColors.Window;
            btn_create_role.Location = new Point(202, 391);
            btn_create_role.Name = "btn_create_role";
            btn_create_role.Size = new Size(91, 38);
            btn_create_role.TabIndex = 14;
            btn_create_role.Text = "Tạo role";
            btn_create_role.UseVisualStyleBackColor = false;
            // 
            // btn_inspect_role
            // 
            btn_inspect_role.BackColor = Color.White;
            btn_inspect_role.BackgroundImage = Properties.Resources.button_round2;
            btn_inspect_role.FlatAppearance.BorderSize = 0;
            btn_inspect_role.FlatStyle = FlatStyle.Flat;
            btn_inspect_role.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_inspect_role.ForeColor = SystemColors.Window;
            btn_inspect_role.Location = new Point(10, 391);
            btn_inspect_role.Name = "btn_inspect_role";
            btn_inspect_role.Size = new Size(91, 38);
            btn_inspect_role.TabIndex = 13;
            btn_inspect_role.Text = "Xem";
            btn_inspect_role.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(tb_search_role);
            panel6.Controls.Add(pic_search_role);
            panel6.Location = new Point(6, 11);
            panel6.Name = "panel6";
            panel6.Size = new Size(567, 38);
            panel6.TabIndex = 12;
            // 
            // tb_search_role
            // 
            tb_search_role.BackColor = Color.WhiteSmoke;
            tb_search_role.BorderStyle = BorderStyle.None;
            tb_search_role.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_search_role.Location = new Point(52, 7);
            tb_search_role.Name = "tb_search_role";
            tb_search_role.PlaceholderText = "Nhập tên người dùng...";
            tb_search_role.Size = new Size(510, 23);
            tb_search_role.TabIndex = 1;
            // 
            // pic_search_role
            // 
            pic_search_role.Image = Properties.Resources.Search1;
            pic_search_role.Location = new Point(3, 3);
            pic_search_role.Name = "pic_search_role";
            pic_search_role.Size = new Size(43, 30);
            pic_search_role.SizeMode = PictureBoxSizeMode.Zoom;
            pic_search_role.TabIndex = 0;
            pic_search_role.TabStop = false;
            // 
            // btn_search_role
            // 
            btn_search_role.BackColor = Color.White;
            btn_search_role.BackgroundImage = Properties.Resources.button_round2;
            btn_search_role.FlatAppearance.BorderSize = 0;
            btn_search_role.FlatStyle = FlatStyle.Flat;
            btn_search_role.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_search_role.ForeColor = SystemColors.Window;
            btn_search_role.Location = new Point(591, 11);
            btn_search_role.Name = "btn_search_role";
            btn_search_role.Size = new Size(91, 38);
            btn_search_role.TabIndex = 11;
            btn_search_role.Text = "Tìm kiếm";
            btn_search_role.UseVisualStyleBackColor = false;
            btn_search_role.Click += btn_search_role_Click;
            // 
            // User_Role
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 107, 167);
            ClientSize = new Size(957, 590);
            Controls.Add(pn_main);
            Controls.Add(pn_dstk);
            Controls.Add(pic_khtn);
            Controls.Add(pn_qlur);
            Controls.Add(pic_logout);
            Controls.Add(pn_qlq);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User_Role";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User_Role";
            pn_dstk.ResumeLayout(false);
            pn_dstk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_khtn).EndInit();
            pn_qlur.ResumeLayout(false);
            pn_qlur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logout).EndInit();
            pn_qlq.ResumeLayout(false);
            pn_qlq.PerformLayout();
            pn_main.ResumeLayout(false);
            pn_main.PerformLayout();
            tbCtrl_main.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGrid_user).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_search_user).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGrid_role).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_search_role).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pn_dstk;
        private Label label2;
        private PictureBox pic_khtn;
        private Panel pn_qlur;
        private Label label3;
        private PictureBox pic_logout;
        private Panel pn_qlq;
        private Label label4;
        private Label lab_ttur;
        private Panel pn_main;
        private TabControl tbCtrl_main;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dtGrid_user;
        private Button btn_update_user;
        private Button btn_delete_user;
        private Button btn_create_user;
        private Button btn_inspect_user;
        private Panel panel5;
        private TextBox tb_search_user;
        private PictureBox pic_search_user;
        private Button btn_search_user;
        private DataGridView dtGrid_role;
        private Button btn_update_role;
        private Button btn_delete_role;
        private Button btn_create_role;
        private Button btn_inspect_role;
        private Panel panel6;
        private TextBox tb_search_role;
        private PictureBox pic_search_role;
        private Button btn_search_role;
    }
}