namespace ATBM_PhanHe1.Role
{
    partial class Delete_R
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
            btn_Create = new Button();
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
            pn_Child.Controls.Add(btn_Create);
            pn_Child.Controls.Add(btn_Back);
            pn_Child.Controls.Add(lb_Name);
            pn_Child.Location = new Point(120, 101);
            pn_Child.Name = "pn_Child";
            pn_Child.Size = new Size(497, 284);
            pn_Child.TabIndex = 23;
            // 
            // tb_name
            // 
            tb_name.BorderStyle = BorderStyle.None;
            tb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(208, 92);
            tb_name.Name = "tb_name";
            tb_name.PlaceholderText = "RoleName";
            tb_name.Size = new Size(224, 27);
            tb_name.TabIndex = 17;
            tb_name.TextChanged += tb_name_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 149);
            label1.Name = "label1";
            label1.Size = new Size(204, 28);
            label1.TabIndex = 23;
            label1.Text = "khỏi danh sách Role?";
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
            // btn_Create
            // 
            btn_Create.BackColor = Color.White;
            btn_Create.BackgroundImage = Properties.Resources.button_round2;
            btn_Create.FlatAppearance.BorderSize = 0;
            btn_Create.FlatStyle = FlatStyle.Flat;
            btn_Create.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Create.ForeColor = SystemColors.Window;
            btn_Create.Location = new Point(308, 203);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(91, 38);
            btn_Create.TabIndex = 20;
            btn_Create.Text = "Xóa";
            btn_Create.UseVisualStyleBackColor = false;
            btn_Create.Click += btn_Create_Click;
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
            lb_Name.Size = new Size(51, 28);
            lb_Name.TabIndex = 15;
            lb_Name.Text = "Role";
            // 
            // Delete_R
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(736, 486);
            Controls.Add(pn_Child);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Delete_R";
            Text = "Delete_R";
            pn_Child.ResumeLayout(false);
            pn_Child.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Child;
        private TextBox tb_name;
        private Label label1;
        private Label lb_confirm;
        private Button btn_Create;
        private Button btn_Back;
        private Label lb_Name;
    }
}