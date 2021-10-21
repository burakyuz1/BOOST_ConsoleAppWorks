
namespace _03VehicleTaxCalculation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmuYas = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmuMotorHacmi = new System.Windows.Forms.NumericUpDown();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.rdBinek = new System.Windows.Forms.RadioButton();
            this.rdTicari = new System.Windows.Forms.RadioButton();
            this.btnSifirla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmuYas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuMotorHacmi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Araç Tipini Seçin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aracın Yaşını girin :";
            // 
            // nmuYas
            // 
            this.nmuYas.AutoSize = true;
            this.nmuYas.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmuYas.Location = new System.Drawing.Point(174, 58);
            this.nmuYas.Name = "nmuYas";
            this.nmuYas.Size = new System.Drawing.Size(194, 25);
            this.nmuYas.TabIndex = 6;
            this.nmuYas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Motor Hacmini girin : ";
            // 
            // nmuMotorHacmi
            // 
            this.nmuMotorHacmi.AutoSize = true;
            this.nmuMotorHacmi.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmuMotorHacmi.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmuMotorHacmi.Location = new System.Drawing.Point(174, 107);
            this.nmuMotorHacmi.Name = "nmuMotorHacmi";
            this.nmuMotorHacmi.Size = new System.Drawing.Size(194, 25);
            this.nmuMotorHacmi.TabIndex = 8;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.ForeColor = System.Drawing.Color.Green;
            this.lblFiyat.Location = new System.Drawing.Point(78, 148);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(36, 39);
            this.lblFiyat.TabIndex = 9;
            this.lblFiyat.Text = "0";
            this.lblFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(49, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "₺";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnHesapla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapla.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(239, 146);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(128, 41);
            this.btnHesapla.TabIndex = 11;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // rdBinek
            // 
            this.rdBinek.AutoSize = true;
            this.rdBinek.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBinek.Location = new System.Drawing.Point(175, 13);
            this.rdBinek.Name = "rdBinek";
            this.rdBinek.Size = new System.Drawing.Size(91, 22);
            this.rdBinek.TabIndex = 12;
            this.rdBinek.TabStop = true;
            this.rdBinek.Text = "Binek Araç";
            this.rdBinek.UseVisualStyleBackColor = true;
            // 
            // rdTicari
            // 
            this.rdTicari.AutoSize = true;
            this.rdTicari.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdTicari.Location = new System.Drawing.Point(277, 13);
            this.rdTicari.Name = "rdTicari";
            this.rdTicari.Size = new System.Drawing.Size(89, 22);
            this.rdTicari.TabIndex = 13;
            this.rdTicari.TabStop = true;
            this.rdTicari.Text = "Ticari Araç";
            this.rdTicari.UseVisualStyleBackColor = true;
            // 
            // btnSifirla
            // 
            this.btnSifirla.BackColor = System.Drawing.Color.Pink;
            this.btnSifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifirla.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifirla.Location = new System.Drawing.Point(174, 146);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(59, 41);
            this.btnSifirla.TabIndex = 14;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(396, 206);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.rdTicari);
            this.Controls.Add(this.rdBinek);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.nmuMotorHacmi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmuYas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARAÇ VERGİ HESAPLAMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmuYas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuMotorHacmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmuYas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmuMotorHacmi;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.RadioButton rdBinek;
        private System.Windows.Forms.RadioButton rdTicari;
        private System.Windows.Forms.Button btnSifirla;
    }
}

