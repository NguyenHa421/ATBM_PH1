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
            pic_logo = new PictureBox();
            lb_main = new Label();
            label2 = new Label();
            label3 = new Label();
            tB_name = new TextBox();
            tB_pass = new TextBox();
            Login_button = new Button();
            pic_close = new PictureBox();
            pic_hide = new PictureBox();
            pic_show = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_hide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_show).BeginInit();
            SuspendLayout();
            // 
            // pic_logo
            // 
            pic_logo.BackColor = Color.White;
            pic_logo.Image = Properties.Resources.Home_Pic1;
            pic_logo.Location = new Point(77, 158);
            pic_logo.Margin = new Padding(3, 4, 3, 4);
            pic_logo.Name = "pic_logo";
            pic_logo.Size = new Size(383, 287);
            pic_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logo.TabIndex = 0;
            pic_logo.TabStop = false;
            // 
            // lb_main
            // 
            lb_main.AutoSize = true;
            lb_main.BackColor = Color.White;
            lb_main.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_main.ForeColor = Color.FromArgb(42, 107, 167);
            lb_main.Location = new Point(384, 63);
            lb_main.Name = "lb_main";
            lb_main.Size = new Size(230, 54);
            lb_main.TabIndex = 1;
            lb_main.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(537, 179);
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
            label3.Location = new Point(537, 315);
            label3.Name = "label3";
            label3.Size = new Size(110, 31);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // tB_name
            // 
            tB_name.BorderStyle = BorderStyle.FixedSingle;
            tB_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tB_name.Location = new Point(537, 229);
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
            tB_pass.Location = new Point(537, 367);
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
            Login_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_button.ForeColor = Color.White;
            Login_button.Location = new Point(685, 452);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(164, 60);
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
            pic_close.Location = new Point(855, 40);
            pic_close.Margin = new Padding(3, 4, 3, 4);
            pic_close.Name = "pic_close";
            pic_close.Size = new Size(49, 48);
            pic_close.SizeMode = PictureBoxSizeMode.Zoom;
            pic_close.TabIndex = 7;
            pic_close.TabStop = false;
            pic_close.Click += pic_close_Click;
            // 
            // pic_hide
            // 
            pic_hide.BackColor = Color.White;
            pic_hide.Image = Properties.Resources.eye;
            pic_hide.Location = new Point(811, 369);
            pic_hide.Margin = new Padding(3, 4, 3, 4);
            pic_hide.Name = "pic_hide";
            pic_hide.Size = new Size(37, 34);
            pic_hide.SizeMode = PictureBoxSizeMode.Zoom;
            pic_hide.TabIndex = 8;
            pic_hide.TabStop = false;
            pic_hide.Click += pic_hide_Click;
            // 
            // pic_show
            // 
            pic_show.BackColor = Color.White;
            pic_show.Image = Properties.Resources.visual;
            pic_show.Location = new Point(811, 369);
            pic_show.Margin = new Padding(3, 4, 3, 4);
            pic_show.Name = "pic_show";
            pic_show.Size = new Size(37, 34);
            pic_show.SizeMode = PictureBoxSizeMode.Zoom;
            pic_show.TabIndex = 9;
            pic_show.TabStop = false;
            pic_show.Click += pic_show_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 107, 167);
            BackgroundImage = Properties.Resources.Background1;
            ClientSize = new Size(957, 590);
            Controls.Add(pic_show);
            Controls.Add(pic_hide);
            Controls.Add(pic_close);
            Controls.Add(Login_button);
            Controls.Add(tB_pass);
            Controls.Add(tB_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lb_main);
            Controls.Add(pic_logo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pic_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_hide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_logo;
        private Label lb_main;
        private Label label2;
        private Label label3;
        private TextBox tB_name;
        private TextBox tB_pass;
        private Button Login_button;
        private PictureBox pic_close;
        private PictureBox pic_hide;
        private PictureBox pic_show;
    }
}