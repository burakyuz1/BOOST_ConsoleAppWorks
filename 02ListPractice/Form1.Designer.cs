
namespace _02ListPractice
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
            this.lblSansliKisi = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lsbIsimler = new System.Windows.Forms.ListBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.btnKaristir = new System.Windows.Forms.Button();
            this.btnSirala = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSansliKisi
            // 
            this.lblSansliKisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSansliKisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSansliKisi.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSansliKisi.Location = new System.Drawing.Point(27, 459);
            this.lblSansliKisi.Name = "lblSansliKisi";
            this.lblSansliKisi.Size = new System.Drawing.Size(246, 73);
            this.lblSansliKisi.TabIndex = 0;
            this.lblSansliKisi.Text = "?";
            this.lblSansliKisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIsim
            // 
            this.txtIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsim.Location = new System.Drawing.Point(27, 43);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(120, 30);
            this.txtIsim.TabIndex = 1;
            this.txtIsim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIsim_KeyDown);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEkle.Location = new System.Drawing.Point(153, 43);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 30);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Kişi ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lsbIsimler
            // 
            this.lsbIsimler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lsbIsimler.FormattingEnabled = true;
            this.lsbIsimler.ItemHeight = 20;
            this.lsbIsimler.Location = new System.Drawing.Point(27, 88);
            this.lsbIsimler.Name = "lsbIsimler";
            this.lsbIsimler.Size = new System.Drawing.Size(120, 304);
            this.lsbIsimler.TabIndex = 3;
            this.lsbIsimler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsbIsimler_KeyDown);
            // 
            // btnCek
            // 
            this.btnCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCek.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCek.Location = new System.Drawing.Point(191, 88);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(82, 304);
            this.btnCek.TabIndex = 4;
            this.btnCek.Text = "Kura Çek";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // btnKaristir
            // 
            this.btnKaristir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaristir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKaristir.Location = new System.Drawing.Point(27, 407);
            this.btnKaristir.Name = "btnKaristir";
            this.btnKaristir.Size = new System.Drawing.Size(120, 36);
            this.btnKaristir.TabIndex = 5;
            this.btnKaristir.Text = "Karıştır";
            this.btnKaristir.UseVisualStyleBackColor = true;
            this.btnKaristir.Click += new System.EventHandler(this.btnKaristir_Click);
            // 
            // btnSirala
            // 
            this.btnSirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSirala.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSirala.Location = new System.Drawing.Point(153, 407);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(120, 36);
            this.btnSirala.TabIndex = 6;
            this.btnSirala.Text = "Sirala";
            this.btnSirala.UseVisualStyleBackColor = true;
            this.btnSirala.Click += new System.EventHandler(this.btnSirala_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "RANDOM.ORG";
            // 
            // btnTop
            // 
            this.btnTop.BackgroundImage = global::_02ListPractice.Properties.Resources._001_top;
            this.btnTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTop.FlatAppearance.BorderSize = 0;
            this.btnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop.Location = new System.Drawing.Point(153, 157);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(32, 34);
            this.btnTop.TabIndex = 8;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnBottom
            // 
            this.btnBottom.BackgroundImage = global::_02ListPractice.Properties.Resources._002_bottom;
            this.btnBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBottom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBottom.FlatAppearance.BorderSize = 0;
            this.btnBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottom.Location = new System.Drawing.Point(153, 280);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(32, 34);
            this.btnBottom.TabIndex = 9;
            this.btnBottom.UseVisualStyleBackColor = true;
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackgroundImage = global::_02ListPractice.Properties.Resources._003_down;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Location = new System.Drawing.Point(153, 239);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(32, 34);
            this.btnDown.TabIndex = 10;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackgroundImage = global::_02ListPractice.Properties.Resources._004_up;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Location = new System.Drawing.Point(153, 198);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(32, 34);
            this.btnUp.TabIndex = 11;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(300, 554);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSirala);
            this.Controls.Add(this.btnKaristir);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.lsbIsimler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.lblSansliKisi);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSansliKisi;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lsbIsimler;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Button btnKaristir;
        private System.Windows.Forms.Button btnSirala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnBottom;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
    }
}

