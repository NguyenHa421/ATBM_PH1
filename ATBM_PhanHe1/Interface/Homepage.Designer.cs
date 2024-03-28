namespace ATBM_PhanHe1.Interface
{
    partial class Homepage
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            btn_search = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(btn_search);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(220, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 536);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(676, 394);
            dataGridView1.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(37, 58);
            panel5.Name = "panel5";
            panel5.Size = new Size(567, 38);
            panel5.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(52, 7);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập tên ...";
            textBox1.Size = new Size(510, 23);
            textBox1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Search1;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.White;
            btn_search.BackgroundImage = Properties.Resources.button_round2;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_search.ForeColor = SystemColors.Window;
            btn_search.Location = new Point(622, 58);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(91, 38);
            btn_search.TabIndex = 2;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(163, 13);
            label1.Name = "label1";
            label1.Size = new Size(427, 31);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH TÀI KHOẢN NGƯỜI DÙNG";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo2;
            pictureBox1.Location = new Point(28, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(177, 213, 246);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 254);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 76);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 21);
            label2.Name = "label2";
            label2.Size = new Size(205, 28);
            label2.TabIndex = 0;
            label2.Text = "Danh sách tài khoản";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Exit;
            pictureBox2.Location = new Point(902, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(42, 107, 167);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(0, 331);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 76);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 21);
            label3.Name = "label3";
            label3.Size = new Size(184, 28);
            label3.TabIndex = 0;
            label3.Text = "Quản lý User/Role";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(42, 107, 167);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(0, 408);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 76);
            panel4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 21);
            label4.Name = "label4";
            label4.Size = new Size(149, 28);
            label4.TabIndex = 0;
            label4.Text = "Quản lý quyền";
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 107, 167);
            ClientSize = new Size(957, 590);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Người Dùng";
            Load += Homepage_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_search;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private PictureBox pictureBox3;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}