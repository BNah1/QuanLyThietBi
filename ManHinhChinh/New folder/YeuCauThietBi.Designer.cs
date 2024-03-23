namespace WindowsFormsApp8
{
    partial class YeuCauThietBi
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbThietBi = new ComboBox();
            label5 = new Label();
            cbPhong = new ComboBox();
            cbPhanmem = new ComboBox();
            cbCPU = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cbRam = new ComboBox();
            cbOCung = new ComboBox();
            dataGridView1 = new DataGridView();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 4);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(313, 38);
            label1.TabIndex = 0;
            label1.Text = "Yêu cầu thiết bị mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 106);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(149, 31);
            label2.TabIndex = 1;
            label2.Text = "Tên thiết bị";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 163);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 31);
            label3.TabIndex = 2;
            label3.Text = "Phầm mềm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(490, 51);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(147, 31);
            label4.TabIndex = 3;
            label4.Text = "Phần cứng:";
            // 
            // cbThietBi
            // 
            cbThietBi.FormattingEnabled = true;
            cbThietBi.Items.AddRange(new object[] { "Máy tính", "Máy chiếu", "Micro" });
            cbThietBi.Location = new Point(255, 102);
            cbThietBi.Margin = new Padding(5, 4, 5, 4);
            cbThietBi.Name = "cbThietBi";
            cbThietBi.Size = new Size(149, 28);
            cbThietBi.TabIndex = 4;
            cbThietBi.SelectedIndexChanged += cbThietBi_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(79, 51);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 31);
            label5.TabIndex = 5;
            label5.Text = "Phòng:";
            // 
            // cbPhong
            // 
            cbPhong.FormattingEnabled = true;
            cbPhong.Location = new Point(255, 46);
            cbPhong.Margin = new Padding(5, 4, 5, 4);
            cbPhong.Name = "cbPhong";
            cbPhong.Size = new Size(149, 28);
            cbPhong.TabIndex = 4;
            cbPhong.SelectedIndexChanged += cbPhong_SelectedIndexChanged;
            // 
            // cbPhanmem
            // 
            cbPhanmem.FormattingEnabled = true;
            cbPhanmem.Location = new Point(255, 158);
            cbPhanmem.Margin = new Padding(5, 4, 5, 4);
            cbPhanmem.Name = "cbPhanmem";
            cbPhanmem.Size = new Size(149, 28);
            cbPhanmem.TabIndex = 4;
            cbPhanmem.SelectedIndexChanged += cbPhanmem_SelectedIndexChanged;
            // 
            // cbCPU
            // 
            cbCPU.FormattingEnabled = true;
            cbCPU.Items.AddRange(new object[] { "i5", "i7", "i9" });
            cbCPU.Location = new Point(701, 51);
            cbCPU.Margin = new Padding(5, 4, 5, 4);
            cbCPU.Name = "cbCPU";
            cbCPU.Size = new Size(79, 28);
            cbCPU.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(630, 51);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(71, 31);
            label7.TabIndex = 7;
            label7.Text = "CPU";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(631, 100);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 31);
            label8.TabIndex = 7;
            label8.Text = "Ram";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(619, 156);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(98, 31);
            label9.TabIndex = 7;
            label9.Text = "Ổ cứng";
            // 
            // cbRam
            // 
            cbRam.FormattingEnabled = true;
            cbRam.Items.AddRange(new object[] { "4GB", "8GB", "12GB" });
            cbRam.Location = new Point(701, 100);
            cbRam.Margin = new Padding(5, 4, 5, 4);
            cbRam.Name = "cbRam";
            cbRam.Size = new Size(70, 28);
            cbRam.TabIndex = 4;
            // 
            // cbOCung
            // 
            cbOCung.FormattingEnabled = true;
            cbOCung.Items.AddRange(new object[] { "128GB", "256GB", "512GB", "1024GB" });
            cbOCung.Location = new Point(727, 156);
            cbOCung.Margin = new Padding(5, 4, 5, 4);
            cbOCung.Name = "cbOCung";
            cbOCung.Size = new Size(69, 28);
            cbOCung.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 286);
            dataGridView1.Margin = new Padding(5, 4, 5, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(834, 246);
            dataGridView1.TabIndex = 9;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(315, 206);
            btnXoa.Margin = new Padding(5, 4, 5, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(181, 58);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xoá ( k cần )";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(204, 215);
            btnSua.Margin = new Padding(5, 4, 5, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(101, 48);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(93, 218);
            btnThem.Margin = new Padding(5, 4, 5, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(101, 46);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(617, 213);
            btnThoat.Margin = new Padding(5, 4, 5, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(210, 53);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát ( k cần )";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(506, 213);
            btnLuu.Margin = new Padding(5, 4, 5, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(101, 53);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // YeuCauThietBi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 559);
            Controls.Add(btnThoat);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(cbPhong);
            Controls.Add(cbOCung);
            Controls.Add(cbRam);
            Controls.Add(cbCPU);
            Controls.Add(cbPhanmem);
            Controls.Add(cbThietBi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "YeuCauThietBi";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbThietBi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.ComboBox cbPhanmem;
        private System.Windows.Forms.ComboBox cbCPU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbRam;
        private System.Windows.Forms.ComboBox cbOCung;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
    }
}

