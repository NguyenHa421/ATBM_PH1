namespace ATBM_PhanHe1.Users_Roles
{
    partial class Grant_R
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
            lb_Column = new Label();
            bt_View = new Button();
            bt_grant = new Button();
            btn_Back = new Button();
            dtGrid_role_table = new DataGridView();
            clb_Role = new CheckedListBox();
            tb_add = new Label();
            lb_n_R = new Label();
            tb_user = new TextBox();
            lb_Name = new Label();
            cbB_Tables = new ComboBox();
            cbB_Column = new ComboBox();
            cB_allCol = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dtGrid_role_table).BeginInit();
            SuspendLayout();
            // 
            // lb_Column
            // 
            lb_Column.AutoSize = true;
            lb_Column.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Column.Location = new Point(311, 333);
            lb_Column.Name = "lb_Column";
            lb_Column.Size = new Size(78, 28);
            lb_Column.TabIndex = 65;
            lb_Column.Text = "Tên cột";
            // 
            // bt_View
            // 
            bt_View.BackColor = Color.White;
            bt_View.BackgroundImage = Properties.Resources.button_round2;
            bt_View.FlatAppearance.BorderSize = 0;
            bt_View.FlatStyle = FlatStyle.Flat;
            bt_View.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bt_View.ForeColor = SystemColors.Window;
            bt_View.Location = new Point(613, 146);
            bt_View.Name = "bt_View";
            bt_View.Size = new Size(91, 38);
            bt_View.TabIndex = 64;
            bt_View.Text = "Xem";
            bt_View.UseVisualStyleBackColor = false;
            bt_View.Click += bt_View_Click;
            // 
            // bt_grant
            // 
            bt_grant.BackColor = Color.White;
            bt_grant.BackgroundImage = Properties.Resources.button_round2;
            bt_grant.FlatAppearance.BorderSize = 0;
            bt_grant.FlatStyle = FlatStyle.Flat;
            bt_grant.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bt_grant.ForeColor = SystemColors.Window;
            bt_grant.Location = new Point(613, 430);
            bt_grant.Name = "bt_grant";
            bt_grant.Size = new Size(91, 38);
            bt_grant.TabIndex = 62;
            bt_grant.Text = "Cấp quyền";
            bt_grant.UseVisualStyleBackColor = false;
            bt_grant.Click += bt_grant_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round2;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(311, 430);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 61;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // dtGrid_role_table
            // 
            dtGrid_role_table.BackgroundColor = Color.WhiteSmoke;
            dtGrid_role_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_role_table.Location = new Point(34, 37);
            dtGrid_role_table.Name = "dtGrid_role_table";
            dtGrid_role_table.RowHeadersWidth = 51;
            dtGrid_role_table.Size = new Size(271, 374);
            dtGrid_role_table.TabIndex = 60;
            // 
            // clb_Role
            // 
            clb_Role.BackColor = Color.White;
            clb_Role.BorderStyle = BorderStyle.None;
            clb_Role.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clb_Role.FormattingEnabled = true;
            clb_Role.Items.AddRange(new object[] { "Select", "Insert", "Delete", "Update" });
            clb_Role.Location = new Point(476, 189);
            clb_Role.Name = "clb_Role";
            clb_Role.Size = new Size(150, 116);
            clb_Role.TabIndex = 59;
            // 
            // tb_add
            // 
            tb_add.AutoSize = true;
            tb_add.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_add.Location = new Point(311, 189);
            tb_add.Name = "tb_add";
            tb_add.Size = new Size(109, 28);
            tb_add.TabIndex = 58;
            tb_add.Text = "Cấp quyền";
            // 
            // lb_n_R
            // 
            lb_n_R.AutoSize = true;
            lb_n_R.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_n_R.Location = new Point(311, 96);
            lb_n_R.Name = "lb_n_R";
            lb_n_R.Size = new Size(96, 28);
            lb_n_R.TabIndex = 56;
            lb_n_R.Text = "Tên bảng";
            // 
            // tb_user
            // 
            tb_user.BorderStyle = BorderStyle.FixedSingle;
            tb_user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_user.Location = new Point(439, 35);
            tb_user.Name = "tb_user";
            tb_user.ReadOnly = true;
            tb_user.Size = new Size(265, 34);
            tb_user.TabIndex = 55;
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Name.Location = new Point(311, 37);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(85, 28);
            lb_Name.TabIndex = 54;
            lb_Name.Text = "Tên role";
            // 
            // cbB_Tables
            // 
            cbB_Tables.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_Tables.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_Tables.FormattingEnabled = true;
            cbB_Tables.Location = new Point(439, 93);
            cbB_Tables.Name = "cbB_Tables";
            cbB_Tables.Size = new Size(265, 36);
            cbB_Tables.TabIndex = 67;
            cbB_Tables.SelectedIndexChanged += cbB_Tables_SelectedIndexChanged;
            // 
            // cbB_Column
            // 
            cbB_Column.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_Column.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_Column.FormattingEnabled = true;
            cbB_Column.Location = new Point(439, 330);
            cbB_Column.Name = "cbB_Column";
            cbB_Column.Size = new Size(265, 36);
            cbB_Column.TabIndex = 68;
            // 
            // cB_allCol
            // 
            cB_allCol.AutoSize = true;
            cB_allCol.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cB_allCol.Location = new Point(476, 377);
            cB_allCol.Name = "cB_allCol";
            cB_allCol.Size = new Size(121, 32);
            cB_allCol.TabIndex = 69;
            cB_allCol.Text = "Tất cả cột";
            cB_allCol.UseVisualStyleBackColor = true;
            // 
            // Grant_R
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(739, 484);
            Controls.Add(cB_allCol);
            Controls.Add(cbB_Column);
            Controls.Add(cbB_Tables);
            Controls.Add(lb_Column);
            Controls.Add(bt_View);
            Controls.Add(bt_grant);
            Controls.Add(btn_Back);
            Controls.Add(dtGrid_role_table);
            Controls.Add(clb_Role);
            Controls.Add(tb_add);
            Controls.Add(lb_n_R);
            Controls.Add(tb_user);
            Controls.Add(lb_Name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Grant_R";
            Text = "Grant_R";
            ((System.ComponentModel.ISupportInitialize)dtGrid_role_table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_Column;
        private Button bt_View;
        private Button bt_grant;
        private Button btn_Back;
        private DataGridView dtGrid_role_table;
        private CheckedListBox clb_Role;
        private Label tb_add;
        private Label lb_n_R;
        private TextBox tb_user;
        private Label lb_Name;
        private ComboBox cbB_Tables;
        private ComboBox cbB_Column;
        private CheckBox cB_allCol;
    }
}