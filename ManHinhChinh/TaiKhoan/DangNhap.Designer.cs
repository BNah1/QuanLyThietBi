﻿namespace Form_DangNhap_Dangky_QMK
{
    partial class DangNhap
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
            Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            pictureBox2 = new PictureBox();
            txt_TenTaiKhoan = new TextBox();
            pictureBox3 = new PictureBox();
            txt_MatKhau = new TextBox();
            linkLabel_QuenMatKhau = new LinkLabel();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(487, 308);
            button1.Name = "button1";
            button1.Size = new Size(153, 30);
            button1.TabIndex = 5;
            button1.Text = "Đăng Nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(437, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txt_TenTaiKhoan
            // 
            txt_TenTaiKhoan.Location = new Point(487, 154);
            txt_TenTaiKhoan.Name = "txt_TenTaiKhoan";
            txt_TenTaiKhoan.Size = new Size(176, 23);
            txt_TenTaiKhoan.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(437, 215);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(487, 231);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.PasswordChar = '*';
            txt_MatKhau.Size = new Size(176, 23);
            txt_MatKhau.TabIndex = 2;
            // 
            // linkLabel_QuenMatKhau
            // 
            linkLabel_QuenMatKhau.AutoSize = true;
            linkLabel_QuenMatKhau.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            linkLabel_QuenMatKhau.Location = new Point(498, 341);
            linkLabel_QuenMatKhau.Name = "linkLabel_QuenMatKhau";
            linkLabel_QuenMatKhau.Size = new Size(118, 18);
            linkLabel_QuenMatKhau.TabIndex = 3;
            linkLabel_QuenMatKhau.TabStop = true;
            linkLabel_QuenMatKhau.Text = "Quên Mật Khẩu";
            linkLabel_QuenMatKhau.LinkClicked += linkLabel_QuenMatKhau_LinkClicked;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(674, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = ManHinhChinh.Properties.Resources.Logo_UEH_xanh;
            pictureBox1.Location = new Point(45, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 169);
            label1.Name = "label1";
            label1.Size = new Size(324, 31);
            label1.TabIndex = 9;
            label1.Text = "Quản lý thiết bị phòng học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(487, 134);
            label2.Name = "label2";
            label2.Size = new Size(103, 19);
            label2.TabIndex = 10;
            label2.Text = "Tên tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(473, 63);
            label3.Name = "label3";
            label3.Size = new Size(162, 31);
            label3.TabIndex = 11;
            label3.Text = "WELCOME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(487, 212);
            label4.Name = "label4";
            label4.Size = new Size(73, 19);
            label4.TabIndex = 12;
            label4.Text = "Mật khẩu";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.InitialImage = ManHinhChinh.Properties.Resources.Logo_UEH_xanh;
            pictureBox5.Location = new Point(45, 163);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(292, 256);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(-4, -9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 393);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(498, 262);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(119, 19);
            radioButton1.TabIndex = 16;
            radioButton1.Text = "Ghi nhớ tài khoản";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(498, 285);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(132, 19);
            radioButton2.TabIndex = 17;
            radioButton2.Text = "Không lưu tài khoản";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(712, 375);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(button1);
            Controls.Add(linkLabel_QuenMatKhau);
            Controls.Add(txt_MatKhau);
            Controls.Add(pictureBox3);
            Controls.Add(txt_TenTaiKhoan);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += DangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private TextBox txt_TenTaiKhoan;
        private PictureBox pictureBox3;
        private TextBox txt_MatKhau;
        private LinkLabel linkLabel_QuenMatKhau;
        private Button button1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox5;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}