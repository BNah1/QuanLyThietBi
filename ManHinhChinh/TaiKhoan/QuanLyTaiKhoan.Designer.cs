namespace ManHinhChinh.TaiKhoan
{
    partial class QuanLyTaiKhoan
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
            Button button_Them;
            Button button_Sua;
            Button button_Xoa;
            txtSdt = new TextBox();
            txtTTK = new TextBox();
            txtID = new TextBox();
            lblTTK = new Label();
            txtTen = new TextBox();
            lblMail = new Label();
            lblID = new Label();
            txtMail = new TextBox();
            lblSdt = new Label();
            lblTen = new Label();
            txtMK = new TextBox();
            lblMK = new Label();
            txtLoaiTK = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            button_Them = new Button();
            button_Sua = new Button();
            button_Xoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_Them
            // 
            button_Them.BackColor = Color.Teal;
            button_Them.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            button_Them.ForeColor = SystemColors.ControlLightLight;
            button_Them.Location = new Point(500, 208);
            button_Them.Margin = new Padding(3, 4, 3, 4);
            button_Them.Name = "button_Them";
            button_Them.Size = new Size(106, 40);
            button_Them.TabIndex = 46;
            button_Them.Text = "Thêm";
            button_Them.UseVisualStyleBackColor = false;
            button_Them.Click += button2_Click;
            // 
            // button_Sua
            // 
            button_Sua.BackColor = Color.Teal;
            button_Sua.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            button_Sua.ForeColor = SystemColors.ControlLightLight;
            button_Sua.Location = new Point(624, 208);
            button_Sua.Margin = new Padding(3, 4, 3, 4);
            button_Sua.Name = "button_Sua";
            button_Sua.Size = new Size(106, 40);
            button_Sua.TabIndex = 47;
            button_Sua.Text = "Sửa ";
            button_Sua.UseVisualStyleBackColor = false;
            button_Sua.Click += button_Sua_Click;
            // 
            // button_Xoa
            // 
            button_Xoa.BackColor = Color.Teal;
            button_Xoa.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            button_Xoa.ForeColor = SystemColors.ControlLightLight;
            button_Xoa.Location = new Point(736, 208);
            button_Xoa.Margin = new Padding(3, 4, 3, 4);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(106, 40);
            button_Xoa.TabIndex = 48;
            button_Xoa.Text = "Xoá";
            button_Xoa.UseVisualStyleBackColor = false;
            button_Xoa.Click += button_Xoa_Click;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(577, 115);
            txtSdt.Margin = new Padding(3, 4, 3, 4);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(211, 27);
            txtSdt.TabIndex = 31;
            // 
            // txtTTK
            // 
            txtTTK.Location = new Point(191, 79);
            txtTTK.Margin = new Padding(3, 4, 3, 4);
            txtTTK.Name = "txtTTK";
            txtTTK.Size = new Size(211, 27);
            txtTTK.TabIndex = 30;
            // 
            // txtID
            // 
            txtID.Location = new Point(190, 185);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(211, 27);
            txtID.TabIndex = 29;
            // 
            // lblTTK
            // 
            lblTTK.AutoSize = true;
            lblTTK.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTTK.ForeColor = Color.Black;
            lblTTK.Location = new Point(74, 83);
            lblTTK.Name = "lblTTK";
            lblTTK.Size = new Size(104, 19);
            lblTTK.TabIndex = 23;
            lblTTK.Text = "Tên tài khoản:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(577, 79);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(211, 27);
            txtTen.TabIndex = 24;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMail.ForeColor = Color.Black;
            lblMail.Location = new Point(467, 157);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(54, 19);
            lblMail.TabIndex = 22;
            lblMail.Text = "Email:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.ForeColor = Color.Black;
            lblID.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblID.Location = new Point(83, 193);
            lblID.Name = "lblID";
            lblID.Size = new Size(31, 19);
            lblID.TabIndex = 19;
            lblID.Text = "ID:";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(577, 149);
            txtMail.Margin = new Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(211, 27);
            txtMail.TabIndex = 25;
            // 
            // lblSdt
            // 
            lblSdt.AutoSize = true;
            lblSdt.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSdt.ForeColor = Color.Black;
            lblSdt.Location = new Point(467, 119);
            lblSdt.Name = "lblSdt";
            lblSdt.Size = new Size(104, 19);
            lblSdt.TabIndex = 21;
            lblSdt.Text = "Số điện thoại:";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTen.ForeColor = Color.Black;
            lblTen.Location = new Point(467, 83);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(39, 19);
            lblTen.TabIndex = 20;
            lblTen.Text = "Tên:";
            lblTen.Click += lblTen_Click;
            // 
            // txtMK
            // 
            txtMK.Location = new Point(190, 115);
            txtMK.Margin = new Padding(3, 4, 3, 4);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(211, 27);
            txtMK.TabIndex = 51;
            // 
            // lblMK
            // 
            lblMK.AutoSize = true;
            lblMK.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMK.ForeColor = Color.Black;
            lblMK.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblMK.Location = new Point(78, 119);
            lblMK.Name = "lblMK";
            lblMK.Size = new Size(76, 19);
            lblMK.TabIndex = 50;
            lblMK.Text = "Mật khẩu:";
            // 
            // txtLoaiTK
            // 
            txtLoaiTK.Location = new Point(190, 151);
            txtLoaiTK.Margin = new Padding(3, 4, 3, 4);
            txtLoaiTK.Name = "txtLoaiTK";
            txtLoaiTK.Size = new Size(211, 27);
            txtLoaiTK.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label1.Location = new Point(79, 155);
            label1.Name = "label1";
            label1.Size = new Size(110, 19);
            label1.TabIndex = 52;
            label1.Text = "Loại tài khoản:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 255);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(823, 271);
            dataGridView1.TabIndex = 54;
            dataGridView1.CellClick += dataGridView_ctpm_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(278, 19);
            label3.Name = "label3";
            label3.Size = new Size(377, 38);
            label3.TabIndex = 55;
            label3.Text = "Quản Lý Các Tài Khoản";
            // 
            // QuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 548);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(txtLoaiTK);
            Controls.Add(label1);
            Controls.Add(txtMK);
            Controls.Add(lblMK);
            Controls.Add(button_Xoa);
            Controls.Add(button_Sua);
            Controls.Add(button_Them);
            Controls.Add(txtSdt);
            Controls.Add(txtTTK);
            Controls.Add(txtID);
            Controls.Add(lblTTK);
            Controls.Add(txtTen);
            Controls.Add(lblMail);
            Controls.Add(lblID);
            Controls.Add(txtMail);
            Controls.Add(lblSdt);
            Controls.Add(lblTen);
            Name = "QuanLyTaiKhoan";
            Text = "QuanLyTaiKhoan";
            Load += QuanLyTaiKhoan_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSdt;
        private TextBox txtTTK;
        private TextBox txtID;
        public Label lblTTK;
        private TextBox txtTen;
        private Label lblMail;
        private Label lblID;
        private TextBox txtMail;
        private Label lblSdt;
        private Label lblTen;
        private TextBox txtMK;
        private Label lblMK;
        private TextBox txtLoaiTK;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label3;
    }
}