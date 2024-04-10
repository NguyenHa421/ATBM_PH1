namespace ATBM_PhanHe1.Users_Roles
{
    partial class Grant_U_R
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
            dtGrid_UserRole = new DataGridView();
            lb_n_R = new Label();
            tb_user = new TextBox();
            lb_Name = new Label();
            btn_grant = new Button();
            cbB_listRole = new ComboBox();
            cB_grant = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dtGrid_UserRole).BeginInit();
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
            bt_View.Location = new Point(613, 171);
            bt_View.Name = "bt_View";
            bt_View.Size = new Size(91, 38);
            bt_View.TabIndex = 51;
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
            bt_revoke.Location = new Point(467, 340);
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
            btn_Back.Location = new Point(311, 340);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 48;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // dtGrid_UserRole
            // 
            dtGrid_UserRole.BackgroundColor = Color.WhiteSmoke;
            dtGrid_UserRole.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_UserRole.Location = new Point(34, 107);
            dtGrid_UserRole.Name = "dtGrid_UserRole";
            dtGrid_UserRole.RowHeadersWidth = 51;
            dtGrid_UserRole.Size = new Size(271, 225);
            dtGrid_UserRole.TabIndex = 47;
            // 
            // lb_n_R
            // 
            lb_n_R.AutoSize = true;
            lb_n_R.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_n_R.Location = new Point(311, 240);
            lb_n_R.Name = "lb_n_R";
            lb_n_R.Size = new Size(85, 28);
            lb_n_R.TabIndex = 43;
            lb_n_R.Text = "Tên role";
            // 
            // tb_user
            // 
            tb_user.BorderStyle = BorderStyle.FixedSingle;
            tb_user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_user.Location = new Point(439, 105);
            tb_user.Name = "tb_user";
            tb_user.ReadOnly = true;
            tb_user.Size = new Size(265, 34);
            tb_user.TabIndex = 42;
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Name.Location = new Point(311, 107);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(89, 28);
            lb_Name.TabIndex = 41;
            lb_Name.Text = "Tên user";
            // 
            // btn_grant
            // 
            btn_grant.BackColor = Color.White;
            btn_grant.BackgroundImage = Properties.Resources.button_round2;
            btn_grant.FlatAppearance.BorderSize = 0;
            btn_grant.FlatStyle = FlatStyle.Flat;
            btn_grant.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_grant.ForeColor = SystemColors.Window;
            btn_grant.Location = new Point(613, 340);
            btn_grant.Name = "btn_grant";
            btn_grant.Size = new Size(91, 38);
            btn_grant.TabIndex = 52;
            btn_grant.Text = "Cấp role";
            btn_grant.UseVisualStyleBackColor = false;
            btn_grant.Click += btn_grant_Click;
            // 
            // cbB_listRole
            // 
            cbB_listRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_listRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_listRole.FormattingEnabled = true;
            cbB_listRole.Location = new Point(439, 237);
            cbB_listRole.Name = "cbB_listRole";
            cbB_listRole.Size = new Size(265, 36);
            cbB_listRole.TabIndex = 53;
            // 
            // cB_grant
            // 
            cB_grant.AutoSize = true;
            cB_grant.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cB_grant.Location = new Point(480, 290);
            cB_grant.Name = "cB_grant";
            cB_grant.Size = new Size(225, 32);
            cB_grant.TabIndex = 54;
            cB_grant.Text = "with ADMIN OPTION";
            cB_grant.UseVisualStyleBackColor = true;
            // 
            // Grant_U_R
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(739, 484);
            Controls.Add(cB_grant);
            Controls.Add(cbB_listRole);
            Controls.Add(btn_grant);
            Controls.Add(bt_View);
            Controls.Add(bt_revoke);
            Controls.Add(btn_Back);
            Controls.Add(dtGrid_UserRole);
            Controls.Add(lb_n_R);
            Controls.Add(tb_user);
            Controls.Add(lb_Name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Grant_U_R";
            Text = "Grant_U_R";
            ((System.ComponentModel.ISupportInitialize)dtGrid_UserRole).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_View;
        private Button bt_revoke;
        private Button btn_Back;
        private DataGridView dtGrid_UserRole;
        private Label lb_n_R;
        private TextBox tb_user;
        private Label lb_Name;
        private Button btn_grant;
        private ComboBox cbB_listRole;
        private CheckBox cB_grant;
    }
}