
namespace _01WFAPasswordGenerator
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbOzelKarakter = new System.Windows.Forms.CheckBox();
            this.btnUret = new System.Windows.Forms.Button();
            this.nmuSifreUzunlugu = new System.Windows.Forms.NumericUpDown();
            this.nmuSifreAdedi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRakam = new System.Windows.Forms.CheckBox();
            this.cbBuyukHarf = new System.Windows.Forms.CheckBox();
            this.cbKucukHarf = new System.Windows.Forms.CheckBox();
            this.rtbSifreAlani = new System.Windows.Forms.RichTextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuSifreUzunlugu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuSifreAdedi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cbOzelKarakter);
            this.groupBox1.Controls.Add(this.btnUret);
            this.groupBox1.Controls.Add(this.nmuSifreUzunlugu);
            this.groupBox1.Controls.Add(this.nmuSifreAdedi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbRakam);
            this.groupBox1.Controls.Add(this.cbBuyukHarf);
            this.groupBox1.Controls.Add(this.cbKucukHarf);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 405);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PARAMETRELER";
            // 
            // cbOzelKarakter
            // 
            this.cbOzelKarakter.AutoSize = true;
            this.cbOzelKarakter.Location = new System.Drawing.Point(52, 155);
            this.cbOzelKarakter.Name = "cbOzelKarakter";
            this.cbOzelKarakter.Size = new System.Drawing.Size(164, 30);
            this.cbOzelKarakter.TabIndex = 8;
            this.cbOzelKarakter.Text = "Özel Karakter";
            this.cbOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(172, 303);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(120, 45);
            this.btnUret.TabIndex = 7;
            this.btnUret.Text = "ÜRET";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // nmuSifreUzunlugu
            // 
            this.nmuSifreUzunlugu.Location = new System.Drawing.Point(172, 254);
            this.nmuSifreUzunlugu.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmuSifreUzunlugu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmuSifreUzunlugu.Name = "nmuSifreUzunlugu";
            this.nmuSifreUzunlugu.Size = new System.Drawing.Size(120, 32);
            this.nmuSifreUzunlugu.TabIndex = 6;
            this.nmuSifreUzunlugu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmuSifreAdedi
            // 
            this.nmuSifreAdedi.Location = new System.Drawing.Point(172, 207);
            this.nmuSifreAdedi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmuSifreAdedi.Name = "nmuSifreAdedi";
            this.nmuSifreAdedi.Size = new System.Drawing.Size(120, 32);
            this.nmuSifreAdedi.TabIndex = 5;
            this.nmuSifreAdedi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre Uzunluğu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Şifre Adedi";
            // 
            // cbRakam
            // 
            this.cbRakam.AutoSize = true;
            this.cbRakam.Location = new System.Drawing.Point(52, 119);
            this.cbRakam.Name = "cbRakam";
            this.cbRakam.Size = new System.Drawing.Size(101, 30);
            this.cbRakam.TabIndex = 2;
            this.cbRakam.Text = "Rakam";
            this.cbRakam.UseVisualStyleBackColor = true;
            // 
            // cbBuyukHarf
            // 
            this.cbBuyukHarf.AutoSize = true;
            this.cbBuyukHarf.Location = new System.Drawing.Point(52, 83);
            this.cbBuyukHarf.Name = "cbBuyukHarf";
            this.cbBuyukHarf.Size = new System.Drawing.Size(139, 30);
            this.cbBuyukHarf.TabIndex = 1;
            this.cbBuyukHarf.Text = "Büyük Harf";
            this.cbBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // cbKucukHarf
            // 
            this.cbKucukHarf.AutoSize = true;
            this.cbKucukHarf.Location = new System.Drawing.Point(52, 47);
            this.cbKucukHarf.Name = "cbKucukHarf";
            this.cbKucukHarf.Size = new System.Drawing.Size(139, 30);
            this.cbKucukHarf.TabIndex = 0;
            this.cbKucukHarf.Text = "Küçük Harf";
            this.cbKucukHarf.UseVisualStyleBackColor = true;
            // 
            // rtbSifreAlani
            // 
            this.rtbSifreAlani.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbSifreAlani.Location = new System.Drawing.Point(347, 32);
            this.rtbSifreAlani.Name = "rtbSifreAlani";
            this.rtbSifreAlani.ReadOnly = true;
            this.rtbSifreAlani.Size = new System.Drawing.Size(325, 329);
            this.rtbSifreAlani.TabIndex = 11;
            this.rtbSifreAlani.Text = "";
            this.rtbSifreAlani.SelectionChanged += new System.EventHandler(this.rtbSifreAlani_SelectionChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCopy.Location = new System.Drawing.Point(347, 373);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(325, 45);
            this.btnCopy.TabIndex = 12;
            this.btnCopy.Text = "ŞİFREYİ KOPYALA";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.rtbSifreAlani);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuSifreUzunlugu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuSifreAdedi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.NumericUpDown nmuSifreUzunlugu;
        private System.Windows.Forms.NumericUpDown nmuSifreAdedi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbRakam;
        private System.Windows.Forms.CheckBox cbBuyukHarf;
        private System.Windows.Forms.CheckBox cbKucukHarf;
        private System.Windows.Forms.CheckBox cbOzelKarakter;
        private System.Windows.Forms.RichTextBox rtbSifreAlani;
        private System.Windows.Forms.Button btnCopy;
    }
}

