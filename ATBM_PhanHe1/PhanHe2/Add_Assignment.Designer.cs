namespace ATBM_PhanHe1.PhanHe2
{
    partial class Add_Assignment
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
            cbB_namelecture = new ComboBox();
            cbB_idlecture = new ComboBox();
            lb_namelecture = new Label();
            lb_idlecture = new Label();
            tb_year = new TextBox();
            SuspendLayout();
            // 
            // cbB_nameCourses
            // 
            cbB_nameCourses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_nameCourses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_nameCourses.FormattingEnabled = true;
            cbB_nameCourses.Location = new Point(191, 154);
            cbB_nameCourses.Name = "cbB_nameCourses";
            cbB_nameCourses.Size = new Size(229, 36);
            cbB_nameCourses.TabIndex = 163;
            cbB_nameCourses.SelectedIndexChanged += cbB_nameCourses_SelectedIndexChanged;
            // 
            // cbB_idcourses
            // 
            cbB_idcourses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_idcourses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_idcourses.FormattingEnabled = true;
            cbB_idcourses.Location = new Point(191, 86);
            cbB_idcourses.Name = "cbB_idcourses";
            cbB_idcourses.Size = new Size(229, 36);
            cbB_idcourses.TabIndex = 162;
            cbB_idcourses.SelectedIndexChanged += cbB_idcourses_SelectedIndexChanged;
            // 
            // cbB_nameprograme
            // 
            cbB_nameprograme.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_nameprograme.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_nameprograme.FormattingEnabled = true;
            cbB_nameprograme.Location = new Point(628, 154);
            cbB_nameprograme.Name = "cbB_nameprograme";
            cbB_nameprograme.Size = new Size(229, 36);
            cbB_nameprograme.TabIndex = 161;
            cbB_nameprograme.SelectedIndexChanged += cbB_nameprograme_SelectedIndexChanged;
            // 
            // cbB_idprogram
            // 
            cbB_idprogram.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_idprogram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_idprogram.FormattingEnabled = true;
            cbB_idprogram.Location = new Point(628, 86);
            cbB_idprogram.Name = "cbB_idprogram";
            cbB_idprogram.Size = new Size(229, 36);
            cbB_idprogram.TabIndex = 160;
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
            btn_Add.Location = new Point(466, 371);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(91, 38);
            btn_Add.TabIndex = 159;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // cbB_semester
            // 
            cbB_semester.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_semester.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_semester.FormattingEnabled = true;
            cbB_semester.Location = new Point(191, 221);
            cbB_semester.Name = "cbB_semester";
            cbB_semester.Size = new Size(229, 36);
            cbB_semester.TabIndex = 157;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round2;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(341, 371);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 156;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // lb_year
            // 
            lb_year.AutoSize = true;
            lb_year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_year.Location = new Point(42, 295);
            lb_year.Name = "lb_year";
            lb_year.Size = new Size(54, 28);
            lb_year.TabIndex = 155;
            lb_year.Text = "Năm";
            // 
            // lb_nameprogram
            // 
            lb_nameprogram.AutoSize = true;
            lb_nameprogram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_nameprogram.Location = new Point(454, 157);
            lb_nameprogram.Name = "lb_nameprogram";
            lb_nameprogram.Size = new Size(159, 28);
            lb_nameprogram.TabIndex = 154;
            lb_nameprogram.Text = "Tên chương trình";
            // 
            // lb_idprogram
            // 
            lb_idprogram.AutoSize = true;
            lb_idprogram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_idprogram.Location = new Point(454, 89);
            lb_idprogram.Name = "lb_idprogram";
            lb_idprogram.Size = new Size(158, 28);
            lb_idprogram.TabIndex = 153;
            lb_idprogram.Text = "Mã chương trình";
            // 
            // lb_semester
            // 
            lb_semester.AutoSize = true;
            lb_semester.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_semester.Location = new Point(42, 224);
            lb_semester.Name = "lb_semester";
            lb_semester.Size = new Size(72, 28);
            lb_semester.TabIndex = 152;
            lb_semester.Text = "Học kỳ";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(42, 157);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(127, 28);
            lb_name.TabIndex = 151;
            lb_name.Text = "Tên học phần";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_id.Location = new Point(42, 89);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(126, 28);
            lb_id.TabIndex = 150;
            lb_id.Text = "Mã học phần";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(313, 13);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(297, 31);
            lb_Info.TabIndex = 149;
            lb_Info.Text = "Thêm phân công giảng dạy";
            // 
            // cbB_namelecture
            // 
            cbB_namelecture.DropDownHeight = 150;
            cbB_namelecture.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_namelecture.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_namelecture.FormattingEnabled = true;
            cbB_namelecture.IntegralHeight = false;
            cbB_namelecture.Location = new Point(628, 289);
            cbB_namelecture.Name = "cbB_namelecture";
            cbB_namelecture.Size = new Size(229, 36);
            cbB_namelecture.TabIndex = 167;
            cbB_namelecture.SelectedIndexChanged += cbB_namelecture_SelectedIndexChanged;
            // 
            // cbB_idlecture
            // 
            cbB_idlecture.DropDownHeight = 150;
            cbB_idlecture.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_idlecture.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_idlecture.FormattingEnabled = true;
            cbB_idlecture.IntegralHeight = false;
            cbB_idlecture.Location = new Point(628, 221);
            cbB_idlecture.Name = "cbB_idlecture";
            cbB_idlecture.Size = new Size(229, 36);
            cbB_idlecture.TabIndex = 166;
            cbB_idlecture.SelectedIndexChanged += cbB_idlecture_SelectedIndexChanged;
            // 
            // lb_namelecture
            // 
            lb_namelecture.AutoSize = true;
            lb_namelecture.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_namelecture.Location = new Point(454, 292);
            lb_namelecture.Name = "lb_namelecture";
            lb_namelecture.Size = new Size(137, 28);
            lb_namelecture.TabIndex = 165;
            lb_namelecture.Text = "Tên giảng viên";
            // 
            // lb_idlecture
            // 
            lb_idlecture.AutoSize = true;
            lb_idlecture.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_idlecture.Location = new Point(454, 224);
            lb_idlecture.Name = "lb_idlecture";
            lb_idlecture.Size = new Size(136, 28);
            lb_idlecture.TabIndex = 164;
            lb_idlecture.Text = "Mã giảng viên";
            // 
            // tb_year
            // 
            tb_year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_year.Location = new Point(191, 292);
            tb_year.Name = "tb_year";
            tb_year.Size = new Size(229, 34);
            tb_year.TabIndex = 168;
            tb_year.TabStop = false;
            // 
            // Add_Assignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(tb_year);
            Controls.Add(cbB_namelecture);
            Controls.Add(cbB_idlecture);
            Controls.Add(lb_namelecture);
            Controls.Add(lb_idlecture);
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
            Name = "Add_Assignment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add_Assignment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private ComboBox cbB_namelecture;
        private ComboBox cbB_idlecture;
        private Label lb_namelecture;
        private Label lb_idlecture;
        private TextBox tb_year;
    }
}