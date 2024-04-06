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
            cB_grant = new CheckBox();
            bt_revoke = new Button();
            btn_Back = new Button();
            dataGridView1 = new DataGridView();
            clb_Role = new CheckedListBox();
            tb_add = new Label();
            lb_n_R = new Label();
            tb_user = new TextBox();
            lb_Name = new Label();
            cbB_Tables = new ComboBox();
            cbB_Column = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lb_Column
            // 
            lb_Column.AutoSize = true;
            lb_Column.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Column.Location = new Point(311, 352);
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
            // 
            // cB_grant
            // 
            cB_grant.AutoSize = true;
            cB_grant.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cB_grant.Location = new Point(476, 311);
            cB_grant.Name = "cB_grant";
            cB_grant.Size = new Size(224, 32);
            cB_grant.TabIndex = 63;
            cB_grant.Text = "with GRANT OPTION";
            cB_grant.UseVisualStyleBackColor = true;
            // 
            // bt_revoke
            // 
            bt_revoke.BackColor = Color.White;
            bt_revoke.BackgroundImage = Properties.Resources.button_round2;
            bt_revoke.FlatAppearance.BorderSize = 0;
            bt_revoke.FlatStyle = FlatStyle.Flat;
            bt_revoke.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bt_revoke.ForeColor = SystemColors.Window;
            bt_revoke.Location = new Point(613, 412);
            bt_revoke.Name = "bt_revoke";
            bt_revoke.Size = new Size(91, 38);
            bt_revoke.TabIndex = 62;
            bt_revoke.Text = "Thu hồi";
            bt_revoke.UseVisualStyleBackColor = false;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round2;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(311, 412);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 61;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(271, 347);
            dataGridView1.TabIndex = 60;
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
            cbB_Column.Location = new Point(439, 349);
            cbB_Column.Name = "cbB_Column";
            cbB_Column.Size = new Size(265, 36);
            cbB_Column.TabIndex = 68;
            // 
            // Grant_R
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(739, 484);
            Controls.Add(cbB_Column);
            Controls.Add(cbB_Tables);
            Controls.Add(lb_Column);
            Controls.Add(bt_View);
            Controls.Add(cB_grant);
            Controls.Add(bt_revoke);
            Controls.Add(btn_Back);
            Controls.Add(dataGridView1);
            Controls.Add(clb_Role);
            Controls.Add(tb_add);
            Controls.Add(lb_n_R);
            Controls.Add(tb_user);
            Controls.Add(lb_Name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Grant_R";
            Text = "Grant_R";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_Column;
        private Button bt_View;
        private CheckBox cB_grant;
        private Button bt_revoke;
        private Button btn_Back;
        private DataGridView dataGridView1;
        private CheckedListBox clb_Role;
        private Label tb_add;
        private Label lb_n_R;
        private TextBox tb_user;
        private Label lb_Name;
        private ComboBox cbB_Tables;
        private ComboBox cbB_Column;
    }
}