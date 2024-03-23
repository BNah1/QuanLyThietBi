namespace ManHinhChinh
{
    partial class ThongTinCaNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinCaNhan));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            textBoxEmail = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxSDT = new TextBox();
            labelTen = new Label();
            labelSDT = new Label();
            labelEmail = new Label();
            labelTenTaiKhoan = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(419, 298);
            button1.Name = "button1";
            button1.Size = new Size(137, 40);
            button1.TabIndex = 44;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(711, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(280, 127);
            label2.Name = "label2";
            label2.Size = new Size(44, 24);
            label2.TabIndex = 39;
            label2.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vast Shadow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(313, 9);
            label1.Name = "label1";
            label1.Size = new Size(369, 34);
            label1.TabIndex = 38;
            label1.Text = "Thông tin cá nhân";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(280, 228);
            label3.Name = "label3";
            label3.Size = new Size(63, 24);
            label3.TabIndex = 46;
            label3.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(419, 227);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(224, 33);
            textBoxEmail.TabIndex = 45;
            textBoxEmail.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(280, 82);
            label4.Name = "label4";
            label4.Size = new Size(133, 24);
            label4.TabIndex = 48;
            label4.Text = "Tên tài khoản";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(280, 175);
            label5.Name = "label5";
            label5.Size = new Size(125, 24);
            label5.TabIndex = 50;
            label5.Text = "Số điện thoại";
            // 
            // textBoxSDT
            // 
            textBoxSDT.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSDT.Location = new Point(419, 176);
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.Size = new Size(224, 33);
            textBoxSDT.TabIndex = 49;
            textBoxSDT.Visible = false;
            // 
            // labelTen
            // 
            labelTen.AutoSize = true;
            labelTen.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelTen.Location = new Point(419, 134);
            labelTen.Name = "labelTen";
            labelTen.Size = new Size(43, 17);
            labelTen.TabIndex = 51;
            labelTen.Text = "label6";
            // 
            // labelSDT
            // 
            labelSDT.AutoSize = true;
            labelSDT.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelSDT.Location = new Point(418, 180);
            labelSDT.Name = "labelSDT";
            labelSDT.Size = new Size(43, 17);
            labelSDT.TabIndex = 52;
            labelSDT.Text = "label6";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelEmail.Location = new Point(418, 233);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(43, 17);
            labelEmail.TabIndex = 53;
            labelEmail.Text = "label6";
            // 
            // labelTenTaiKhoan
            // 
            labelTenTaiKhoan.AutoSize = true;
            labelTenTaiKhoan.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelTenTaiKhoan.Location = new Point(419, 87);
            labelTenTaiKhoan.Name = "labelTenTaiKhoan";
            labelTenTaiKhoan.Size = new Size(43, 17);
            labelTenTaiKhoan.TabIndex = 54;
            labelTenTaiKhoan.Text = "label6";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(649, 175);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 55;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(649, 225);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 56;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 72);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(242, 252);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 57;
            pictureBox4.TabStop = false;
            // 
            // ThongTinCaNhan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(784, 411);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(labelTenTaiKhoan);
            Controls.Add(labelEmail);
            Controls.Add(labelSDT);
            Controls.Add(labelTen);
            Controls.Add(label5);
            Controls.Add(textBoxSDT);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxEmail);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ThongTinCaNhan";
            Text = "ThongTinCaNhan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label4;
        private Label label5;
        private TextBox textBoxSDT;
        private Label labelTen;
        private Label labelSDT;
        private Label labelEmail;
        private Label labelTenTaiKhoan;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}