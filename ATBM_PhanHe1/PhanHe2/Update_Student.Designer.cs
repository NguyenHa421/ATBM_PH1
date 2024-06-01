namespace ATBM_PhanHe1.PhanHe2
{
    partial class Update_Student
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
            cbB_major = new ComboBox();
            cbB_program = new ComboBox();
            tb_birth = new DateTimePicker();
            btn_Update = new Button();
            btn_Back = new Button();
            tb_role = new TextBox();
            tb_phone = new TextBox();
            tb_name = new TextBox();
            tb_id = new TextBox();
            lb_major = new Label();
            lb_address = new Label();
            lb_phone = new Label();
            lb_program = new Label();
            lb_birth = new Label();
            lb_gender = new Label();
            lb_name = new Label();
            lb_id = new Label();
            lb_Info = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            tb_name_unit = new TextBox();
            lb_number_credits = new Label();
            SuspendLayout();
            // 
            // cbB_gender
            // 
            cbB_gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_gender.FormattingEnabled = true;
            cbB_gender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbB_gender.Location = new Point(183, 192);
            cbB_gender.Name = "cbB_gender";
            cbB_gender.Size = new Size(229, 36);
            cbB_gender.TabIndex = 88;
            // 
            // cbB_major
            // 
            cbB_major.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_major.FormattingEnabled = true;
            cbB_major.Location = new Point(626, 192);
            cbB_major.Name = "cbB_major";
            cbB_major.Size = new Size(229, 36);
            cbB_major.TabIndex = 87;
            // 
            // cbB_program
            // 
            cbB_program.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_program.FormattingEnabled = true;
            cbB_program.Location = new Point(626, 135);
            cbB_program.Name = "cbB_program";
            cbB_program.Size = new Size(229, 36);
            cbB_program.TabIndex = 86;
            // 
            // tb_birth
            // 
            tb_birth.CustomFormat = "dd/MM/yyyy";
            tb_birth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_birth.Format = DateTimePickerFormat.Custom;
            tb_birth.Location = new Point(183, 252);
            tb_birth.MaxDate = new DateTime(2024, 5, 31, 0, 0, 0, 0);
            tb_birth.MinDate = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            tb_birth.Name = "tb_birth";
            tb_birth.Size = new Size(229, 34);
            tb_birth.TabIndex = 85;
            tb_birth.Value = new DateTime(2024, 5, 31, 0, 0, 0, 0);
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.White;
            btn_Update.BackgroundImage = Properties.Resources.button_round2;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Update.ForeColor = SystemColors.Window;
            btn_Update.Location = new Point(472, 370);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(91, 38);
            btn_Update.TabIndex = 84;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = false;
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
            // tb_role
            // 
            tb_role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_role.Location = new Point(626, 82);
            tb_role.Name = "tb_role";
            tb_role.Size = new Size(229, 34);
            tb_role.TabIndex = 82;
            tb_role.TabStop = false;
            // 
            // tb_phone
            // 
            tb_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_phone.Location = new Point(183, 309);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(229, 34);
            tb_phone.TabIndex = 81;
            tb_phone.TabStop = false;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(183, 135);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(229, 34);
            tb_name.TabIndex = 80;
            tb_name.TabStop = false;
            // 
            // tb_id
            // 
            tb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_id.Location = new Point(183, 82);
            tb_id.Name = "tb_id";
            tb_id.ReadOnly = true;
            tb_id.Size = new Size(229, 34);
            tb_id.TabIndex = 79;
            tb_id.TabStop = false;
            // 
            // lb_major
            // 
            lb_major.AutoSize = true;
            lb_major.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_major.Location = new Point(492, 195);
            lb_major.Name = "lb_major";
            lb_major.Size = new Size(108, 28);
            lb_major.TabIndex = 78;
            lb_major.Text = "Ngành học";
            // 
            // lb_address
            // 
            lb_address.AutoSize = true;
            lb_address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_address.Location = new Point(492, 85);
            lb_address.Name = "lb_address";
            lb_address.Size = new Size(71, 28);
            lb_address.TabIndex = 77;
            lb_address.Text = "Địa chỉ";
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_phone.Location = new Point(40, 312);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new Size(128, 28);
            lb_phone.TabIndex = 76;
            lb_phone.Text = "Số điện thoại";
            lb_phone.Click += lb_phone_Click;
            // 
            // lb_program
            // 
            lb_program.AutoSize = true;
            lb_program.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_program.Location = new Point(492, 138);
            lb_program.Name = "lb_program";
            lb_program.Size = new Size(128, 28);
            lb_program.TabIndex = 75;
            lb_program.Text = "Chương trình";
            // 
            // lb_birth
            // 
            lb_birth.AutoSize = true;
            lb_birth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_birth.Location = new Point(40, 257);
            lb_birth.Name = "lb_birth";
            lb_birth.Size = new Size(99, 28);
            lb_birth.TabIndex = 74;
            lb_birth.Text = "Ngày sinh";
            // 
            // lb_gender
            // 
            lb_gender.AutoSize = true;
            lb_gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_gender.Location = new Point(40, 195);
            lb_gender.Name = "lb_gender";
            lb_gender.Size = new Size(49, 28);
            lb_gender.TabIndex = 73;
            lb_gender.Text = "Phái";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(40, 138);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(96, 28);
            lb_name.TabIndex = 72;
            lb_name.Text = "Họ và tên";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_id.Location = new Point(40, 85);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(121, 28);
            lb_id.TabIndex = 71;
            lb_id.Text = "Mã sinh viên";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(366, 17);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(203, 31);
            lb_Info.TabIndex = 70;
            lb_Info.Text = "Cập nhật sinh viên";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(749, 306);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 34);
            textBox1.TabIndex = 92;
            textBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(492, 312);
            label1.Name = "label1";
            label1.Size = new Size(223, 28);
            label1.TabIndex = 91;
            label1.Text = "Điểm trung bình tích lũy";
            // 
            // tb_name_unit
            // 
            tb_name_unit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name_unit.Location = new Point(749, 254);
            tb_name_unit.Name = "tb_name_unit";
            tb_name_unit.Size = new Size(106, 34);
            tb_name_unit.TabIndex = 90;
            tb_name_unit.TabStop = false;
            // 
            // lb_number_credits
            // 
            lb_number_credits.AutoSize = true;
            lb_number_credits.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_number_credits.Location = new Point(492, 257);
            lb_number_credits.Name = "lb_number_credits";
            lb_number_credits.Size = new Size(161, 28);
            lb_number_credits.TabIndex = 89;
            lb_number_credits.Text = "Số tín chỉ tích lũy";
            // 
            // Update_Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(tb_name_unit);
            Controls.Add(lb_number_credits);
            Controls.Add(cbB_gender);
            Controls.Add(cbB_major);
            Controls.Add(cbB_program);
            Controls.Add(tb_birth);
            Controls.Add(btn_Update);
            Controls.Add(btn_Back);
            Controls.Add(tb_role);
            Controls.Add(tb_phone);
            Controls.Add(tb_name);
            Controls.Add(tb_id);
            Controls.Add(lb_major);
            Controls.Add(lb_address);
            Controls.Add(lb_phone);
            Controls.Add(lb_program);
            Controls.Add(lb_birth);
            Controls.Add(lb_gender);
            Controls.Add(lb_name);
            Controls.Add(lb_id);
            Controls.Add(lb_Info);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Update_Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update_Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbB_gender;
        private ComboBox cbB_major;
        private ComboBox cbB_program;
        private DateTimePicker tb_birth;
        private Button btn_Update;
        private Button btn_Back;
        private TextBox tb_role;
        private TextBox tb_phone;
        private TextBox tb_name;
        private TextBox tb_id;
        private Label lb_major;
        private Label lb_address;
        private Label lb_phone;
        private Label lb_program;
        private Label lb_birth;
        private Label lb_gender;
        private Label lb_name;
        private Label lb_id;
        private Label lb_Info;
        private TextBox textBox1;
        private Label label1;
        private TextBox tb_name_unit;
        private Label lb_number_credits;
    }
}