namespace ATBM_PhanHe1.PhanHe2
{
    partial class Add_Personnel
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
            cbB_gender = new ComboBox();
            cbB_unit = new ComboBox();
            cbB_role = new ComboBox();
            tb_birth = new DateTimePicker();
            btn_Add = new Button();
            btn_Back = new Button();
            tb_allowance = new TextBox();
            tb_phone = new TextBox();
            tb_name = new TextBox();
            tb_id = new TextBox();
            lb_unit = new Label();
            lb_allowance = new Label();
            lb_phone = new Label();
            lb_role = new Label();
            lb_birth = new Label();
            lb_gender = new Label();
            lb_name = new Label();
            lb_id = new Label();
            lb_Info = new Label();
            SuspendLayout();
            // 
            // cbB_gender
            // 
            cbB_gender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_gender.FormattingEnabled = true;
            cbB_gender.Items.AddRange(new object[] { "Male", "Female" });
            cbB_gender.Location = new Point(183, 227);
            cbB_gender.Name = "cbB_gender";
            cbB_gender.Size = new Size(229, 36);
            cbB_gender.TabIndex = 88;
            // 
            // cbB_unit
            // 
            cbB_unit.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_unit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_unit.FormattingEnabled = true;
            cbB_unit.Location = new Point(626, 299);
            cbB_unit.Name = "cbB_unit";
            cbB_unit.Size = new Size(229, 36);
            cbB_unit.TabIndex = 87;
            // 
            // cbB_role
            // 
            cbB_role.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_role.FormattingEnabled = true;
            cbB_role.Items.AddRange(new object[] { "Nhan vien co ban", "Giang vien", "Giao vu" });
            cbB_role.Location = new Point(626, 227);
            cbB_role.Name = "cbB_role";
            cbB_role.Size = new Size(229, 36);
            cbB_role.TabIndex = 86;
            // 
            // tb_birth
            // 
            tb_birth.CustomFormat = "dd/MM/yyyy";
            tb_birth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_birth.Format = DateTimePickerFormat.Custom;
            tb_birth.Location = new Point(183, 297);
            tb_birth.MaxDate = new DateTime(2024, 5, 31, 0, 0, 0, 0);
            tb_birth.MinDate = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            tb_birth.Name = "tb_birth";
            tb_birth.Size = new Size(229, 34);
            tb_birth.TabIndex = 85;
            tb_birth.Value = new DateTime(2024, 5, 31, 0, 0, 0, 0);
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.White;
            btn_Add.BackgroundImage = Properties.Resources.button_round2;
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Add.ForeColor = SystemColors.Window;
            btn_Add.Location = new Point(472, 370);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(91, 38);
            btn_Add.TabIndex = 84;
            btn_Add.Text = "Tạo mới";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round2;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(351, 370);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 83;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // tb_allowance
            // 
            tb_allowance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_allowance.Location = new Point(626, 157);
            tb_allowance.Name = "tb_allowance";
            tb_allowance.Size = new Size(229, 34);
            tb_allowance.TabIndex = 82;
            tb_allowance.TabStop = false;
            // 
            // tb_phone
            // 
            tb_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_phone.Location = new Point(626, 88);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(229, 34);
            tb_phone.TabIndex = 81;
            tb_phone.TabStop = false;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(183, 157);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(229, 34);
            tb_name.TabIndex = 80;
            tb_name.TabStop = false;
            // 
            // tb_id
            // 
            tb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_id.Location = new Point(183, 88);
            tb_id.Name = "tb_id";
            tb_id.ReadOnly = true;
            tb_id.Size = new Size(229, 34);
            tb_id.TabIndex = 79;
            tb_id.TabStop = false;
            // 
            // lb_unit
            // 
            lb_unit.AutoSize = true;
            lb_unit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_unit.Location = new Point(492, 302);
            lb_unit.Name = "lb_unit";
            lb_unit.Size = new Size(69, 28);
            lb_unit.TabIndex = 78;
            lb_unit.Text = "Đơn vị";
            // 
            // lb_allowance
            // 
            lb_allowance.AutoSize = true;
            lb_allowance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_allowance.Location = new Point(492, 160);
            lb_allowance.Name = "lb_allowance";
            lb_allowance.Size = new Size(81, 28);
            lb_allowance.TabIndex = 77;
            lb_allowance.Text = "Phụ cấp";
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_phone.Location = new Point(492, 91);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new Size(128, 28);
            lb_phone.TabIndex = 76;
            lb_phone.Text = "Số điện thoại";
            // 
            // lb_role
            // 
            lb_role.AutoSize = true;
            lb_role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_role.Location = new Point(492, 230);
            lb_role.Name = "lb_role";
            lb_role.Size = new Size(69, 28);
            lb_role.TabIndex = 75;
            lb_role.Text = "Vai trò";
            // 
            // lb_birth
            // 
            lb_birth.AutoSize = true;
            lb_birth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_birth.Location = new Point(40, 302);
            lb_birth.Name = "lb_birth";
            lb_birth.Size = new Size(99, 28);
            lb_birth.TabIndex = 74;
            lb_birth.Text = "Ngày sinh";
            // 
            // lb_gender
            // 
            lb_gender.AutoSize = true;
            lb_gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_gender.Location = new Point(40, 230);
            lb_gender.Name = "lb_gender";
            lb_gender.Size = new Size(49, 28);
            lb_gender.TabIndex = 73;
            lb_gender.Text = "Phái";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(40, 160);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(96, 28);
            lb_name.TabIndex = 72;
            lb_name.Text = "Họ và tên";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_id.Location = new Point(40, 91);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(113, 28);
            lb_id.TabIndex = 71;
            lb_id.Text = "Mã nhân sự";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(366, 17);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(159, 31);
            lb_Info.TabIndex = 70;
            lb_Info.Text = "Thêm nhân sự";
            // 
            // Add_Personnel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(cbB_gender);
            Controls.Add(cbB_unit);
            Controls.Add(cbB_role);
            Controls.Add(tb_birth);
            Controls.Add(btn_Add);
            Controls.Add(btn_Back);
            Controls.Add(tb_allowance);
            Controls.Add(tb_phone);
            Controls.Add(tb_name);
            Controls.Add(tb_id);
            Controls.Add(lb_unit);
            Controls.Add(lb_allowance);
            Controls.Add(lb_phone);
            Controls.Add(lb_role);
            Controls.Add(lb_birth);
            Controls.Add(lb_gender);
            Controls.Add(lb_name);
            Controls.Add(lb_id);
            Controls.Add(lb_Info);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Add_Personnel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Personnel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbB_gender;
        private ComboBox cbB_unit;
        private ComboBox cbB_role;
        private DateTimePicker tb_birth;
        private Button btn_Add;
        private Button btn_Back;
        private TextBox tb_allowance;
        private TextBox tb_phone;
        private TextBox tb_name;
        private TextBox tb_id;
        private Label lb_unit;
        private Label lb_allowance;
        private Label lb_phone;
        private Label lb_role;
        private Label lb_birth;
        private Label lb_gender;
        private Label lb_name;
        private Label lb_id;
        private Label lb_Info;
    }
}