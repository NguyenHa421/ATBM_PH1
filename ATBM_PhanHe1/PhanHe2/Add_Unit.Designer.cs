namespace ATBM_PhanHe1.PhanHe2
{
    partial class Add_Unit
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
            lb_Info = new Label();
            btn_Update = new Button();
            btn_Back = new Button();
            tb_name = new TextBox();
            tb_id = new TextBox();
            lb_name = new Label();
            lb_id = new Label();
            SuspendLayout();
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(365, 59);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(143, 31);
            lb_Info.TabIndex = 70;
            lb_Info.Text = "Thêm đơn vị";
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.White;
            btn_Update.BackgroundImage = Properties.Resources.button_round2;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Update.ForeColor = SystemColors.Window;
            btn_Update.Location = new Point(446, 313);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(91, 38);
            btn_Update.TabIndex = 108;
            btn_Update.Text = "Tạo mới";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round2;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(325, 313);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 107;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(405, 213);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(260, 34);
            tb_name.TabIndex = 105;
            tb_name.TabStop = false;
            // 
            // tb_id
            // 
            tb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_id.Location = new Point(405, 144);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(260, 34);
            tb_id.TabIndex = 104;
            tb_id.TabStop = false;
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(226, 216);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(101, 28);
            lb_name.TabIndex = 102;
            lb_name.Text = "Tên đơn vị";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_id.Location = new Point(226, 147);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(100, 28);
            lb_id.TabIndex = 101;
            lb_id.Text = "Mã đơn vị";
            // 
            // Add_Unit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(btn_Update);
            Controls.Add(btn_Back);
            Controls.Add(tb_name);
            Controls.Add(tb_id);
            Controls.Add(lb_name);
            Controls.Add(lb_id);
            Controls.Add(lb_Info);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Add_Unit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add_Unit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_Info;
        private Button btn_Update;
        private Button btn_Back;
        private TextBox tb_name;
        private TextBox tb_id;
        private Label lb_name;
        private Label lb_id;
    }
}