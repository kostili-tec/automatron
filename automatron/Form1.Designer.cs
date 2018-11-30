namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxHR = new System.Windows.Forms.TextBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxFinish = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxDirect = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.listBoxWrite = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpClick = new System.Windows.Forms.Button();
            this.DownClick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "SAVE TXT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxHR
            // 
            this.textBoxHR.Location = new System.Drawing.Point(12, 12);
            this.textBoxHR.Name = "textBoxHR";
            this.textBoxHR.Size = new System.Drawing.Size(37, 20);
            this.textBoxHR.TabIndex = 6;
            this.textBoxHR.Text = "<hr />";
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(55, 12);
            this.textBoxStart.Multiline = true;
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(335, 24);
            this.textBoxStart.TabIndex = 7;
            this.textBoxStart.Text = "<p><a href=\"http://www.smikbr.ru/2008/rgazeta/chervest/01";
            // 
            // textBoxFinish
            // 
            this.textBoxFinish.Location = new System.Drawing.Point(778, 12);
            this.textBoxFinish.Multiline = true;
            this.textBoxFinish.Name = "textBoxFinish";
            this.textBoxFinish.Size = new System.Drawing.Size(117, 24);
            this.textBoxFinish.TabIndex = 8;
            this.textBoxFinish.Text = "</span></a></p>";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(440, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(277, 20);
            this.textBoxName.TabIndex = 10;
            this.textBoxName.Text = "\"><span style=\"font-size:16px\">Черекские вести - №";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(505, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Path";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxDirect
            // 
            this.textBoxDirect.Location = new System.Drawing.Point(145, 42);
            this.textBoxDirect.Name = "textBoxDirect";
            this.textBoxDirect.Size = new System.Drawing.Size(231, 20);
            this.textBoxDirect.TabIndex = 12;
            this.textBoxDirect.Text = "\\\\MISHA\\smikbr\\2010\\rgazeta\\chervest\\01";
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(776, 109);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(88, 342);
            this.listBoxFiles.TabIndex = 14;
            // 
            // listBoxWrite
            // 
            this.listBoxWrite.FormattingEnabled = true;
            this.listBoxWrite.Location = new System.Drawing.Point(83, 109);
            this.listBoxWrite.Name = "listBoxWrite";
            this.listBoxWrite.Size = new System.Drawing.Size(672, 537);
            this.listBoxWrite.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "file.pdf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Имя - №";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(608, 68);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 19;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::automatron.Properties.Resources.bender_hard;
            this.pictureBox1.Location = new System.Drawing.Point(794, 481);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 175);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // UpClick
            // 
            this.UpClick.Location = new System.Drawing.Point(12, 128);
            this.UpClick.Name = "UpClick";
            this.UpClick.Size = new System.Drawing.Size(47, 23);
            this.UpClick.TabIndex = 21;
            this.UpClick.Text = "Туда";
            this.UpClick.UseVisualStyleBackColor = true;
            this.UpClick.Click += new System.EventHandler(this.UpClick_Click);
            // 
            // DownClick
            // 
            this.DownClick.Location = new System.Drawing.Point(12, 177);
            this.DownClick.Name = "DownClick";
            this.DownClick.Size = new System.Drawing.Size(47, 23);
            this.DownClick.TabIndex = 22;
            this.DownClick.Text = "Сюда";
            this.DownClick.UseVisualStyleBackColor = true;
            this.DownClick.Click += new System.EventHandler(this.DownClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(924, 664);
            this.Controls.Add(this.DownClick);
            this.Controls.Add(this.UpClick);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxWrite);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.textBoxDirect);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxFinish);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.textBoxHR);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "automatron";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxHR;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TextBox textBoxFinish;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxDirect;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.ListBox listBoxWrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UpClick;
        private System.Windows.Forms.Button DownClick;
    }
}

