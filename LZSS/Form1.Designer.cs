
namespace LZSS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.conpressPage = new System.Windows.Forms.TabPage();
            this.compressPanel = new System.Windows.Forms.Panel();
            this.buttonCompress = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelEntropyC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSizeC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boxBufferSize = new System.Windows.Forms.ComboBox();
            this.boxWindowSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.path2Compress = new System.Windows.Forms.TextBox();
            this.decompressPage = new System.Windows.Forms.TabPage();
            this.decompressPanel = new System.Windows.Forms.Panel();
            this.buttonDecompress = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelEntropyD = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelSizeD = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelBufferSize = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelWindowSize = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.path2Decompress = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.conpressPage.SuspendLayout();
            this.compressPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.decompressPage.SuspendLayout();
            this.decompressPanel.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.conpressPage);
            this.tabControl1.Controls.Add(this.decompressPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(340, 246);
            this.tabControl1.TabIndex = 0;
            // 
            // conpressPage
            // 
            this.conpressPage.Controls.Add(this.compressPanel);
            this.conpressPage.Location = new System.Drawing.Point(4, 22);
            this.conpressPage.Name = "conpressPage";
            this.conpressPage.Padding = new System.Windows.Forms.Padding(3);
            this.conpressPage.Size = new System.Drawing.Size(332, 220);
            this.conpressPage.TabIndex = 0;
            this.conpressPage.Text = "Сжатие";
            this.conpressPage.UseVisualStyleBackColor = true;
            // 
            // compressPanel
            // 
            this.compressPanel.AllowDrop = true;
            this.compressPanel.Controls.Add(this.buttonCompress);
            this.compressPanel.Controls.Add(this.groupBox3);
            this.compressPanel.Controls.Add(this.groupBox2);
            this.compressPanel.Controls.Add(this.groupBox1);
            this.compressPanel.Location = new System.Drawing.Point(0, 0);
            this.compressPanel.Name = "compressPanel";
            this.compressPanel.Size = new System.Drawing.Size(332, 220);
            this.compressPanel.TabIndex = 1;
            this.compressPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.compressPanel_DragDrop);
            this.compressPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.compressPanel_DragEnter);
            // 
            // buttonCompress
            // 
            this.buttonCompress.Enabled = false;
            this.buttonCompress.Location = new System.Drawing.Point(8, 191);
            this.buttonCompress.Name = "buttonCompress";
            this.buttonCompress.Size = new System.Drawing.Size(312, 23);
            this.buttonCompress.TabIndex = 4;
            this.buttonCompress.Text = "Сжать";
            this.buttonCompress.UseVisualStyleBackColor = true;
            this.buttonCompress.Click += new System.EventHandler(this.buttonCompress_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelEntropyC);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.labelSizeC);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(8, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 60);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сведения о файле";
            // 
            // labelEntropyC
            // 
            this.labelEntropyC.AutoSize = true;
            this.labelEntropyC.Location = new System.Drawing.Point(72, 36);
            this.labelEntropyC.Name = "labelEntropyC";
            this.labelEntropyC.Size = new System.Drawing.Size(26, 13);
            this.labelEntropyC.TabIndex = 3;
            this.labelEntropyC.Text = "Н/Д";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Энтропия:";
            // 
            // labelSizeC
            // 
            this.labelSizeC.AutoSize = true;
            this.labelSizeC.Location = new System.Drawing.Point(72, 17);
            this.labelSizeC.Name = "labelSizeC";
            this.labelSizeC.Size = new System.Drawing.Size(26, 13);
            this.labelSizeC.TabIndex = 1;
            this.labelSizeC.Text = "Н/Д";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Размер:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.boxBufferSize);
            this.groupBox2.Controls.Add(this.boxWindowSize);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(8, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 60);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры сжатия";
            // 
            // boxBufferSize
            // 
            this.boxBufferSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxBufferSize.FormattingEnabled = true;
            this.boxBufferSize.IntegralHeight = false;
            this.boxBufferSize.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024"});
            this.boxBufferSize.Location = new System.Drawing.Point(170, 33);
            this.boxBufferSize.Name = "boxBufferSize";
            this.boxBufferSize.Size = new System.Drawing.Size(136, 21);
            this.boxBufferSize.TabIndex = 5;
            // 
            // boxWindowSize
            // 
            this.boxWindowSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxWindowSize.FormattingEnabled = true;
            this.boxWindowSize.IntegralHeight = false;
            this.boxWindowSize.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024"});
            this.boxWindowSize.Location = new System.Drawing.Point(6, 33);
            this.boxWindowSize.Name = "boxWindowSize";
            this.boxWindowSize.Size = new System.Drawing.Size(136, 21);
            this.boxWindowSize.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Длина буфера";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина скользящего окна";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.path2Compress);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Путь к файлу";
            // 
            // path2Compress
            // 
            this.path2Compress.Location = new System.Drawing.Point(6, 20);
            this.path2Compress.Name = "path2Compress";
            this.path2Compress.Size = new System.Drawing.Size(300, 21);
            this.path2Compress.TabIndex = 0;
            this.path2Compress.TextChanged += new System.EventHandler(this.path2Compress_TextChanged);
            // 
            // decompressPage
            // 
            this.decompressPage.Controls.Add(this.decompressPanel);
            this.decompressPage.Location = new System.Drawing.Point(4, 22);
            this.decompressPage.Name = "decompressPage";
            this.decompressPage.Padding = new System.Windows.Forms.Padding(3);
            this.decompressPage.Size = new System.Drawing.Size(332, 220);
            this.decompressPage.TabIndex = 1;
            this.decompressPage.Text = "Распаковка";
            this.decompressPage.UseVisualStyleBackColor = true;
            // 
            // decompressPanel
            // 
            this.decompressPanel.AllowDrop = true;
            this.decompressPanel.Controls.Add(this.buttonDecompress);
            this.decompressPanel.Controls.Add(this.groupBox6);
            this.decompressPanel.Controls.Add(this.groupBox5);
            this.decompressPanel.Controls.Add(this.groupBox4);
            this.decompressPanel.Location = new System.Drawing.Point(0, 0);
            this.decompressPanel.Name = "decompressPanel";
            this.decompressPanel.Size = new System.Drawing.Size(332, 220);
            this.decompressPanel.TabIndex = 0;
            this.decompressPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.decompressPanel_DragDrop);
            this.decompressPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.decompressPanel_DragEnter);
            // 
            // buttonDecompress
            // 
            this.buttonDecompress.Enabled = false;
            this.buttonDecompress.Location = new System.Drawing.Point(8, 191);
            this.buttonDecompress.Name = "buttonDecompress";
            this.buttonDecompress.Size = new System.Drawing.Size(312, 23);
            this.buttonDecompress.TabIndex = 4;
            this.buttonDecompress.Text = "Распаковка";
            this.buttonDecompress.UseVisualStyleBackColor = true;
            this.buttonDecompress.Click += new System.EventHandler(this.buttonDecompress_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelEntropyD);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.labelSizeD);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(8, 125);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(312, 60);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Сведения о файле";
            // 
            // labelEntropyD
            // 
            this.labelEntropyD.AutoSize = true;
            this.labelEntropyD.Location = new System.Drawing.Point(72, 36);
            this.labelEntropyD.Name = "labelEntropyD";
            this.labelEntropyD.Size = new System.Drawing.Size(26, 13);
            this.labelEntropyD.TabIndex = 3;
            this.labelEntropyD.Text = "Н/Д";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Энтропия:";
            // 
            // labelSizeD
            // 
            this.labelSizeD.AutoSize = true;
            this.labelSizeD.Location = new System.Drawing.Point(72, 17);
            this.labelSizeD.Name = "labelSizeD";
            this.labelSizeD.Size = new System.Drawing.Size(26, 13);
            this.labelSizeD.TabIndex = 1;
            this.labelSizeD.Text = "Н/Д";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Размер:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelBufferSize);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.labelWindowSize);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(8, 59);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(312, 60);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Параметры распаковки";
            // 
            // labelBufferSize
            // 
            this.labelBufferSize.AutoSize = true;
            this.labelBufferSize.Location = new System.Drawing.Point(151, 36);
            this.labelBufferSize.Name = "labelBufferSize";
            this.labelBufferSize.Size = new System.Drawing.Size(26, 13);
            this.labelBufferSize.TabIndex = 3;
            this.labelBufferSize.Text = "Н/Д";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Длина буфера:";
            // 
            // labelWindowSize
            // 
            this.labelWindowSize.AutoSize = true;
            this.labelWindowSize.Location = new System.Drawing.Point(151, 17);
            this.labelWindowSize.Name = "labelWindowSize";
            this.labelWindowSize.Size = new System.Drawing.Size(26, 13);
            this.labelWindowSize.TabIndex = 1;
            this.labelWindowSize.Text = "Н/Д";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Длина скользящего окна:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.path2Decompress);
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 47);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Путь к файлу";
            // 
            // path2Decompress
            // 
            this.path2Decompress.Location = new System.Drawing.Point(6, 20);
            this.path2Decompress.Name = "path2Decompress";
            this.path2Decompress.Size = new System.Drawing.Size(300, 21);
            this.path2Decompress.TabIndex = 0;
            this.path2Decompress.TextChanged += new System.EventHandler(this.path2Decompress_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 242);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LZSS";
            this.tabControl1.ResumeLayout(false);
            this.conpressPage.ResumeLayout(false);
            this.compressPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.decompressPage.ResumeLayout(false);
            this.decompressPanel.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage conpressPage;
        private System.Windows.Forms.TabPage decompressPage;
        private System.Windows.Forms.TextBox path2Compress;
        private System.Windows.Forms.Panel compressPanel;
        private System.Windows.Forms.Panel decompressPanel;
        private System.Windows.Forms.TextBox path2Decompress;
        private System.Windows.Forms.Button buttonCompress;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelEntropyC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSizeC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelBufferSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelWindowSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDecompress;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelEntropyD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelSizeD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox boxWindowSize;
        private System.Windows.Forms.ComboBox boxBufferSize;
    }
}

