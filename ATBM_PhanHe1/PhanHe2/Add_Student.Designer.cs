namespace ATBM_PhanHe1.PhanHe2
{
    partial class Add_Student
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
            btn_Add = new Button();
            btn_Back = new Button();
            tb_birth = new DateTimePicker();
            cbB_program = new ComboBox();
            cbB_major = new ComboBox();
            cbB_gender = new ComboBox();
            SuspendLayout();
            // 
            // tb_role
            // 
            tb_role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_role.Location = new Point(626, 149);
            tb_role.Name = "tb_role";
            tb_role.Size = new Size(229, 34);
            tb_role.TabIndex = 60;
            tb_role.TabStop = false;
            // 
            // tb_phone
            // 
            tb_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_phone.Location = new Point(626, 80);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(229, 34);
            tb_phone.TabIndex = 59;
            tb_phone.TabStop = false;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(183, 149);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(229, 34);
            tb_name.TabIndex = 56;
            tb_name.TabStop = false;
            // 
            // tb_id
            // 
            tb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_id.Location = new Point(183, 80);
            tb_id.Name = "tb_id";
            tb_id.ReadOnly = true;
            tb_id.Size = new Size(229, 34);
            tb_id.TabIndex = 55;
            tb_id.TabStop = false;
            // 
            // lb_major
            // 
            lb_major.AutoSize = true;
            lb_major.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_major.Location = new Point(492, 294);
            lb_major.Name = "lb_major";
            lb_major.Size = new Size(108, 28);
            lb_major.TabIndex = 53;
            lb_major.Text = "Ngành học";
            // 
            // lb_address
            // 
            lb_address.AutoSize = true;
            lb_address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_address.Location = new Point(492, 152);
            lb_address.Name = "lb_address";
            lb_address.Size = new Size(71, 28);
            lb_address.TabIndex = 52;
            lb_address.Text = "Địa chỉ";
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_phone.Location = new Point(492, 83);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new Size(128, 28);
            lb_phone.TabIndex = 51;
            lb_phone.Text = "Số điện thoại";
            // 
            // lb_program
            // 
            lb_program.AutoSize = true;
            lb_program.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_program.Location = new Point(492, 222);
            lb_program.Name = "lb_program";
            lb_program.Size = new Size(128, 28);
            lb_program.TabIndex = 50;
            lb_program.Text = "Chương trình";
            // 
            // lb_birth
            // 
            lb_birth.AutoSize = true;
            lb_birth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_birth.Location = new Point(40, 294);
            lb_birth.Name = "lb_birth";
            lb_birth.Size = new Size(99, 28);
            lb_birth.TabIndex = 49;
            lb_birth.Text = "Ngày sinh";
            // 
            // lb_gender
            // 
            lb_gender.AutoSize = true;
            lb_gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_gender.Location = new Point(40, 222);
            lb_gender.Name = "lb_gender";
            lb_gender.Size = new Size(49, 28);
            lb_gender.TabIndex = 48;
            lb_gender.Text = "Phái";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(40, 152);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(96, 28);
            lb_name.TabIndex = 47;
            lb_name.Text = "Họ và tên";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_id.Location = new Point(40, 83);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(121, 28);
            lb_id.TabIndex = 46;
            lb_id.Text = "Mã sinh viên";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(366, 9);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(169, 31);
            lb_Info.TabIndex = 45;
            lb_Info.Text = "Thêm sinh viên";
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.White;
            btn_Add.BackgroundImage = Properties.Resources.button_round2;
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Add.ForeColor = SystemColors.Window;
            btn_Add.Location = new Point(472, 362);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(91, 38);
            btn_Add.TabIndex = 64;
            btn_Add.Text = "Tạo mới";
            btn_Add.UseVisualStyleBackColor = false;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round2;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(351, 362);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 63;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // tb_birth
            // 
            tb_birth.CustomFormat = "dd/MM/yyyy";
            tb_birth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_birth.Format = DateTimePickerFormat.Custom;
            tb_birth.Location = new Point(183, 289);
            tb_birth.MaxDate = new DateTime(2024, 5, 31, 0, 0, 0, 0);
            tb_birth.MinDate = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            tb_birth.Name = "tb_birth";
            tb_birth.Size = new Size(229, 34);
            tb_birth.TabIndex = 65;
            tb_birth.Value = new DateTime(2024, 5, 31, 0, 0, 0, 0);
            // 
            // cbB_program
            // 
            cbB_program.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_program.FormattingEnabled = true;
            cbB_program.Location = new Point(626, 219);
            cbB_program.Name = "cbB_program";
            cbB_program.Size = new Size(229, 36);
            cbB_program.TabIndex = 67;
            // 
            // cbB_major
            // 
            cbB_major.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_major.FormattingEnabled = true;
            cbB_major.Location = new Point(626, 291);
            cbB_major.Name = "cbB_major";
            cbB_major.Size = new Size(229, 36);
            cbB_major.TabIndex = 68;
            // 
            // cbB_gender
            // 
            cbB_gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_gender.FormattingEnabled = true;
            cbB_gender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbB_gender.Location = new Point(183, 219);
            cbB_gender.Name = "cbB_gender";
            cbB_gender.Size = new Size(229, 36);
            cbB_gender.TabIndex = 69;
            // 
            // Add_Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(cbB_gender);
            Controls.Add(cbB_major);
            Controls.Add(cbB_program);
            Controls.Add(tb_birth);
            Controls.Add(btn_Add);
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
            Name = "Add_Student";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add_Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button btn_Add;
        private Button btn_Back;
        private DateTimePicker tb_birth;
        private ComboBox tb_gender;
        private ComboBox cbB_program;
        private ComboBox cbB_major;
        private ComboBox cbB_gender;
    }
}