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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            listPConline = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btn_Savelocation = new Button();
            btn_Stop = new Button();
            btn_Find = new Button();
            btn_Browse = new Button();
            btn_Clear = new Button();
            textBox_ReceiverIP = new TextBox();
            btn_SendFile = new Button();
            label1 = new Label();
            label2 = new Label();
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
            // btn_Savelocation
            // 
            btn_Savelocation.BackColor = SystemColors.ActiveCaption;
            btn_Savelocation.Location = new Point(181, 12);
            btn_Savelocation.Name = "btn_Savelocation";
            btn_Savelocation.Size = new Size(160, 50);
            btn_Savelocation.TabIndex = 2;
            btn_Savelocation.Text = "Change save location";
            btn_Savelocation.UseVisualStyleBackColor = false;
            btn_Savelocation.Click += button2_Click;
            // 
            // btn_Stop
            // 
            btn_Stop.BackColor = Color.Red;
            btn_Stop.Location = new Point(103, 12);
            btn_Stop.Name = "btn_Stop";
            btn_Stop.Size = new Size(68, 55);
            btn_Stop.TabIndex = 3;
            btn_Stop.Text = "Stop";
            btn_Stop.UseVisualStyleBackColor = false;
            btn_Stop.Click += btn__Click;
            // 
            // btn_Find
            // 
            btn_Find.BackColor = Color.LimeGreen;
            btn_Find.Location = new Point(12, 12);
            btn_Find.Name = "btn_Find";
            btn_Find.Size = new Size(85, 55);
            btn_Find.TabIndex = 4;
            btn_Find.Text = "Find/Start";
            btn_Find.UseVisualStyleBackColor = false;
            // 
            // btn_Browse
            // 
            btn_Browse.BackColor = SystemColors.ActiveCaption;
            btn_Browse.Font = new Font("Segoe UI", 10.8F);
            btn_Browse.Image = (Image)resources.GetObject("btn_Browse.Image");
            btn_Browse.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Browse.Location = new Point(12, 314);
            btn_Browse.Name = "btn_Browse";
            btn_Browse.Size = new Size(112, 59);
            btn_Browse.TabIndex = 5;
            btn_Browse.Text = "Browse";
            btn_Browse.TextAlign = ContentAlignment.MiddleRight;
            btn_Browse.UseVisualStyleBackColor = false;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = SystemColors.ActiveCaption;
            btn_Clear.Font = new Font("Segoe UI", 10.8F);
            btn_Clear.Image = (Image)resources.GetObject("btn_Clear.Image");
            btn_Clear.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Clear.Location = new Point(650, 379);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(88, 59);
            btn_Clear.TabIndex = 6;
            btn_Clear.Text = "Clear";
            btn_Clear.TextAlign = ContentAlignment.MiddleRight;
            btn_Clear.UseVisualStyleBackColor = false;
            // 
            // textBox_ReceiverIP
            // 
            textBox_ReceiverIP.Location = new Point(12, 125);
            textBox_ReceiverIP.Name = "textBox_ReceiverIP";
            textBox_ReceiverIP.Size = new Size(148, 27);
            textBox_ReceiverIP.TabIndex = 7;
            // 
            // btn_SendFile
            // 
            btn_SendFile.BackColor = SystemColors.ActiveCaption;
            btn_SendFile.Font = new Font("Segoe UI", 10.8F);
            btn_SendFile.ForeColor = SystemColors.ControlText;
            btn_SendFile.Image = (Image)resources.GetObject("btn_SendFile.Image");
            btn_SendFile.ImageAlign = ContentAlignment.MiddleLeft;
            btn_SendFile.Location = new Point(12, 379);
            btn_SendFile.Name = "btn_SendFile";
            btn_SendFile.Size = new Size(294, 59);
            btn_SendFile.TabIndex = 8;
            btn_SendFile.Text = "Send file to selected computer";
            btn_SendFile.TextAlign = ContentAlignment.MiddleRight;
            btn_SendFile.UseVisualStyleBackColor = false;
            btn_SendFile.Click += button7_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 27);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 10;
            label2.Text = "C:\\";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_SendFile);
            Controls.Add(textBox_ReceiverIP);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Browse);
            Controls.Add(btn_Find);
            Controls.Add(btn_Stop);
            Controls.Add(btn_Savelocation);
            Controls.Add(listPConline);
            Name = "Home";
            Text = "Large File Transfer";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listPConline;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btn_Savelocation;
        private Button btn_Stop;
        private Button btn_Find;
        private Button btn_Browse;
        private Button btn_Clear;
        private TextBox textBox_ReceiverIP;
        private Button btn_SendFile;
        private Label label1;
        private Label label2;
    }
}