namespace _00IEnumerableOrnek
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
            this.btnGetir = new System.Windows.Forms.Button();
            this.lstFutbolcular = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(22, 20);
            this.btnGetir.Margin = new System.Windows.Forms.Padding(5);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(573, 55);
            this.btnGetir.TabIndex = 0;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // lstFutbolcular
            // 
            this.lstFutbolcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstFutbolcular.FormattingEnabled = true;
            this.lstFutbolcular.ItemHeight = 25;
            this.lstFutbolcular.Location = new System.Drawing.Point(22, 86);
            this.lstFutbolcular.Margin = new System.Windows.Forms.Padding(5);
            this.lstFutbolcular.Name = "lstFutbolcular";
            this.lstFutbolcular.Size = new System.Drawing.Size(573, 354);
            this.lstFutbolcular.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 468);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Forma No Ortalaması";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(368, 468);
            this.lblOrtalama.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(0, 22);
            this.lblOrtalama.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 491);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toplam Sayi: ";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(311, 488);
            this.lblToplam.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(0, 22);
            this.lblToplam.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 540);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstFutbolcular);
            this.Controls.Add(this.btnGetir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "TAKIM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.ListBox lstFutbolcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplam;
    }
}

