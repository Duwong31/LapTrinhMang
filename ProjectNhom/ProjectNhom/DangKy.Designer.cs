namespace ProjectNhom
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            textBox_Matkhau = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox_Tentaikhoan = new TextBox();
            label3 = new Label();
            textBox_Xacnhanmatkhau = new TextBox();
            label4 = new Label();
            textBox_Email = new TextBox();
            button_DangKy = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox_Matkhau
            // 
            textBox_Matkhau.BorderStyle = BorderStyle.FixedSingle;
            textBox_Matkhau.Location = new Point(273, 315);
            textBox_Matkhau.Multiline = true;
            textBox_Matkhau.Name = "textBox_Matkhau";
            textBox_Matkhau.PasswordChar = '*';
            textBox_Matkhau.Size = new Size(271, 40);
            textBox_Matkhau.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(199, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(86, 315);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 6;
            label1.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(86, 269);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 8;
            label2.Text = "Username:";
            // 
            // textBox_Tentaikhoan
            // 
            textBox_Tentaikhoan.BorderStyle = BorderStyle.FixedSingle;
            textBox_Tentaikhoan.Location = new Point(273, 269);
            textBox_Tentaikhoan.Multiline = true;
            textBox_Tentaikhoan.Name = "textBox_Tentaikhoan";
            textBox_Tentaikhoan.Size = new Size(271, 40);
            textBox_Tentaikhoan.TabIndex = 7;
            textBox_Tentaikhoan.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(86, 361);
            label3.Name = "label3";
            label3.Size = new Size(170, 25);
            label3.TabIndex = 10;
            label3.Text = "Confirm password:";
            // 
            // textBox_Xacnhanmatkhau
            // 
            textBox_Xacnhanmatkhau.BorderStyle = BorderStyle.FixedSingle;
            textBox_Xacnhanmatkhau.Location = new Point(273, 361);
            textBox_Xacnhanmatkhau.Multiline = true;
            textBox_Xacnhanmatkhau.Name = "textBox_Xacnhanmatkhau";
            textBox_Xacnhanmatkhau.PasswordChar = '*';
            textBox_Xacnhanmatkhau.Size = new Size(271, 40);
            textBox_Xacnhanmatkhau.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(86, 407);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 12;
            label4.Text = "Email:";
            // 
            // textBox_Email
            // 
            textBox_Email.BorderStyle = BorderStyle.FixedSingle;
            textBox_Email.Location = new Point(273, 407);
            textBox_Email.Multiline = true;
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(271, 40);
            textBox_Email.TabIndex = 11;
            // 
            // button_DangKy
            // 
            button_DangKy.BackColor = SystemColors.ActiveCaption;
            button_DangKy.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_DangKy.Location = new Point(199, 469);
            button_DangKy.Name = "button_DangKy";
            button_DangKy.Size = new Size(215, 51);
            button_DangKy.TabIndex = 13;
            button_DangKy.Text = "Sign up";
            button_DangKy.UseVisualStyleBackColor = false;
            button_DangKy.Click += button_DangKy_Click;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 532);
            Controls.Add(button_DangKy);
            Controls.Add(label4);
            Controls.Add(textBox_Email);
            Controls.Add(label3);
            Controls.Add(textBox_Xacnhanmatkhau);
            Controls.Add(label2);
            Controls.Add(textBox_Tentaikhoan);
            Controls.Add(label1);
            Controls.Add(textBox_Matkhau);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DangKy";
            Text = "Create new account";
            Load += DangKi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Matkhau;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox_Tentaikhoan;
        private Label label3;
        private TextBox textBox_Xacnhanmatkhau;
        private Label label4;
        private TextBox textBox_Email;
        private Button button_DangKy;
    }
}