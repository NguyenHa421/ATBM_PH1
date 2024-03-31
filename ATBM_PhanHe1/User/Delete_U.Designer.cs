namespace ATBM_PhanHe1.User
{
    partial class Delete_U
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
            pn_Child = new Panel();
            tb_name = new TextBox();
            label1 = new Label();
            lb_confirm = new Label();
            btn_delete = new Button();
            btn_Back = new Button();
            lb_Name = new Label();
            pn_Child.SuspendLayout();
            SuspendLayout();
            // 
            // pn_Child
            // 
            pn_Child.BackgroundImage = Properties.Resources.bg_mini;
            pn_Child.Controls.Add(tb_name);
            pn_Child.Controls.Add(label1);
            pn_Child.Controls.Add(lb_confirm);
            pn_Child.Controls.Add(btn_delete);
            pn_Child.Controls.Add(btn_Back);
            pn_Child.Controls.Add(lb_Name);
            pn_Child.Location = new Point(120, 101);
            pn_Child.Name = "pn_Child";
            pn_Child.Size = new Size(497, 284);
            pn_Child.TabIndex = 22;
            // 
            // tb_name
            // 
            tb_name.BorderStyle = BorderStyle.None;
            tb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(211, 92);
            tb_name.Name = "tb_name";
            tb_name.PlaceholderText = "UserName";
            tb_name.Size = new Size(224, 27);
            tb_name.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 149);
            label1.Name = "label1";
            label1.Size = new Size(206, 28);
            label1.TabIndex = 23;
            label1.Text = "khỏi danh sách User?";
            // 
            // lb_confirm
            // 
            lb_confirm.AutoSize = true;
            lb_confirm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_confirm.Location = new Point(155, 36);
            lb_confirm.Name = "lb_confirm";
            lb_confirm.Size = new Size(193, 28);
            lb_confirm.TabIndex = 21;
            lb_confirm.Text = "Xác nhận muốn xóa";
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.White;
            btn_delete.BackgroundImage = Properties.Resources.button_round2;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_delete.ForeColor = SystemColors.Window;
            btn_delete.Location = new Point(308, 203);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(91, 38);
            btn_delete.TabIndex = 20;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round2;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(103, 203);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 19;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Name.Location = new Point(155, 92);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(59, 28);
            lb_Name.TabIndex = 15;
            lb_Name.Text = "User ";
            // 
            // Delete_U
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(736, 486);
            Controls.Add(pn_Child);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Delete_U";
            Text = "Delete_U";
            pn_Child.ResumeLayout(false);
            pn_Child.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Child;
        private Label lb_confirm;
        private Button btn_delete;
        private Button btn_Back;
        private TextBox tb_name;
        private Label lb_Name;
        private Label label1;
    }
}