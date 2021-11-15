namespace _01KisiRehberi
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
            this.btnYeniKisi = new System.Windows.Forms.Button();
            this.dgwKisiListesi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKriter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKisiListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniKisi
            // 
            this.btnYeniKisi.Location = new System.Drawing.Point(13, 23);
            this.btnYeniKisi.Name = "btnYeniKisi";
            this.btnYeniKisi.Size = new System.Drawing.Size(75, 23);
            this.btnYeniKisi.TabIndex = 0;
            this.btnYeniKisi.Text = "Kişi Ekle";
            this.btnYeniKisi.UseVisualStyleBackColor = true;
            // 
            // dgwKisiListesi
            // 
            this.dgwKisiListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKisiListesi.Location = new System.Drawing.Point(13, 65);
            this.dgwKisiListesi.Name = "dgwKisiListesi";
            this.dgwKisiListesi.Size = new System.Drawing.Size(775, 425);
            this.dgwKisiListesi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kriter Seçin";
            // 
            // cmbKriter
            // 
            this.cmbKriter.FormattingEnabled = true;
            this.cmbKriter.Items.AddRange(new object[] {
            "Ada göre sırala",
            "Ada göre tersten sırala",
            "Soyada göre sırala",
            "Soyada göre tersten sırala",
            "Yaşa göre sırala",
            "Yaşa göre tersten sırala"});
            this.cmbKriter.Location = new System.Drawing.Point(667, 25);
            this.cmbKriter.Name = "cmbKriter";
            this.cmbKriter.Size = new System.Drawing.Size(121, 21);
            this.cmbKriter.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.cmbKriter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwKisiListesi);
            this.Controls.Add(this.btnYeniKisi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwKisiListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeniKisi;
        private System.Windows.Forms.DataGridView dgwKisiListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKriter;
    }
}

