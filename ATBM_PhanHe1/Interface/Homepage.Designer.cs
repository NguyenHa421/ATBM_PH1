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
            pn_main = new Panel();
            dtGrid_main = new DataGridView();
            tb_search = new TextBox();
            pic_search = new PictureBox();
            pic_khtn = new PictureBox();
            lab_dstknd = new Label();
            btn_search = new Button();
            pn_dstk = new Panel();
            btn_dstk = new Button();
            label2 = new Label();
            pic_logout = new PictureBox();
            pn_qlur = new Panel();
            btn_qlur = new Button();
            pn_qlq = new Panel();
            btn_qlq = new Button();
            pn_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_khtn).BeginInit();
            pn_dstk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logout).BeginInit();
            pn_qlur.SuspendLayout();
            pn_qlq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrid_main).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_search).BeginInit();
            SuspendLayout();
            // 
            // pn_main
            // 
            pn_main.BackColor = SystemColors.Window;
            pn_main.Controls.Add(pn_main);
            pn_main.Location = new Point(220, 54);
            pn_main.Name = "pn_main";
            pn_main.Size = new Size(739, 536);
            pn_main.TabIndex = 0;
            // 
            // pn_dstk
            // 
            pn_dstk.BackColor = Color.FromArgb(177, 213, 246);
            pn_dstk.Controls.Add(btn_dstk);
            pn_dstk.Controls.Add(label2);
            pn_dstk.Location = new Point(0, 254);
            pn_dstk.Name = "pn_dstk";
            pn_dstk.Size = new Size(220, 76);
            pn_dstk.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 21);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 0;
            // 
            // pic_logout
            // 
            pic_logout.Image = Properties.Resources.Exit;
            pic_logout.Location = new Point(902, 9);
            pic_logout.Name = "pic_logout";
            pic_logout.Size = new Size(43, 36);
            pic_logout.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logout.TabIndex = 3;
            pic_logout.TabStop = false;
            pic_logout.Click += pic_logout_Click;
            // 
            // pn_qlur
            // 
            pn_qlur.BackColor = Color.FromArgb(42, 107, 167);
            pn_qlur.Controls.Add(btn_qlur);
            pn_qlur.Location = new Point(0, 331);
            pn_qlur.Name = "pn_qlur";
            pn_qlur.Size = new Size(220, 76);
            pn_qlur.TabIndex = 3;
            // 
            // pn_qlq
            // 
            pn_qlq.BackColor = Color.FromArgb(42, 107, 167);
            pn_qlq.Controls.Add(btn_qlq);
            pn_qlq.Location = new Point(0, 408);
            pn_qlq.Name = "pn_qlq";
            pn_qlq.Size = new Size(220, 76);
            pn_qlq.TabIndex = 4;
            // 
            // dtGrid_main
            // 
            dtGrid_main.BackgroundColor = Color.WhiteSmoke;
            dtGrid_main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_main.Location = new Point(34, 121);
            dtGrid_main.Name = "dtGrid_main";
            dtGrid_main.RowHeadersWidth = 51;
            dtGrid_main.Size = new Size(676, 394);
            dtGrid_main.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(tb_search);
            panel5.Controls.Add(pic_search);
            panel5.Location = new Point(34, 67);
            panel5.Name = "panel5";
            panel5.Size = new Size(567, 38);
            panel5.TabIndex = 15;
            // 
            // tb_search
            // 
            tb_search.BackColor = Color.WhiteSmoke;
            tb_search.BorderStyle = BorderStyle.None;
            tb_search.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_search.Location = new Point(52, 7);
            tb_search.Name = "tb_search";
            tb_search.PlaceholderText = "Nhập tên ...";
            tb_search.Size = new Size(510, 23);
            tb_search.TabIndex = 1;
            // 
            // pic_search
            // 
            pic_search.Image = Properties.Resources.Search1;
            pic_search.Location = new Point(3, 3);
            pic_search.Name = "pic_search";
            pic_search.Size = new Size(43, 30);
            pic_search.SizeMode = PictureBoxSizeMode.Zoom;
            pic_search.TabIndex = 0;
            pic_search.TabStop = false;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.White;
            btn_search.BackgroundImage = Properties.Resources.button_round2;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_search.ForeColor = SystemColors.Window;
            btn_search.Location = new Point(619, 67);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(91, 38);
            btn_search.TabIndex = 14;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = false;
            // 
            // lab_dstknd
            // 
            lab_dstknd.AutoSize = true;
            lab_dstknd.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lab_dstknd.Location = new Point(160, 22);
            lab_dstknd.Name = "lab_dstknd";
            lab_dstknd.Size = new Size(427, 31);
            lab_dstknd.TabIndex = 13;
            lab_dstknd.Text = "DANH SÁCH TÀI KHOẢN NGƯỜI DÙNG";
            lab_dstknd.TextAlign = ContentAlignment.TopCenter;
            // 
            // pic_khtn
            // 
            pic_khtn.Image = Properties.Resources.logo2;
            pic_khtn.Location = new Point(28, 28);
            pic_khtn.Name = "pic_khtn";
            pic_khtn.Size = new Size(170, 155);
            pic_khtn.SizeMode = PictureBoxSizeMode.Zoom;
            pic_khtn.TabIndex = 1;
            pic_khtn.TabStop = false;
            // 
            // pn_dstk
            // 
            pn_dstk.BackColor = Color.FromArgb(177, 213, 246);
            pn_dstk.Controls.Add(btn_dstk);
            pn_dstk.Controls.Add(label2);
            pn_dstk.Location = new Point(0, 254);
            pn_dstk.Name = "pn_dstk";
            pn_dstk.Size = new Size(220, 76);
            pn_dstk.TabIndex = 2;
            // 
            // btn_dstk
            // 
            btn_dstk.BackColor = Color.FromArgb(177, 213, 246);
            btn_dstk.FlatAppearance.BorderColor = Color.FromArgb(177, 213, 246);
            btn_dstk.FlatAppearance.BorderSize = 0;
            btn_dstk.FlatStyle = FlatStyle.Flat;
            btn_dstk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dstk.ForeColor = Color.Black;
            btn_dstk.Location = new Point(0, 9);
            btn_dstk.Name = "btn_dstk";
            btn_dstk.Size = new Size(218, 56);
            btn_dstk.TabIndex = 5;
            btn_dstk.Text = "Danh sách tài khoản";
            btn_dstk.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 21);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 0;
            // 
            // pic_logout
            // 
            pic_logout.Image = Properties.Resources.Exit;
            pic_logout.Location = new Point(902, 9);
            pic_logout.Name = "pic_logout";
            pic_logout.Size = new Size(43, 36);
            pic_logout.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logout.TabIndex = 3;
            pic_logout.TabStop = false;
            pic_logout.Click += pic_logout_Click;
            // 
            // pn_qlur
            // 
            pn_qlur.BackColor = Color.FromArgb(42, 107, 167);
            pn_qlur.Controls.Add(btn_qlur);
            pn_qlur.Location = new Point(0, 331);
            pn_qlur.Name = "pn_qlur";
            pn_qlur.Size = new Size(220, 76);
            pn_qlur.TabIndex = 3;
            // 
            // btn_qlur
            // 
            btn_qlur.BackColor = Color.FromArgb(42, 107, 167);
            btn_qlur.FlatAppearance.BorderColor = Color.FromArgb(177, 213, 246);
            btn_qlur.FlatAppearance.BorderSize = 0;
            btn_qlur.FlatStyle = FlatStyle.Flat;
            btn_qlur.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_qlur.ForeColor = Color.Transparent;
            btn_qlur.Location = new Point(1, 10);
            btn_qlur.Name = "btn_qlur";
            btn_qlur.Size = new Size(218, 56);
            btn_qlur.TabIndex = 6;
            btn_qlur.Text = "Quản lý User/Role";
            btn_qlur.UseVisualStyleBackColor = false;
            // 
            // pn_qlq
            // 
            pn_qlq.BackColor = Color.FromArgb(42, 107, 167);
            pn_qlq.Controls.Add(btn_qlq);
            pn_qlq.Location = new Point(0, 408);
            pn_qlq.Name = "pn_qlq";
            pn_qlq.Size = new Size(220, 76);
            pn_qlq.TabIndex = 4;
            // 
            // btn_qlq
            // 
            btn_qlq.BackColor = Color.FromArgb(42, 107, 167);
            btn_qlq.FlatAppearance.BorderColor = Color.FromArgb(177, 213, 246);
            btn_qlq.FlatAppearance.BorderSize = 0;
            btn_qlq.FlatStyle = FlatStyle.Flat;
            btn_qlq.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_qlq.ForeColor = Color.Transparent;
            btn_qlq.Location = new Point(1, 10);
            btn_qlq.Name = "btn_qlq";
            btn_qlq.Size = new Size(218, 56);
            btn_qlq.TabIndex = 7;
            btn_qlq.Text = "Quản lý quyền";
            btn_qlq.UseVisualStyleBackColor = false;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 107, 167);
            ClientSize = new Size(957, 590);
            Controls.Add(pn_qlq);
            Controls.Add(pn_qlur);
            Controls.Add(pic_logout);
            Controls.Add(pn_dstk);
            Controls.Add(pic_khtn);
            Controls.Add(pn_main);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Người Dùng";
            Load += Homepage_Load_1;
            pn_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_khtn).EndInit();
            pn_dstk.ResumeLayout(false);
            pn_dstk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logout).EndInit();
            pn_qlur.ResumeLayout(false);
            pn_qlq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGrid_main).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_search).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_main;
        private PictureBox pic_khtn;
        private Panel pn_dstk;
        private Label label2;
        private PictureBox pic_logout;
        private Panel pn_qlur;
        private Panel pn_qlq;
        private Panel panel5;
        private PictureBox pic_search;
        private TextBox tb_search;
        private Button btn_search;
        private DataGridView dtGrid_main;
        private Label lab_dstknd;
        private Button btn_dstk;
        private Button btn_qlur;
        private Button btn_qlq;
    }
}