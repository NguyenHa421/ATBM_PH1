namespace ATBM_PhanHe1.PhanHe2
{
    partial class Update_StudentSelf
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
            tb_newphone = new TextBox();
            lb_new_phone = new Label();
            btn_Update = new Button();
            btn_Cancel = new Button();
            tb_phone = new TextBox();
            tb_name = new TextBox();
            tb_id = new TextBox();
            lb_phone = new Label();
            lb_name = new Label();
            lb_id = new Label();
            lb_Info = new Label();
            tb_role = new TextBox();
            lb_address = new Label();
            tb_newaddress = new TextBox();
            lb_newaddress = new Label();
            SuspendLayout();
            // 
            // tb_newphone
            // 
            tb_newphone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_newphone.Location = new Point(396, 219);
            tb_newphone.Name = "tb_newphone";
            tb_newphone.Size = new Size(229, 34);
            tb_newphone.TabIndex = 55;
            tb_newphone.TabStop = false;
            // 
            // lb_new_phone
            // 
            lb_new_phone.AutoSize = true;
            lb_new_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_new_phone.Location = new Point(223, 222);
            lb_new_phone.Name = "lb_new_phone";
            lb_new_phone.Size = new Size(167, 28);
            lb_new_phone.TabIndex = 54;
            lb_new_phone.Text = "Số điện thoại mới";
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.White;
            btn_Update.BackgroundImage = Properties.Resources.button_round2;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Update.ForeColor = SystemColors.Window;
            btn_Update.Location = new Point(452, 372);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(91, 38);
            btn_Update.TabIndex = 53;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = Color.White;
            btn_Cancel.BackgroundImage = Properties.Resources.button_round2;
            btn_Cancel.FlatAppearance.BorderSize = 0;
            btn_Cancel.FlatStyle = FlatStyle.Flat;
            btn_Cancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Cancel.ForeColor = SystemColors.Window;
            btn_Cancel.Location = new Point(331, 372);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(91, 38);
            btn_Cancel.TabIndex = 52;
            btn_Cancel.Text = "Hủy";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // tb_phone
            // 
            tb_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_phone.Location = new Point(396, 166);
            tb_phone.Name = "tb_phone";
            tb_phone.ReadOnly = true;
            tb_phone.Size = new Size(229, 34);
            tb_phone.TabIndex = 51;
            tb_phone.TabStop = false;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(396, 111);
            tb_name.Name = "tb_name";
            tb_name.ReadOnly = true;
            tb_name.Size = new Size(229, 34);
            tb_name.TabIndex = 50;
            tb_name.TabStop = false;
            // 
            // tb_id
            // 
            tb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_id.Location = new Point(396, 56);
            tb_id.Name = "tb_id";
            tb_id.ReadOnly = true;
            tb_id.Size = new Size(229, 34);
            tb_id.TabIndex = 49;
            tb_id.TabStop = false;
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_phone.Location = new Point(223, 169);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new Size(153, 28);
            lb_phone.TabIndex = 48;
            lb_phone.Text = "Số điện thoại cũ";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(223, 114);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(96, 28);
            lb_name.TabIndex = 47;
            lb_name.Text = "Họ và tên";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_id.Location = new Point(223, 59);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(121, 28);
            lb_id.TabIndex = 46;
            lb_id.Text = "Mã sinh viên";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(299, 9);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(293, 31);
            lb_Info.TabIndex = 45;
            lb_Info.Text = "Cập nhật thông tin cá nhân";
            // 
            // tb_role
            // 
            tb_role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_role.Location = new Point(396, 269);
            tb_role.Name = "tb_role";
            tb_role.ReadOnly = true;
            tb_role.Size = new Size(229, 34);
            tb_role.TabIndex = 57;
            tb_role.TabStop = false;
            // 
            // lb_address
            // 
            lb_address.AutoSize = true;
            lb_address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_address.Location = new Point(223, 272);
            lb_address.Name = "lb_address";
            lb_address.Size = new Size(96, 28);
            lb_address.TabIndex = 56;
            lb_address.Text = "Địa chỉ cũ";
            // 
            // tb_newaddress
            // 
            tb_newaddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_newaddress.Location = new Point(396, 323);
            tb_newaddress.Name = "tb_newaddress";
            tb_newaddress.Size = new Size(229, 34);
            tb_newaddress.TabIndex = 59;
            tb_newaddress.TabStop = false;
            // 
            // lb_newaddress
            // 
            lb_newaddress.AutoSize = true;
            lb_newaddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_newaddress.Location = new Point(223, 326);
            lb_newaddress.Name = "lb_newaddress";
            lb_newaddress.Size = new Size(110, 28);
            lb_newaddress.TabIndex = 58;
            lb_newaddress.Text = "Địa chỉ mới";
            // 
            // Update_StudentSelf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(tb_newaddress);
            Controls.Add(lb_newaddress);
            Controls.Add(tb_role);
            Controls.Add(lb_address);
            Controls.Add(tb_newphone);
            Controls.Add(lb_new_phone);
            Controls.Add(btn_Update);
            Controls.Add(btn_Cancel);
            Controls.Add(tb_phone);
            Controls.Add(tb_name);
            Controls.Add(tb_id);
            Controls.Add(lb_phone);
            Controls.Add(lb_name);
            Controls.Add(lb_id);
            Controls.Add(lb_Info);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Update_StudentSelf";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update_StudentSelf";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_newphone;
        private Label lb_new_phone;
        private Button btn_Update;
        private Button btn_Cancel;
        private TextBox tb_phone;
        private TextBox tb_name;
        private TextBox tb_id;
        private Label lb_phone;
        private Label lb_name;
        private Label lb_id;
        private Label lb_Info;
        private TextBox tb_role;
        private Label lb_address;
        private TextBox tb_newaddress;
        private Label lb_newaddress;
    }
}