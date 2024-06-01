namespace ATBM_PhanHe1.PhanHe2
{
    partial class Homepage_Staff
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
            pn_parents = new Panel();
            pn_plan = new Panel();
            bt_plan = new Button();
            pic_plan = new PictureBox();
            pn_course = new Panel();
            bt_course = new Button();
            pic_course = new PictureBox();
            pn_unit = new Panel();
            bt_unit = new Button();
            pic_unit = new PictureBox();
            pn_student = new Panel();
            bt_student = new Button();
            pic_student = new PictureBox();
            pn_info = new Panel();
            bt_info = new Button();
            pic_info = new PictureBox();
            pn_parents.SuspendLayout();
            pn_plan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_plan).BeginInit();
            pn_course.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_course).BeginInit();
            pn_unit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_unit).BeginInit();
            pn_student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_student).BeginInit();
            pn_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_info).BeginInit();
            SuspendLayout();
            // 
            // pn_parents
            // 
            pn_parents.Controls.Add(pn_plan);
            pn_parents.Controls.Add(pn_course);
            pn_parents.Controls.Add(pn_unit);
            pn_parents.Controls.Add(pn_student);
            pn_parents.Controls.Add(pn_info);
            pn_parents.Location = new Point(0, 0);
            pn_parents.Name = "pn_parents";
            pn_parents.Size = new Size(895, 425);
            pn_parents.TabIndex = 3;
            // 
            // pn_plan
            // 
            pn_plan.BackColor = Color.White;
            pn_plan.BackgroundImage = Properties.Resources.Bg_icon;
            pn_plan.Controls.Add(bt_plan);
            pn_plan.Controls.Add(pic_plan);
            pn_plan.Location = new Point(38, 228);
            pn_plan.Name = "pn_plan";
            pn_plan.Size = new Size(170, 170);
            pn_plan.TabIndex = 7;
            // 
            // bt_plan
            // 
            bt_plan.BackgroundImage = Properties.Resources.button_2;
            bt_plan.FlatAppearance.BorderSize = 0;
            bt_plan.FlatStyle = FlatStyle.Flat;
            bt_plan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_plan.ForeColor = Color.White;
            bt_plan.Location = new Point(13, 115);
            bt_plan.Name = "bt_plan";
            bt_plan.Size = new Size(144, 38);
            bt_plan.TabIndex = 5;
            bt_plan.Text = "Kế hoạch môn";
            bt_plan.UseVisualStyleBackColor = true;
            bt_plan.Click += bt_plan_Click;
            // 
            // pic_plan
            // 
            pic_plan.Image = Properties.Resources.project_management;
            pic_plan.Location = new Point(38, 21);
            pic_plan.Name = "pic_plan";
            pic_plan.Size = new Size(91, 82);
            pic_plan.SizeMode = PictureBoxSizeMode.Zoom;
            pic_plan.TabIndex = 4;
            pic_plan.TabStop = false;
            // 
            // pn_course
            // 
            pn_course.BackColor = Color.White;
            pn_course.BackgroundImage = Properties.Resources.Bg_icon;
            pn_course.Controls.Add(bt_course);
            pn_course.Controls.Add(pic_course);
            pn_course.Location = new Point(685, 25);
            pn_course.Name = "pn_course";
            pn_course.Size = new Size(170, 170);
            pn_course.TabIndex = 4;
            // 
            // bt_course
            // 
            bt_course.BackgroundImage = Properties.Resources.button_2;
            bt_course.FlatAppearance.BorderSize = 0;
            bt_course.FlatStyle = FlatStyle.Flat;
            bt_course.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_course.ForeColor = Color.White;
            bt_course.Location = new Point(14, 116);
            bt_course.Name = "bt_course";
            bt_course.Size = new Size(144, 38);
            bt_course.TabIndex = 4;
            bt_course.Text = "Học phần";
            bt_course.UseVisualStyleBackColor = true;
            bt_course.Click += bt_course_Click;
            // 
            // pic_course
            // 
            pic_course.Image = Properties.Resources.online_course;
            pic_course.Location = new Point(40, 18);
            pic_course.Name = "pic_course";
            pic_course.Size = new Size(91, 82);
            pic_course.SizeMode = PictureBoxSizeMode.Zoom;
            pic_course.TabIndex = 3;
            pic_course.TabStop = false;
            // 
            // pn_unit
            // 
            pn_unit.BackColor = Color.White;
            pn_unit.BackgroundImage = Properties.Resources.Bg_icon;
            pn_unit.Controls.Add(bt_unit);
            pn_unit.Controls.Add(pic_unit);
            pn_unit.Location = new Point(469, 25);
            pn_unit.Name = "pn_unit";
            pn_unit.Size = new Size(170, 170);
            pn_unit.TabIndex = 5;
            // 
            // bt_unit
            // 
            bt_unit.BackgroundImage = Properties.Resources.button_2;
            bt_unit.FlatAppearance.BorderSize = 0;
            bt_unit.FlatStyle = FlatStyle.Flat;
            bt_unit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_unit.ForeColor = Color.White;
            bt_unit.Location = new Point(13, 116);
            bt_unit.Name = "bt_unit";
            bt_unit.Size = new Size(144, 38);
            bt_unit.TabIndex = 3;
            bt_unit.Text = "Đơn vị";
            bt_unit.UseVisualStyleBackColor = true;
            bt_unit.Click += bt_unit_Click;
            // 
            // pic_unit
            // 
            pic_unit.Image = Properties.Resources.together1;
            pic_unit.Location = new Point(40, 18);
            pic_unit.Name = "pic_unit";
            pic_unit.Size = new Size(91, 82);
            pic_unit.SizeMode = PictureBoxSizeMode.Zoom;
            pic_unit.TabIndex = 2;
            pic_unit.TabStop = false;
            // 
            // pn_student
            // 
            pn_student.BackColor = Color.White;
            pn_student.BackgroundImage = Properties.Resources.Bg_icon;
            pn_student.Controls.Add(bt_student);
            pn_student.Controls.Add(pic_student);
            pn_student.Location = new Point(251, 25);
            pn_student.Name = "pn_student";
            pn_student.Size = new Size(170, 170);
            pn_student.TabIndex = 6;
            // 
            // bt_student
            // 
            bt_student.BackgroundImage = Properties.Resources.button_2;
            bt_student.FlatAppearance.BorderSize = 0;
            bt_student.FlatStyle = FlatStyle.Flat;
            bt_student.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_student.ForeColor = Color.White;
            bt_student.Location = new Point(14, 116);
            bt_student.Name = "bt_student";
            bt_student.Size = new Size(144, 38);
            bt_student.TabIndex = 2;
            bt_student.Text = "Sinh viên";
            bt_student.UseVisualStyleBackColor = true;
            bt_student.Click += bt_student_Click_1;
            // 
            // pic_student
            // 
            pic_student.Image = Properties.Resources.graduated;
            pic_student.Location = new Point(42, 18);
            pic_student.Name = "pic_student";
            pic_student.Size = new Size(91, 82);
            pic_student.SizeMode = PictureBoxSizeMode.Zoom;
            pic_student.TabIndex = 1;
            pic_student.TabStop = false;
            // 
            // pn_info
            // 
            pn_info.BackColor = Color.White;
            pn_info.BackgroundImage = Properties.Resources.Bg_icon;
            pn_info.Controls.Add(bt_info);
            pn_info.Controls.Add(pic_info);
            pn_info.Location = new Point(38, 25);
            pn_info.Name = "pn_info";
            pn_info.Size = new Size(170, 170);
            pn_info.TabIndex = 3;
            // 
            // bt_info
            // 
            bt_info.BackgroundImage = Properties.Resources.button_2;
            bt_info.FlatAppearance.BorderSize = 0;
            bt_info.FlatStyle = FlatStyle.Flat;
            bt_info.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_info.ForeColor = Color.White;
            bt_info.Location = new Point(13, 116);
            bt_info.Name = "bt_info";
            bt_info.Size = new Size(144, 38);
            bt_info.TabIndex = 1;
            bt_info.Text = "Hồ sơ cá nhân";
            bt_info.UseVisualStyleBackColor = true;
            bt_info.Click += bt_info_Click;
            // 
            // pic_info
            // 
            pic_info.Image = Properties.Resources.information_button;
            pic_info.Location = new Point(39, 18);
            pic_info.Name = "pic_info";
            pic_info.Size = new Size(91, 82);
            pic_info.SizeMode = PictureBoxSizeMode.Zoom;
            pic_info.TabIndex = 0;
            pic_info.TabStop = false;
            // 
            // Homepage_Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(pn_parents);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Homepage_Staff";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Homepage_Staff";
            pn_parents.ResumeLayout(false);
            pn_plan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_plan).EndInit();
            pn_course.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_course).EndInit();
            pn_unit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_unit).EndInit();
            pn_student.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_student).EndInit();
            pn_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_info).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pn_parents;
        private Panel pn_plan;
        private Button bt_plan;
        private PictureBox pic_plan;
        private Panel pn_course;
        private Button bt_course;
        private PictureBox pic_course;
        private Panel pn_unit;
        private Button bt_unit;
        private PictureBox pic_unit;
        private Panel pn_student;
        private Button bt_student;
        private PictureBox pic_student;
        private Panel pn_info;
        private Button bt_info;
        private PictureBox pic_info;
    }
}