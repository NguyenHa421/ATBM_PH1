namespace ATBM_PhanHe1.Users_Roles
{
    partial class Revoke_U
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
            dtGrid_priv = new DataGridView();
            clb_privs = new CheckedListBox();
            tb_revoke = new Label();
            lb_n_R = new Label();
            tb_user = new TextBox();
            lb_Name = new Label();
            cbB_Tables = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtGrid_priv).BeginInit();
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
            bt_View.Location = new Point(613, 175);
            bt_View.Name = "bt_View";
            bt_View.Size = new Size(91, 38);
            bt_View.TabIndex = 40;
            bt_View.Text = "Xem";
            bt_View.UseVisualStyleBackColor = false;
            // 
            // bt_revoke
            // 
            bt_revoke.BackColor = Color.White;
            bt_revoke.BackgroundImage = Properties.Resources.button_round2;
            bt_revoke.FlatAppearance.BorderSize = 0;
            bt_revoke.FlatStyle = FlatStyle.Flat;
            bt_revoke.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bt_revoke.ForeColor = SystemColors.Window;
            bt_revoke.Location = new Point(613, 386);
            bt_revoke.Name = "bt_revoke";
            bt_revoke.Size = new Size(91, 38);
            bt_revoke.TabIndex = 38;
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
            btn_Back.Location = new Point(311, 386);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 37;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // dtGrid_priv
            // 
            dtGrid_priv.BackgroundColor = Color.WhiteSmoke;
            dtGrid_priv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_priv.Location = new Point(34, 66);
            dtGrid_priv.Name = "dtGrid_priv";
            dtGrid_priv.RowHeadersWidth = 51;
            dtGrid_priv.Size = new Size(271, 328);
            dtGrid_priv.TabIndex = 36;
            // 
            // clb_privs
            // 
            clb_privs.BackColor = Color.White;
            clb_privs.BorderStyle = BorderStyle.None;
            clb_privs.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clb_privs.FormattingEnabled = true;
            clb_privs.Items.AddRange(new object[] { "Select", "Insert", "Delete", "Update" });
            clb_privs.Location = new Point(476, 236);
            clb_privs.Name = "clb_privs";
            clb_privs.Size = new Size(150, 116);
            clb_privs.TabIndex = 35;
            // 
            // tb_revoke
            // 
            tb_revoke.AutoSize = true;
            tb_revoke.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_revoke.Location = new Point(311, 236);
            tb_revoke.Name = "tb_revoke";
            tb_revoke.Size = new Size(145, 28);
            tb_revoke.TabIndex = 34;
            tb_revoke.Text = "Thu hồi quyền";
            // 
            // lb_n_R
            // 
            lb_n_R.AutoSize = true;
            lb_n_R.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_n_R.Location = new Point(311, 125);
            lb_n_R.Name = "lb_n_R";
            lb_n_R.Size = new Size(96, 28);
            lb_n_R.TabIndex = 32;
            lb_n_R.Text = "Tên bảng";
            // 
            // tb_user
            // 
            tb_user.BorderStyle = BorderStyle.FixedSingle;
            tb_user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_user.Location = new Point(439, 64);
            tb_user.Name = "tb_user";
            tb_user.ReadOnly = true;
            tb_user.Size = new Size(265, 34);
            tb_user.TabIndex = 31;
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Name.Location = new Point(311, 66);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(89, 28);
            lb_Name.TabIndex = 30;
            lb_Name.Text = "Tên user";
            // 
            // cbB_Tables
            // 
            cbB_Tables.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_Tables.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_Tables.FormattingEnabled = true;
            cbB_Tables.Location = new Point(439, 122);
            cbB_Tables.Name = "cbB_Tables";
            cbB_Tables.Size = new Size(265, 36);
            cbB_Tables.TabIndex = 69;
            cbB_Tables.SelectedIndexChanged += cbB_Tables_SelectedIndexChanged;
            // 
            // Revoke_U
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(739, 484);
            Controls.Add(cbB_Tables);
            Controls.Add(bt_View);
            Controls.Add(bt_revoke);
            Controls.Add(btn_Back);
            Controls.Add(dtGrid_priv);
            Controls.Add(clb_privs);
            Controls.Add(tb_revoke);
            Controls.Add(lb_n_R);
            Controls.Add(tb_user);
            Controls.Add(lb_Name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Revoke_U";
            Text = "Revorke_U";
            ((System.ComponentModel.ISupportInitialize)dtGrid_priv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_View;
        private Button bt_revoke;
        private Button btn_Back;
        private DataGridView dtGrid_priv;
        private CheckedListBox clb_privs;
        private Label tb_revoke;
        private Label lb_n_R;
        private TextBox tb_user;
        private Label lb_Name;
        private ComboBox cbB_Tables;
    }
}