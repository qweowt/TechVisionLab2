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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ListView
            // 
            ListView.Location = new Point(12, 12);
            ListView.Name = "ListView";
            ListView.Size = new Size(150, 147);
            ListView.TabIndex = 0;
            ListView.UseCompatibleStateImageBehavior = false;
            ListView.SelectedIndexChanged += ListView_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(168, 12);
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
            PathTb.Location = new Point(12, 167);
            PathTb.Name = "PathTb";
            PathTb.Size = new Size(150, 27);
            PathTb.TabIndex = 2;
            PathTb.Text = "Z:\\GitHub\\TechVisionLab2\\TechVisionLab2\\Images";
            // 
            // PathSetButton
            // 
            PathSetButton.Location = new Point(12, 200);
            PathSetButton.Name = "PathSetButton";
            PathSetButton.Size = new Size(150, 27);
            PathSetButton.TabIndex = 3;
            PathSetButton.Text = "Set Path";
            PathSetButton.UseVisualStyleBackColor = true;
            PathSetButton.Click += PathSetButton_Click;
            // 
            // PixelRead
            // 
            PixelRead.AutoSize = true;
            PixelRead.Location = new Point(12, 233);
            PixelRead.Name = "PixelRead";
            PixelRead.Size = new Size(147, 24);
            PixelRead.TabIndex = 4;
            PixelRead.Text = "Read pixel param";
            PixelRead.UseVisualStyleBackColor = true;
            // 
            // labelPixelColor
            // 
            labelPixelColor.AutoSize = true;
            labelPixelColor.Location = new Point(12, 289);
            labelPixelColor.Name = "labelPixelColor";
            labelPixelColor.Size = new Size(50, 20);
            labelPixelColor.TabIndex = 5;
            labelPixelColor.Text = "label1";
            labelPixelColor.Visible = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(12, 262);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(84, 24);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Set area";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // RminTB
            // 
            RminTB.Location = new Point(574, 29);
            RminTB.Name = "RminTB";
            RminTB.Size = new Size(77, 27);
            RminTB.TabIndex = 7;
            RminTB.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(574, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 8;
            label1.Text = "Rmin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(657, 9);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 10;
            label2.Text = "Rmax";
            // 
            // RmaxTB
            // 
            RmaxTB.Location = new Point(657, 29);
            RmaxTB.Name = "RmaxTB";
            RmaxTB.Size = new Size(77, 27);
            RmaxTB.TabIndex = 9;
            RmaxTB.Text = "255";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(657, 60);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 14;
            label3.Text = "Gmax";
            // 
            // GmaxTB
            // 
            GmaxTB.Location = new Point(657, 80);
            GmaxTB.Name = "GmaxTB";
            GmaxTB.Size = new Size(77, 27);
            GmaxTB.TabIndex = 13;
            GmaxTB.Text = "255";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(574, 60);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 12;
            label4.Text = "Gmin";
            // 
            // GminTB
            // 
            GminTB.Location = new Point(574, 80);
            GminTB.Name = "GminTB";
            GminTB.Size = new Size(77, 27);
            GminTB.TabIndex = 11;
            GminTB.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(657, 112);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 18;
            label5.Text = "Bmax";
            // 
            // BmaxTB
            // 
            BmaxTB.Location = new Point(657, 132);
            BmaxTB.Name = "BmaxTB";
            BmaxTB.Size = new Size(77, 27);
            BmaxTB.TabIndex = 17;
            BmaxTB.Text = "255";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(574, 112);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 16;
            label6.Text = "Bmin";
            // 
            // BminTB
            // 
            BminTB.Location = new Point(574, 132);
            BminTB.Name = "BminTB";
            BminTB.Size = new Size(77, 27);
            BminTB.TabIndex = 15;
            BminTB.Text = "0";
            // 
            // BlackMask
            // 
            BlackMask.Location = new Point(574, 165);
            BlackMask.Name = "BlackMask";
            BlackMask.Size = new Size(136, 29);
            BlackMask.TabIndex = 19;
            BlackMask.Text = "Set mask";
            BlackMask.UseVisualStyleBackColor = true;
            BlackMask.Click += BlackMask_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(716, 172);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 20;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // AvgLabel
            // 
            AvgLabel.AutoSize = true;
            AvgLabel.Location = new Point(12, 289);
            AvgLabel.Name = "AvgLabel";
            AvgLabel.Size = new Size(40, 20);
            AvgLabel.TabIndex = 21;
            AvgLabel.Text = "AVG:";
            // 
            // Compress
            // 
            Compress.Location = new Point(574, 200);
            Compress.Name = "Compress";
            Compress.Size = new Size(136, 29);
            Compress.TabIndex = 22;
            Compress.Text = "Compress";
            Compress.UseVisualStyleBackColor = true;
            Compress.Click += Compress_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 424);
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
    }
}
