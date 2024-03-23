
namespace ManHinhChinh
{
    partial class QuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMatKhau));
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_email = new TextBox();
            txt_TenTaiKhoan = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txt_phone = new TextBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(192, 256);
            button1.Name = "button1";
            button1.Size = new Size(156, 32);
            button1.TabIndex = 24;
            button1.Text = "Lấy lại mật khẩu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(182, 149);
            label4.Name = "label4";
            label4.Size = new Size(100, 19);
            label4.TabIndex = 19;
            label4.Text = "Địa chỉ email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(182, 98);
            label2.Name = "label2";
            label2.Size = new Size(103, 19);
            label2.TabIndex = 18;
            label2.Text = "Tên tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 40);
            label1.Name = "label1";
            label1.Size = new Size(195, 31);
            label1.TabIndex = 17;
            label1.Text = "Quên mật khẩu";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(182, 168);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(178, 23);
            txt_email.TabIndex = 16;
            // 
            // txt_TenTaiKhoan
            // 
            txt_TenTaiKhoan.Location = new Point(182, 118);
            txt_TenTaiKhoan.Name = "txt_TenTaiKhoan";
            txt_TenTaiKhoan.Size = new Size(178, 23);
            txt_TenTaiKhoan.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(329, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(185, 202);
            label3.Name = "label3";
            label3.Size = new Size(98, 19);
            label3.TabIndex = 22;
            label3.Text = "Số điện thoại";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(185, 220);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(178, 23);
            txt_phone.TabIndex = 21;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 118);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 131);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(378, 336);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(txt_phone);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_email);
            Controls.Add(txt_TenTaiKhoan);
            Margin = new Padding(3, 2, 3, 2);
            Name = "QuenMatKhau";
            Text = "QuenMatKhau";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txt_email;
        private TextBox txt_TenTaiKhoan;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txt_phone;
        private PictureBox pictureBox2;
    }
}