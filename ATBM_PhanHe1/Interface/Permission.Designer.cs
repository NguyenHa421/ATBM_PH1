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
            pic_refresh2 = new PictureBox();
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
            pic_refresh_U = new PictureBox();
            btn_revoke_user = new Button();
            btn_role = new Button();
            btn_search_user = new Button();
            pn_main = new Panel();
            lab_qlq = new Label();
            Parent_panel = new Panel();
            pic_logout = new PictureBox();
            pn_qlq = new Panel();
            btn_qlq = new Button();
            pn_qlur = new Panel();
            btn_qlur = new Button();
            pn_dstk = new Panel();
            btn_dstk = new Button();
            pic_khtn = new PictureBox();
            btn_xnk = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGrid_role).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_search_role).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_refresh2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_search_user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_user).BeginInit();
            panel5.SuspendLayout();
            tbCtrl_main.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_refresh_U).BeginInit();
            pn_main.SuspendLayout();
            Parent_panel.SuspendLayout();
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
            btn_search_role.Location = new Point(517, 8);
            btn_search_role.Margin = new Padding(3, 2, 3, 2);
            btn_search_role.Name = "btn_search_role";
            btn_search_role.Size = new Size(80, 28);
            btn_search_role.TabIndex = 11;
            btn_search_role.Text = "Tìm kiếm";
            btn_search_role.UseVisualStyleBackColor = false;
            btn_search_role.Click += btn_search_role_Click;
            // 
            // tb_search_role
            // 
            tb_search_role.BackColor = Color.WhiteSmoke;
            tb_search_role.BorderStyle = BorderStyle.None;
            tb_search_role.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_search_role.Location = new Point(46, 5);
            tb_search_role.Margin = new Padding(3, 2, 3, 2);
            tb_search_role.Name = "tb_search_role";
            tb_search_role.PlaceholderText = "Nhập tên người dùng...";
            tb_search_role.Size = new Size(409, 19);
            tb_search_role.TabIndex = 1;
            // 
            // dtGrid_role
            // 
            dtGrid_role.BackgroundColor = Color.WhiteSmoke;
            dtGrid_role.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_role.Location = new Point(5, 44);
            dtGrid_role.Margin = new Padding(3, 2, 3, 2);
            dtGrid_role.Name = "dtGrid_role";
            dtGrid_role.RowHeadersWidth = 51;
            dtGrid_role.Size = new Size(592, 238);
            dtGrid_role.TabIndex = 17;
            dtGrid_role.CellContentClick += dtGrid_role_CellContentClick;
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(tb_search_role);
            panel6.Controls.Add(pic_search_role);
            panel6.Location = new Point(5, 8);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(459, 29);
            panel6.TabIndex = 12;
            // 
            // pic_search_role
            // 
            pic_search_role.Image = Properties.Resources.Search1;
            pic_search_role.Location = new Point(3, 2);
            pic_search_role.Margin = new Padding(3, 2, 3, 2);
            pic_search_role.Name = "pic_search_role";
            pic_search_role.Size = new Size(38, 22);
            pic_search_role.SizeMode = PictureBoxSizeMode.Zoom;
            pic_search_role.TabIndex = 0;
            pic_search_role.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(249, 240, 240);
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(pic_refresh2);
            tabPage2.Controls.Add(btn_revoke_role);
            tabPage2.Controls.Add(btn_grant_role);
            tabPage2.Controls.Add(dtGrid_role);
            tabPage2.Controls.Add(panel6);
            tabPage2.Controls.Add(btn_search_role);
            tabPage2.ForeColor = Color.Black;
            tabPage2.Location = new Point(4, 28);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(605, 326);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Role";
            // 
            // pic_refresh2
            // 
            pic_refresh2.Image = Properties.Resources.refresh_buttons;
            pic_refresh2.Location = new Point(469, 8);
            pic_refresh2.Margin = new Padding(3, 2, 3, 2);
            pic_refresh2.Name = "pic_refresh2";
            pic_refresh2.Size = new Size(43, 29);
            pic_refresh2.SizeMode = PictureBoxSizeMode.Zoom;
            pic_refresh2.TabIndex = 21;
            pic_refresh2.TabStop = false;
            pic_refresh2.Click += pic_refresh2_Click;
            // 
            // btn_revoke_role
            // 
            btn_revoke_role.BackColor = Color.White;
            btn_revoke_role.BackgroundImage = Properties.Resources.button_round1;
            btn_revoke_role.FlatAppearance.BorderSize = 0;
            btn_revoke_role.FlatStyle = FlatStyle.Flat;
            btn_revoke_role.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_revoke_role.ForeColor = SystemColors.Window;
            btn_revoke_role.Location = new Point(483, 293);
            btn_revoke_role.Margin = new Padding(3, 2, 3, 2);
            btn_revoke_role.Name = "btn_revoke_role";
            btn_revoke_role.Size = new Size(114, 28);
            btn_revoke_role.TabIndex = 19;
            btn_revoke_role.Text = "Thu hồi quyền";
            btn_revoke_role.UseVisualStyleBackColor = false;
            btn_revoke_role.Click += btn_revoke_role_Click;
            // 
            // btn_grant_role
            // 
            btn_grant_role.BackColor = Color.White;
            btn_grant_role.BackgroundImage = Properties.Resources.button_round1;
            btn_grant_role.FlatAppearance.BorderSize = 0;
            btn_grant_role.FlatStyle = FlatStyle.Flat;
            btn_grant_role.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_grant_role.ForeColor = SystemColors.Window;
            btn_grant_role.Location = new Point(245, 293);
            btn_grant_role.Margin = new Padding(3, 2, 3, 2);
            btn_grant_role.Name = "btn_grant_role";
            btn_grant_role.Size = new Size(114, 28);
            btn_grant_role.TabIndex = 18;
            btn_grant_role.Text = "Cấp quyền";
            btn_grant_role.UseVisualStyleBackColor = false;
            btn_grant_role.Click += btn_grant_role_Click;
            // 
            // tb_search_user
            // 
            tb_search_user.BackColor = Color.WhiteSmoke;
            tb_search_user.BorderStyle = BorderStyle.None;
            tb_search_user.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_search_user.Location = new Point(46, 5);
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
            // dtGrid_user
            // 
            dtGrid_user.BackgroundColor = Color.WhiteSmoke;
            dtGrid_user.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_user.Location = new Point(5, 44);
            dtGrid_user.Margin = new Padding(3, 2, 3, 2);
            dtGrid_user.Name = "dtGrid_user";
            dtGrid_user.RowHeadersWidth = 51;
            dtGrid_user.Size = new Size(592, 238);
            dtGrid_user.TabIndex = 10;
            dtGrid_user.CellContentClick += dtGrid_user_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(177, 295);
            button2.Margin = new Padding(3, 2, 3, 2);
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
            btn_grant_user.Location = new Point(9, 293);
            btn_grant_user.Margin = new Padding(3, 2, 3, 2);
            btn_grant_user.Name = "btn_grant_user";
            btn_grant_user.Size = new Size(114, 28);
            btn_grant_user.TabIndex = 6;
            btn_grant_user.Text = "Cấp quyền";
            btn_grant_user.UseVisualStyleBackColor = false;
            btn_grant_user.Click += btn_grant_user_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(tb_search_user);
            panel5.Controls.Add(pic_search_user);
            panel5.Location = new Point(5, 8);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(459, 29);
            panel5.TabIndex = 5;
            // 
            // tbCtrl_main
            // 
            tbCtrl_main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbCtrl_main.Controls.Add(tabPage1);
            tbCtrl_main.Controls.Add(tabPage2);
            tbCtrl_main.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCtrl_main.Location = new Point(21, 2);
            tbCtrl_main.Margin = new Padding(3, 2, 3, 2);
            tbCtrl_main.Name = "tbCtrl_main";
            tbCtrl_main.SelectedIndex = 0;
            tbCtrl_main.Size = new Size(613, 358);
            tbCtrl_main.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(237, 248, 243);
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(pic_refresh_U);
            tabPage1.Controls.Add(btn_revoke_user);
            tabPage1.Controls.Add(btn_role);
            tabPage1.Controls.Add(dtGrid_user);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(btn_grant_user);
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(btn_search_user);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 28);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(605, 326);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "User";
            // 
            // pic_refresh_U
            // 
            pic_refresh_U.Image = Properties.Resources.refresh_buttons;
            pic_refresh_U.Location = new Point(469, 8);
            pic_refresh_U.Margin = new Padding(3, 2, 3, 2);
            pic_refresh_U.Name = "pic_refresh_U";
            pic_refresh_U.Size = new Size(43, 29);
            pic_refresh_U.SizeMode = PictureBoxSizeMode.Zoom;
            pic_refresh_U.TabIndex = 20;
            pic_refresh_U.TabStop = false;
            pic_refresh_U.Click += pic_refresh_U_Click;
            // 
            // btn_revoke_user
            // 
            btn_revoke_user.BackColor = Color.White;
            btn_revoke_user.BackgroundImage = Properties.Resources.button_round1;
            btn_revoke_user.FlatAppearance.BorderSize = 0;
            btn_revoke_user.FlatStyle = FlatStyle.Flat;
            btn_revoke_user.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_revoke_user.ForeColor = SystemColors.Window;
            btn_revoke_user.Location = new Point(483, 293);
            btn_revoke_user.Margin = new Padding(3, 2, 3, 2);
            btn_revoke_user.Name = "btn_revoke_user";
            btn_revoke_user.Size = new Size(114, 28);
            btn_revoke_user.TabIndex = 12;
            btn_revoke_user.Text = "Thu hồi quyền";
            btn_revoke_user.UseVisualStyleBackColor = false;
            btn_revoke_user.Click += btn_revoke_user_Click;
            // 
            // btn_role
            // 
            btn_role.BackColor = Color.White;
            btn_role.BackgroundImage = Properties.Resources.button_round1;
            btn_role.FlatAppearance.BorderSize = 0;
            btn_role.FlatStyle = FlatStyle.Flat;
            btn_role.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_role.ForeColor = SystemColors.Window;
            btn_role.Location = new Point(245, 293);
            btn_role.Margin = new Padding(3, 2, 3, 2);
            btn_role.Name = "btn_role";
            btn_role.Size = new Size(114, 28);
            btn_role.TabIndex = 11;
            btn_role.Text = "Cấp role";
            btn_role.UseVisualStyleBackColor = false;
            btn_role.Click += btn_role_Click;
            // 
            // btn_search_user
            // 
            btn_search_user.BackColor = Color.White;
            btn_search_user.BackgroundImage = Properties.Resources.button_round2;
            btn_search_user.FlatAppearance.BorderSize = 0;
            btn_search_user.FlatStyle = FlatStyle.Flat;
            btn_search_user.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_search_user.ForeColor = SystemColors.Window;
            btn_search_user.Location = new Point(517, 8);
            btn_search_user.Margin = new Padding(3, 2, 3, 2);
            btn_search_user.Name = "btn_search_user";
            btn_search_user.Size = new Size(80, 28);
            btn_search_user.TabIndex = 4;
            btn_search_user.Text = "Tìm kiếm";
            btn_search_user.UseVisualStyleBackColor = false;
            btn_search_user.Click += btn_search_user_Click;
            // 
            // pn_main
            // 
            pn_main.BackColor = SystemColors.Window;
            pn_main.Controls.Add(lab_qlq);
            pn_main.Controls.Add(Parent_panel);
            pn_main.Location = new Point(192, 40);
            pn_main.Margin = new Padding(3, 2, 3, 2);
            pn_main.Name = "pn_main";
            pn_main.Size = new Size(647, 402);
            pn_main.TabIndex = 11;
            // 
            // lab_qlq
            // 
            lab_qlq.AutoSize = true;
            lab_qlq.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lab_qlq.Location = new Point(234, 11);
            lab_qlq.Name = "lab_qlq";
            lab_qlq.Size = new Size(159, 25);
            lab_qlq.TabIndex = 0;
            lab_qlq.Text = "QUẢN LÝ QUYỀN";
            lab_qlq.TextAlign = ContentAlignment.TopCenter;
            // 
            // Parent_panel
            // 
            Parent_panel.Controls.Add(tbCtrl_main);
            Parent_panel.Location = new Point(0, 37);
            Parent_panel.Margin = new Padding(3, 2, 3, 2);
            Parent_panel.Name = "Parent_panel";
            Parent_panel.Size = new Size(647, 363);
            Parent_panel.TabIndex = 2;
            // 
            // pic_logout
            // 
            pic_logout.Image = Properties.Resources.Exit;
            pic_logout.Location = new Point(789, 7);
            pic_logout.Margin = new Padding(3, 2, 3, 2);
            pic_logout.Name = "pic_logout";
            pic_logout.Size = new Size(38, 27);
            pic_logout.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logout.TabIndex = 15;
            pic_logout.TabStop = false;
            pic_logout.Click += pic_logout_Click;
            // 
            // pn_qlq
            // 
            pn_qlq.BackColor = Color.FromArgb(177, 213, 246);
            pn_qlq.Controls.Add(btn_qlq);
            pn_qlq.Location = new Point(0, 306);
            pn_qlq.Margin = new Padding(3, 2, 3, 2);
            pn_qlq.Name = "pn_qlq";
            pn_qlq.Size = new Size(192, 57);
            pn_qlq.TabIndex = 16;
            // 
            // btn_qlq
            // 
            btn_qlq.BackColor = Color.FromArgb(177, 213, 246);
            btn_qlq.FlatAppearance.BorderColor = Color.FromArgb(177, 213, 246);
            btn_qlq.FlatAppearance.BorderSize = 0;
            btn_qlq.FlatStyle = FlatStyle.Flat;
            btn_qlq.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_qlq.ForeColor = Color.Black;
            btn_qlq.Location = new Point(1, 8);
            btn_qlq.Margin = new Padding(3, 2, 3, 2);
            btn_qlq.Name = "btn_qlq";
            btn_qlq.Size = new Size(191, 42);
            btn_qlq.TabIndex = 9;
            btn_qlq.Text = "Quản lý quyền";
            btn_qlq.UseVisualStyleBackColor = false;
            // 
            // pn_qlur
            // 
            pn_qlur.BackColor = Color.FromArgb(42, 107, 167);
            pn_qlur.Controls.Add(btn_qlur);
            pn_qlur.Location = new Point(0, 248);
            pn_qlur.Margin = new Padding(3, 2, 3, 2);
            pn_qlur.Name = "pn_qlur";
            pn_qlur.Size = new Size(192, 57);
            pn_qlur.TabIndex = 14;
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
            btn_qlur.TabIndex = 7;
            btn_qlur.Text = "Quản lý User/Role";
            btn_qlur.UseVisualStyleBackColor = false;
            btn_qlur.Click += btn_qlur_Click;
            // 
            // pn_dstk
            // 
            pn_dstk.BackColor = Color.FromArgb(42, 107, 167);
            pn_dstk.Controls.Add(btn_dstk);
            pn_dstk.Location = new Point(0, 190);
            pn_dstk.Margin = new Padding(3, 2, 3, 2);
            pn_dstk.Name = "pn_dstk";
            pn_dstk.Size = new Size(192, 57);
            pn_dstk.TabIndex = 13;
            // 
            // btn_dstk
            // 
            btn_dstk.BackColor = Color.FromArgb(42, 107, 167);
            btn_dstk.FlatAppearance.BorderColor = Color.FromArgb(177, 213, 246);
            btn_dstk.FlatAppearance.BorderSize = 0;
            btn_dstk.FlatStyle = FlatStyle.Flat;
            btn_dstk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dstk.ForeColor = Color.White;
            btn_dstk.Location = new Point(1, 8);
            btn_dstk.Margin = new Padding(3, 2, 3, 2);
            btn_dstk.Name = "btn_dstk";
            btn_dstk.Size = new Size(191, 42);
            btn_dstk.TabIndex = 7;
            btn_dstk.Text = "Danh sách tài khoản";
            btn_dstk.UseVisualStyleBackColor = false;
            btn_dstk.Click += btn_dstk_Click;
            // 
            // pic_khtn
            // 
            pic_khtn.Image = Properties.Resources.logo2;
            pic_khtn.Location = new Point(24, 21);
            pic_khtn.Margin = new Padding(3, 2, 3, 2);
            pic_khtn.Name = "pic_khtn";
            pic_khtn.Size = new Size(149, 116);
            pic_khtn.SizeMode = PictureBoxSizeMode.Zoom;
            pic_khtn.TabIndex = 12;
            pic_khtn.TabStop = false;
            // 
            // btn_xnk
            // 
            btn_xnk.BackColor = Color.FromArgb(42, 107, 167);
            btn_xnk.FlatAppearance.BorderColor = Color.FromArgb(177, 213, 246);
            btn_xnk.FlatAppearance.BorderSize = 0;
            btn_xnk.FlatStyle = FlatStyle.Flat;
            btn_xnk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xnk.ForeColor = Color.Transparent;
            btn_xnk.Location = new Point(0, 367);
            btn_xnk.Margin = new Padding(3, 2, 3, 2);
            btn_xnk.Name = "btn_xnk";
            btn_xnk.Size = new Size(191, 42);
            btn_xnk.TabIndex = 17;
            btn_xnk.Text = "Xem nhật ký";
            btn_xnk.UseVisualStyleBackColor = false;
            btn_xnk.Click += btn_xnk_Click;
            // 
            // Permission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 107, 167);
            ClientSize = new Size(837, 442);
            Controls.Add(btn_xnk);
            Controls.Add(pn_main);
            Controls.Add(pic_logout);
            Controls.Add(pn_qlq);
            Controls.Add(pn_qlur);
            Controls.Add(pn_dstk);
            Controls.Add(pic_khtn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Permission";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Permission";
            ((System.ComponentModel.ISupportInitialize)dtGrid_role).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_search_role).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_refresh2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_search_user).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_user).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tbCtrl_main.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_refresh_U).EndInit();
            pn_main.ResumeLayout(false);
            pn_main.PerformLayout();
            Parent_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_logout).EndInit();
            pn_qlq.ResumeLayout(false);
            pn_qlur.ResumeLayout(false);
            pn_dstk.ResumeLayout(false);
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
        private PictureBox pic_logout;
        private Panel pn_qlq;
        private Panel pn_qlur;
        private Panel pn_dstk;
        private PictureBox pic_khtn;
        private Button btn_revoke_role;
        private Button btn_grant_role;
        private Button btn_revoke_user;
        private Button btn_role;
        private Panel Parent_panel;
        private PictureBox pic_refresh_U;
        private Button btn_dstk;
        private Button btn_qlur;
        private Button btn_qlq;
        private PictureBox pic_refresh2;
        private Button btn_xnk;
    }
}