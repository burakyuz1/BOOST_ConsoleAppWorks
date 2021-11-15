namespace _05BatikentSuDeposu
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
            this.pnlSu = new System.Windows.Forms.Panel();
            this.pnlDepo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nmuSuMiktari = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.pnlDepo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuSuMiktari)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSu
            // 
            this.pnlSu.BackColor = System.Drawing.Color.Aqua;
            this.pnlSu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSu.Location = new System.Drawing.Point(0, 372);
            this.pnlSu.Name = "pnlSu";
            this.pnlSu.Size = new System.Drawing.Size(302, 61);
            this.pnlSu.TabIndex = 1;
            // 
            // pnlDepo
            // 
            this.pnlDepo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlDepo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDepo.Controls.Add(this.pnlSu);
            this.pnlDepo.Location = new System.Drawing.Point(421, 27);
            this.pnlDepo.Name = "pnlDepo";
            this.pnlDepo.Size = new System.Drawing.Size(304, 435);
            this.pnlDepo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Su Miktarı (litre)";
            // 
            // nmuSuMiktari
            // 
            this.nmuSuMiktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmuSuMiktari.Location = new System.Drawing.Point(80, 207);
            this.nmuSuMiktari.Name = "nmuSuMiktari";
            this.nmuSuMiktari.Size = new System.Drawing.Size(176, 32);
            this.nmuSuMiktari.TabIndex = 7;
            this.nmuSuMiktari.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(80, 245);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(176, 40);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 480);
            this.Controls.Add(this.pnlDepo);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nmuSuMiktari);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BATIKENT SU DEPOSU";
            this.pnlDepo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmuSuMiktari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSu;
        private System.Windows.Forms.Panel pnlDepo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmuSuMiktari;
        private System.Windows.Forms.Button btnEkle;
    }
}

