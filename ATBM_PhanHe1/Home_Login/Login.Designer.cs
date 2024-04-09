namespace ATBM_PhanHe1.Home_Login
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tB_name = new TextBox();
            tB_pass = new TextBox();
            Login_button = new Button();
            pic_close = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_close).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.Home_Pic1;
            pictureBox1.Location = new Point(77, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(42, 107, 167);
            label1.Location = new Point(386, 55);
            label1.Name = "label1";
            label1.Size = new Size(230, 54);
            label1.TabIndex = 1;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(549, 174);
            label2.Name = "label2";
            label2.Size = new Size(117, 31);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(549, 306);
            label3.Name = "label3";
            label3.Size = new Size(110, 31);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // tB_name
            // 
            tB_name.BorderStyle = BorderStyle.FixedSingle;
            tB_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tB_name.Location = new Point(549, 225);
            tB_name.Name = "tB_name";
            tB_name.PlaceholderText = "   Username";
            tB_name.Size = new Size(312, 38);
            tB_name.TabIndex = 4;
            tB_name.TabStop = false;
            // 
            // tB_pass
            // 
            tB_pass.BorderStyle = BorderStyle.FixedSingle;
            tB_pass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tB_pass.Location = new Point(549, 361);
            tB_pass.Name = "tB_pass";
            tB_pass.PlaceholderText = "   Password";
            tB_pass.Size = new Size(312, 38);
            tB_pass.TabIndex = 5;
            tB_pass.TabStop = false;
            // 
            // Login_button
            // 
            Login_button.BackColor = Color.White;
            Login_button.BackgroundImage = Properties.Resources.b_r;
            Login_button.BackgroundImageLayout = ImageLayout.Zoom;
            Login_button.FlatStyle = FlatStyle.Flat;
            Login_button.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_button.ForeColor = Color.White;
            Login_button.Location = new Point(699, 453);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(162, 64);
            Login_button.TabIndex = 6;
            Login_button.TabStop = false;
            Login_button.Text = "Đăng nhập";
            Login_button.UseVisualStyleBackColor = false;
            Login_button.Click += Login_button_Click;
            // 
            // pic_close
            // 
            pic_close.BackColor = Color.White;
            pic_close.Image = Properties.Resources.Exit1;
            pic_close.Location = new Point(859, 41);
            pic_close.Name = "pic_close";
            pic_close.Size = new Size(43, 36);
            pic_close.SizeMode = PictureBoxSizeMode.Zoom;
            pic_close.TabIndex = 7;
            pic_close.TabStop = false;
            pic_close.Click += pic_close_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 107, 167);
            BackgroundImage = Properties.Resources.Background1;
            ClientSize = new Size(957, 590);
            Controls.Add(pic_close);
            Controls.Add(Login_button);
            Controls.Add(tB_pass);
            Controls.Add(tB_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_close).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tB_name;
        private TextBox tB_pass;
        private Button Login_button;
        private PictureBox pic_close;
    }
}