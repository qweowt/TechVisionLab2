namespace TechVisionLab2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ListView = new ListView();
            pictureBox1 = new PictureBox();
            PathTb = new TextBox();
            PathSetButton = new Button();
            PixelRead = new RadioButton();
            labelPixelColor = new Label();
            radioButton1 = new RadioButton();
            RminTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            RmaxTB = new TextBox();
            label3 = new Label();
            GmaxTB = new TextBox();
            label4 = new Label();
            GminTB = new TextBox();
            label5 = new Label();
            BmaxTB = new TextBox();
            label6 = new Label();
            BminTB = new TextBox();
            BlackMask = new Button();
            checkBox1 = new CheckBox();
            AvgLabel = new Label();
            Compress = new Button();
            clusterSearchBtn = new Button();
            comboBox1 = new ComboBox();
            label7 = new Label();
            autoMode = new Button();
            YellowSearchBtn = new Button();
            GreenSearchBtn = new Button();
            RedSearchBtn = new Button();
            listBox1 = new ListBox();
            ListBoxClearBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ListView
            // 
            ListView.Location = new Point(10, 9);
            ListView.Margin = new Padding(3, 2, 3, 2);
            ListView.Name = "ListView";
            ListView.Size = new Size(132, 111);
            ListView.TabIndex = 0;
            ListView.UseCompatibleStateImageBehavior = false;
            ListView.SelectedIndexChanged += ListView_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(148, 7);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += PBMouseDown;
            pictureBox1.MouseMove += PBMouseMove;
            pictureBox1.MouseUp += PBMouseUp;
            // 
            // PathTb
            // 
            PathTb.Location = new Point(10, 125);
            PathTb.Margin = new Padding(3, 2, 3, 2);
            PathTb.Name = "PathTb";
            PathTb.Size = new Size(132, 23);
            PathTb.TabIndex = 2;
            PathTb.Text = "C:\\Users\\Никита\\Documents\\GitHub\\TechVisionLab2\\TechVisionLab2\\Images";
            // 
            // PathSetButton
            // 
            PathSetButton.Location = new Point(10, 150);
            PathSetButton.Margin = new Padding(3, 2, 3, 2);
            PathSetButton.Name = "PathSetButton";
            PathSetButton.Size = new Size(131, 20);
            PathSetButton.TabIndex = 3;
            PathSetButton.Text = "Set Path";
            PathSetButton.UseVisualStyleBackColor = true;
            PathSetButton.Click += PathSetButton_Click;
            // 
            // PixelRead
            // 
            PixelRead.AutoSize = true;
            PixelRead.Location = new Point(10, 175);
            PixelRead.Margin = new Padding(3, 2, 3, 2);
            PixelRead.Name = "PixelRead";
            PixelRead.Size = new Size(116, 19);
            PixelRead.TabIndex = 4;
            PixelRead.Text = "Read pixel param";
            PixelRead.UseVisualStyleBackColor = true;
            // 
            // labelPixelColor
            // 
            labelPixelColor.AutoSize = true;
            labelPixelColor.Location = new Point(10, 217);
            labelPixelColor.Name = "labelPixelColor";
            labelPixelColor.Size = new Size(38, 15);
            labelPixelColor.TabIndex = 5;
            labelPixelColor.Text = "label1";
            labelPixelColor.Visible = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(10, 196);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(66, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Set area";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // RminTB
            // 
            RminTB.Location = new Point(554, 62);
            RminTB.Margin = new Padding(3, 2, 3, 2);
            RminTB.Name = "RminTB";
            RminTB.Size = new Size(68, 23);
            RminTB.TabIndex = 7;
            RminTB.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(554, 46);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 8;
            label1.Text = "Rmin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(627, 46);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 10;
            label2.Text = "Rmax";
            // 
            // RmaxTB
            // 
            RmaxTB.Location = new Point(627, 62);
            RmaxTB.Margin = new Padding(3, 2, 3, 2);
            RmaxTB.Name = "RmaxTB";
            RmaxTB.Size = new Size(68, 23);
            RmaxTB.TabIndex = 9;
            RmaxTB.Text = "255";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(627, 85);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 14;
            label3.Text = "Gmax";
            // 
            // GmaxTB
            // 
            GmaxTB.Location = new Point(627, 100);
            GmaxTB.Margin = new Padding(3, 2, 3, 2);
            GmaxTB.Name = "GmaxTB";
            GmaxTB.Size = new Size(68, 23);
            GmaxTB.TabIndex = 13;
            GmaxTB.Text = "255";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(554, 85);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 12;
            label4.Text = "Gmin";
            // 
            // GminTB
            // 
            GminTB.Location = new Point(554, 100);
            GminTB.Margin = new Padding(3, 2, 3, 2);
            GminTB.Name = "GminTB";
            GminTB.Size = new Size(68, 23);
            GminTB.TabIndex = 11;
            GminTB.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(627, 124);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 18;
            label5.Text = "Bmax";
            // 
            // BmaxTB
            // 
            BmaxTB.Location = new Point(627, 139);
            BmaxTB.Margin = new Padding(3, 2, 3, 2);
            BmaxTB.Name = "BmaxTB";
            BmaxTB.Size = new Size(68, 23);
            BmaxTB.TabIndex = 17;
            BmaxTB.Text = "255";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(554, 124);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 16;
            label6.Text = "Bmin";
            // 
            // BminTB
            // 
            BminTB.Location = new Point(554, 139);
            BminTB.Margin = new Padding(3, 2, 3, 2);
            BminTB.Name = "BminTB";
            BminTB.Size = new Size(68, 23);
            BminTB.TabIndex = 15;
            BminTB.Text = "0";
            // 
            // BlackMask
            // 
            BlackMask.Location = new Point(554, 164);
            BlackMask.Margin = new Padding(3, 2, 3, 2);
            BlackMask.Name = "BlackMask";
            BlackMask.Size = new Size(119, 22);
            BlackMask.TabIndex = 19;
            BlackMask.Text = "Set mask";
            BlackMask.UseVisualStyleBackColor = true;
            BlackMask.Click += BlackMask_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(678, 169);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 20;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // AvgLabel
            // 
            AvgLabel.AutoSize = true;
            AvgLabel.Location = new Point(10, 217);
            AvgLabel.Name = "AvgLabel";
            AvgLabel.Size = new Size(32, 15);
            AvgLabel.TabIndex = 21;
            AvgLabel.Text = "AVG:";
            // 
            // Compress
            // 
            Compress.Location = new Point(554, 190);
            Compress.Margin = new Padding(3, 2, 3, 2);
            Compress.Name = "Compress";
            Compress.Size = new Size(119, 22);
            Compress.TabIndex = 22;
            Compress.Text = "Compress";
            Compress.UseVisualStyleBackColor = true;
            Compress.Click += Compress_Click;
            // 
            // clusterSearchBtn
            // 
            clusterSearchBtn.Location = new Point(554, 216);
            clusterSearchBtn.Margin = new Padding(3, 2, 3, 2);
            clusterSearchBtn.Name = "clusterSearchBtn";
            clusterSearchBtn.Size = new Size(119, 22);
            clusterSearchBtn.TabIndex = 23;
            clusterSearchBtn.Text = "Search Clusters";
            clusterSearchBtn.UseVisualStyleBackColor = true;
            clusterSearchBtn.Click += ClusterSearch;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "default", "Yellow", "Red", "Green" });
            comboBox1.Location = new Point(554, 23);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 23);
            comboBox1.TabIndex = 24;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(555, 6);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 25;
            label7.Text = "Manual";
            // 
            // autoMode
            // 
            autoMode.Location = new Point(554, 372);
            autoMode.Margin = new Padding(3, 2, 3, 2);
            autoMode.Name = "autoMode";
            autoMode.Size = new Size(140, 23);
            autoMode.TabIndex = 26;
            autoMode.Text = "Light Search";
            autoMode.UseVisualStyleBackColor = true;
            autoMode.Click += autoMode_Click;
            // 
            // YellowSearchBtn
            // 
            YellowSearchBtn.Location = new Point(554, 295);
            YellowSearchBtn.Margin = new Padding(3, 2, 3, 2);
            YellowSearchBtn.Name = "YellowSearchBtn";
            YellowSearchBtn.Size = new Size(140, 23);
            YellowSearchBtn.TabIndex = 27;
            YellowSearchBtn.Text = "Yellow Search";
            YellowSearchBtn.UseVisualStyleBackColor = true;
            YellowSearchBtn.Click += YellowSearchBtn_Click;
            // 
            // GreenSearchBtn
            // 
            GreenSearchBtn.Location = new Point(555, 322);
            GreenSearchBtn.Margin = new Padding(3, 2, 3, 2);
            GreenSearchBtn.Name = "GreenSearchBtn";
            GreenSearchBtn.Size = new Size(140, 23);
            GreenSearchBtn.TabIndex = 28;
            GreenSearchBtn.Text = "Green Search";
            GreenSearchBtn.UseVisualStyleBackColor = true;
            GreenSearchBtn.Click += GreenSearchBtn_Click;
            // 
            // RedSearchBtn
            // 
            RedSearchBtn.Location = new Point(555, 268);
            RedSearchBtn.Margin = new Padding(3, 2, 3, 2);
            RedSearchBtn.Name = "RedSearchBtn";
            RedSearchBtn.Size = new Size(140, 23);
            RedSearchBtn.TabIndex = 29;
            RedSearchBtn.Text = "Red Search";
            RedSearchBtn.UseVisualStyleBackColor = true;
            RedSearchBtn.Click += RedSearchBtn_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(10, 251);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(132, 124);
            listBox1.TabIndex = 30;
            // 
            // ListBoxClearBTN
            // 
            ListBoxClearBTN.Location = new Point(10, 380);
            ListBoxClearBTN.Margin = new Padding(3, 2, 3, 2);
            ListBoxClearBTN.Name = "ListBoxClearBTN";
            ListBoxClearBTN.Size = new Size(131, 22);
            ListBoxClearBTN.TabIndex = 31;
            ListBoxClearBTN.Text = "Clear ListBox";
            ListBoxClearBTN.UseVisualStyleBackColor = true;
            ListBoxClearBTN.Click += ListBoxClearBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 418);
            Controls.Add(ListBoxClearBTN);
            Controls.Add(listBox1);
            Controls.Add(RedSearchBtn);
            Controls.Add(GreenSearchBtn);
            Controls.Add(YellowSearchBtn);
            Controls.Add(autoMode);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(clusterSearchBtn);
            Controls.Add(Compress);
            Controls.Add(AvgLabel);
            Controls.Add(checkBox1);
            Controls.Add(BlackMask);
            Controls.Add(label5);
            Controls.Add(BmaxTB);
            Controls.Add(label6);
            Controls.Add(BminTB);
            Controls.Add(label3);
            Controls.Add(GmaxTB);
            Controls.Add(label4);
            Controls.Add(GminTB);
            Controls.Add(label2);
            Controls.Add(RmaxTB);
            Controls.Add(label1);
            Controls.Add(RminTB);
            Controls.Add(radioButton1);
            Controls.Add(labelPixelColor);
            Controls.Add(PixelRead);
            Controls.Add(PathSetButton);
            Controls.Add(PathTb);
            Controls.Add(pictureBox1);
            Controls.Add(ListView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "TechVisionLab2Klimenko";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ListView;
        private PictureBox pictureBox1;
        private TextBox PathTb;
        private Button PathSetButton;
        private RadioButton PixelRead;
        private Label labelPixelColor;
        private RadioButton radioButton1;
        private TextBox RminTB;
        private Label label1;
        private Label label2;
        private TextBox RmaxTB;
        private Label label3;
        private TextBox GmaxTB;
        private Label label4;
        private TextBox GminTB;
        private Label label5;
        private TextBox BmaxTB;
        private Label label6;
        private TextBox BminTB;
        private Button BlackMask;
        private CheckBox checkBox1;
        private Label AvgLabel;
        private Button Compress;
        private Button clusterSearchBtn;
        private ComboBox comboBox1;
        private Label label7;
        private Button autoMode;
        private Button YellowSearchBtn;
        private Button GreenSearchBtn;
        private Button RedSearchBtn;
        private ListBox listBox1;
        private Button ListBoxClearBTN;
    }
}
