namespace ATBM_PhanHe1.PhanHe2
{
    partial class Update_Assignment
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
            cbB_lecturerName = new ComboBox();
            cbB_lecturerID = new ComboBox();
            lb_namelecture = new Label();
            lb_idlecture = new Label();
            btn_Update = new Button();
            btn_Back = new Button();
            lb_year = new Label();
            lb_nameprogram = new Label();
            lb_idprogram = new Label();
            lb_semester = new Label();
            lb_name = new Label();
            lb_id = new Label();
            lb_Info = new Label();
            tb_courseID = new TextBox();
            tb_courseName = new TextBox();
            tb_semester = new TextBox();
            tb_year = new TextBox();
            tb_programID = new TextBox();
            tb_programName = new TextBox();
            SuspendLayout();
            // 
            // cbB_lecturerName
            // 
            cbB_lecturerName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_lecturerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_lecturerName.FormattingEnabled = true;
            cbB_lecturerName.Location = new Point(626, 290);
            cbB_lecturerName.Name = "cbB_lecturerName";
            cbB_lecturerName.Size = new Size(229, 36);
            cbB_lecturerName.TabIndex = 186;
            cbB_lecturerName.SelectedIndexChanged += cbB_lecturerName_SelectedIndexChanged;
            // 
            // cbB_lecturerID
            // 
            cbB_lecturerID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_lecturerID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_lecturerID.FormattingEnabled = true;
            cbB_lecturerID.Location = new Point(626, 222);
            cbB_lecturerID.Name = "cbB_lecturerID";
            cbB_lecturerID.Size = new Size(229, 36);
            cbB_lecturerID.TabIndex = 185;
            cbB_lecturerID.SelectedIndexChanged += cbB_lecturerID_SelectedIndexChanged;
            // 
            // lb_namelecture
            // 
            lb_namelecture.AutoSize = true;
            lb_namelecture.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_namelecture.Location = new Point(452, 293);
            lb_namelecture.Name = "lb_namelecture";
            lb_namelecture.Size = new Size(137, 28);
            lb_namelecture.TabIndex = 184;
            lb_namelecture.Text = "Tên giảng viên";
            // 
            // lb_idlecture
            // 
            lb_idlecture.AutoSize = true;
            lb_idlecture.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_idlecture.Location = new Point(452, 225);
            lb_idlecture.Name = "lb_idlecture";
            lb_idlecture.Size = new Size(136, 28);
            lb_idlecture.TabIndex = 183;
            lb_idlecture.Text = "Mã giảng viên";
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.White;
            btn_Update.BackgroundImage = Properties.Resources.button_round2;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Update.ForeColor = SystemColors.Window;
            btn_Update.Location = new Point(464, 372);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(91, 38);
            btn_Update.TabIndex = 178;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round2;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(339, 372);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 175;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // lb_year
            // 
            lb_year.AutoSize = true;
            lb_year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_year.Location = new Point(40, 296);
            lb_year.Name = "lb_year";
            lb_year.Size = new Size(54, 28);
            lb_year.TabIndex = 174;
            lb_year.Text = "Năm";
            // 
            // lb_nameprogram
            // 
            lb_nameprogram.AutoSize = true;
            lb_nameprogram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_nameprogram.Location = new Point(452, 158);
            lb_nameprogram.Name = "lb_nameprogram";
            lb_nameprogram.Size = new Size(159, 28);
            lb_nameprogram.TabIndex = 173;
            lb_nameprogram.Text = "Tên chương trình";
            // 
            // lb_idprogram
            // 
            lb_idprogram.AutoSize = true;
            lb_idprogram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_idprogram.Location = new Point(452, 90);
            lb_idprogram.Name = "lb_idprogram";
            lb_idprogram.Size = new Size(158, 28);
            lb_idprogram.TabIndex = 172;
            lb_idprogram.Text = "Mã chương trình";
            // 
            // lb_semester
            // 
            lb_semester.AutoSize = true;
            lb_semester.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_semester.Location = new Point(40, 225);
            lb_semester.Name = "lb_semester";
            lb_semester.Size = new Size(72, 28);
            lb_semester.TabIndex = 171;
            lb_semester.Text = "Học kỳ";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(40, 158);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(127, 28);
            lb_name.TabIndex = 170;
            lb_name.Text = "Tên học phần";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_id.Location = new Point(40, 90);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(126, 28);
            lb_id.TabIndex = 169;
            lb_id.Text = "Mã học phần";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(280, 9);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(331, 31);
            lb_Info.TabIndex = 168;
            lb_Info.Text = "Cập nhật phân công giảng dạy";
            // 
            // tb_courseID
            // 
            tb_courseID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_courseID.Location = new Point(189, 90);
            tb_courseID.Name = "tb_courseID";
            tb_courseID.ReadOnly = true;
            tb_courseID.Size = new Size(229, 34);
            tb_courseID.TabIndex = 187;
            tb_courseID.TabStop = false;
            // 
            // tb_courseName
            // 
            tb_courseName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_courseName.Location = new Point(189, 155);
            tb_courseName.Name = "tb_courseName";
            tb_courseName.ReadOnly = true;
            tb_courseName.Size = new Size(229, 34);
            tb_courseName.TabIndex = 187;
            tb_courseName.TabStop = false;
            // 
            // tb_semester
            // 
            tb_semester.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_semester.Location = new Point(189, 225);
            tb_semester.Name = "tb_semester";
            tb_semester.ReadOnly = true;
            tb_semester.Size = new Size(229, 34);
            tb_semester.TabIndex = 187;
            tb_semester.TabStop = false;
            // 
            // tb_year
            // 
            tb_year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_year.Location = new Point(189, 293);
            tb_year.Name = "tb_year";
            tb_year.ReadOnly = true;
            tb_year.Size = new Size(229, 34);
            tb_year.TabIndex = 187;
            tb_year.TabStop = false;
            // 
            // tb_programID
            // 
            tb_programID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_programID.Location = new Point(626, 90);
            tb_programID.Name = "tb_programID";
            tb_programID.ReadOnly = true;
            tb_programID.Size = new Size(229, 34);
            tb_programID.TabIndex = 187;
            tb_programID.TabStop = false;
            // 
            // tb_programName
            // 
            tb_programName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_programName.Location = new Point(626, 155);
            tb_programName.Name = "tb_programName";
            tb_programName.ReadOnly = true;
            tb_programName.Size = new Size(229, 34);
            tb_programName.TabIndex = 187;
            tb_programName.TabStop = false;
            // 
            // Update_Assignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(tb_year);
            Controls.Add(tb_semester);
            Controls.Add(tb_courseName);
            Controls.Add(tb_programName);
            Controls.Add(tb_programID);
            Controls.Add(tb_courseID);
            Controls.Add(cbB_lecturerName);
            Controls.Add(cbB_lecturerID);
            Controls.Add(lb_namelecture);
            Controls.Add(lb_idlecture);
            Controls.Add(btn_Update);
            Controls.Add(btn_Back);
            Controls.Add(lb_year);
            Controls.Add(lb_nameprogram);
            Controls.Add(lb_idprogram);
            Controls.Add(lb_semester);
            Controls.Add(lb_name);
            Controls.Add(lb_id);
            Controls.Add(lb_Info);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Update_Assignment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update_Assignment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbB_lecturerName;
        private ComboBox cbB_lecturerID;
        private Label lb_namelecture;
        private Label lb_idlecture;
        private Button btn_Update;
        private Button btn_Back;
        private Label lb_year;
        private Label lb_nameprogram;
        private Label lb_idprogram;
        private Label lb_semester;
        private Label lb_name;
        private Label lb_id;
        private Label lb_Info;
        private TextBox tb_courseID;
        private TextBox tb_courseName;
        private TextBox tb_semester;
        private TextBox tb_year;
        private TextBox tb_programID;
        private TextBox tb_programName;
    }
}