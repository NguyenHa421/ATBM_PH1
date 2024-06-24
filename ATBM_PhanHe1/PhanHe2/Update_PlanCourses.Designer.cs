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
            tb_idprogram = new TextBox();
            tb_nameprogram = new TextBox();
            tb_idcourse = new TextBox();
            tb_namecourse = new TextBox();
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
            btn_Update.Location = new Point(454, 378);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(91, 38);
            btn_Update.TabIndex = 129;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // cbB_year
            // 
            cbB_year.DropDownHeight = 120;
            cbB_year.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_year.FormattingEnabled = true;
            cbB_year.IntegralHeight = false;
            cbB_year.Location = new Point(417, 224);
            cbB_year.Name = "cbB_year";
            cbB_year.Size = new Size(229, 36);
            cbB_year.TabIndex = 125;
            // 
            // cbB_semester
            // 
            cbB_semester.DropDownHeight = 120;
            cbB_semester.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_semester.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_semester.FormattingEnabled = true;
            cbB_semester.IntegralHeight = false;
            cbB_semester.Items.AddRange(new object[] { "1", "2", "3" });
            cbB_semester.Location = new Point(417, 166);
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
            btn_Back.Location = new Point(329, 378);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 123;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // lb_year
            // 
            lb_year.AutoSize = true;
            lb_year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_year.Location = new Point(235, 227);
            lb_year.Name = "lb_year";
            lb_year.Size = new Size(54, 28);
            lb_year.TabIndex = 119;
            lb_year.Text = "Năm";
            // 
            // lb_nameprogram
            // 
            lb_nameprogram.AutoSize = true;
            lb_nameprogram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_nameprogram.Location = new Point(235, 333);
            lb_nameprogram.Name = "lb_nameprogram";
            lb_nameprogram.Size = new Size(159, 28);
            lb_nameprogram.TabIndex = 118;
            lb_nameprogram.Text = "Tên chương trình";
            // 
            // lb_idprogram
            // 
            lb_idprogram.AutoSize = true;
            lb_idprogram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_idprogram.Location = new Point(235, 281);
            lb_idprogram.Name = "lb_idprogram";
            lb_idprogram.Size = new Size(158, 28);
            lb_idprogram.TabIndex = 117;
            lb_idprogram.Text = "Mã chương trình";
            // 
            // lb_semester
            // 
            lb_semester.AutoSize = true;
            lb_semester.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_semester.Location = new Point(235, 169);
            lb_semester.Name = "lb_semester";
            lb_semester.Size = new Size(72, 28);
            lb_semester.TabIndex = 116;
            lb_semester.Text = "Học kỳ";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(235, 116);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(127, 28);
            lb_name.TabIndex = 113;
            lb_name.Text = "Tên học phần";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_id.Location = new Point(235, 64);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(126, 28);
            lb_id.TabIndex = 112;
            lb_id.Text = "Mã học phần";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(282, 17);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(298, 31);
            lb_Info.TabIndex = 111;
            lb_Info.Text = "Cập nhật kế hoạch mở môn";
            // 
            // tb_idprogram
            // 
            tb_idprogram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_idprogram.Location = new Point(417, 278);
            tb_idprogram.Name = "tb_idprogram";
            tb_idprogram.ReadOnly = true;
            tb_idprogram.Size = new Size(229, 34);
            tb_idprogram.TabIndex = 134;
            tb_idprogram.TabStop = false;
            // 
            // tb_nameprogram
            // 
            tb_nameprogram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_nameprogram.Location = new Point(417, 330);
            tb_nameprogram.Name = "tb_nameprogram";
            tb_nameprogram.ReadOnly = true;
            tb_nameprogram.Size = new Size(229, 34);
            tb_nameprogram.TabIndex = 135;
            tb_nameprogram.TabStop = false;
            // 
            // tb_idcourse
            // 
            tb_idcourse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_idcourse.Location = new Point(417, 61);
            tb_idcourse.Name = "tb_idcourse";
            tb_idcourse.ReadOnly = true;
            tb_idcourse.Size = new Size(229, 34);
            tb_idcourse.TabIndex = 136;
            tb_idcourse.TabStop = false;
            // 
            // tb_namecourse
            // 
            tb_namecourse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_namecourse.Location = new Point(417, 113);
            tb_namecourse.Name = "tb_namecourse";
            tb_namecourse.ReadOnly = true;
            tb_namecourse.Size = new Size(229, 34);
            tb_namecourse.TabIndex = 137;
            tb_namecourse.TabStop = false;
            // 
            // Update_PlanCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(tb_namecourse);
            Controls.Add(tb_idcourse);
            Controls.Add(tb_nameprogram);
            Controls.Add(tb_idprogram);
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
        private TextBox tb_idprogram;
        private TextBox tb_nameprogram;
        private TextBox tb_idcourse;
        private TextBox tb_namecourse;
    }
}