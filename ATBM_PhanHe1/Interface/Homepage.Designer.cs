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
            label1 = new Label();
            tb_search = new TextBox();
            btn_search = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(btn_search);
            panel1.Controls.Add(tb_search);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(178, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 405);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(131, 23);
            label1.Name = "label1";
            label1.Size = new Size(447, 27);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH TÀI KHOẢN NGƯỜI DÙNG";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tb_search
            // 
            tb_search.Location = new Point(30, 67);
            tb_search.Name = "tb_search";
            tb_search.PlaceholderText = "Nhập tên...";
            tb_search.Size = new Size(548, 27);
            tb_search.TabIndex = 1;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.FromArgb(42, 107, 167);
            btn_search.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_search.ForeColor = SystemColors.Window;
            btn_search.Location = new Point(584, 66);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(108, 29);
            btn_search.TabIndex = 2;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = false;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 107, 167);
            ClientSize = new Size(882, 453);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Người Dùng";
            Load += Homepage_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox tb_search;
        private Button btn_search;
    }
}