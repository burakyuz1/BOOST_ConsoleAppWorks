
namespace _01AtYarisi
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
            this.components = new System.ComponentModel.Container();
            this.btnBasla = new System.Windows.Forms.Button();
            this.tmrYaris = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.pcbAt3 = new System.Windows.Forms.PictureBox();
            this.pcbAt2 = new System.Windows.Forms.PictureBox();
            this.pcbAt1 = new System.Windows.Forms.PictureBox();
            this.tmrSayac = new System.Windows.Forms.Timer(this.components);
            this.lblSayac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBasla.Location = new System.Drawing.Point(23, 375);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(765, 63);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "Yarışı Başlat";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // tmrYaris
            // 
            this.tmrYaris.Tick += new System.EventHandler(this.tmrYaris_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(-12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 10);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(-12, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 11);
            this.label2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(-12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(800, 10);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(-12, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(800, 11);
            this.label5.TabIndex = 9;
            // 
            // lblBitis
            // 
            this.lblBitis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBitis.Location = new System.Drawing.Point(778, 9);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(10, 358);
            this.lblBitis.TabIndex = 10;
            // 
            // pcbAt3
            // 
            this.pcbAt3.Image = global::_01AtYarisi.Properties.Resources.horse3;
            this.pcbAt3.Location = new System.Drawing.Point(23, 257);
            this.pcbAt3.Name = "pcbAt3";
            this.pcbAt3.Size = new System.Drawing.Size(100, 90);
            this.pcbAt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAt3.TabIndex = 28;
            this.pcbAt3.TabStop = false;
            this.pcbAt3.Tag = "3";
            // 
            // pcbAt2
            // 
            this.pcbAt2.Image = global::_01AtYarisi.Properties.Resources.horse2;
            this.pcbAt2.Location = new System.Drawing.Point(23, 142);
            this.pcbAt2.Name = "pcbAt2";
            this.pcbAt2.Size = new System.Drawing.Size(100, 90);
            this.pcbAt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAt2.TabIndex = 27;
            this.pcbAt2.TabStop = false;
            this.pcbAt2.Tag = "2";
            // 
            // pcbAt1
            // 
            this.pcbAt1.Image = global::_01AtYarisi.Properties.Resources.horse1;
            this.pcbAt1.Location = new System.Drawing.Point(23, 28);
            this.pcbAt1.Name = "pcbAt1";
            this.pcbAt1.Size = new System.Drawing.Size(100, 90);
            this.pcbAt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAt1.TabIndex = 26;
            this.pcbAt1.TabStop = false;
            this.pcbAt1.Tag = "1";
            // 
            // tmrSayac
            // 
            this.tmrSayac.Interval = 1000;
            this.tmrSayac.Tick += new System.EventHandler(this.tmrSayac_Tick);
            // 
            // lblSayac
            // 
            this.lblSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 128F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.Location = new System.Drawing.Point(227, 38);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(428, 295);
            this.lblSayac.TabIndex = 29;
            this.lblSayac.Text = "3";
            this.lblSayac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.pcbAt3);
            this.Controls.Add(this.pcbAt2);
            this.Controls.Add(this.pcbAt1);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBasla);
            this.Name = "Form1";
            this.Text = "AT YARIŞI";
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Timer tmrYaris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.PictureBox pcbAt1;
        private System.Windows.Forms.PictureBox pcbAt2;
        private System.Windows.Forms.PictureBox pcbAt3;
        private System.Windows.Forms.Timer tmrSayac;
        private System.Windows.Forms.Label lblSayac;
    }
}

