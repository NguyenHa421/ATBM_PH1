namespace ATBM_PhanHe1.PhanHe2
{
    partial class View_InfoPlanCourses
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
            cbB_program = new ComboBox();
            lb_program = new Label();
            cbB_semester = new ComboBox();
            tb_year = new TextBox();
            lb_year = new Label();
            pic_refresh_U = new PictureBox();
            btn_search = new Button();
            btn_Add = new Button();
            btn_Update = new Button();
            dtGrid_planCourses = new DataGridView();
            btn_Back = new Button();
            lb_semester = new Label();
            lb_Info = new Label();
            pn_parents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_refresh_U).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_planCourses).BeginInit();
            SuspendLayout();
            // 
            // pn_parents
            // 
            pn_parents.Controls.Add(cbB_program);
            pn_parents.Controls.Add(lb_program);
            pn_parents.Controls.Add(cbB_semester);
            pn_parents.Controls.Add(tb_year);
            pn_parents.Controls.Add(lb_year);
            pn_parents.Controls.Add(pic_refresh_U);
            pn_parents.Controls.Add(btn_search);
            pn_parents.Controls.Add(btn_Add);
            pn_parents.Controls.Add(btn_Update);
            pn_parents.Controls.Add(dtGrid_planCourses);
            pn_parents.Controls.Add(btn_Back);
            pn_parents.Controls.Add(lb_semester);
            pn_parents.Controls.Add(lb_Info);
            pn_parents.Location = new Point(0, 0);
            pn_parents.Margin = new Padding(3, 2, 3, 2);
            pn_parents.Name = "pn_parents";
            pn_parents.Size = new Size(783, 319);
            pn_parents.TabIndex = 2;
            // 
            // cbB_program
            // 
            cbB_program.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_program.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_program.FormattingEnabled = true;
            cbB_program.Location = new Point(444, 38);
            cbB_program.Margin = new Padding(3, 2, 3, 2);
            cbB_program.Name = "cbB_program";
            cbB_program.Size = new Size(173, 29);
            cbB_program.TabIndex = 113;
            // 
            // lb_program
            // 
            lb_program.AutoSize = true;
            lb_program.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_program.Location = new Point(327, 40);
            lb_program.Name = "lb_program";
            lb_program.Size = new Size(103, 21);
            lb_program.TabIndex = 112;
            lb_program.Text = "Chương trình";
            // 
            // cbB_semester
            // 
            cbB_semester.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_semester.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_semester.FormattingEnabled = true;
            cbB_semester.Location = new Point(89, 38);
            cbB_semester.Margin = new Padding(3, 2, 3, 2);
            cbB_semester.Name = "cbB_semester";
            cbB_semester.Size = new Size(53, 29);
            cbB_semester.TabIndex = 111;
            // 
            // tb_year
            // 
            tb_year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_year.Location = new Point(212, 38);
            tb_year.Margin = new Padding(3, 2, 3, 2);
            tb_year.Name = "tb_year";
            tb_year.Size = new Size(92, 29);
            tb_year.TabIndex = 110;
            tb_year.TabStop = false;
            // 
            // lb_year
            // 
            lb_year.AutoSize = true;
            lb_year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_year.Location = new Point(159, 40);
            lb_year.Name = "lb_year";
            lb_year.Size = new Size(44, 21);
            lb_year.TabIndex = 109;
            lb_year.Text = "Năm";
            // 
            // pic_refresh_U
            // 
            pic_refresh_U.Image = Properties.Resources.refresh_buttons;
            pic_refresh_U.Location = new Point(629, 36);
            pic_refresh_U.Margin = new Padding(3, 2, 3, 2);
            pic_refresh_U.Name = "pic_refresh_U";
            pic_refresh_U.Size = new Size(43, 29);
            pic_refresh_U.SizeMode = PictureBoxSizeMode.Zoom;
            pic_refresh_U.TabIndex = 108;
            pic_refresh_U.TabStop = false;
            pic_refresh_U.Click += pic_refresh_U_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.White;
            btn_search.BackgroundImage = Properties.Resources.button_round2;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_search.ForeColor = SystemColors.Window;
            btn_search.Location = new Point(679, 37);
            btn_search.Margin = new Padding(3, 2, 3, 2);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(80, 28);
            btn_search.TabIndex = 107;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.White;
            btn_Add.BackgroundImage = Properties.Resources.button_round2;
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Add.ForeColor = SystemColors.Window;
            btn_Add.Location = new Point(444, 280);
            btn_Add.Margin = new Padding(3, 2, 3, 2);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(80, 28);
            btn_Add.TabIndex = 106;
            btn_Add.Text = "Tạo mới";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.White;
            btn_Update.BackgroundImage = Properties.Resources.button_round2;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Update.ForeColor = SystemColors.Window;
            btn_Update.Location = new Point(564, 280);
            btn_Update.Margin = new Padding(3, 2, 3, 2);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(80, 28);
            btn_Update.TabIndex = 105;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // dtGrid_planCourses
            // 
            dtGrid_planCourses.BackgroundColor = SystemColors.Control;
            dtGrid_planCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_planCourses.Location = new Point(21, 76);
            dtGrid_planCourses.Margin = new Padding(3, 2, 3, 2);
            dtGrid_planCourses.Name = "dtGrid_planCourses";
            dtGrid_planCourses.RowHeadersWidth = 51;
            dtGrid_planCourses.Size = new Size(738, 196);
            dtGrid_planCourses.TabIndex = 104;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round2;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(679, 280);
            btn_Back.Margin = new Padding(3, 2, 3, 2);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(80, 28);
            btn_Back.TabIndex = 103;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // lb_semester
            // 
            lb_semester.AutoSize = true;
            lb_semester.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_semester.Location = new Point(21, 40);
            lb_semester.Name = "lb_semester";
            lb_semester.Size = new Size(57, 21);
            lb_semester.TabIndex = 101;
            lb_semester.Text = "Học kỳ";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(302, 7);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(169, 25);
            lb_Info.TabIndex = 100;
            lb_Info.Text = "Kế hoạch mở môn";
            // 
            // View_InfoPlanCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(783, 319);
            Controls.Add(pn_parents);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "View_InfoPlanCourses";
            StartPosition = FormStartPosition.CenterParent;
            Text = "View_InfoPlanCourses";
            pn_parents.ResumeLayout(false);
            pn_parents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_refresh_U).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_planCourses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_parents;
        private PictureBox pic_refresh_U;
        private Button btn_search;
        private Button btn_Add;
        private Button btn_Update;
        private DataGridView dtGrid_planCourses;
        private Button btn_Back;
        private Label lb_semester;
        private Label lb_Info;
        private TextBox tb_year;
        private Label lb_year;
        private ComboBox cbB_program;
        private Label lb_program;
        private ComboBox cbB_semester;
    }
}