namespace ATBM_PhanHe1.PhanHe2
{
    partial class Homepage_Student
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
            pn_info = new Panel();
            bt_info = new Button();
            pic_info = new PictureBox();
            pn_course = new Panel();
            bt_course = new Button();
            pic_course = new PictureBox();
            pn_plan = new Panel();
            bt_plan = new Button();
            pic_plan = new PictureBox();
            bt_register = new Button();
            pn_register = new Panel();
            pic_register = new PictureBox();
            pn_parents.SuspendLayout();
            pn_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_info).BeginInit();
            pn_course.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_course).BeginInit();
            pn_plan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_plan).BeginInit();
            pn_register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_register).BeginInit();
            SuspendLayout();
            // 
            // pn_parents
            // 
            pn_parents.Controls.Add(pn_info);
            pn_parents.Controls.Add(pn_course);
            pn_parents.Controls.Add(pn_plan);
            pn_parents.Controls.Add(pn_register);
            pn_parents.Location = new Point(0, 0);
            pn_parents.Name = "pn_parents";
            pn_parents.Size = new Size(895, 425);
            pn_parents.TabIndex = 0;
            // 
            // pn_info
            // 
            pn_info.BackColor = Color.White;
            pn_info.BackgroundImage = Properties.Resources.Bg_icon;
            pn_info.Controls.Add(bt_info);
            pn_info.Controls.Add(pic_info);
            pn_info.Location = new Point(41, 27);
            pn_info.Name = "pn_info";
            pn_info.Size = new Size(170, 170);
            pn_info.TabIndex = 22;
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
            // pn_course
            // 
            pn_course.BackColor = Color.White;
            pn_course.BackgroundImage = Properties.Resources.Bg_icon;
            pn_course.Controls.Add(bt_course);
            pn_course.Controls.Add(pic_course);
            pn_course.Location = new Point(254, 27);
            pn_course.Name = "pn_course";
            pn_course.Size = new Size(170, 170);
            pn_course.TabIndex = 23;
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
            // pn_plan
            // 
            pn_plan.BackColor = Color.White;
            pn_plan.BackgroundImage = Properties.Resources.Bg_icon;
            pn_plan.Controls.Add(bt_plan);
            pn_plan.Controls.Add(pic_plan);
            pn_plan.Location = new Point(472, 27);
            pn_plan.Name = "pn_plan";
            pn_plan.Size = new Size(170, 170);
            pn_plan.TabIndex = 24;
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
            // bt_register
            // 
            bt_register.BackgroundImage = Properties.Resources.button_2;
            bt_register.FlatAppearance.BorderSize = 0;
            bt_register.FlatStyle = FlatStyle.Flat;
            bt_register.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_register.ForeColor = Color.White;
            bt_register.Location = new Point(13, 115);
            bt_register.Name = "bt_register";
            bt_register.Size = new Size(144, 38);
            bt_register.TabIndex = 5;
            bt_register.Text = "Đăng ký";
            bt_register.UseVisualStyleBackColor = true;
            // 
            // pn_register
            // 
            pn_register.BackColor = Color.White;
            pn_register.BackgroundImage = Properties.Resources.Bg_icon;
            pn_register.Controls.Add(bt_register);
            pn_register.Controls.Add(pic_register);
            pn_register.Location = new Point(688, 27);
            pn_register.Name = "pn_register";
            pn_register.Size = new Size(170, 170);
            pn_register.TabIndex = 25;
            // 
            // pic_register
            // 
            pic_register.Image = Properties.Resources.document;
            pic_register.Location = new Point(38, 21);
            pic_register.Name = "pic_register";
            pic_register.Size = new Size(91, 82);
            pic_register.SizeMode = PictureBoxSizeMode.Zoom;
            pic_register.TabIndex = 4;
            pic_register.TabStop = false;
            // 
            // Homepage_Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(pn_parents);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Homepage_Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homepage_Student";
            pn_parents.ResumeLayout(false);
            pn_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_info).EndInit();
            pn_course.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_course).EndInit();
            pn_plan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_plan).EndInit();
            pn_register.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_register).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_parents;
        private Panel pn_info;
        private Button bt_info;
        private PictureBox pic_info;
        private Panel pn_course;
        private Button bt_course;
        private PictureBox pic_course;
        private Panel pn_plan;
        private Button bt_plan;
        private PictureBox pic_plan;
        private Panel pn_register;
        private Button bt_register;
        private PictureBox pic_register;
    }
}