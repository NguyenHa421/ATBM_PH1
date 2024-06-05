namespace ATBM_PhanHe1.PhanHe2
{
    partial class Confirm_Update
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
            lb_Confirm = new Label();
            btn_Confirm = new Button();
            btn_Cancel = new Button();
            SuspendLayout();
            // 
            // lb_Confirm
            // 
            lb_Confirm.AutoSize = true;
            lb_Confirm.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Confirm.Location = new Point(88, 74);
            lb_Confirm.Name = "lb_Confirm";
            lb_Confirm.Size = new Size(314, 31);
            lb_Confirm.TabIndex = 23;
            lb_Confirm.Text = "Xác nhận cập nhật thông tin?";
            // 
            // btn_Confirm
            // 
            btn_Confirm.BackColor = Color.White;
            btn_Confirm.BackgroundImage = Properties.Resources.button_round2;
            btn_Confirm.FlatAppearance.BorderSize = 0;
            btn_Confirm.FlatStyle = FlatStyle.Flat;
            btn_Confirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Confirm.ForeColor = SystemColors.Window;
            btn_Confirm.Location = new Point(283, 157);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new Size(91, 38);
            btn_Confirm.TabIndex = 44;
            btn_Confirm.Text = "Xác nhận";
            btn_Confirm.UseVisualStyleBackColor = false;
            btn_Confirm.Click += btn_Confirm_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = Color.White;
            btn_Cancel.BackgroundImage = Properties.Resources.button_round2;
            btn_Cancel.FlatAppearance.BorderSize = 0;
            btn_Cancel.FlatStyle = FlatStyle.Flat;
            btn_Cancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Cancel.ForeColor = SystemColors.Window;
            btn_Cancel.Location = new Point(103, 157);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(91, 38);
            btn_Cancel.TabIndex = 43;
            btn_Cancel.Text = "Hủy";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // Confirm_Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg_confirm;
            ClientSize = new Size(485, 240);
            Controls.Add(btn_Confirm);
            Controls.Add(btn_Cancel);
            Controls.Add(lb_Confirm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Confirm_Update";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Confirm_Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Confirm;
        private Button btn_Confirm;
        private Button btn_Cancel;
    }
}