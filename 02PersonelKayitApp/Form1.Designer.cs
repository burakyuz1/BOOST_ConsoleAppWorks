namespace _02PersonelKayitApp
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
            this.btnTemizle = new System.Windows.Forms.Button();
            this.rdoKadin = new System.Windows.Forms.RadioButton();
            this.rdoErkek = new System.Windows.Forms.RadioButton();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblYas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblKayitGoruntule = new System.Windows.Forms.Label();
            this.lblKayitSayisi = new System.Windows.Forms.Label();
            this.nmuKayitNo = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuKayitNo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.rdoKadin);
            this.groupBox1.Controls.Add(this.rdoErkek);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.lblYas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpDogumTarihi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBirim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, -2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(386, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONEL KAYIT";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemizle.Location = new System.Drawing.Point(219, 294);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(66, 59);
            this.btnTemizle.TabIndex = 22;
            this.btnTemizle.Text = "CLEAR";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // rdoKadin
            // 
            this.rdoKadin.AutoSize = true;
            this.rdoKadin.Location = new System.Drawing.Point(289, 199);
            this.rdoKadin.Name = "rdoKadin";
            this.rdoKadin.Size = new System.Drawing.Size(68, 23);
            this.rdoKadin.TabIndex = 21;
            this.rdoKadin.TabStop = true;
            this.rdoKadin.Text = "Kadın";
            this.rdoKadin.UseVisualStyleBackColor = true;
            // 
            // rdoErkek
            // 
            this.rdoErkek.AutoSize = true;
            this.rdoErkek.Location = new System.Drawing.Point(134, 199);
            this.rdoErkek.Name = "rdoErkek";
            this.rdoErkek.Size = new System.Drawing.Size(67, 23);
            this.rdoErkek.TabIndex = 20;
            this.rdoErkek.TabStop = true;
            this.rdoErkek.Text = "Erkek";
            this.rdoErkek.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::_02PersonelKayitApp.Properties.Resources._4136712;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Location = new System.Drawing.Point(291, 294);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(66, 59);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblYas.Location = new System.Drawing.Point(130, 314);
            this.lblYas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(17, 19);
            this.lblYas.TabIndex = 18;
            this.lblYas.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 314);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Yas :";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(133, 241);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(224, 27);
            this.dtpDogumTarihi.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dogum Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cinsiyet";
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(133, 148);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(224, 27);
            this.txtBirim.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Birim";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(133, 99);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(224, 27);
            this.txtTc.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "T.C. NO";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(133, 52);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(224, 27);
            this.txtAdSoyad.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox2.Controls.Add(this.btnShow);
            this.groupBox2.Controls.Add(this.lblKayitGoruntule);
            this.groupBox2.Controls.Add(this.lblKayitSayisi);
            this.groupBox2.Controls.Add(this.nmuKayitNo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(424, -2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(280, 362);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PERSONEL BİLGİLERİ";
            // 
            // btnShow
            // 
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Location = new System.Drawing.Point(204, 20);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(66, 59);
            this.btnShow.TabIndex = 23;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblKayitGoruntule
            // 
            this.lblKayitGoruntule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKayitGoruntule.Location = new System.Drawing.Point(7, 99);
            this.lblKayitGoruntule.Name = "lblKayitGoruntule";
            this.lblKayitGoruntule.Size = new System.Drawing.Size(263, 254);
            this.lblKayitGoruntule.TabIndex = 27;
            this.lblKayitGoruntule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.AutoSize = true;
            this.lblKayitSayisi.Location = new System.Drawing.Point(106, 25);
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Size = new System.Drawing.Size(18, 19);
            this.lblKayitSayisi.TabIndex = 26;
            this.lblKayitSayisi.Text = "0";
            // 
            // nmuKayitNo
            // 
            this.nmuKayitNo.Location = new System.Drawing.Point(110, 52);
            this.nmuKayitNo.Name = "nmuKayitNo";
            this.nmuKayitNo.Size = new System.Drawing.Size(66, 27);
            this.nmuKayitNo.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Kayıt No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Kayıt Sayısı: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox3.Location = new System.Drawing.Point(713, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 363);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(712, 370);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuKayitNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.RadioButton rdoKadin;
        private System.Windows.Forms.RadioButton rdoErkek;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblKayitGoruntule;
        private System.Windows.Forms.Label lblKayitSayisi;
        private System.Windows.Forms.NumericUpDown nmuKayitNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnShow;
    }
}

