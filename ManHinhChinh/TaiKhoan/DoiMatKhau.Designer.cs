namespace ManHinhChinh
{
    partial class DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_newPassword = new TextBox();
            txt_oldPassword = new TextBox();
            txt_confirmPassword = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(211, 206);
            button1.Name = "button1";
            button1.Size = new Size(110, 32);
            button1.TabIndex = 34;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 71);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 131);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(186, 155);
            label3.Name = "label3";
            label3.Size = new Size(165, 19);
            label3.TabIndex = 32;
            label3.Text = "Nhập lại mật khẩu mới";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(310, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(183, 102);
            label4.Name = "label4";
            label4.Size = new Size(103, 19);
            label4.TabIndex = 29;
            label4.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(183, 51);
            label2.Name = "label2";
            label2.Size = new Size(129, 19);
            label2.TabIndex = 28;
            label2.Text = "Mật khẩu hiện tại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 12);
            label1.Name = "label1";
            label1.Size = new Size(174, 31);
            label1.TabIndex = 27;
            label1.Text = "Đổi mật khẩu";
            // 
            // txt_newPassword
            // 
            txt_newPassword.Location = new Point(183, 121);
            txt_newPassword.Name = "txt_newPassword";
            txt_newPassword.PasswordChar = '*';
            txt_newPassword.Size = new Size(168, 23);
            txt_newPassword.TabIndex = 26;
            // 
            // txt_oldPassword
            // 
            txt_oldPassword.Location = new Point(183, 71);
            txt_oldPassword.Name = "txt_oldPassword";
            txt_oldPassword.PasswordChar = '*';
            txt_oldPassword.Size = new Size(168, 23);
            txt_oldPassword.TabIndex = 25;
            txt_oldPassword.TextChanged += textBox_TenTaiKhoan_TextChanged;
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.Location = new Point(183, 177);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.PasswordChar = '*';
            txt_confirmPassword.Size = new Size(168, 23);
            txt_confirmPassword.TabIndex = 35;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(357, 251);
            Controls.Add(txt_confirmPassword);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_newPassword);
            Controls.Add(txt_oldPassword);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DoiMatKhau";
            Text = "DoiMatKhau";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txt_newPassword;
        private TextBox txt_oldPassword;
        private TextBox txt_confirmPassword;
    }
}