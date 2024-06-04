namespace ATBM_PhanHe1.PhanHe2
{
    partial class Update_Courses
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
            tb_practice = new TextBox();
            tb_credit = new TextBox();
            tb_maxstudent = new TextBox();
            cbB_unit = new ComboBox();
            cbB_idunit = new ComboBox();
            btn_Back = new Button();
            tb_theory = new TextBox();
            tb_name = new TextBox();
            tb_id = new TextBox();
            lb_unit = new Label();
            lb_practice = new Label();
            lb_theory = new Label();
            lb_idunit = new Label();
            lb_maxstudent = new Label();
            lb_credit = new Label();
            lb_name = new Label();
            lb_id = new Label();
            lb_Info = new Label();
            btn_Update = new Button();
            SuspendLayout();
            // 
            // tb_practice
            // 
            tb_practice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_practice.Location = new Point(662, 157);
            tb_practice.Name = "tb_practice";
            tb_practice.Size = new Size(185, 34);
            tb_practice.TabIndex = 109;
            tb_practice.TabStop = false;
            // 
            // tb_credit
            // 
            tb_credit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_credit.Location = new Point(662, 225);
            tb_credit.Name = "tb_credit";
            tb_credit.Size = new Size(185, 34);
            tb_credit.TabIndex = 108;
            tb_credit.TabStop = false;
            // 
            // tb_maxstudent
            // 
            tb_maxstudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_maxstudent.Location = new Point(662, 297);
            tb_maxstudent.Name = "tb_maxstudent";
            tb_maxstudent.Size = new Size(185, 34);
            tb_maxstudent.TabIndex = 107;
            tb_maxstudent.TabStop = false;
            // 
            // cbB_unit
            // 
            cbB_unit.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_unit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_unit.FormattingEnabled = true;
            cbB_unit.Location = new Point(191, 297);
            cbB_unit.Name = "cbB_unit";
            cbB_unit.Size = new Size(229, 36);
            cbB_unit.TabIndex = 106;
            // 
            // cbB_idunit
            // 
            cbB_idunit.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_idunit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_idunit.FormattingEnabled = true;
            cbB_idunit.Location = new Point(191, 225);
            cbB_idunit.Name = "cbB_idunit";
            cbB_idunit.Size = new Size(229, 36);
            cbB_idunit.TabIndex = 105;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round2;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(359, 370);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 103;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // tb_theory
            // 
            tb_theory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_theory.Location = new Point(662, 88);
            tb_theory.Name = "tb_theory";
            tb_theory.Size = new Size(185, 34);
            tb_theory.TabIndex = 102;
            tb_theory.TabStop = false;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(191, 157);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(229, 34);
            tb_name.TabIndex = 101;
            tb_name.TabStop = false;
            // 
            // tb_id
            // 
            tb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_id.Location = new Point(191, 88);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(229, 34);
            tb_id.TabIndex = 100;
            tb_id.TabStop = false;
            // 
            // lb_unit
            // 
            lb_unit.AutoSize = true;
            lb_unit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_unit.Location = new Point(57, 300);
            lb_unit.Name = "lb_unit";
            lb_unit.Size = new Size(69, 28);
            lb_unit.TabIndex = 99;
            lb_unit.Text = "Đơn vị";
            // 
            // lb_practice
            // 
            lb_practice.AutoSize = true;
            lb_practice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_practice.Location = new Point(484, 160);
            lb_practice.Name = "lb_practice";
            lb_practice.Size = new Size(161, 28);
            lb_practice.TabIndex = 98;
            lb_practice.Text = "Số tiết thực hành";
            // 
            // lb_theory
            // 
            lb_theory.AutoSize = true;
            lb_theory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_theory.Location = new Point(484, 91);
            lb_theory.Name = "lb_theory";
            lb_theory.Size = new Size(150, 28);
            lb_theory.TabIndex = 97;
            lb_theory.Text = "Số tiết lý thuyết";
            // 
            // lb_idunit
            // 
            lb_idunit.AutoSize = true;
            lb_idunit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_idunit.Location = new Point(57, 228);
            lb_idunit.Name = "lb_idunit";
            lb_idunit.Size = new Size(100, 28);
            lb_idunit.TabIndex = 96;
            lb_idunit.Text = "Mã đơn vị";
            // 
            // lb_maxstudent
            // 
            lb_maxstudent.AutoSize = true;
            lb_maxstudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_maxstudent.Location = new Point(484, 300);
            lb_maxstudent.Name = "lb_maxstudent";
            lb_maxstudent.Size = new Size(172, 28);
            lb_maxstudent.TabIndex = 95;
            lb_maxstudent.Text = "Số sinh viên tối đa";
            // 
            // lb_credit
            // 
            lb_credit.AutoSize = true;
            lb_credit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_credit.Location = new Point(484, 228);
            lb_credit.Name = "lb_credit";
            lb_credit.Size = new Size(93, 28);
            lb_credit.TabIndex = 94;
            lb_credit.Text = "Số tín chỉ";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(48, 160);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(127, 28);
            lb_name.TabIndex = 93;
            lb_name.Text = "Tên học phần";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_id.Location = new Point(48, 91);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(126, 28);
            lb_id.TabIndex = 92;
            lb_id.Text = "Mã học phần";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(362, 17);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(208, 31);
            lb_Info.TabIndex = 91;
            lb_Info.Text = "Cập nhật học phần";
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.White;
            btn_Update.BackgroundImage = Properties.Resources.button_round2;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Update.ForeColor = SystemColors.Window;
            btn_Update.Location = new Point(484, 370);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(91, 38);
            btn_Update.TabIndex = 110;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // Update_Courses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(btn_Update);
            Controls.Add(tb_practice);
            Controls.Add(tb_credit);
            Controls.Add(tb_maxstudent);
            Controls.Add(cbB_unit);
            Controls.Add(cbB_idunit);
            Controls.Add(btn_Back);
            Controls.Add(tb_theory);
            Controls.Add(tb_name);
            Controls.Add(tb_id);
            Controls.Add(lb_unit);
            Controls.Add(lb_practice);
            Controls.Add(lb_theory);
            Controls.Add(lb_idunit);
            Controls.Add(lb_maxstudent);
            Controls.Add(lb_credit);
            Controls.Add(lb_name);
            Controls.Add(lb_id);
            Controls.Add(lb_Info);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Update_Courses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update_Courses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_practice;
        private TextBox tb_credit;
        private TextBox tb_maxstudent;
        private ComboBox cbB_unit;
        private ComboBox cbB_idunit;
        private Button btn_Back;
        private TextBox tb_theory;
        private TextBox tb_name;
        private TextBox tb_id;
        private Label lb_unit;
        private Label lb_practice;
        private Label lb_theory;
        private Label lb_idunit;
        private Label lb_maxstudent;
        private Label lb_credit;
        private Label lb_name;
        private Label lb_id;
        private Label lb_Info;
        private Button btn_Update;
    }
}