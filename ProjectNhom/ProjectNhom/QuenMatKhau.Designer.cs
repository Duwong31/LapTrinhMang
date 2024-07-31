namespace ProjectNhom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMatKhau));
            label2 = new Label();
            textBox_emaildangky = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button_Laymatkhau = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(85, 285);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 11;
            label2.Text = "Email đăng ký:";
            label2.Click += label2_Click;
            // 
            // textBox_emaildangky
            // 
            textBox_emaildangky.BorderStyle = BorderStyle.FixedSingle;
            textBox_emaildangky.Location = new Point(276, 285);
            textBox_emaildangky.Multiline = true;
            textBox_emaildangky.Name = "textBox_emaildangky";
            textBox_emaildangky.Size = new Size(271, 40);
            textBox_emaildangky.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(206, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(94, 370);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 12;
            label1.Text = "Kết quả:";
            // 
            // button_Laymatkhau
            // 
            button_Laymatkhau.BackColor = SystemColors.ActiveCaption;
            button_Laymatkhau.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Laymatkhau.Location = new Point(231, 451);
            button_Laymatkhau.Name = "button_Laymatkhau";
            button_Laymatkhau.Size = new Size(162, 49);
            button_Laymatkhau.TabIndex = 13;
            button_Laymatkhau.Text = "Lấy Lại Mật Khẩu";
            button_Laymatkhau.UseVisualStyleBackColor = false;
            button_Laymatkhau.Click += button_Laymatkhau_Click;
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 532);
            Controls.Add(button_Laymatkhau);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox_emaildangky);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QuenMatKhau";
            Text = "Quên Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox_emaildangky;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button_Laymatkhau;
    }
}