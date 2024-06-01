namespace ATBM_PhanHe1.PhanHe2
{
    partial class View_InfoRegister
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
            bt_delete = new Button();
            cbB_program = new ComboBox();
            lb_program = new Label();
            cbB_semester = new ComboBox();
            tb_year = new TextBox();
            lb_year = new Label();
            pic_refresh_U = new PictureBox();
            btn_search = new Button();
            btn_Add = new Button();
            btn_Update = new Button();
            dataGridView1 = new DataGridView();
            btn_Back = new Button();
            lb_semester = new Label();
            lb_Info = new Label();
            pn_parents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_refresh_U).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pn_parents
            // 
            pn_parents.Controls.Add(bt_delete);
            pn_parents.Controls.Add(cbB_program);
            pn_parents.Controls.Add(lb_program);
            pn_parents.Controls.Add(cbB_semester);
            pn_parents.Controls.Add(tb_year);
            pn_parents.Controls.Add(lb_year);
            pn_parents.Controls.Add(pic_refresh_U);
            pn_parents.Controls.Add(btn_search);
            pn_parents.Controls.Add(btn_Add);
            pn_parents.Controls.Add(btn_Update);
            pn_parents.Controls.Add(dataGridView1);
            pn_parents.Controls.Add(btn_Back);
            pn_parents.Controls.Add(lb_semester);
            pn_parents.Controls.Add(lb_Info);
            pn_parents.Location = new Point(0, 0);
            pn_parents.Name = "pn_parents";
            pn_parents.Size = new Size(895, 425);
            pn_parents.TabIndex = 4;
            // 
            // bt_delete
            // 
            bt_delete.BackColor = Color.White;
            bt_delete.BackgroundImage = Properties.Resources.button_round2;
            bt_delete.FlatAppearance.BorderSize = 0;
            bt_delete.FlatStyle = FlatStyle.Flat;
            bt_delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bt_delete.ForeColor = SystemColors.Window;
            bt_delete.Location = new Point(374, 373);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(91, 38);
            bt_delete.TabIndex = 114;
            bt_delete.Text = "Xóa";
            bt_delete.UseVisualStyleBackColor = false;
            bt_delete.Click += bt_delete_Click;
            // 
            // cbB_program
            // 
            cbB_program.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_program.FormattingEnabled = true;
            cbB_program.Items.AddRange(new object[] { "1", "2", "3" });
            cbB_program.Location = new Point(508, 50);
            cbB_program.Name = "cbB_program";
            cbB_program.Size = new Size(197, 36);
            cbB_program.TabIndex = 113;
            // 
            // lb_program
            // 
            lb_program.AutoSize = true;
            lb_program.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_program.Location = new Point(374, 53);
            lb_program.Name = "lb_program";
            lb_program.Size = new Size(128, 28);
            lb_program.TabIndex = 112;
            lb_program.Text = "Chương trình";
            // 
            // cbB_semester
            // 
            cbB_semester.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_semester.FormattingEnabled = true;
            cbB_semester.Items.AddRange(new object[] { "1", "2", "3" });
            cbB_semester.Location = new Point(102, 50);
            cbB_semester.Name = "cbB_semester";
            cbB_semester.Size = new Size(60, 36);
            cbB_semester.TabIndex = 111;
            // 
            // tb_year
            // 
            tb_year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_year.Location = new Point(242, 50);
            tb_year.Name = "tb_year";
            tb_year.Size = new Size(105, 34);
            tb_year.TabIndex = 110;
            tb_year.TabStop = false;
            // 
            // lb_year
            // 
            lb_year.AutoSize = true;
            lb_year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_year.Location = new Point(182, 53);
            lb_year.Name = "lb_year";
            lb_year.Size = new Size(54, 28);
            lb_year.TabIndex = 109;
            lb_year.Text = "Năm";
            // 
            // pic_refresh_U
            // 
            pic_refresh_U.Image = Properties.Resources.refresh_buttons;
            pic_refresh_U.Location = new Point(719, 48);
            pic_refresh_U.Name = "pic_refresh_U";
            pic_refresh_U.Size = new Size(49, 39);
            pic_refresh_U.SizeMode = PictureBoxSizeMode.Zoom;
            pic_refresh_U.TabIndex = 108;
            pic_refresh_U.TabStop = false;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.White;
            btn_search.BackgroundImage = Properties.Resources.button_round2;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_search.ForeColor = SystemColors.Window;
            btn_search.Location = new Point(776, 49);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(91, 38);
            btn_search.TabIndex = 107;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.White;
            btn_Add.BackgroundImage = Properties.Resources.button_round2;
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Add.ForeColor = SystemColors.Window;
            btn_Add.Location = new Point(508, 373);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(91, 38);
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
            btn_Update.Location = new Point(645, 373);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(91, 38);
            btn_Update.TabIndex = 105;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(843, 262);
            dataGridView1.TabIndex = 104;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round2;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(776, 373);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 103;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // lb_semester
            // 
            lb_semester.AutoSize = true;
            lb_semester.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_semester.Location = new Point(24, 53);
            lb_semester.Name = "lb_semester";
            lb_semester.Size = new Size(72, 28);
            lb_semester.TabIndex = 101;
            lb_semester.Text = "Học kỳ";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(308, 9);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(305, 31);
            lb_Info.TabIndex = 100;
            lb_Info.Text = "Thông tin đăng ký học phần";
            // 
            // View_InfoRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(pn_parents);
            FormBorderStyle = FormBorderStyle.None;
            Name = "View_InfoRegister";
            StartPosition = FormStartPosition.CenterParent;
            Text = "View_InfoRegister";
            pn_parents.ResumeLayout(false);
            pn_parents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_refresh_U).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_parents;
        private ComboBox cbB_program;
        private Label lb_program;
        private ComboBox cbB_semester;
        private TextBox tb_year;
        private Label lb_year;
        private PictureBox pic_refresh_U;
        private Button btn_search;
        private Button btn_Add;
        private Button btn_Update;
        private DataGridView dataGridView1;
        private Button btn_Back;
        private Label lb_semester;
        private Label lb_Info;
        private Button bt_delete;
    }
}