namespace ATBM_PhanHe1.PhanHe2
{
    partial class View_InfoPersonnel
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
            bt_delete = new Button();
            pic_refresh_U = new PictureBox();
            btn_search = new Button();
            btn_Add = new Button();
            btn_Update = new Button();
            dtGrid_personel = new DataGridView();
            btn_Back = new Button();
            tb_name = new TextBox();
            lb_name = new Label();
            lb_Info = new Label();
            pn_parents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_refresh_U).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_personel).BeginInit();
            SuspendLayout();
            // 
            // pn_parents
            // 
            pn_parents.Controls.Add(bt_delete);
            pn_parents.Controls.Add(pic_refresh_U);
            pn_parents.Controls.Add(btn_search);
            pn_parents.Controls.Add(btn_Add);
            pn_parents.Controls.Add(btn_Update);
            pn_parents.Controls.Add(dtGrid_personel);
            pn_parents.Controls.Add(btn_Back);
            pn_parents.Controls.Add(tb_name);
            pn_parents.Controls.Add(lb_name);
            pn_parents.Controls.Add(lb_Info);
            pn_parents.Location = new Point(0, 0);
            pn_parents.Name = "pn_parents";
            pn_parents.Size = new Size(895, 425);
            pn_parents.TabIndex = 1;
            // 
            // bt_delete
            // 
            bt_delete.BackColor = Color.White;
            bt_delete.BackgroundImage = Properties.Resources.button_round2;
            bt_delete.FlatAppearance.BorderSize = 0;
            bt_delete.FlatStyle = FlatStyle.Flat;
            bt_delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bt_delete.ForeColor = SystemColors.Window;
            bt_delete.Location = new Point(361, 376);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(91, 38);
            bt_delete.TabIndex = 100;
            bt_delete.Text = "Xóa";
            bt_delete.UseVisualStyleBackColor = false;
            bt_delete.Click += bt_delete_Click;
            // 
            // pic_refresh_U
            // 
            pic_refresh_U.Image = Properties.Resources.refresh_buttons;
            pic_refresh_U.Location = new Point(706, 52);
            pic_refresh_U.Name = "pic_refresh_U";
            pic_refresh_U.Size = new Size(49, 39);
            pic_refresh_U.SizeMode = PictureBoxSizeMode.Zoom;
            pic_refresh_U.TabIndex = 99;
            pic_refresh_U.TabStop = false;
            pic_refresh_U.Click += pic_refresh_U_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.White;
            btn_search.BackgroundImage = Properties.Resources.button_round2;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_search.ForeColor = SystemColors.Window;
            btn_search.Location = new Point(766, 52);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(91, 38);
            btn_search.TabIndex = 98;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.White;
            btn_Add.BackgroundImage = Properties.Resources.button_round2;
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Add.ForeColor = SystemColors.Window;
            btn_Add.Location = new Point(500, 376);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(91, 38);
            btn_Add.TabIndex = 97;
            btn_Add.Text = "Tạo mới";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.White;
            btn_Update.BackgroundImage = Properties.Resources.button_round2;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Update.ForeColor = SystemColors.Window;
            btn_Update.Location = new Point(639, 376);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(91, 38);
            btn_Update.TabIndex = 96;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // dtGrid_personel
            // 
            dtGrid_personel.BackgroundColor = SystemColors.Control;
            dtGrid_personel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_personel.Location = new Point(41, 104);
            dtGrid_personel.Name = "dtGrid_personel";
            dtGrid_personel.RowHeadersWidth = 51;
            dtGrid_personel.Size = new Size(816, 262);
            dtGrid_personel.TabIndex = 95;
            dtGrid_personel.CellContentClick += dtGrid_personel_CellContentClick;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round2;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(768, 376);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 38);
            btn_Back.TabIndex = 94;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(143, 56);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(546, 34);
            tb_name.TabIndex = 93;
            tb_name.TabStop = false;
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(41, 59);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(96, 28);
            lb_name.TabIndex = 91;
            lb_name.Text = "Họ và tên";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(346, 10);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(201, 31);
            lb_Info.TabIndex = 89;
            lb_Info.Text = "Thông tin nhân sự";
            // 
            // View_InfoPersonnel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(pn_parents);
            FormBorderStyle = FormBorderStyle.None;
            Name = "View_InfoPersonnel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_InfoPersonnel";
            pn_parents.ResumeLayout(false);
            pn_parents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_refresh_U).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_personel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_parents;
        private Button bt_delete;
        private PictureBox pic_refresh_U;
        private Button btn_search;
        private Button btn_Add;
        private Button btn_Update;
        private DataGridView dtGrid_personel;
        private Button btn_Back;
        private TextBox tb_name;
        private Label lb_name;
        private Label lb_Info;
    }
}