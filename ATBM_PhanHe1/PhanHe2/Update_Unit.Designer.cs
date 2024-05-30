namespace ATBM_PhanHe1.PhanHe2
{
    partial class Update_Unit
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
            cbB_program = new ComboBox();
            tb_name = new TextBox();
            tb_id = new TextBox();
            lb_unithead = new Label();
            lb_name = new Label();
            lb_id = new Label();
            lb_Info = new Label();
            btn_Update = new Button();
            btn_Back = new Button();
            SuspendLayout();
            // 
            // cbB_program
            // 
            cbB_program.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_program.FormattingEnabled = true;
            cbB_program.Location = new Point(404, 255);
            cbB_program.Name = "cbB_program";
            cbB_program.Size = new Size(229, 36);
            cbB_program.TabIndex = 95;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(404, 188);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(229, 34);
            tb_name.TabIndex = 92;
            tb_name.TabStop = false;
            // 
            // tb_id
            // 
            tb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_id.Location = new Point(404, 119);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(229, 34);
            tb_id.TabIndex = 91;
            tb_id.TabStop = false;
            // 
            // lb_unithead
            // 
            lb_unithead.AutoSize = true;
            lb_unithead.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_unithead.Location = new Point(261, 258);
            lb_unithead.Name = "lb_unithead";
            lb_unithead.Size = new Size(134, 28);
            lb_unithead.TabIndex = 90;
            lb_unithead.Text = "Trưởng đơn vị";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(261, 191);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(101, 28);
            lb_name.TabIndex = 89;
            lb_name.Text = "Tên đơn vị";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_id.Location = new Point(261, 122);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(100, 28);
            lb_id.TabIndex = 88;
            lb_id.Text = "Mã đơn vị";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(384, 54);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(177, 31);
            lb_Info.TabIndex = 87;
            lb_Info.Text = "Cập nhật đơn vị";
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.White;
            btn_Update.BackgroundImage = Properties.Resources.button_round2;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Update.ForeColor = SystemColors.Window;
            btn_Update.Location = new Point(482, 330);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(91, 38);
            btn_Update.TabIndex = 97;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = false;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round2;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(361, 330);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 96;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            // 
            // Update_Unit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(btn_Update);
            Controls.Add(btn_Back);
            Controls.Add(cbB_program);
            Controls.Add(tb_name);
            Controls.Add(tb_id);
            Controls.Add(lb_unithead);
            Controls.Add(lb_name);
            Controls.Add(lb_id);
            Controls.Add(lb_Info);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Update_Unit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update_Unit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbB_program;
        private TextBox tb_name;
        private TextBox tb_id;
        private Label lb_unithead;
        private Label lb_name;
        private Label lb_id;
        private Label lb_Info;
        private Button btn_Update;
        private Button btn_Back;
    }
}