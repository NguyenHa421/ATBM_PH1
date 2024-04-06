namespace ATBM_PhanHe1.Role
{
    partial class Create_R
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
            btn_Create = new Button();
            btn_Back = new Button();
            tb_role = new TextBox();
            lb_Name = new Label();
            pn_Child.SuspendLayout();
            SuspendLayout();
            // 
            // pn_Child
            // 
            pn_Child.BackgroundImage = Properties.Resources.bg_mini;
            pn_Child.Controls.Add(btn_Create);
            pn_Child.Controls.Add(btn_Back);
            pn_Child.Controls.Add(tb_role);
            pn_Child.Controls.Add(lb_Name);
            pn_Child.Location = new Point(120, 101);
            pn_Child.Name = "pn_Child";
            pn_Child.Size = new Size(497, 284);
            pn_Child.TabIndex = 22;
            // 
            // btn_Create
            // 
            btn_Create.BackColor = Color.White;
            btn_Create.BackgroundImage = Properties.Resources.button_round2;
            btn_Create.FlatAppearance.BorderSize = 0;
            btn_Create.FlatStyle = FlatStyle.Flat;
            btn_Create.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Create.ForeColor = SystemColors.Window;
            btn_Create.Location = new Point(351, 191);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(91, 38);
            btn_Create.TabIndex = 20;
            btn_Create.Text = "Tạo mới";
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
            btn_Back.Location = new Point(177, 191);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 19;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // tb_role
            // 
            tb_role.BorderStyle = BorderStyle.FixedSingle;
            tb_role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_role.Location = new Point(177, 100);
            tb_role.Name = "tb_role";
            tb_role.Size = new Size(265, 34);
            tb_role.TabIndex = 17;
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Name.Location = new Point(42, 102);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(85, 28);
            lb_Name.TabIndex = 15;
            lb_Name.Text = "Tên role";
            // 
            // Create_R
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(736, 486);
            Controls.Add(pn_Child);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Create_R";
            Text = "Create_R";
            pn_Child.ResumeLayout(false);
            pn_Child.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Child;
        private Button btn_Create;
        private Button btn_Back;
        private TextBox tb_role;
        private Label lb_Name;
    }
}