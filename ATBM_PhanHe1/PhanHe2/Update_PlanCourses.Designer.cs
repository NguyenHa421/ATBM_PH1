namespace ATBM_PhanHe1.PhanHe2
{
    partial class Update_PlanCourses
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
            btn_Update = new Button();
            cbB_year = new ComboBox();
            cbB_semester = new ComboBox();
            btn_Back = new Button();
            lb_year = new Label();
            lb_nameprogram = new Label();
            lb_idprogram = new Label();
            lb_semester = new Label();
            lb_name = new Label();
            lb_id = new Label();
            lb_Info = new Label();
            cbB_idprogram = new ComboBox();
            cbB_nameprograme = new ComboBox();
            cbB_nameCourses = new ComboBox();
            cbB_idcourses = new ComboBox();
            SuspendLayout();
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.White;
            btn_Update.BackgroundImage = Properties.Resources.button_round2;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Update.ForeColor = SystemColors.Window;
            btn_Update.Location = new Point(484, 372);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(91, 38);
            btn_Update.TabIndex = 129;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = false;
            // 
            // cbB_year
            // 
            cbB_year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_year.FormattingEnabled = true;
            cbB_year.Location = new Point(447, 218);
            cbB_year.Name = "cbB_year";
            cbB_year.Size = new Size(229, 36);
            cbB_year.TabIndex = 125;
            // 
            // cbB_semester
            // 
            cbB_semester.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_semester.FormattingEnabled = true;
            cbB_semester.Items.AddRange(new object[] { "1", "2", "3" });
            cbB_semester.Location = new Point(447, 160);
            cbB_semester.Name = "cbB_semester";
            cbB_semester.Size = new Size(229, 36);
            cbB_semester.TabIndex = 124;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round2;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(359, 372);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 123;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            // 
            // lb_year
            // 
            lb_year.AutoSize = true;
            lb_year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_year.Location = new Point(265, 221);
            lb_year.Name = "lb_year";
            lb_year.Size = new Size(54, 28);
            lb_year.TabIndex = 119;
            lb_year.Text = "Năm";
            // 
            // lb_nameprogram
            // 
            lb_nameprogram.AutoSize = true;
            lb_nameprogram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_nameprogram.Location = new Point(265, 327);
            lb_nameprogram.Name = "lb_nameprogram";
            lb_nameprogram.Size = new Size(159, 28);
            lb_nameprogram.TabIndex = 118;
            lb_nameprogram.Text = "Tên chương trình";
            // 
            // lb_idprogram
            // 
            lb_idprogram.AutoSize = true;
            lb_idprogram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_idprogram.Location = new Point(265, 275);
            lb_idprogram.Name = "lb_idprogram";
            lb_idprogram.Size = new Size(158, 28);
            lb_idprogram.TabIndex = 117;
            lb_idprogram.Text = "Mã chương trình";
            // 
            // lb_semester
            // 
            lb_semester.AutoSize = true;
            lb_semester.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_semester.Location = new Point(265, 163);
            lb_semester.Name = "lb_semester";
            lb_semester.Size = new Size(72, 28);
            lb_semester.TabIndex = 116;
            lb_semester.Text = "Học kỳ";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(265, 110);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(127, 28);
            lb_name.TabIndex = 113;
            lb_name.Text = "Tên học phần";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_id.Location = new Point(265, 58);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(126, 28);
            lb_id.TabIndex = 112;
            lb_id.Text = "Mã học phần";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(312, 11);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(298, 31);
            lb_Info.TabIndex = 111;
            lb_Info.Text = "Cập nhật kế hoạch mở môn";
            // 
            // cbB_idprogram
            // 
            cbB_idprogram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_idprogram.FormattingEnabled = true;
            cbB_idprogram.Location = new Point(447, 272);
            cbB_idprogram.Name = "cbB_idprogram";
            cbB_idprogram.Size = new Size(229, 36);
            cbB_idprogram.TabIndex = 130;
            // 
            // cbB_nameprograme
            // 
            cbB_nameprograme.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_nameprograme.FormattingEnabled = true;
            cbB_nameprograme.Location = new Point(447, 324);
            cbB_nameprograme.Name = "cbB_nameprograme";
            cbB_nameprograme.Size = new Size(229, 36);
            cbB_nameprograme.TabIndex = 131;
            // 
            // cbB_nameCourses
            // 
            cbB_nameCourses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_nameCourses.FormattingEnabled = true;
            cbB_nameCourses.Location = new Point(447, 107);
            cbB_nameCourses.Name = "cbB_nameCourses";
            cbB_nameCourses.Size = new Size(229, 36);
            cbB_nameCourses.TabIndex = 133;
            // 
            // cbB_idcourses
            // 
            cbB_idcourses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_idcourses.FormattingEnabled = true;
            cbB_idcourses.Location = new Point(447, 55);
            cbB_idcourses.Name = "cbB_idcourses";
            cbB_idcourses.Size = new Size(229, 36);
            cbB_idcourses.TabIndex = 132;
            // 
            // Update_PlanCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(cbB_nameCourses);
            Controls.Add(cbB_idcourses);
            Controls.Add(cbB_nameprograme);
            Controls.Add(cbB_idprogram);
            Controls.Add(btn_Update);
            Controls.Add(cbB_year);
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
            Name = "Update_PlanCourses";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update_PlanCourses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Update;
        private ComboBox cbB_year;
        private ComboBox cbB_semester;
        private Button btn_Back;
        private Label lb_year;
        private Label lb_nameprogram;
        private Label lb_idprogram;
        private Label lb_semester;
        private Label lb_name;
        private Label lb_id;
        private Label lb_Info;
        private ComboBox cbB_idprogram;
        private ComboBox cbB_nameprograme;
        private ComboBox cbB_nameCourses;
        private ComboBox cbB_idcourses;
    }
}