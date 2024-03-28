namespace WindowsFormsApp7
{
    partial class TongHopYeuCau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TongHopYeuCau));
            dgv1 = new DataGridView();
            btnDuyet = new Button();
            label2 = new Label();
            btnThoat = new Button();
            btnTuChoi = new Button();
            groupBox1 = new GroupBox();
            pictureBox6 = new PictureBox();
            chkThoigian = new CheckBox();
            chkHoanThanh = new CheckBox();
            chkDaduyet = new CheckBox();
            chkChoxuly = new CheckBox();
            chkTuChoi = new CheckBox();
            chkHuy = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label3 = new Label();
            btnBoLoc = new Button();
            btnLoc = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(30, 265);
            dgv1.Margin = new Padding(5, 4, 5, 4);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 51;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv1.Size = new Size(689, 277);
            dgv1.TabIndex = 3;
            // 
            // btnDuyet
            // 
            btnDuyet.BackColor = Color.FromArgb(0, 192, 192);
            btnDuyet.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDuyet.Location = new Point(731, 265);
            btnDuyet.Margin = new Padding(5, 4, 5, 4);
            btnDuyet.Name = "btnDuyet";
            btnDuyet.Size = new Size(150, 57);
            btnDuyet.TabIndex = 4;
            btnDuyet.Text = "Duyệt";
            btnDuyet.UseVisualStyleBackColor = false;
            btnDuyet.Click += btnDuyet_Click;
            btnDuyet.MouseLeave += btnDuyet_MouseLeave;
            btnDuyet.MouseHover += btnDuyet_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(166, 12);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(625, 38);
            label2.TabIndex = 6;
            label2.Text = "DANH SÁCH YÊU CẦU THIẾT BỊ MỚI";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(0, 192, 192);
            btnThoat.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(731, 436);
            btnThoat.Margin = new Padding(5, 4, 5, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 63);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            btnThoat.MouseLeave += btnThoat_MouseLeave;
            btnThoat.MouseHover += btnThoat_MouseHover;
            // 
            // btnTuChoi
            // 
            btnTuChoi.BackColor = Color.FromArgb(0, 192, 192);
            btnTuChoi.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTuChoi.Location = new Point(731, 348);
            btnTuChoi.Margin = new Padding(5, 4, 5, 4);
            btnTuChoi.Name = "btnTuChoi";
            btnTuChoi.Size = new Size(150, 63);
            btnTuChoi.TabIndex = 11;
            btnTuChoi.Text = "Từ chối";
            btnTuChoi.UseVisualStyleBackColor = false;
            btnTuChoi.Click += btnTuChoi_Click;
            btnTuChoi.MouseLeave += btnTuChoi_MouseLeave;
            btnTuChoi.MouseHover += btnTuChoi_MouseHover;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(chkThoigian);
            groupBox1.Controls.Add(chkHoanThanh);
            groupBox1.Controls.Add(chkDaduyet);
            groupBox1.Controls.Add(chkChoxuly);
            groupBox1.Controls.Add(chkTuChoi);
            groupBox1.Controls.Add(chkHuy);
            groupBox1.Location = new Point(15, 59);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(576, 147);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lọc dữ liệu";
            // 
            // pictureBox6
            // 
            pictureBox6.AccessibleRole = AccessibleRole.Grip;
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.BackgroundImageLayout = ImageLayout.Center;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(505, 81);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(49, 51);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 113;
            pictureBox6.TabStop = false;
            // 
            // chkThoigian
            // 
            chkThoigian.AutoSize = true;
            chkThoigian.Location = new Point(27, 99);
            chkThoigian.Margin = new Padding(5, 4, 5, 4);
            chkThoigian.Name = "chkThoigian";
            chkThoigian.Size = new Size(93, 24);
            chkThoigian.TabIndex = 5;
            chkThoigian.Text = "Thời gian";
            chkThoigian.UseVisualStyleBackColor = true;
            chkThoigian.CheckedChanged += chkThoigian_CheckedChanged;
            // 
            // chkHoanThanh
            // 
            chkHoanThanh.AutoSize = true;
            chkHoanThanh.Location = new Point(453, 48);
            chkHoanThanh.Margin = new Padding(5, 4, 5, 4);
            chkHoanThanh.Name = "chkHoanThanh";
            chkHoanThanh.Size = new Size(108, 24);
            chkHoanThanh.TabIndex = 4;
            chkHoanThanh.Text = "Hoàn thành";
            chkHoanThanh.UseVisualStyleBackColor = true;
            // 
            // chkDaduyet
            // 
            chkDaduyet.AutoSize = true;
            chkDaduyet.Location = new Point(352, 48);
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
            chkChoxuly.Location = new Point(251, 48);
            chkChoxuly.Margin = new Padding(5, 4, 5, 4);
            chkChoxuly.Name = "chkChoxuly";
            chkChoxuly.Size = new Size(92, 24);
            chkChoxuly.TabIndex = 2;
            chkChoxuly.Text = "Chờ xử lý";
            chkChoxuly.UseVisualStyleBackColor = true;
            // 
            // chkTuChoi
            // 
            chkTuChoi.AutoSize = true;
            chkTuChoi.Location = new Point(151, 48);
            chkTuChoi.Margin = new Padding(5, 4, 5, 4);
            chkTuChoi.Name = "chkTuChoi";
            chkTuChoi.Size = new Size(80, 24);
            chkTuChoi.TabIndex = 1;
            chkTuChoi.Text = "Từ chối";
            chkTuChoi.UseVisualStyleBackColor = true;
            // 
            // chkHuy
            // 
            chkHuy.AutoSize = true;
            chkHuy.Location = new Point(27, 48);
            chkHuy.Margin = new Padding(5, 4, 5, 4);
            chkHuy.Name = "chkHuy";
            chkHuy.Size = new Size(111, 24);
            chkHuy.TabIndex = 0;
            chkHuy.Text = "Huỷ yêu cầu";
            chkHuy.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(101, 209);
            dateTimePicker1.Margin = new Padding(5, 4, 5, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(453, 209);
            dateTimePicker2.Margin = new Padding(5, 4, 5, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(266, 27);
            dateTimePicker2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 209);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 15;
            label1.Text = "Từ ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 219);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 16;
            label3.Text = "đến ngày";
            // 
            // btnBoLoc
            // 
            btnBoLoc.BackColor = Color.FromArgb(0, 192, 192);
            btnBoLoc.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBoLoc.Location = new Point(617, 145);
            btnBoLoc.Margin = new Padding(5, 4, 5, 4);
            btnBoLoc.Name = "btnBoLoc";
            btnBoLoc.Size = new Size(101, 39);
            btnBoLoc.TabIndex = 17;
            btnBoLoc.Text = "Bỏ lọc";
            btnBoLoc.UseVisualStyleBackColor = false;
            btnBoLoc.Click += btnBoLoc_Click;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.FromArgb(0, 192, 192);
            btnLoc.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoc.Location = new Point(615, 75);
            btnLoc.Margin = new Padding(5, 4, 5, 4);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(103, 40);
            btnLoc.TabIndex = 18;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // TongHopYeuCau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(896, 548);
            Controls.Add(btnLoc);
            Controls.Add(btnBoLoc);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBox1);
            Controls.Add(btnTuChoi);
            Controls.Add(btnThoat);
            Controls.Add(label2);
            Controls.Add(btnDuyet);
            Controls.Add(dgv1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "TongHopYeuCau";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnDuyet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTuChoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBoLoc;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.CheckBox chkThoigian;
        private System.Windows.Forms.CheckBox chkHoanThanh;
        private System.Windows.Forms.CheckBox chkDaduyet;
        private System.Windows.Forms.CheckBox chkChoxuly;
        private System.Windows.Forms.CheckBox chkTuChoi;
        private System.Windows.Forms.CheckBox chkHuy;
        private PictureBox pictureBox6;
    }
}

