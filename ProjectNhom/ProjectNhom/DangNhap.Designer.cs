namespace ProjectNhom
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            pictureBox1 = new PictureBox();
            linkLabel_QuenMatKhau = new LinkLabel();
            pictureBox2 = new PictureBox();
            textBox_username = new TextBox();
            textBox_password = new TextBox();
            pictureBox3 = new PictureBox();
            button_DangNhap = new Button();
            button_DangKy = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gojo__saison2_;
            pictureBox1.Location = new Point(209, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // linkLabel_QuenMatKhau
            // 
            linkLabel_QuenMatKhau.AutoSize = true;
            linkLabel_QuenMatKhau.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel_QuenMatKhau.Location = new Point(318, 397);
            linkLabel_QuenMatKhau.Name = "linkLabel_QuenMatKhau";
            linkLabel_QuenMatKhau.Size = new Size(162, 25);
            linkLabel_QuenMatKhau.TabIndex = 1;
            linkLabel_QuenMatKhau.TabStop = true;
            linkLabel_QuenMatKhau.Text = "Quên Mật Khẩu?";
            linkLabel_QuenMatKhau.LinkClicked += linkLabel_QuenMatKhau_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2024_07_30_193426;
            pictureBox2.Location = new Point(136, 265);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // textBox_username
            // 
            textBox_username.BorderStyle = BorderStyle.FixedSingle;
            textBox_username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_username.Location = new Point(209, 265);
            textBox_username.Multiline = true;
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(271, 40);
            textBox_username.TabIndex = 3;
            // 
            // textBox_password
            // 
            textBox_password.BorderStyle = BorderStyle.FixedSingle;
            textBox_password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_password.Location = new Point(209, 339);
            textBox_password.Multiline = true;
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(271, 40);
            textBox_password.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Screenshot_2024_07_30_1930541;
            pictureBox3.Location = new Point(136, 339);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // button_DangNhap
            // 
            button_DangNhap.BackColor = SystemColors.ActiveCaption;
            button_DangNhap.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_DangNhap.Location = new Point(209, 460);
            button_DangNhap.Name = "button_DangNhap";
            button_DangNhap.Size = new Size(215, 43);
            button_DangNhap.TabIndex = 7;
            button_DangNhap.Text = "Đăng Nhập";
            button_DangNhap.UseVisualStyleBackColor = false;
            button_DangNhap.Click += button_DangNhap_Click;
            // 
            // button_DangKy
            // 
            button_DangKy.BackColor = SystemColors.ActiveCaption;
            button_DangKy.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_DangKy.Location = new Point(528, 12);
            button_DangKy.Name = "button_DangKy";
            button_DangKy.Size = new Size(82, 43);
            button_DangKy.TabIndex = 8;
            button_DangKy.Text = "Đăng Ký";
            button_DangKy.UseVisualStyleBackColor = false;
            button_DangKy.Click += button_DangKy_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 532);
            Controls.Add(button_DangKy);
            Controls.Add(button_DangNhap);
            Controls.Add(textBox_password);
            Controls.Add(pictureBox3);
            Controls.Add(textBox_username);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabel_QuenMatKhau);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DangNhap";
            Text = "Đăng nhập";
            Load += DangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel linkLabel_QuenMatKhau;
        private PictureBox pictureBox2;
        private TextBox textBox_username;
        private TextBox textBox_password;
        private PictureBox pictureBox3;
        private Button button_DangNhap;
        private Button button_DangKy;
    }
}
