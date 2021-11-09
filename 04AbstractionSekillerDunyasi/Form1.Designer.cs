
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.chkIciBoyali = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pboRenk = new System.Windows.Forms.PictureBox();
            this.nmuYukseklik = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nmuGenislik = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nmuKonumY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmuKonumX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSekiller = new System.Windows.Forms.ListBox();
            this.pnlCizim = new System.Windows.Forms.Panel();
            this.cdiDolgu = new System.Windows.Forms.ColorDialog();
            this.fdiYazi = new System.Windows.Forms.FontDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pboMetinRenk = new System.Windows.Forms.PictureBox();
            this.nmuMetiny = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nmuMetinx = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cdiYazi = new System.Windows.Forms.ColorDialog();
            this.btnMetinEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboRenk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuYukseklik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuGenislik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuKonumY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuKonumX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboMetinRenk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuMetiny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuMetinx)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(624, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Şekil";
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(523, 29);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 27);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "RENK";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = " X (KONUM)";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tür";
            // 
            // lstSekiller
            // 
            this.lstSekiller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSekiller.FormattingEnabled = true;
            this.lstSekiller.Location = new System.Drawing.Point(12, 90);
            this.lstSekiller.Name = "lstSekiller";
            this.lstSekiller.Size = new System.Drawing.Size(1105, 82);
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
            this.pnlCizim.Size = new System.Drawing.Size(1105, 477);
            this.pnlCizim.TabIndex = 2;
            this.pnlCizim.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCizim_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnMetinEkle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnFont);
            this.groupBox2.Controls.Add(this.pboMetinRenk);
            this.groupBox2.Controls.Add(this.nmuMetiny);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nmuMetinx);
            this.groupBox2.Controls.Add(this.txtMetin);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(652, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 70);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Metin";
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(11, 36);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(120, 20);
            this.txtMetin.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Metin";
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(308, 33);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(49, 23);
            this.btnFont.TabIndex = 4;
            this.btnFont.Text = "FONT";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "RENK";
            // 
            // pboMetinRenk
            // 
            this.pboMetinRenk.BackColor = System.Drawing.Color.Black;
            this.pboMetinRenk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboMetinRenk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboMetinRenk.Location = new System.Drawing.Point(277, 35);
            this.pboMetinRenk.Name = "pboMetinRenk";
            this.pboMetinRenk.Size = new System.Drawing.Size(21, 20);
            this.pboMetinRenk.TabIndex = 11;
            this.pboMetinRenk.TabStop = false;
            this.pboMetinRenk.Click += new System.EventHandler(this.pboMetinRenk_Click);
            // 
            // nmuMetiny
            // 
            this.nmuMetiny.Location = new System.Drawing.Point(202, 35);
            this.nmuMetiny.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmuMetiny.Name = "nmuMetiny";
            this.nmuMetiny.Size = new System.Drawing.Size(61, 20);
            this.nmuMetiny.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Y (KONUM)";
            // 
            // nmuMetinx
            // 
            this.nmuMetinx.Location = new System.Drawing.Point(136, 36);
            this.nmuMetinx.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmuMetinx.Name = "nmuMetinx";
            this.nmuMetinx.Size = new System.Drawing.Size(61, 20);
            this.nmuMetinx.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(131, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = " X (KONUM)";
            // 
            // btnMetinEkle
            // 
            this.btnMetinEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetinEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMetinEkle.Location = new System.Drawing.Point(373, 30);
            this.btnMetinEkle.Name = "btnMetinEkle";
            this.btnMetinEkle.Size = new System.Drawing.Size(75, 27);
            this.btnMetinEkle.TabIndex = 11;
            this.btnMetinEkle.Text = "EKLE";
            this.btnMetinEkle.UseVisualStyleBackColor = true;
            this.btnMetinEkle.Click += new System.EventHandler(this.btnMetinEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 667);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnlCizim);
            this.Controls.Add(this.lstSekiller);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ŞEKILLER DUNYASI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboRenk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuYukseklik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuGenislik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuKonumY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuKonumX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboMetinRenk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuMetiny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuMetinx)).EndInit();
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
        private System.Windows.Forms.FontDialog fdiYazi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMetinEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.PictureBox pboMetinRenk;
        private System.Windows.Forms.NumericUpDown nmuMetiny;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmuMetinx;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColorDialog cdiYazi;
    }
}

