namespace ATBM_PhanHe1.PhanHe2
{
    partial class ViewInfo_Personnel
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
            pn_parents = new Panel();
            btn_Update = new Button();
            btn_Back = new Button();
            tb_name_unit = new TextBox();
            tb_id_unit = new TextBox();
            tb_allowance = new TextBox();
            tb_role = new TextBox();
            tb_phone = new TextBox();
            tb_birth = new TextBox();
            tb_gender = new TextBox();
            tb_name = new TextBox();
            tb_id = new TextBox();
            lb_name_unit = new Label();
            lb_id_unit = new Label();
            lb_role = new Label();
            lb_phone = new Label();
            lb_allowance = new Label();
            lb_birth = new Label();
            lb_gender = new Label();
            lb_name = new Label();
            lb_id = new Label();
            lb_Info = new Label();
            pn_parents.SuspendLayout();
            SuspendLayout();
            // 
            // pn_parents
            // 
            pn_parents.Controls.Add(btn_Update);
            pn_parents.Controls.Add(btn_Back);
            pn_parents.Controls.Add(tb_name_unit);
            pn_parents.Controls.Add(tb_id_unit);
            pn_parents.Controls.Add(tb_allowance);
            pn_parents.Controls.Add(tb_role);
            pn_parents.Controls.Add(tb_phone);
            pn_parents.Controls.Add(tb_birth);
            pn_parents.Controls.Add(tb_gender);
            pn_parents.Controls.Add(tb_name);
            pn_parents.Controls.Add(tb_id);
            pn_parents.Controls.Add(lb_name_unit);
            pn_parents.Controls.Add(lb_id_unit);
            pn_parents.Controls.Add(lb_role);
            pn_parents.Controls.Add(lb_phone);
            pn_parents.Controls.Add(lb_allowance);
            pn_parents.Controls.Add(lb_birth);
            pn_parents.Controls.Add(lb_gender);
            pn_parents.Controls.Add(lb_name);
            pn_parents.Controls.Add(lb_id);
            pn_parents.Controls.Add(lb_Info);
            pn_parents.Location = new Point(0, 0);
            pn_parents.Name = "pn_parents";
            pn_parents.Size = new Size(895, 425);
            pn_parents.TabIndex = 0;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.White;
            btn_Update.BackgroundImage = Properties.Resources.button_round2;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Update.ForeColor = SystemColors.Window;
            btn_Update.Location = new Point(482, 372);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(91, 38);
            btn_Update.TabIndex = 42;
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
            btn_Back.Location = new Point(361, 372);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 41;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // tb_name_unit
            // 
            tb_name_unit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name_unit.Location = new Point(601, 300);
            tb_name_unit.Name = "tb_name_unit";
            tb_name_unit.ReadOnly = true;
            tb_name_unit.Size = new Size(229, 34);
            tb_name_unit.TabIndex = 40;
            tb_name_unit.TabStop = false;
            // 
            // tb_id_unit
            // 
            tb_id_unit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_id_unit.Location = new Point(601, 245);
            tb_id_unit.Name = "tb_id_unit";
            tb_id_unit.ReadOnly = true;
            tb_id_unit.Size = new Size(229, 34);
            tb_id_unit.TabIndex = 39;
            tb_id_unit.TabStop = false;
            // 
            // tb_allowance
            // 
            tb_allowance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_allowance.Location = new Point(601, 190);
            tb_allowance.Name = "tb_allowance";
            tb_allowance.ReadOnly = true;
            tb_allowance.Size = new Size(229, 34);
            tb_allowance.TabIndex = 38;
            tb_allowance.TabStop = false;
            // 
            // tb_role
            // 
            tb_role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_role.Location = new Point(601, 135);
            tb_role.Name = "tb_role";
            tb_role.ReadOnly = true;
            tb_role.Size = new Size(229, 34);
            tb_role.TabIndex = 37;
            tb_role.TabStop = false;
            // 
            // tb_phone
            // 
            tb_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_phone.Location = new Point(214, 300);
            tb_phone.Name = "tb_phone";
            tb_phone.ReadOnly = true;
            tb_phone.Size = new Size(229, 34);
            tb_phone.TabIndex = 36;
            tb_phone.TabStop = false;
            // 
            // tb_birth
            // 
            tb_birth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_birth.Location = new Point(214, 245);
            tb_birth.Name = "tb_birth";
            tb_birth.ReadOnly = true;
            tb_birth.Size = new Size(229, 34);
            tb_birth.TabIndex = 35;
            tb_birth.TabStop = false;
            // 
            // tb_gender
            // 
            tb_gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_gender.Location = new Point(214, 190);
            tb_gender.Name = "tb_gender";
            tb_gender.ReadOnly = true;
            tb_gender.Size = new Size(229, 34);
            tb_gender.TabIndex = 34;
            tb_gender.TabStop = false;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(214, 135);
            tb_name.Name = "tb_name";
            tb_name.ReadOnly = true;
            tb_name.Size = new Size(229, 34);
            tb_name.TabIndex = 33;
            tb_name.TabStop = false;
            // 
            // tb_id
            // 
            tb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_id.Location = new Point(214, 80);
            tb_id.Name = "tb_id";
            tb_id.ReadOnly = true;
            tb_id.Size = new Size(229, 34);
            tb_id.TabIndex = 32;
            tb_id.TabStop = false;
            // 
            // lb_name_unit
            // 
            lb_name_unit.AutoSize = true;
            lb_name_unit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name_unit.Location = new Point(492, 303);
            lb_name_unit.Name = "lb_name_unit";
            lb_name_unit.Size = new Size(101, 28);
            lb_name_unit.TabIndex = 31;
            lb_name_unit.Text = "Tên đơn vị";
            // 
            // lb_id_unit
            // 
            lb_id_unit.AutoSize = true;
            lb_id_unit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_id_unit.Location = new Point(492, 248);
            lb_id_unit.Name = "lb_id_unit";
            lb_id_unit.Size = new Size(100, 28);
            lb_id_unit.TabIndex = 30;
            lb_id_unit.Text = "Mã đơn vị";
            // 
            // lb_role
            // 
            lb_role.AutoSize = true;
            lb_role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_role.Location = new Point(492, 138);
            lb_role.Name = "lb_role";
            lb_role.Size = new Size(69, 28);
            lb_role.TabIndex = 29;
            lb_role.Text = "Vai trò";
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_phone.Location = new Point(64, 303);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new Size(128, 28);
            lb_phone.TabIndex = 28;
            lb_phone.Text = "Số điện thoại";
            // 
            // lb_allowance
            // 
            lb_allowance.AutoSize = true;
            lb_allowance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_allowance.Location = new Point(492, 193);
            lb_allowance.Name = "lb_allowance";
            lb_allowance.Size = new Size(81, 28);
            lb_allowance.TabIndex = 27;
            lb_allowance.Text = "Phụ cấp";
            // 
            // lb_birth
            // 
            lb_birth.AutoSize = true;
            lb_birth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_birth.Location = new Point(64, 248);
            lb_birth.Name = "lb_birth";
            lb_birth.Size = new Size(99, 28);
            lb_birth.TabIndex = 26;
            lb_birth.Text = "Ngày sinh";
            // 
            // lb_gender
            // 
            lb_gender.AutoSize = true;
            lb_gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_gender.Location = new Point(64, 193);
            lb_gender.Name = "lb_gender";
            lb_gender.Size = new Size(49, 28);
            lb_gender.TabIndex = 25;
            lb_gender.Text = "Phái";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(64, 138);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(96, 28);
            lb_name.TabIndex = 24;
            lb_name.Text = "Họ và tên";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_id.Location = new Point(64, 83);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(113, 28);
            lb_id.TabIndex = 23;
            lb_id.Text = "Mã nhân sự";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(361, 15);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(200, 31);
            lb_Info.TabIndex = 22;
            lb_Info.Text = "Thông tin cá nhân";
            // 
            // ViewInfo_Personnel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(pn_parents);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewInfo_Personnel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ViewInfo_Personnel";
            pn_parents.ResumeLayout(false);
            pn_parents.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_parents;
        private Button btn_Update;
        private Button btn_Back;
        private TextBox tb_name_unit;
        private TextBox tb_id_unit;
        private TextBox tb_allowance;
        private TextBox tb_role;
        private TextBox tb_phone;
        private TextBox tb_birth;
        private TextBox tb_gender;
        private TextBox tb_name;
        private TextBox tb_id;
        private Label lb_name_unit;
        private Label lb_id_unit;
        private Label lb_role;
        private Label lb_phone;
        private Label lb_allowance;
        private Label lb_birth;
        private Label lb_gender;
        private Label lb_name;
        private Label lb_id;
        private Label lb_Info;
    }
}