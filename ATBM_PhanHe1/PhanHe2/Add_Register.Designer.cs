namespace ATBM_PhanHe1.PhanHe2
{
    partial class Add_Register
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
            lb_namestudent = new Label();
            lb_idstudent = new Label();
            cbB_nameCourses = new ComboBox();
            cbB_idcourses = new ComboBox();
            cbB_nameprograme = new ComboBox();
            cbB_idprogram = new ComboBox();
            btn_Add = new Button();
            cbB_semester = new ComboBox();
            btn_Back = new Button();
            lb_year = new Label();
            lb_nameprogram = new Label();
            lb_idprogram = new Label();
            lb_semester = new Label();
            lb_name = new Label();
            lb_id = new Label();
            lb_Info = new Label();
            tb_idstudent = new TextBox();
            tb_namestudent = new TextBox();
            tb_year = new TextBox();
            SuspendLayout();
            // 
            // lb_namestudent
            // 
            lb_namestudent.AutoSize = true;
            lb_namestudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_namestudent.Location = new Point(35, 118);
            lb_namestudent.Name = "lb_namestudent";
            lb_namestudent.Size = new Size(99, 21);
            lb_namestudent.TabIndex = 184;
            lb_namestudent.Text = "Tên sinh viên";
            // 
            // lb_idstudent
            // 
            lb_idstudent.AutoSize = true;
            lb_idstudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_idstudent.Location = new Point(35, 68);
            lb_idstudent.Name = "lb_idstudent";
            lb_idstudent.Size = new Size(98, 21);
            lb_idstudent.TabIndex = 183;
            lb_idstudent.Text = "Mã sinh viên";
            // 
            // cbB_nameCourses
            // 
            cbB_nameCourses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_nameCourses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_nameCourses.FormattingEnabled = true;
            cbB_nameCourses.Location = new Point(548, 220);
            cbB_nameCourses.Margin = new Padding(3, 2, 3, 2);
            cbB_nameCourses.Name = "cbB_nameCourses";
            cbB_nameCourses.Size = new Size(201, 29);
            cbB_nameCourses.TabIndex = 182;
            cbB_nameCourses.SelectedIndexChanged += cbB_nameCourses_SelectedIndexChanged;
            // 
            // cbB_idcourses
            // 
            cbB_idcourses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_idcourses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_idcourses.FormattingEnabled = true;
            cbB_idcourses.Location = new Point(548, 169);
            cbB_idcourses.Margin = new Padding(3, 2, 3, 2);
            cbB_idcourses.Name = "cbB_idcourses";
            cbB_idcourses.Size = new Size(201, 29);
            cbB_idcourses.TabIndex = 181;
            cbB_idcourses.SelectedIndexChanged += cbB_idcourses_SelectedIndexChanged;
            // 
            // cbB_nameprograme
            // 
            cbB_nameprograme.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_nameprograme.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_nameprograme.FormattingEnabled = true;
            cbB_nameprograme.Location = new Point(548, 116);
            cbB_nameprograme.Margin = new Padding(3, 2, 3, 2);
            cbB_nameprograme.Name = "cbB_nameprograme";
            cbB_nameprograme.Size = new Size(201, 29);
            cbB_nameprograme.TabIndex = 180;
            cbB_nameprograme.SelectedIndexChanged += cbB_nameprograme_SelectedIndexChanged;
            // 
            // cbB_idprogram
            // 
            cbB_idprogram.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_idprogram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_idprogram.FormattingEnabled = true;
            cbB_idprogram.Location = new Point(548, 65);
            cbB_idprogram.Margin = new Padding(3, 2, 3, 2);
            cbB_idprogram.Name = "cbB_idprogram";
            cbB_idprogram.Size = new Size(201, 29);
            cbB_idprogram.TabIndex = 179;
            cbB_idprogram.SelectedIndexChanged += cbB_idprogram_SelectedIndexChanged;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.White;
            btn_Add.BackgroundImage = Properties.Resources.button_round2;
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Add.ForeColor = SystemColors.Window;
            btn_Add.Location = new Point(406, 279);
            btn_Add.Margin = new Padding(3, 2, 3, 2);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(80, 28);
            btn_Add.TabIndex = 178;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // cbB_semester
            // 
            cbB_semester.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_semester.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_semester.FormattingEnabled = true;
            cbB_semester.Location = new Point(165, 166);
            cbB_semester.Margin = new Padding(3, 2, 3, 2);
            cbB_semester.Name = "cbB_semester";
            cbB_semester.Size = new Size(201, 29);
            cbB_semester.TabIndex = 176;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round2;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(297, 279);
            btn_Back.Margin = new Padding(3, 2, 3, 2);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(80, 28);
            btn_Back.TabIndex = 175;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // lb_year
            // 
            lb_year.AutoSize = true;
            lb_year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_year.Location = new Point(35, 222);
            lb_year.Name = "lb_year";
            lb_year.Size = new Size(44, 21);
            lb_year.TabIndex = 174;
            lb_year.Text = "Năm";
            // 
            // lb_nameprogram
            // 
            lb_nameprogram.AutoSize = true;
            lb_nameprogram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_nameprogram.Location = new Point(396, 118);
            lb_nameprogram.Name = "lb_nameprogram";
            lb_nameprogram.Size = new Size(127, 21);
            lb_nameprogram.TabIndex = 173;
            lb_nameprogram.Text = "Tên chương trình";
            // 
            // lb_idprogram
            // 
            lb_idprogram.AutoSize = true;
            lb_idprogram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_idprogram.Location = new Point(396, 68);
            lb_idprogram.Name = "lb_idprogram";
            lb_idprogram.Size = new Size(126, 21);
            lb_idprogram.TabIndex = 172;
            lb_idprogram.Text = "Mã chương trình";
            // 
            // lb_semester
            // 
            lb_semester.AutoSize = true;
            lb_semester.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_semester.Location = new Point(35, 169);
            lb_semester.Name = "lb_semester";
            lb_semester.Size = new Size(57, 21);
            lb_semester.TabIndex = 171;
            lb_semester.Text = "Học kỳ";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(396, 222);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(101, 21);
            lb_name.TabIndex = 170;
            lb_name.Text = "Tên học phần";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_id.Location = new Point(396, 171);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(100, 21);
            lb_id.TabIndex = 169;
            lb_id.Text = "Mã học phần";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(272, 10);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(218, 25);
            lb_Info.TabIndex = 168;
            lb_Info.Text = "Thêm đăng ký học phần";
            // 
            // tb_idstudent
            // 
            tb_idstudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_idstudent.Location = new Point(165, 65);
            tb_idstudent.Margin = new Padding(3, 2, 3, 2);
            tb_idstudent.Name = "tb_idstudent";
            tb_idstudent.Size = new Size(201, 29);
            tb_idstudent.TabIndex = 185;
            tb_idstudent.TabStop = false;
            tb_idstudent.TextChanged += tb_idstudent_TextChanged;
            // 
            // tb_namestudent
            // 
            tb_namestudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_namestudent.Location = new Point(165, 116);
            tb_namestudent.Margin = new Padding(3, 2, 3, 2);
            tb_namestudent.Name = "tb_namestudent";
            tb_namestudent.ReadOnly = true;
            tb_namestudent.Size = new Size(201, 29);
            tb_namestudent.TabIndex = 186;
            tb_namestudent.TabStop = false;
            // 
            // tb_year
            // 
            tb_year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_year.Location = new Point(165, 220);
            tb_year.Margin = new Padding(3, 2, 3, 2);
            tb_year.Name = "tb_year";
            tb_year.Size = new Size(201, 29);
            tb_year.TabIndex = 187;
            tb_year.TabStop = false;
            // 
            // Add_Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(783, 319);
            Controls.Add(tb_year);
            Controls.Add(tb_namestudent);
            Controls.Add(tb_idstudent);
            Controls.Add(lb_namestudent);
            Controls.Add(lb_idstudent);
            Controls.Add(cbB_nameCourses);
            Controls.Add(cbB_idcourses);
            Controls.Add(cbB_nameprograme);
            Controls.Add(cbB_idprogram);
            Controls.Add(btn_Add);
            Controls.Add(cbB_semester);
            Controls.Add(btn_Back);
            Controls.Add(lb_year);
            Controls.Add(lb_nameprogram);
            Controls.Add(lb_idprogram);
            Controls.Add(lb_semester);
            Controls.Add(lb_name);
            Controls.Add(lb_id);
            Controls.Add(lb_Info);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Add_Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_namestudent;
        private Label lb_idstudent;
        private ComboBox cbB_nameCourses;
        private ComboBox cbB_idcourses;
        private ComboBox cbB_nameprograme;
        private ComboBox cbB_idprogram;
        private Button btn_Add;
        private ComboBox cbB_semester;
        private Button btn_Back;
        private Label lb_year;
        private Label lb_nameprogram;
        private Label lb_idprogram;
        private Label lb_semester;
        private Label lb_name;
        private Label lb_id;
        private Label lb_Info;
        private TextBox tb_idstudent;
        private TextBox tb_namestudent;
        private TextBox tb_year;
    }
}