namespace ManHinhChinh.QuanLyThietBi
{
    partial class ChiTietPhanMem
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
            groupBox2 = new GroupBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            dataGridView_ctpm = new DataGridView();
            groupBox1 = new GroupBox();
            txt_pmcn = new TextBox();
            btn_delete = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            label2 = new Label();
            label1 = new Label();
            txt_newSoft = new TextBox();
            txt_mamt = new TextBox();
            dateTimePicker_gv = new DateTimePicker();
            dateTimePicker_nv = new DateTimePicker();
            txt_thongbao = new TextBox();
            cb_tinhtrang = new ComboBox();
            txt_maphong = new TextBox();
            lbl_updateGV = new Label();
            lbl_giaovien = new Label();
            lbl_update = new Label();
            lbl_tinhtrang = new Label();
            lbl_idphong = new Label();
            id_device = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ctpm).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 224, 192);
            groupBox2.Controls.Add(dataGridView_ctpm);
            groupBox2.Location = new Point(404, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(375, 387);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin phần mềm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(545, 2);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "ID Phòng";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(607, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView_ctpm
            // 
            dataGridView_ctpm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ctpm.Location = new Point(6, 15);
            dataGridView_ctpm.Name = "dataGridView_ctpm";
            dataGridView_ctpm.Size = new Size(367, 368);
            dataGridView_ctpm.TabIndex = 0;
            dataGridView_ctpm.CellClick += dataGridView_ctpm_CellClick;
            dataGridView_ctpm.CellContentClick += dataGridView_ctpm_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.Controls.Add(txt_pmcn);
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(btn_edit);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_newSoft);
            groupBox1.Controls.Add(txt_mamt);
            groupBox1.Controls.Add(dateTimePicker_gv);
            groupBox1.Controls.Add(dateTimePicker_nv);
            groupBox1.Controls.Add(txt_thongbao);
            groupBox1.Controls.Add(cb_tinhtrang);
            groupBox1.Controls.Add(txt_maphong);
            groupBox1.Controls.Add(lbl_updateGV);
            groupBox1.Controls.Add(lbl_giaovien);
            groupBox1.Controls.Add(lbl_update);
            groupBox1.Controls.Add(lbl_tinhtrang);
            groupBox1.Controls.Add(lbl_idphong);
            groupBox1.Controls.Add(id_device);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 442);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin máy tính";
            // 
            // txt_pmcn
            // 
            txt_pmcn.Location = new Point(171, 305);
            txt_pmcn.Name = "txt_pmcn";
            txt_pmcn.Size = new Size(200, 23);
            txt_pmcn.TabIndex = 51;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = SystemColors.ActiveCaptionText;
            btn_delete.Location = new Point(244, 374);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(77, 33);
            btn_delete.TabIndex = 50;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_edit.ForeColor = SystemColors.ActiveCaptionText;
            btn_edit.Location = new Point(161, 374);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(77, 33);
            btn_edit.TabIndex = 49;
            btn_edit.Text = "Sửa";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = SystemColors.ActiveCaptionText;
            btn_add.Location = new Point(78, 374);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(77, 33);
            btn_add.TabIndex = 48;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 345);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 47;
            label2.Text = "Phần mềm mới";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 308);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 46;
            label1.Text = "Phần mềm muốn cập nhật";
            // 
            // txt_newSoft
            // 
            txt_newSoft.Location = new Point(171, 342);
            txt_newSoft.Name = "txt_newSoft";
            txt_newSoft.Size = new Size(200, 23);
            txt_newSoft.TabIndex = 42;
            // 
            // txt_mamt
            // 
            txt_mamt.Location = new Point(208, 55);
            txt_mamt.Multiline = true;
            txt_mamt.Name = "txt_mamt";
            txt_mamt.Size = new Size(120, 27);
            txt_mamt.TabIndex = 19;
            // 
            // dateTimePicker_gv
            // 
            dateTimePicker_gv.Location = new Point(172, 266);
            dateTimePicker_gv.Name = "dateTimePicker_gv";
            dateTimePicker_gv.Size = new Size(200, 23);
            dateTimePicker_gv.TabIndex = 18;
            // 
            // dateTimePicker_nv
            // 
            dateTimePicker_nv.Location = new Point(171, 146);
            dateTimePicker_nv.Name = "dateTimePicker_nv";
            dateTimePicker_nv.Size = new Size(200, 23);
            dateTimePicker_nv.TabIndex = 17;
            // 
            // txt_thongbao
            // 
            txt_thongbao.Location = new Point(172, 187);
            txt_thongbao.Multiline = true;
            txt_thongbao.Name = "txt_thongbao";
            txt_thongbao.Size = new Size(199, 59);
            txt_thongbao.TabIndex = 14;
            // 
            // cb_tinhtrang
            // 
            cb_tinhtrang.FormattingEnabled = true;
            cb_tinhtrang.Items.AddRange(new object[] { "Hoạt động", "Bảo trì" });
            cb_tinhtrang.Location = new Point(208, 97);
            cb_tinhtrang.Name = "cb_tinhtrang";
            cb_tinhtrang.Size = new Size(121, 23);
            cb_tinhtrang.TabIndex = 12;
            // 
            // txt_maphong
            // 
            txt_maphong.Location = new Point(208, 16);
            txt_maphong.Multiline = true;
            txt_maphong.Name = "txt_maphong";
            txt_maphong.Size = new Size(120, 27);
            txt_maphong.TabIndex = 11;
            // 
            // lbl_updateGV
            // 
            lbl_updateGV.AutoSize = true;
            lbl_updateGV.Location = new Point(9, 266);
            lbl_updateGV.Name = "lbl_updateGV";
            lbl_updateGV.Size = new Size(135, 15);
            lbl_updateGV.TabIndex = 6;
            lbl_updateGV.Text = "Ngày cập nhật giáo viên";
            // 
            // lbl_giaovien
            // 
            lbl_giaovien.AutoSize = true;
            lbl_giaovien.Location = new Point(9, 202);
            lbl_giaovien.Name = "lbl_giaovien";
            lbl_giaovien.Size = new Size(115, 15);
            lbl_giaovien.TabIndex = 5;
            lbl_giaovien.Text = "Thông báo giáo viên";
            // 
            // lbl_update
            // 
            lbl_update.AutoSize = true;
            lbl_update.Location = new Point(9, 146);
            lbl_update.Name = "lbl_update";
            lbl_update.RightToLeft = RightToLeft.No;
            lbl_update.Size = new Size(139, 15);
            lbl_update.TabIndex = 4;
            lbl_update.Text = "Ngày cập nhật nhân viên";
            // 
            // lbl_tinhtrang
            // 
            lbl_tinhtrang.AutoSize = true;
            lbl_tinhtrang.Location = new Point(15, 105);
            lbl_tinhtrang.Name = "lbl_tinhtrang";
            lbl_tinhtrang.Size = new Size(61, 15);
            lbl_tinhtrang.TabIndex = 3;
            lbl_tinhtrang.Text = "Tình trạng";
            // 
            // lbl_idphong
            // 
            lbl_idphong.AutoSize = true;
            lbl_idphong.Location = new Point(15, 19);
            lbl_idphong.Name = "lbl_idphong";
            lbl_idphong.Size = new Size(85, 15);
            lbl_idphong.TabIndex = 2;
            lbl_idphong.Text = "Mã phòng học";
            // 
            // id_device
            // 
            id_device.AutoSize = true;
            id_device.Location = new Point(15, 58);
            id_device.Name = "id_device";
            id_device.Size = new Size(64, 15);
            id_device.TabIndex = 0;
            id_device.Text = "Mã thiết bị";
            // 
            // ChiTietPhanMem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(784, 411);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ChiTietPhanMem";
            Text = "ChiTietPhanMem";
            Load += ChiTietPhanMem_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_ctpm).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView_ctpm;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker_gv;
        private DateTimePicker dateTimePicker_nv;
        private TextBox txt_thongbao;
        private ComboBox cb_tinhtrang;
        private Label lbl_updateGV;
        private Label lbl_giaovien;
        private Label lbl_update;
        private Label lbl_tinhtrang;
        private TextBox txt_mamt;
        private Label id_device;
        private Label label2;
        private Label label1;
        private TextBox txt_newSoft;
        private Button btn_delete;
        private Button btn_edit;
        private Button btn_add;
        private TextBox txt_maphong;
        private Label lbl_idphong;
        private TextBox txt_pmcn;
        private Label label3;
        private ComboBox comboBox1;
    }
}