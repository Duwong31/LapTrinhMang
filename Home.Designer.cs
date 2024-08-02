namespace ProjectNhom
{
    partial class Home
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
            listPConline = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            button7 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listPConline
            // 
            listPConline.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listPConline.Font = new Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listPConline.Location = new Point(177, 68);
            listPConline.Name = "listPConline";
            listPConline.Size = new Size(561, 256);
            listPConline.TabIndex = 1;
            listPConline.UseCompatibleStateImageBehavior = false;
            listPConline.View = View.Details;
            listPConline.SelectedIndexChanged += listPConline_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "IP Address";
            columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Computer Name";
            columnHeader2.Width = 250;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(181, 12);
            button2.Name = "button2";
            button2.Size = new Size(160, 50);
            button2.TabIndex = 2;
            button2.Text = "Change save location";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(103, 12);
            button3.Name = "button3";
            button3.Size = new Size(68, 55);
            button3.TabIndex = 3;
            button3.Text = "Stop";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LimeGreen;
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(85, 55);
            button4.TabIndex = 4;
            button4.Text = "Find/Start";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Location = new Point(6, 321);
            button5.Name = "button5";
            button5.Size = new Size(91, 52);
            button5.TabIndex = 5;
            button5.Text = "Browse";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaption;
            button6.Location = new Point(634, 379);
            button6.Name = "button6";
            button6.Size = new Size(104, 59);
            button6.TabIndex = 6;
            button6.Text = "Clear";
            button6.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 27);
            textBox1.TabIndex = 7;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaption;
            button7.Location = new Point(6, 379);
            button7.Name = "button7";
            button7.Size = new Size(306, 59);
            button7.TabIndex = 8;
            button7.Text = "Send file to selected computer";
            button7.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 102);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 9;
            label1.Text = "Input Receiver's IP";
            label1.Click += label1_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 450);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listPConline);
            Name = "Home";
            Text = "Large File Transfer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listPConline;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox1;
        private Button button7;
        private Label label1;
    }
}