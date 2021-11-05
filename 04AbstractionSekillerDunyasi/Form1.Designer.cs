
namespace _04AbstractionSekillerDunyasi
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmuKonumX = new System.Windows.Forms.NumericUpDown();
            this.nmuKonumY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmuYukseklik = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nmuGenislik = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pboRenk = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkIciBoyali = new System.Windows.Forms.CheckBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstSekiller = new System.Windows.Forms.ListBox();
            this.pnlCizim = new System.Windows.Forms.Panel();
            this.cdiDolgu = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuKonumX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuKonumY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuYukseklik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuGenislik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRenk)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.chkIciBoyali);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pboRenk);
            this.groupBox1.Controls.Add(this.nmuYukseklik);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nmuGenislik);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nmuKonumY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nmuKonumX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbTur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Şekil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tür";
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Dikdörtgen",
            "Elips"});
            this.cmbTur.Location = new System.Drawing.Point(10, 37);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(121, 21);
            this.cmbTur.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = " X (KONUM)";
            // 
            // nmuKonumX
            // 
            this.nmuKonumX.Location = new System.Drawing.Point(137, 36);
            this.nmuKonumX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmuKonumX.Name = "nmuKonumX";
            this.nmuKonumX.Size = new System.Drawing.Size(60, 20);
            this.nmuKonumX.TabIndex = 3;
            // 
            // nmuKonumY
            // 
            this.nmuKonumY.Location = new System.Drawing.Point(206, 36);
            this.nmuKonumY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmuKonumY.Name = "nmuKonumY";
            this.nmuKonumY.Size = new System.Drawing.Size(60, 20);
            this.nmuKonumY.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y (KONUM)";
            // 
            // nmuYukseklik
            // 
            this.nmuYukseklik.Location = new System.Drawing.Point(341, 36);
            this.nmuYukseklik.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmuYukseklik.Name = "nmuYukseklik";
            this.nmuYukseklik.Size = new System.Drawing.Size(60, 20);
            this.nmuYukseklik.TabIndex = 9;
            this.nmuYukseklik.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "YUKSEKLIK";
            // 
            // nmuGenislik
            // 
            this.nmuGenislik.Location = new System.Drawing.Point(272, 36);
            this.nmuGenislik.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmuGenislik.Name = "nmuGenislik";
            this.nmuGenislik.Size = new System.Drawing.Size(60, 20);
            this.nmuGenislik.TabIndex = 7;
            this.nmuGenislik.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "GENISLIK";
            // 
            // pboRenk
            // 
            this.pboRenk.BackColor = System.Drawing.Color.Black;
            this.pboRenk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboRenk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboRenk.Location = new System.Drawing.Point(407, 36);
            this.pboRenk.Name = "pboRenk";
            this.pboRenk.Size = new System.Drawing.Size(20, 20);
            this.pboRenk.TabIndex = 1;
            this.pboRenk.TabStop = false;
            this.pboRenk.Click += new System.EventHandler(this.pboRenk_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "RENK";
            // 
            // chkIciBoyali
            // 
            this.chkIciBoyali.AutoSize = true;
            this.chkIciBoyali.Location = new System.Drawing.Point(445, 37);
            this.chkIciBoyali.Name = "chkIciBoyali";
            this.chkIciBoyali.Size = new System.Drawing.Size(68, 17);
            this.chkIciBoyali.TabIndex = 1;
            this.chkIciBoyali.Text = "İçi Boyalı";
            this.chkIciBoyali.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(531, 20);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 38);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstSekiller
            // 
            this.lstSekiller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSekiller.FormattingEnabled = true;
            this.lstSekiller.Location = new System.Drawing.Point(12, 90);
            this.lstSekiller.Name = "lstSekiller";
            this.lstSekiller.Size = new System.Drawing.Size(642, 82);
            this.lstSekiller.TabIndex = 1;
            // 
            // pnlCizim
            // 
            this.pnlCizim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCizim.BackColor = System.Drawing.Color.White;
            this.pnlCizim.Location = new System.Drawing.Point(12, 178);
            this.pnlCizim.Name = "pnlCizim";
            this.pnlCizim.Size = new System.Drawing.Size(642, 456);
            this.pnlCizim.TabIndex = 2;
            this.pnlCizim.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCizim_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 646);
            this.Controls.Add(this.pnlCizim);
            this.Controls.Add(this.lstSekiller);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ŞEKILLER DUNYASI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuKonumX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuKonumY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuYukseklik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuGenislik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRenk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmuKonumY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmuKonumX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox chkIciBoyali;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pboRenk;
        private System.Windows.Forms.NumericUpDown nmuYukseklik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmuGenislik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstSekiller;
        private System.Windows.Forms.Panel pnlCizim;
        private System.Windows.Forms.ColorDialog cdiDolgu;
    }
}

