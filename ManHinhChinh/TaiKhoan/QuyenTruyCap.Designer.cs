namespace ManHinhChinh.TaiKhoan
{
    partial class QuyenTruyCap
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
            Button button_Xoa;
            Button button_Sua;
            Button button_Them;
            lblTTK = new Label();
            dataGridView1 = new DataGridView();
            comboBoxPhong = new ComboBox();
            comboBoxToaNha = new ComboBox();
            lblPhong = new Label();
            lblToa = new Label();
            comboBoxTTK = new ComboBox();
            label1 = new Label();
            txtLTK = new TextBox();
            button_Xoa = new Button();
            button_Sua = new Button();
            button_Them = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_Xoa
            // 
            button_Xoa.BackColor = Color.Teal;
            button_Xoa.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            button_Xoa.ForeColor = SystemColors.ControlLightLight;
            button_Xoa.Location = new Point(349, 397);
            button_Xoa.Margin = new Padding(3, 4, 3, 4);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(106, 40);
            button_Xoa.TabIndex = 64;
            button_Xoa.Text = "Xoá";
            button_Xoa.UseVisualStyleBackColor = false;
            button_Xoa.Click += button_Xoa_Click;
            // 
            // button_Sua
            // 
            button_Sua.BackColor = Color.Teal;
            button_Sua.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            button_Sua.ForeColor = SystemColors.ControlLightLight;
            button_Sua.Location = new Point(227, 397);
            button_Sua.Margin = new Padding(3, 4, 3, 4);
            button_Sua.Name = "button_Sua";
            button_Sua.Size = new Size(106, 40);
            button_Sua.TabIndex = 63;
            button_Sua.Text = "Sửa ";
            button_Sua.UseVisualStyleBackColor = false;
            button_Sua.Click += button_Sua_Click;
            // 
            // button_Them
            // 
            button_Them.BackColor = Color.Teal;
            button_Them.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            button_Them.ForeColor = SystemColors.ControlLightLight;
            button_Them.Location = new Point(103, 397);
            button_Them.Margin = new Padding(3, 4, 3, 4);
            button_Them.Name = "button_Them";
            button_Them.Size = new Size(106, 40);
            button_Them.TabIndex = 62;
            button_Them.Text = "Thêm";
            button_Them.UseVisualStyleBackColor = false;
            button_Them.Click += button_Them_Click;
            // 
            // lblTTK
            // 
            lblTTK.AutoSize = true;
            lblTTK.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTTK.ForeColor = Color.Black;
            lblTTK.Location = new Point(12, 16);
            lblTTK.Name = "lblTTK";
            lblTTK.Size = new Size(104, 19);
            lblTTK.TabIndex = 31;
            lblTTK.Text = "Tên tài khoản:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(506, 281);
            dataGridView1.TabIndex = 55;
            dataGridView1.CellClick += DataGridView_CellClick;
            // 
            // comboBoxPhong
            // 
            comboBoxPhong.FormattingEnabled = true;
            comboBoxPhong.Location = new Point(407, 40);
            comboBoxPhong.Name = "comboBoxPhong";
            comboBoxPhong.Size = new Size(90, 28);
            comboBoxPhong.TabIndex = 58;
            // 
            // comboBoxToaNha
            // 
            comboBoxToaNha.FormattingEnabled = true;
            comboBoxToaNha.Location = new Point(407, 7);
            comboBoxToaNha.Name = "comboBoxToaNha";
            comboBoxToaNha.Size = new Size(89, 28);
            comboBoxToaNha.TabIndex = 59;
            // 
            // lblPhong
            // 
            lblPhong.AutoSize = true;
            lblPhong.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhong.ForeColor = Color.Black;
            lblPhong.Location = new Point(349, 49);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new Size(52, 19);
            lblPhong.TabIndex = 60;
            lblPhong.Text = "Phòng";
            // 
            // lblToa
            // 
            lblToa.AutoSize = true;
            lblToa.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToa.ForeColor = Color.Black;
            lblToa.Location = new Point(341, 16);
            lblToa.Name = "lblToa";
            lblToa.Size = new Size(60, 19);
            lblToa.TabIndex = 61;
            lblToa.Text = "Toà nhà";
            // 
            // comboBoxTTK
            // 
            comboBoxTTK.FormattingEnabled = true;
            comboBoxTTK.Location = new Point(131, 7);
            comboBoxTTK.Name = "comboBoxTTK";
            comboBoxTTK.Size = new Size(96, 28);
            comboBoxTTK.TabIndex = 65;
            comboBoxTTK.SelectedIndexChanged += comboBoxTTK_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(113, 19);
            label1.TabIndex = 68;
            label1.Text = "Loại Tài Khoản";
            // 
            // txtLTK
            // 
            txtLTK.Location = new Point(131, 42);
            txtLTK.Margin = new Padding(3, 4, 3, 4);
            txtLTK.Name = "txtLTK";
            txtLTK.Size = new Size(96, 27);
            txtLTK.TabIndex = 69;
            // 
            // QuyenTruyCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 450);
            Controls.Add(txtLTK);
            Controls.Add(label1);
            Controls.Add(comboBoxTTK);
            Controls.Add(button_Xoa);
            Controls.Add(button_Sua);
            Controls.Add(button_Them);
            Controls.Add(lblToa);
            Controls.Add(lblPhong);
            Controls.Add(comboBoxToaNha);
            Controls.Add(comboBoxPhong);
            Controls.Add(dataGridView1);
            Controls.Add(lblTTK);
            Name = "QuyenTruyCap";
            Text = "QuyenTruyCap";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lblTTK;
        private DataGridView dataGridView1;
        private ComboBox comboBoxPhong;
        private ComboBox comboBoxToaNha;
        public Label lblPhong;
        public Label lblToa;
        private ComboBox comboBoxTTK;
        public Label label1;
        private TextBox txtLTK;
    }
}