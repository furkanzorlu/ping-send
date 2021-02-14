namespace ping_gönderme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.adres = new System.Windows.Forms.TextBox();
            this.hız = new System.Windows.Forms.TextBox();
            this.sayı = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ping Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dışarı Aktar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ping hızını ayarla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ping Sayısı";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Durdur";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(223, 27);
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(229, 22);
            this.adres.TabIndex = 5;
            // 
            // hız
            // 
            this.hız.Location = new System.Drawing.Point(223, 69);
            this.hız.Name = "hız";
            this.hız.Size = new System.Drawing.Size(100, 22);
            this.hız.TabIndex = 6;
            // 
            // sayı
            // 
            this.sayı.Location = new System.Drawing.Point(223, 108);
            this.sayı.Name = "sayı";
            this.sayı.Size = new System.Drawing.Size(100, 22);
            this.sayı.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(358, 109);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Sınırsız ping gönder";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(223, 151);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 212);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.sayı);
            this.Controls.Add(this.hız);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox hız;
        private System.Windows.Forms.TextBox sayı;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

