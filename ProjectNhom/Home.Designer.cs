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
            textBox_IP = new TextBox();
            btn_SendFile = new Button();
            label1 = new Label();
            SaveFileLabel = new Label();
            FileNameLabel = new Label();
            NotificationLabel = new Label();
            NotificationFileSending = new Label();
            InfoLabel = new Label();
            ListFileSent = new ListBox();
            SuspendLayout();
            // 
            // listPConline
            // 
            listPConline.Activation = ItemActivation.OneClick;
            listPConline.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listPConline.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listPConline.Font = new Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listPConline.FullRowSelect = true;
            listPConline.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listPConline.HoverSelection = true;
            listPConline.Location = new Point(228, 68);
            listPConline.MultiSelect = false;
            listPConline.Name = "listPConline";
            listPConline.Size = new Size(656, 299);
            listPConline.TabIndex = 0;
            listPConline.UseCompatibleStateImageBehavior = false;
            listPConline.View = View.Details;
            listPConline.SelectedIndexChanged += listPConline_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "IP Address";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Computer Name";
            columnHeader2.Width = 450;
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
            btn_Savelocation.Click += btn_FileLocation_Click;
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
            btn_Stop.Click += btn_Stop_Click;
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
            btn_Find.Click += btn_Find_Click;
            // 
            // btn_Browse
            // 
            btn_Browse.BackColor = SystemColors.ActiveCaption;
            btn_Browse.BackgroundImageLayout = ImageLayout.None;
            btn_Browse.Image = Properties.Resources.project;
            btn_Browse.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Browse.Location = new Point(10, 369);
            btn_Browse.Name = "btn_Browse";
            btn_Browse.Size = new Size(109, 49);
            btn_Browse.TabIndex = 5;
            btn_Browse.Text = "Browse";
            btn_Browse.TextAlign = ContentAlignment.MiddleRight;
            btn_Browse.UseVisualStyleBackColor = false;
            btn_Browse.Click += btn_Browse_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = SystemColors.ActiveCaption;
            btn_Clear.Image = Properties.Resources.delete;
            btn_Clear.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Clear.Location = new Point(802, 409);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(83, 49);
            btn_Clear.TabIndex = 6;
            btn_Clear.Text = "Clear";
            btn_Clear.TextAlign = ContentAlignment.MiddleRight;
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // textBox_IP
            // 
            textBox_IP.BorderStyle = BorderStyle.FixedSingle;
            textBox_IP.Location = new Point(10, 142);
            textBox_IP.Name = "textBox_IP";
            textBox_IP.Size = new Size(150, 27);
            textBox_IP.TabIndex = 7;
            textBox_IP.TextChanged += textBox_ReceiverIP_TextChanged;
            // 
            // btn_SendFile
            // 
            btn_SendFile.BackColor = SystemColors.ActiveCaption;
            btn_SendFile.Image = Properties.Resources.icons8_send_file_32;
            btn_SendFile.ImageAlign = ContentAlignment.MiddleLeft;
            btn_SendFile.Location = new Point(10, 425);
            btn_SendFile.Name = "btn_SendFile";
            btn_SendFile.Size = new Size(109, 49);
            btn_SendFile.TabIndex = 8;
            btn_SendFile.Text = "Send File";
            btn_SendFile.TextAlign = ContentAlignment.MiddleRight;
            btn_SendFile.UseVisualStyleBackColor = false;
            btn_SendFile.Click += btn_SendFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 119);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 9;
            label1.Text = "Input Receiver's IP";
            label1.Click += label1_Click;
            // 
            // SaveFileLabel
            // 
            SaveFileLabel.AutoSize = true;
            SaveFileLabel.Location = new Point(383, 29);
            SaveFileLabel.Name = "SaveFileLabel";
            SaveFileLabel.Size = new Size(182, 20);
            SaveFileLabel.TabIndex = 10;
            SaveFileLabel.Text = "C:\\Users\\DELL\\Downloads";
            // 
            // FileNameLabel
            // 
            FileNameLabel.AutoSize = true;
            FileNameLabel.Location = new Point(128, 383);
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new Size(12, 20);
            FileNameLabel.TabIndex = 11;
            FileNameLabel.Text = ".";
            // 
            // NotificationLabel
            // 
            NotificationLabel.AutoSize = true;
            NotificationLabel.Location = new Point(12, 68);
            NotificationLabel.Name = "NotificationLabel";
            NotificationLabel.Size = new Size(12, 20);
            NotificationLabel.TabIndex = 12;
            NotificationLabel.Text = ".";
            NotificationLabel.Click += NotificationLabel_Click;
            // 
            // NotificationFileSending
            // 
            NotificationFileSending.AutoSize = true;
            NotificationFileSending.Location = new Point(128, 438);
            NotificationFileSending.Name = "NotificationFileSending";
            NotificationFileSending.Size = new Size(12, 20);
            NotificationFileSending.TabIndex = 13;
            NotificationFileSending.Text = ".";
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Location = new Point(12, 99);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(12, 20);
            InfoLabel.TabIndex = 14;
            InfoLabel.Text = ".";
            // 
            // ListFileSent
            // 
            ListFileSent.BorderStyle = BorderStyle.FixedSingle;
            ListFileSent.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListFileSent.FormattingEnabled = true;
            ListFileSent.HorizontalScrollbar = true;
            ListFileSent.ItemHeight = 22;
            ListFileSent.Items.AddRange(new object[] { "Files sent" });
            ListFileSent.Location = new Point(10, 189);
            ListFileSent.Name = "ListFileSent";
            ListFileSent.Size = new Size(200, 178);
            ListFileSent.TabIndex = 15;
            ListFileSent.SelectedIndexChanged += ListFileSent_SelectedIndexChanged;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 486);
            Controls.Add(ListFileSent);
            Controls.Add(InfoLabel);
            Controls.Add(NotificationFileSending);
            Controls.Add(NotificationLabel);
            Controls.Add(FileNameLabel);
            Controls.Add(SaveFileLabel);
            Controls.Add(label1);
            Controls.Add(btn_SendFile);
            Controls.Add(textBox_IP);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Browse);
            Controls.Add(btn_Find);
            Controls.Add(btn_Stop);
            Controls.Add(btn_Savelocation);
            Controls.Add(listPConline);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private TextBox textBox_IP;
        private Button btn_SendFile;
        private Label label1;
        private Label SaveFileLabel;
        private Label FileNameLabel;
        private Label NotificationLabel;
        private Label NotificationFileSending;
        private Label InfoLabel;
        private ListBox ListFileSent;
    }
}