
namespace _05TelefonRehberi
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.mtxTelNo = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKisiListesi = new System.Windows.Forms.DataGridView();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.mtxTelNo);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(290, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Ekle / Düzenle";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(153, 274);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(99, 33);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // mtxTelNo
            // 
            this.mtxTelNo.Location = new System.Drawing.Point(120, 203);
            this.mtxTelNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mtxTelNo.Mask = "(999) 000-0000";
            this.mtxTelNo.Name = "mtxTelNo";
            this.mtxTelNo.Size = new System.Drawing.Size(132, 27);
            this.mtxTelNo.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(120, 130);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(132, 27);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(120, 62);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(132, 27);
            this.txtAd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // dgvKisiListesi
            // 
            this.dgvKisiListesi.AllowUserToAddRows = false;
            this.dgvKisiListesi.AllowUserToDeleteRows = false;
            this.dgvKisiListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKisiListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKisiListesi.Location = new System.Drawing.Point(312, 66);
            this.dgvKisiListesi.Name = "dgvKisiListesi";
            this.dgvKisiListesi.ReadOnly = true;
            this.dgvKisiListesi.Size = new System.Drawing.Size(568, 291);
            this.dgvKisiListesi.TabIndex = 1;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(748, 34);
            this.txtAra.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(132, 27);
            this.txtAra.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(714, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ad";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(781, 365);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(99, 33);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(676, 365);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(99, 33);
            this.btnDuzenle.TabIndex = 8;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(892, 404);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dgvKisiListesi);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "Telefon Rehberi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox mtxTelNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvKisiListesi;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
    }
}

