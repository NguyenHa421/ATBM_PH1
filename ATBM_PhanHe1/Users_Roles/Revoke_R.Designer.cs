namespace ATBM_PhanHe1.Users_Roles
{
    partial class Revoke_R
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
            bt_View = new Button();
            bt_revoke = new Button();
            btn_Back = new Button();
            dtGrid_role_table = new DataGridView();
            clb_Role = new CheckedListBox();
            tb_revoke = new Label();
            lb_n_R = new Label();
            tb_user = new TextBox();
            lb_Name = new Label();
            cbB_Tables = new ComboBox();
            bt_viewall = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGrid_role_table).BeginInit();
            SuspendLayout();
            // 
            // bt_View
            // 
            bt_View.BackColor = Color.White;
            bt_View.BackgroundImage = Properties.Resources.button_round2;
            bt_View.FlatAppearance.BorderSize = 0;
            bt_View.FlatStyle = FlatStyle.Flat;
            bt_View.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bt_View.ForeColor = SystemColors.Window;
            bt_View.Location = new Point(636, 129);
            bt_View.Name = "bt_View";
            bt_View.Size = new Size(91, 38);
            bt_View.TabIndex = 50;
            bt_View.Text = "Xem";
            bt_View.UseVisualStyleBackColor = false;
            bt_View.Click += bt_View_Click;
            // 
            // bt_revoke
            // 
            bt_revoke.BackColor = Color.White;
            bt_revoke.BackgroundImage = Properties.Resources.button_round2;
            bt_revoke.FlatAppearance.BorderSize = 0;
            bt_revoke.FlatStyle = FlatStyle.Flat;
            bt_revoke.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bt_revoke.ForeColor = SystemColors.Window;
            bt_revoke.Location = new Point(636, 439);
            bt_revoke.Name = "bt_revoke";
            bt_revoke.Size = new Size(91, 38);
            bt_revoke.TabIndex = 49;
            bt_revoke.Text = "Thu hồi";
            bt_revoke.UseVisualStyleBackColor = false;
            bt_revoke.Click += bt_revoke_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round2;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(12, 439);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 48;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // dtGrid_role_table
            // 
            dtGrid_role_table.BackgroundColor = Color.WhiteSmoke;
            dtGrid_role_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_role_table.Location = new Point(12, 173);
            dtGrid_role_table.Name = "dtGrid_role_table";
            dtGrid_role_table.RowHeadersWidth = 51;
            dtGrid_role_table.Size = new Size(715, 260);
            dtGrid_role_table.TabIndex = 47;
            // 
            // clb_Role
            // 
            clb_Role.BackColor = Color.White;
            clb_Role.BorderStyle = BorderStyle.None;
            clb_Role.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clb_Role.FormattingEnabled = true;
            clb_Role.Items.AddRange(new object[] { "Select", "Insert", "Delete", "Update" });
            clb_Role.Location = new Point(577, 7);
            clb_Role.Name = "clb_Role";
            clb_Role.Size = new Size(150, 116);
            clb_Role.TabIndex = 46;
            // 
            // tb_revoke
            // 
            tb_revoke.AutoSize = true;
            tb_revoke.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_revoke.Location = new Point(426, 52);
            tb_revoke.Name = "tb_revoke";
            tb_revoke.Size = new Size(145, 28);
            tb_revoke.TabIndex = 45;
            tb_revoke.Text = "Thu hồi quyền";
            // 
            // lb_n_R
            // 
            lb_n_R.AutoSize = true;
            lb_n_R.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_n_R.Location = new Point(12, 85);
            lb_n_R.Name = "lb_n_R";
            lb_n_R.Size = new Size(96, 28);
            lb_n_R.TabIndex = 43;
            lb_n_R.Text = "Tên bảng";
            // 
            // tb_user
            // 
            tb_user.BorderStyle = BorderStyle.FixedSingle;
            tb_user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_user.Location = new Point(140, 24);
            tb_user.Name = "tb_user";
            tb_user.ReadOnly = true;
            tb_user.Size = new Size(265, 34);
            tb_user.TabIndex = 42;
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Name.Location = new Point(12, 26);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(85, 28);
            lb_Name.TabIndex = 41;
            lb_Name.Text = "Tên role";
            // 
            // cbB_Tables
            // 
            cbB_Tables.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_Tables.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_Tables.FormattingEnabled = true;
            cbB_Tables.Location = new Point(140, 82);
            cbB_Tables.Name = "cbB_Tables";
            cbB_Tables.Size = new Size(265, 36);
            cbB_Tables.TabIndex = 68;
            // 
            // bt_viewall
            // 
            bt_viewall.BackColor = Color.White;
            bt_viewall.BackgroundImage = Properties.Resources.button_round2;
            bt_viewall.FlatAppearance.BorderSize = 0;
            bt_viewall.FlatStyle = FlatStyle.Flat;
            bt_viewall.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bt_viewall.ForeColor = SystemColors.Window;
            bt_viewall.Location = new Point(529, 439);
            bt_viewall.Name = "bt_viewall";
            bt_viewall.Size = new Size(91, 38);
            bt_viewall.TabIndex = 71;
            bt_viewall.Text = "Tất cả";
            bt_viewall.UseVisualStyleBackColor = false;
            bt_viewall.Click += bt_viewall_Click;
            // 
            // Revoke_R
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(739, 484);
            Controls.Add(bt_viewall);
            Controls.Add(cbB_Tables);
            Controls.Add(bt_View);
            Controls.Add(bt_revoke);
            Controls.Add(btn_Back);
            Controls.Add(dtGrid_role_table);
            Controls.Add(clb_Role);
            Controls.Add(tb_revoke);
            Controls.Add(lb_n_R);
            Controls.Add(tb_user);
            Controls.Add(lb_Name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Revoke_R";
            Text = "Revorke_R";
            ((System.ComponentModel.ISupportInitialize)dtGrid_role_table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_View;
        private Button bt_revoke;
        private Button btn_Back;
        private DataGridView dtGrid_role_table;
        private CheckedListBox clb_Role;
        private Label tb_revoke;
        private Label lb_n_R;
        private TextBox tb_user;
        private Label lb_Name;
        private ComboBox cbB_Tables;
        private Button bt_viewall;
    }
}