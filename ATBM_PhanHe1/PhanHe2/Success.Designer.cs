namespace ATBM_PhanHe1.PhanHe2
{
    partial class Success
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
            btn_Back = new Button();
            lb_Confirm = new Label();
            SuspendLayout();
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round2;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(194, 141);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 49;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // lb_Confirm
            // 
            lb_Confirm.AutoSize = true;
            lb_Confirm.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Confirm.Location = new Point(164, 61);
            lb_Confirm.Name = "lb_Confirm";
            lb_Confirm.Size = new Size(143, 31);
            lb_Confirm.TabIndex = 48;
            lb_Confirm.Text = "Thành công!";
            // 
            // Success
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg_confirm;
            ClientSize = new Size(485, 240);
            Controls.Add(btn_Back);
            Controls.Add(lb_Confirm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Success";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Success";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Back;
        private Label lb_Confirm;
    }
}