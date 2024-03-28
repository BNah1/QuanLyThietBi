namespace WinFormsApp1
{
    partial class ChiTietThietBi_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cb_idphong = new ComboBox();
            label1 = new Label();
            btn_delete = new Button();
            txt_matb = new TextBox();
            dateTimePicker_gv = new DateTimePicker();
            dateTimePicker_nv = new DateTimePicker();
            txt_thongbao = new TextBox();
            cb_tinhtrang = new ComboBox();
            txt_maphong = new TextBox();
            txt_tentb = new TextBox();
            btn_edit = new Button();
            btn_add = new Button();
            lbl_updateGV = new Label();
            lbl_giaovien = new Label();
            lbl_update = new Label();
            lbl_tinhtrang = new Label();
            lbl_idphong = new Label();
            lbl_name = new Label();
            id_device = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.Controls.Add(cb_idphong);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(txt_matb);
            groupBox1.Controls.Add(dateTimePicker_gv);
            groupBox1.Controls.Add(dateTimePicker_nv);
            groupBox1.Controls.Add(txt_thongbao);
            groupBox1.Controls.Add(cb_tinhtrang);
            groupBox1.Controls.Add(txt_maphong);
            groupBox1.Controls.Add(txt_tentb);
            groupBox1.Controls.Add(btn_edit);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(lbl_updateGV);
            groupBox1.Controls.Add(lbl_giaovien);
            groupBox1.Controls.Add(lbl_update);
            groupBox1.Controls.Add(lbl_tinhtrang);
            groupBox1.Controls.Add(lbl_idphong);
            groupBox1.Controls.Add(lbl_name);
            groupBox1.Controls.Add(id_device);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(869, 541);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thiết bị";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cb_idphong
            // 
            cb_idphong.FormattingEnabled = true;
            cb_idphong.Location = new Point(683, 4);
            cb_idphong.Margin = new Padding(3, 4, 3, 4);
            cb_idphong.Name = "cb_idphong";
            cb_idphong.Size = new Size(138, 28);
            cb_idphong.TabIndex = 1;
            cb_idphong.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(526, 7);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 2;
            label1.Text = "Chọn ID Phòng";
            label1.Click += label1_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(0, 192, 192);
            btn_delete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = SystemColors.ActiveCaptionText;
            btn_delete.Location = new Point(703, 208);
            btn_delete.Margin = new Padding(3, 4, 3, 4);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(88, 44);
            btn_delete.TabIndex = 20;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            btn_delete.MouseLeave += btn_delete_MouseLeave;
            btn_delete.MouseHover += btn_delete_MouseHover;
            // 
            // txt_matb
            // 
            txt_matb.Location = new Point(232, 39);
            txt_matb.Margin = new Padding(3, 4, 3, 4);
            txt_matb.Multiline = true;
            txt_matb.Name = "txt_matb";
            txt_matb.Size = new Size(137, 40);
            txt_matb.TabIndex = 19;
            txt_matb.Text = " ";
            // 
            // dateTimePicker_gv
            // 
            dateTimePicker_gv.Location = new Point(589, 160);
            dateTimePicker_gv.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker_gv.Name = "dateTimePicker_gv";
            dateTimePicker_gv.Size = new Size(241, 27);
            dateTimePicker_gv.TabIndex = 18;
            // 
            // dateTimePicker_nv
            // 
            dateTimePicker_nv.Location = new Point(589, 43);
            dateTimePicker_nv.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker_nv.Name = "dateTimePicker_nv";
            dateTimePicker_nv.Size = new Size(241, 27);
            dateTimePicker_nv.TabIndex = 17;
            // 
            // txt_thongbao
            // 
            txt_thongbao.Location = new Point(589, 81);
            txt_thongbao.Margin = new Padding(3, 4, 3, 4);
            txt_thongbao.Multiline = true;
            txt_thongbao.Name = "txt_thongbao";
            txt_thongbao.Size = new Size(241, 69);
            txt_thongbao.TabIndex = 14;
            // 
            // cb_tinhtrang
            // 
            cb_tinhtrang.FormattingEnabled = true;
            cb_tinhtrang.Items.AddRange(new object[] { "Hoạt động", "Bảo trì", "Sữa chửa" });
            cb_tinhtrang.Location = new Point(231, 188);
            cb_tinhtrang.Margin = new Padding(3, 4, 3, 4);
            cb_tinhtrang.Name = "cb_tinhtrang";
            cb_tinhtrang.Size = new Size(138, 28);
            cb_tinhtrang.TabIndex = 12;
            // 
            // txt_maphong
            // 
            txt_maphong.Location = new Point(232, 137);
            txt_maphong.Margin = new Padding(3, 4, 3, 4);
            txt_maphong.Multiline = true;
            txt_maphong.Name = "txt_maphong";
            txt_maphong.Size = new Size(137, 40);
            txt_maphong.TabIndex = 11;
            // 
            // txt_tentb
            // 
            txt_tentb.Location = new Point(232, 88);
            txt_tentb.Margin = new Padding(3, 4, 3, 4);
            txt_tentb.Multiline = true;
            txt_tentb.Name = "txt_tentb";
            txt_tentb.Size = new Size(137, 40);
            txt_tentb.TabIndex = 10;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(0, 192, 192);
            btn_edit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_edit.ForeColor = SystemColors.ActiveCaptionText;
            btn_edit.Location = new Point(563, 208);
            btn_edit.Margin = new Padding(3, 4, 3, 4);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(88, 44);
            btn_edit.TabIndex = 8;
            btn_edit.Text = "Sửa";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            btn_edit.MouseLeave += btn_edit_MouseLeave;
            btn_edit.MouseHover += btn_edit_MouseHover;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(0, 192, 192);
            btn_add.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = SystemColors.ActiveCaptionText;
            btn_add.Location = new Point(434, 208);
            btn_add.Margin = new Padding(3, 4, 3, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(88, 44);
            btn_add.TabIndex = 7;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            btn_add.MouseLeave += btn_add_MouseLeave;
            btn_add.MouseHover += btn_add_MouseHover;
            // 
            // lbl_updateGV
            // 
            lbl_updateGV.AutoSize = true;
            lbl_updateGV.ForeColor = SystemColors.ActiveCaptionText;
            lbl_updateGV.Location = new Point(402, 160);
            lbl_updateGV.Name = "lbl_updateGV";
            lbl_updateGV.Size = new Size(170, 20);
            lbl_updateGV.TabIndex = 6;
            lbl_updateGV.Text = "Ngày cập nhật giáo viên";
            // 
            // lbl_giaovien
            // 
            lbl_giaovien.AutoSize = true;
            lbl_giaovien.ForeColor = SystemColors.ActiveCaptionText;
            lbl_giaovien.Location = new Point(403, 101);
            lbl_giaovien.Name = "lbl_giaovien";
            lbl_giaovien.Size = new Size(146, 20);
            lbl_giaovien.TabIndex = 5;
            lbl_giaovien.Text = "Thông báo giáo viên";
            // 
            // lbl_update
            // 
            lbl_update.AutoSize = true;
            lbl_update.ForeColor = SystemColors.ActiveCaptionText;
            lbl_update.Location = new Point(403, 43);
            lbl_update.Name = "lbl_update";
            lbl_update.RightToLeft = RightToLeft.No;
            lbl_update.Size = new Size(172, 20);
            lbl_update.TabIndex = 4;
            lbl_update.Text = "Ngày cập nhật nhân viên";
            // 
            // lbl_tinhtrang
            // 
            lbl_tinhtrang.AutoSize = true;
            lbl_tinhtrang.ForeColor = SystemColors.ActiveCaptionText;
            lbl_tinhtrang.Location = new Point(6, 192);
            lbl_tinhtrang.Name = "lbl_tinhtrang";
            lbl_tinhtrang.Size = new Size(76, 20);
            lbl_tinhtrang.TabIndex = 3;
            lbl_tinhtrang.Text = "Tình trạng";
            // 
            // lbl_idphong
            // 
            lbl_idphong.AutoSize = true;
            lbl_idphong.ForeColor = SystemColors.ActiveCaptionText;
            lbl_idphong.Location = new Point(7, 147);
            lbl_idphong.Name = "lbl_idphong";
            lbl_idphong.Size = new Size(105, 20);
            lbl_idphong.TabIndex = 2;
            lbl_idphong.Text = "Mã phòng học";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.ForeColor = SystemColors.ActiveCaptionText;
            lbl_name.Location = new Point(7, 101);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(83, 20);
            lbl_name.TabIndex = 1;
            lbl_name.Text = "Tên thiết bị";
            // 
            // id_device
            // 
            id_device.AutoSize = true;
            id_device.ForeColor = SystemColors.ActiveCaptionText;
            id_device.Location = new Point(7, 43);
            id_device.Name = "id_device";
            id_device.Size = new Size(81, 20);
            id_device.TabIndex = 0;
            id_device.Text = "Mã thiết bị";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 224, 192);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(6, 245);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(871, 343);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 11);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(838, 277);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ChiTietThietBi_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(896, 548);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ControlLight;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChiTietThietBi_Form";
            Text = "Chi tiết thiết bị";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbl_tinhtrang;
        private Label lbl_idphong;
        private Label lbl_name;
        private Label id_device;
        private GroupBox groupBox2;
        private Button btn_edit;
        private Button btn_add;
        private Label lbl_updateGV;
        private Label lbl_giaovien;
        private Label lbl_update;
        private TextBox txt_maphong;
        private TextBox txt_tentb;
        private ComboBox cb_tinhtrang;
        private TextBox txt_thongbao;
        private DateTimePicker dateTimePicker_gv;
        private DateTimePicker dateTimePicker_nv;
        private TextBox txt_matb;
        private Button btn_delete;
        private ComboBox cb_idphong;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
