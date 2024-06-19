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
            cbB_unitHead = new ComboBox();
            tb_name = new TextBox();
            tb_id = new TextBox();
            lb_unithead = new Label();
            lb_name = new Label();
            lb_id = new Label();
            lb_Info = new Label();
            btn_Update = new Button();
            btn_Back = new Button();
            tb_nameheadUnit = new TextBox();
            lb_nameUnit = new Label();
            SuspendLayout();
            // 
            // cbB_unitHead
            // 
            cbB_unitHead.DropDownHeight = 150;
            cbB_unitHead.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_unitHead.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_unitHead.FormattingEnabled = true;
            cbB_unitHead.IntegralHeight = false;
            cbB_unitHead.Location = new Point(387, 229);
            cbB_unitHead.Name = "cbB_unitHead";
            cbB_unitHead.Size = new Size(260, 36);
            cbB_unitHead.TabIndex = 95;
            cbB_unitHead.SelectedIndexChanged += cbB_unitHead_SelectedIndexChanged;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(387, 162);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(260, 34);
            tb_name.TabIndex = 92;
            tb_name.TabStop = false;
            // 
            // tb_id
            // 
            tb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_id.Location = new Point(387, 93);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(260, 34);
            tb_id.TabIndex = 91;
            tb_id.TabStop = false;
            // 
            // lb_unithead
            // 
            lb_unithead.AutoSize = true;
            lb_unithead.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_unithead.Location = new Point(208, 232);
            lb_unithead.Name = "lb_unithead";
            lb_unithead.Size = new Size(166, 28);
            lb_unithead.TabIndex = 90;
            lb_unithead.Text = "Mã trưởng đơn vị";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(208, 165);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(101, 28);
            lb_name.TabIndex = 89;
            lb_name.Text = "Tên đơn vị";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_id.Location = new Point(208, 96);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(100, 28);
            lb_id.TabIndex = 88;
            lb_id.Text = "Mã đơn vị";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(344, 33);
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
            btn_Update.Location = new Point(453, 360);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(91, 38);
            btn_Update.TabIndex = 97;
            btn_Update.Text = "Cập nhật";
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
            btn_Back.Location = new Point(332, 360);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 96;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // tb_nameheadUnit
            // 
            tb_nameheadUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_nameheadUnit.Location = new Point(387, 303);
            tb_nameheadUnit.Name = "tb_nameheadUnit";
            tb_nameheadUnit.ReadOnly = true;
            tb_nameheadUnit.Size = new Size(260, 34);
            tb_nameheadUnit.TabIndex = 99;
            tb_nameheadUnit.TabStop = false;
            // 
            // lb_nameUnit
            // 
            lb_nameUnit.AutoSize = true;
            lb_nameUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_nameUnit.Location = new Point(208, 306);
            lb_nameUnit.Name = "lb_nameUnit";
            lb_nameUnit.Size = new Size(167, 28);
            lb_nameUnit.TabIndex = 98;
            lb_nameUnit.Text = "Tên trưởng đơn vị";
            // 
            // Update_Unit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(tb_nameheadUnit);
            Controls.Add(lb_nameUnit);
            Controls.Add(btn_Update);
            Controls.Add(btn_Back);
            Controls.Add(cbB_unitHead);
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

        private ComboBox cbB_unitHead;
        private TextBox tb_name;
        private TextBox tb_id;
        private Label lb_unithead;
        private Label lb_name;
        private Label lb_id;
        private Label lb_Info;
        private Button btn_Update;
        private Button btn_Back;
        private TextBox tb_nameheadUnit;
        private Label lb_nameUnit;
    }
}