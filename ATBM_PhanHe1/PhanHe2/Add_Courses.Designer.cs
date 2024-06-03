namespace ATBM_PhanHe1.PhanHe2
{
    partial class Add_Courses
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
            cbB_unit = new ComboBox();
            cbB_idunit = new ComboBox();
            btn_Add = new Button();
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
            tb_maxstudent = new TextBox();
            tb_credit = new TextBox();
            tb_practice = new TextBox();
            SuspendLayout();
            // 
            // cbB_unit
            // 
            cbB_unit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_unit.FormattingEnabled = true;
            cbB_unit.Location = new Point(183, 297);
            cbB_unit.Name = "cbB_unit";
            cbB_unit.Size = new Size(229, 36);
            cbB_unit.TabIndex = 87;
            cbB_unit.SelectedIndexChanged += cbB_unit_SelectedIndexChanged;
            // 
            // cbB_idunit
            // 
            cbB_idunit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_idunit.FormattingEnabled = true;
            cbB_idunit.Location = new Point(183, 225);
            cbB_idunit.Name = "cbB_idunit";
            cbB_idunit.Size = new Size(229, 36);
            cbB_idunit.TabIndex = 86;
            cbB_idunit.SelectedIndexChanged += cbB_idunit_SelectedIndexChanged;
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
            // tb_theory
            // 
            tb_theory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_theory.Location = new Point(654, 88);
            tb_theory.Name = "tb_theory";
            tb_theory.Size = new Size(185, 34);
            tb_theory.TabIndex = 81;
            tb_theory.TabStop = false;
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
            tb_id.Size = new Size(229, 34);
            tb_id.TabIndex = 79;
            tb_id.TabStop = false;
            // 
            // lb_unit
            // 
            lb_unit.AutoSize = true;
            lb_unit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_unit.Location = new Point(49, 300);
            lb_unit.Name = "lb_unit";
            lb_unit.Size = new Size(101, 28);
            lb_unit.TabIndex = 78;
            lb_unit.Text = "Tên đơn vị";
            // 
            // lb_practice
            // 
            lb_practice.AutoSize = true;
            lb_practice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_practice.Location = new Point(476, 160);
            lb_practice.Name = "lb_practice";
            lb_practice.Size = new Size(161, 28);
            lb_practice.TabIndex = 77;
            lb_practice.Text = "Số tiết thực hành";
            // 
            // lb_theory
            // 
            lb_theory.AutoSize = true;
            lb_theory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_theory.Location = new Point(476, 91);
            lb_theory.Name = "lb_theory";
            lb_theory.Size = new Size(150, 28);
            lb_theory.TabIndex = 76;
            lb_theory.Text = "Số tiết lý thuyết";
            // 
            // lb_idunit
            // 
            lb_idunit.AutoSize = true;
            lb_idunit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_idunit.Location = new Point(49, 228);
            lb_idunit.Name = "lb_idunit";
            lb_idunit.Size = new Size(100, 28);
            lb_idunit.TabIndex = 75;
            lb_idunit.Text = "Mã đơn vị";
            // 
            // lb_maxstudent
            // 
            lb_maxstudent.AutoSize = true;
            lb_maxstudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_maxstudent.Location = new Point(476, 300);
            lb_maxstudent.Name = "lb_maxstudent";
            lb_maxstudent.Size = new Size(172, 28);
            lb_maxstudent.TabIndex = 74;
            lb_maxstudent.Text = "Số sinh viên tối đa";
            // 
            // lb_credit
            // 
            lb_credit.AutoSize = true;
            lb_credit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_credit.Location = new Point(476, 228);
            lb_credit.Name = "lb_credit";
            lb_credit.Size = new Size(93, 28);
            lb_credit.TabIndex = 73;
            lb_credit.Text = "Số tín chỉ";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(40, 160);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(127, 28);
            lb_name.TabIndex = 72;
            lb_name.Text = "Tên học phần";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_id.Location = new Point(40, 91);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(126, 28);
            lb_id.TabIndex = 71;
            lb_id.Text = "Mã học phần";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(366, 17);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(174, 31);
            lb_Info.TabIndex = 70;
            lb_Info.Text = "Thêm học phần";
            // 
            // tb_maxstudent
            // 
            tb_maxstudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_maxstudent.Location = new Point(654, 297);
            tb_maxstudent.Name = "tb_maxstudent";
            tb_maxstudent.Size = new Size(185, 34);
            tb_maxstudent.TabIndex = 88;
            tb_maxstudent.TabStop = false;
            // 
            // tb_credit
            // 
            tb_credit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_credit.Location = new Point(654, 225);
            tb_credit.Name = "tb_credit";
            tb_credit.Size = new Size(185, 34);
            tb_credit.TabIndex = 89;
            tb_credit.TabStop = false;
            // 
            // tb_practice
            // 
            tb_practice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_practice.Location = new Point(654, 157);
            tb_practice.Name = "tb_practice";
            tb_practice.Size = new Size(185, 34);
            tb_practice.TabIndex = 90;
            tb_practice.TabStop = false;
            // 
            // Add_Courses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(tb_practice);
            Controls.Add(tb_credit);
            Controls.Add(tb_maxstudent);
            Controls.Add(cbB_unit);
            Controls.Add(cbB_idunit);
            Controls.Add(btn_Add);
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
            Name = "Add_Courses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Courses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbB_unit;
        private ComboBox cbB_idunit;
        private Button btn_Add;
        private Button btn_Back;
        private TextBox tb_role;
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
        private TextBox tb_maxstudent;
        private TextBox tb_credit;
        private TextBox tb_practice;
    }
}