namespace ATBM_PhanHe1.Users_Roles
{
    partial class Grant_U
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
            cB_grant = new CheckBox();
            bt_grant = new Button();
            btn_Back = new Button();
            dtGrid_privs = new DataGridView();
            clb_Privs = new CheckedListBox();
            lb_n_R = new Label();
            tb_user = new TextBox();
            lb_Name = new Label();
            lb_Column = new Label();
            cbB_table = new ComboBox();
            cbB_column = new ComboBox();
            cB_allCol = new CheckBox();
            tb_add = new Label();
            bt_View = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGrid_privs).BeginInit();
            SuspendLayout();
            // 
            // cB_grant
            // 
            cB_grant.AutoSize = true;
            cB_grant.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cB_grant.Location = new Point(452, 134);
            cB_grant.Name = "cB_grant";
            cB_grant.Size = new Size(224, 32);
            cB_grant.TabIndex = 50;
            cB_grant.Text = "with GRANT OPTION";
            cB_grant.UseVisualStyleBackColor = true;
            // 
            // bt_grant
            // 
            bt_grant.BackColor = Color.White;
            bt_grant.BackgroundImage = Properties.Resources.button_round2;
            bt_grant.FlatAppearance.BorderSize = 0;
            bt_grant.FlatStyle = FlatStyle.Flat;
            bt_grant.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bt_grant.ForeColor = SystemColors.Window;
            bt_grant.Location = new Point(636, 434);
            bt_grant.Name = "bt_grant";
            bt_grant.Size = new Size(91, 38);
            bt_grant.TabIndex = 49;
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
            btn_Back.Location = new Point(17, 434);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 48;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // dtGrid_privs
            // 
            dtGrid_privs.BackgroundColor = Color.WhiteSmoke;
            dtGrid_privs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_privs.Location = new Point(12, 199);
            dtGrid_privs.Name = "dtGrid_privs";
            dtGrid_privs.RowHeadersWidth = 51;
            dtGrid_privs.Size = new Size(715, 229);
            dtGrid_privs.TabIndex = 47;
            // 
            // clb_Privs
            // 
            clb_Privs.BackColor = Color.White;
            clb_Privs.BorderStyle = BorderStyle.None;
            clb_Privs.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clb_Privs.FormattingEnabled = true;
            clb_Privs.Items.AddRange(new object[] { "Insert", "Delete", "Select", "Update" });
            clb_Privs.Location = new Point(577, 12);
            clb_Privs.Name = "clb_Privs";
            clb_Privs.Size = new Size(150, 116);
            clb_Privs.TabIndex = 46;
            // 
            // lb_n_R
            // 
            lb_n_R.AutoSize = true;
            lb_n_R.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_n_R.Location = new Point(12, 65);
            lb_n_R.Name = "lb_n_R";
            lb_n_R.Size = new Size(96, 28);
            lb_n_R.TabIndex = 43;
            lb_n_R.Text = "Tên bảng";
            // 
            // tb_user
            // 
            tb_user.BorderStyle = BorderStyle.FixedSingle;
            tb_user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_user.Location = new Point(140, 7);
            tb_user.Name = "tb_user";
            tb_user.ReadOnly = true;
            tb_user.Size = new Size(265, 34);
            tb_user.TabIndex = 42;
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Name.Location = new Point(12, 9);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(89, 28);
            lb_Name.TabIndex = 41;
            lb_Name.Text = "Tên user";
            // 
            // lb_Column
            // 
            lb_Column.AutoSize = true;
            lb_Column.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Column.Location = new Point(12, 122);
            lb_Column.Name = "lb_Column";
            lb_Column.Size = new Size(78, 28);
            lb_Column.TabIndex = 52;
            lb_Column.Text = "Tên cột";
            // 
            // cbB_table
            // 
            cbB_table.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_table.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbB_table.FormattingEnabled = true;
            cbB_table.Location = new Point(140, 62);
            cbB_table.Name = "cbB_table";
            cbB_table.Size = new Size(265, 36);
            cbB_table.TabIndex = 54;
            cbB_table.SelectedIndexChanged += cbB_table_SelectedIndexChanged;
            // 
            // cbB_column
            // 
            cbB_column.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_column.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbB_column.FormattingEnabled = true;
            cbB_column.Location = new Point(140, 119);
            cbB_column.Name = "cbB_column";
            cbB_column.Size = new Size(265, 36);
            cbB_column.TabIndex = 54;
            // 
            // cB_allCol
            // 
            cB_allCol.AutoSize = true;
            cB_allCol.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cB_allCol.Location = new Point(140, 161);
            cB_allCol.Name = "cB_allCol";
            cB_allCol.Size = new Size(121, 32);
            cB_allCol.TabIndex = 50;
            cB_allCol.Text = "Tất cả cột";
            cB_allCol.UseVisualStyleBackColor = true;
            cB_allCol.CheckedChanged += cB_allCol_CheckedChanged;
            // 
            // tb_add
            // 
            tb_add.AutoSize = true;
            tb_add.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_add.Location = new Point(452, 50);
            tb_add.Name = "tb_add";
            tb_add.Size = new Size(109, 28);
            tb_add.TabIndex = 59;
            tb_add.Text = "Cấp quyền";
            // 
            // bt_View
            // 
            bt_View.BackColor = Color.White;
            bt_View.BackgroundImage = Properties.Resources.button_round2;
            bt_View.FlatAppearance.BorderSize = 0;
            bt_View.FlatStyle = FlatStyle.Flat;
            bt_View.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bt_View.ForeColor = SystemColors.Window;
            bt_View.Location = new Point(523, 434);
            bt_View.Name = "bt_View";
            bt_View.Size = new Size(91, 38);
            bt_View.TabIndex = 65;
            bt_View.Text = "Tất cả";
            bt_View.UseVisualStyleBackColor = false;
            bt_View.Click += bt_View_Click;
            // 
            // Grant_U
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(739, 484);
            Controls.Add(bt_View);
            Controls.Add(tb_add);
            Controls.Add(cbB_column);
            Controls.Add(cbB_table);
            Controls.Add(lb_Column);
            Controls.Add(cB_allCol);
            Controls.Add(cB_grant);
            Controls.Add(bt_grant);
            Controls.Add(btn_Back);
            Controls.Add(dtGrid_privs);
            Controls.Add(clb_Privs);
            Controls.Add(lb_n_R);
            Controls.Add(tb_user);
            Controls.Add(lb_Name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Grant_U";
            Text = "Grant_U";
            ((System.ComponentModel.ISupportInitialize)dtGrid_privs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox cB_grant;
        private Button bt_grant;
        private Button btn_Back;
        private DataGridView dtGrid_privs;
        private CheckedListBox clb_Privs;
        private Label lb_n_R;
        private TextBox tb_user;
        private Label lb_Name;
        private Label lb_Column;
        private ComboBox cbB_table;
        private ComboBox cbB_column;
        private CheckBox cB_allCol;
        private Label tb_add;
        private Button bt_View;
    }
}