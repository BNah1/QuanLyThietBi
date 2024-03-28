using System;

namespace WindowsFormsApp11
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtCountDG = new TextBox();
            label10 = new Label();
            cbThietBi = new ComboBox();
            label9 = new Label();
            btnThoat = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dataGridView1 = new DataGridView();
            cbWin = new ComboBox();
            cbCPU = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            cbRam = new ComboBox();
            cbPhanmem = new ComboBox();
            cbPhong = new ComboBox();
            label2 = new Label();
            cbOCung = new ComboBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            btLoc = new Button();
            btCancelLoc = new Button();
            grbLoc = new GroupBox();
            chkThoigian = new CheckBox();
            chkHuy = new CheckBox();
            chkHoanThanh = new CheckBox();
            chkTuChoi = new CheckBox();
            chkDaduyet = new CheckBox();
            chkChoxuly = new CheckBox();
            label12 = new Label();
            label11 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            btXoaYC = new Button();
            dgv2 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            grbLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(5, 4, 5, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.ShowToolTips = true;
            tabControl1.Size = new Size(896, 548);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(255, 224, 192);
            tabPage1.Controls.Add(txtCountDG);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(cbThietBi);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(btnThoat);
            tabPage1.Controls.Add(btnLuu);
            tabPage1.Controls.Add(btnXoa);
            tabPage1.Controls.Add(btnSua);
            tabPage1.Controls.Add(btnThem);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(cbWin);
            tabPage1.Controls.Add(cbCPU);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cbRam);
            tabPage1.Controls.Add(cbPhanmem);
            tabPage1.Controls.Add(cbPhong);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(cbOCung);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(5, 4, 5, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5, 4, 5, 4);
            tabPage1.Size = new Size(888, 515);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Yêu cầu TB";
            tabPage1.Click += tabPage1_Click;
            // 
            // txtCountDG
            // 
            txtCountDG.Location = new Point(287, 453);
            txtCountDG.Margin = new Padding(5, 4, 5, 4);
            txtCountDG.Name = "txtCountDG";
            txtCountDG.Size = new Size(30, 38);
            txtCountDG.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(9, 468);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(298, 27);
            label10.TabIndex = 23;
            label10.Text = "Số lượng yêu cầu thiết bị mới";
            // 
            // cbThietBi
            // 
            cbThietBi.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbThietBi.FormattingEnabled = true;
            cbThietBi.Items.AddRange(new object[] { "Máy tính", "Máy chiếu", "Micro", "Maý lạnh" });
            cbThietBi.Location = new Point(306, 76);
            cbThietBi.Margin = new Padding(5, 4, 5, 4);
            cbThietBi.Name = "cbThietBi";
            cbThietBi.Size = new Size(137, 35);
            cbThietBi.TabIndex = 2;
            cbThietBi.SelectedIndexChanged += cbThietBi_SelectedIndexChanged_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(241, 4);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(486, 45);
            label9.TabIndex = 21;
            label9.Text = "YÊU CẦU THIẾT BỊ MỚI";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(0, 192, 192);
            btnThoat.Location = new Point(482, 452);
            btnThoat.Margin = new Padding(5, 4, 5, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(109, 43);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            btnThoat.MouseLeave += btnThoat_MouseLeave;
            btnThoat.MouseHover += btnThoat_MouseHover;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(0, 192, 192);
            btnLuu.Location = new Point(367, 452);
            btnLuu.Margin = new Padding(5, 4, 5, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(93, 43);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(0, 192, 192);
            btnXoa.Location = new Point(773, 299);
            btnXoa.Margin = new Padding(5, 4, 5, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(104, 51);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            btnXoa.MouseLeave += btnXoa_MouseLeave;
            btnXoa.MouseHover += btnXoa_MouseHover;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(0, 192, 192);
            btnSua.Location = new Point(773, 391);
            btnSua.Margin = new Padding(5, 4, 5, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(104, 51);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            btnSua.MouseLeave += btnSua_MouseLeave;
            btnSua.MouseHover += btnSua_MouseHover;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 192, 192);
            btnThem.Location = new Point(773, 211);
            btnThem.Margin = new Padding(5, 4, 5, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(104, 51);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            btnThem.MouseLeave += btnThem_MouseLeave;
            btnThem.MouseHover += btnThem_MouseHover;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 211);
            dataGridView1.Margin = new Padding(5, 4, 5, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(769, 231);
            dataGridView1.TabIndex = 15;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged_1;
            // 
            // cbWin
            // 
            cbWin.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbWin.FormattingEnabled = true;
            cbWin.Items.AddRange(new object[] { "Window 10", "Window 11", "Window 12", "N/A" });
            cbWin.Location = new Point(727, 129);
            cbWin.Margin = new Padding(5, 4, 5, 4);
            cbWin.Name = "cbWin";
            cbWin.Size = new Size(70, 35);
            cbWin.TabIndex = 4;
            // 
            // cbCPU
            // 
            cbCPU.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCPU.FormattingEnabled = true;
            cbCPU.Items.AddRange(new object[] { "i5", "i7", "i9", "N/A" });
            cbCPU.Location = new Point(83, 129);
            cbCPU.Margin = new Padding(5, 4, 5, 4);
            cbCPU.Name = "cbCPU";
            cbCPU.Size = new Size(92, 35);
            cbCPU.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(409, 136);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(98, 31);
            label8.TabIndex = 11;
            label8.Text = "Ổ cứng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(193, 136);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 31);
            label7.TabIndex = 10;
            label7.Text = "RAM";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 136);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 31);
            label6.TabIndex = 9;
            label6.Text = "CPU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(623, 136);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 31);
            label4.TabIndex = 7;
            label4.Text = "Window";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(453, 83);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 31);
            label3.TabIndex = 6;
            label3.Text = "Phần mềm";
            // 
            // cbRam
            // 
            cbRam.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbRam.FormattingEnabled = true;
            cbRam.Items.AddRange(new object[] { "4GB", "8GB", "12GB", ">12GB", "N/A" });
            cbRam.Location = new Point(270, 129);
            cbRam.Margin = new Padding(5, 4, 5, 4);
            cbRam.Name = "cbRam";
            cbRam.Size = new Size(132, 35);
            cbRam.TabIndex = 6;
            // 
            // cbPhanmem
            // 
            cbPhanmem.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPhanmem.FormattingEnabled = true;
            cbPhanmem.Location = new Point(578, 76);
            cbPhanmem.Margin = new Padding(5, 4, 5, 4);
            cbPhanmem.Name = "cbPhanmem";
            cbPhanmem.Size = new Size(166, 35);
            cbPhanmem.TabIndex = 3;
            // 
            // cbPhong
            // 
            cbPhong.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPhong.FormattingEnabled = true;
            cbPhong.ItemHeight = 27;
            cbPhong.Location = new Point(90, 76);
            cbPhong.Margin = new Padding(5, 4, 5, 4);
            cbPhong.Name = "cbPhong";
            cbPhong.Size = new Size(71, 35);
            cbPhong.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(171, 83);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(149, 31);
            label2.TabIndex = 2;
            label2.Text = "Tên thiết bị";
            // 
            // cbOCung
            // 
            cbOCung.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOCung.FormattingEnabled = true;
            cbOCung.Items.AddRange(new object[] { "128GB", "256GB", "512GB", "1024GB", ">1024GB", "N/A" });
            cbOCung.Location = new Point(505, 129);
            cbOCung.Margin = new Padding(5, 4, 5, 4);
            cbOCung.Name = "cbOCung";
            cbOCung.Size = new Size(108, 35);
            cbOCung.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 83);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 31);
            label1.TabIndex = 0;
            label1.Text = "Phòng:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btLoc);
            tabPage2.Controls.Add(btCancelLoc);
            tabPage2.Controls.Add(grbLoc);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(dateTimePicker2);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(btXoaYC);
            tabPage2.Controls.Add(dgv2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(5, 4, 5, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(5, 4, 5, 4);
            tabPage2.Size = new Size(888, 515);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lịch sử yêu cầu";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btLoc
            // 
            btLoc.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLoc.Location = new Point(688, 49);
            btLoc.Margin = new Padding(5, 4, 5, 4);
            btLoc.Name = "btLoc";
            btLoc.Size = new Size(101, 36);
            btLoc.TabIndex = 12;
            btLoc.Text = "Lọc";
            btLoc.UseVisualStyleBackColor = true;
            btLoc.Click += btLoc_Click;
            // 
            // btCancelLoc
            // 
            btCancelLoc.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelLoc.Location = new Point(688, 103);
            btCancelLoc.Margin = new Padding(5, 4, 5, 4);
            btCancelLoc.Name = "btCancelLoc";
            btCancelLoc.Size = new Size(101, 36);
            btCancelLoc.TabIndex = 10;
            btCancelLoc.Text = "Bỏ lọc";
            btCancelLoc.UseVisualStyleBackColor = true;
            btCancelLoc.Click += btCancelLoc_Click;
            // 
            // grbLoc
            // 
            grbLoc.Controls.Add(chkThoigian);
            grbLoc.Controls.Add(chkHuy);
            grbLoc.Controls.Add(chkHoanThanh);
            grbLoc.Controls.Add(chkTuChoi);
            grbLoc.Controls.Add(chkDaduyet);
            grbLoc.Controls.Add(chkChoxuly);
            grbLoc.Location = new Point(10, 29);
            grbLoc.Margin = new Padding(5, 4, 5, 4);
            grbLoc.Name = "grbLoc";
            grbLoc.Padding = new Padding(5, 4, 5, 4);
            grbLoc.Size = new Size(641, 109);
            grbLoc.TabIndex = 8;
            grbLoc.TabStop = false;
            grbLoc.Text = "Lọc dữ liệu";
            // 
            // chkThoigian
            // 
            chkThoigian.AutoSize = true;
            chkThoigian.Location = new Point(32, 73);
            chkThoigian.Margin = new Padding(5, 4, 5, 4);
            chkThoigian.Name = "chkThoigian";
            chkThoigian.Size = new Size(93, 24);
            chkThoigian.TabIndex = 5;
            chkThoigian.Text = "Thời gian";
            chkThoigian.UseVisualStyleBackColor = true;
            chkThoigian.CheckedChanged += chkThoigian_CheckedChanged;
            // 
            // chkHuy
            // 
            chkHuy.AutoSize = true;
            chkHuy.Location = new Point(32, 29);
            chkHuy.Margin = new Padding(5, 4, 5, 4);
            chkHuy.Name = "chkHuy";
            chkHuy.Size = new Size(111, 24);
            chkHuy.TabIndex = 0;
            chkHuy.Text = "Huỷ yêu cầu";
            chkHuy.UseVisualStyleBackColor = true;
            // 
            // chkHoanThanh
            // 
            chkHoanThanh.AutoSize = true;
            chkHoanThanh.Location = new Point(446, 29);
            chkHoanThanh.Margin = new Padding(5, 4, 5, 4);
            chkHoanThanh.Name = "chkHoanThanh";
            chkHoanThanh.Size = new Size(108, 24);
            chkHoanThanh.TabIndex = 4;
            chkHoanThanh.Text = "Hoàn thành";
            chkHoanThanh.UseVisualStyleBackColor = true;
            // 
            // chkTuChoi
            // 
            chkTuChoi.AutoSize = true;
            chkTuChoi.Location = new Point(154, 29);
            chkTuChoi.Margin = new Padding(5, 4, 5, 4);
            chkTuChoi.Name = "chkTuChoi";
            chkTuChoi.Size = new Size(80, 24);
            chkTuChoi.TabIndex = 2;
            chkTuChoi.Text = "Từ chối";
            chkTuChoi.UseVisualStyleBackColor = true;
            // 
            // chkDaduyet
            // 
            chkDaduyet.AutoSize = true;
            chkDaduyet.Location = new Point(345, 29);
            chkDaduyet.Margin = new Padding(5, 4, 5, 4);
            chkDaduyet.Name = "chkDaduyet";
            chkDaduyet.Size = new Size(91, 24);
            chkDaduyet.TabIndex = 3;
            chkDaduyet.Text = "Đã duyệt";
            chkDaduyet.UseVisualStyleBackColor = true;
            // 
            // chkChoxuly
            // 
            chkChoxuly.AutoSize = true;
            chkChoxuly.Location = new Point(246, 29);
            chkChoxuly.Margin = new Padding(5, 4, 5, 4);
            chkChoxuly.Name = "chkChoxuly";
            chkChoxuly.Size = new Size(92, 24);
            chkChoxuly.TabIndex = 1;
            chkChoxuly.Text = "Chờ xử lý";
            chkChoxuly.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(414, 157);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(70, 20);
            label12.TabIndex = 5;
            label12.Text = "đến ngày";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 157);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(62, 20);
            label11.TabIndex = 4;
            label11.Text = "Từ ngày";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(501, 157);
            dateTimePicker2.Margin = new Padding(5, 4, 5, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(266, 27);
            dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(114, 157);
            dateTimePicker1.Margin = new Padding(5, 4, 5, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // btXoaYC
            // 
            btXoaYC.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXoaYC.Location = new Point(473, 712);
            btXoaYC.Margin = new Padding(5, 4, 5, 4);
            btXoaYC.Name = "btXoaYC";
            btXoaYC.Size = new Size(158, 83);
            btXoaYC.TabIndex = 1;
            btXoaYC.Text = "Huỷ yêu cầu";
            btXoaYC.UseVisualStyleBackColor = true;
            btXoaYC.Click += btXoaYC_Click;
            // 
            // dgv2
            // 
            dgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv2.Location = new Point(-1, 197);
            dgv2.Margin = new Padding(5, 4, 5, 4);
            dgv2.Name = "dgv2";
            dgv2.RowHeadersWidth = 51;
            dgv2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv2.Size = new Size(1107, 427);
            dgv2.TabIndex = 0;
            // 
            // YeuCauThietBi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 548);
            Controls.Add(tabControl1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "YeuCauThietBi";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            grbLoc.ResumeLayout(false);
            grbLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbWin;
        private System.Windows.Forms.ComboBox cbCPU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRam;
        private System.Windows.Forms.ComboBox cbPhanmem;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOCung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbThietBi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCountDG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grbLoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btXoaYC;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button btCancelLoc;
        private System.Windows.Forms.Button btLoc;
        private System.Windows.Forms.CheckBox chkHoanThanh;
        private System.Windows.Forms.CheckBox chkDaduyet;
        private System.Windows.Forms.CheckBox chkTuChoi;
        private System.Windows.Forms.CheckBox chkChoxuly;
        private System.Windows.Forms.CheckBox chkHuy;
        private System.Windows.Forms.CheckBox chkThoigian;
    }
}

