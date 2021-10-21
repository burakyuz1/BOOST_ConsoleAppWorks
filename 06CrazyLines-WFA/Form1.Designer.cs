
namespace _06CrazyLines_WFA
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
            this.pnlCizim = new System.Windows.Forms.Panel();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnAnimasyonBaslat = new System.Windows.Forms.Button();
            this.tmrDraw = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlCizim
            // 
            this.pnlCizim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCizim.BackColor = System.Drawing.Color.White;
            this.pnlCizim.Location = new System.Drawing.Point(33, 18);
            this.pnlCizim.Name = "pnlCizim";
            this.pnlCizim.Size = new System.Drawing.Size(1078, 499);
            this.pnlCizim.TabIndex = 0;
            this.pnlCizim.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCizim_Paint);
            // 
            // btnYenile
            // 
            this.btnYenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYenile.Location = new System.Drawing.Point(599, 523);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(512, 59);
            this.btnYenile.TabIndex = 1;
            this.btnYenile.Text = "DRAW AGAIN";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnAnimasyonBaslat
            // 
            this.btnAnimasyonBaslat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnimasyonBaslat.Location = new System.Drawing.Point(31, 523);
            this.btnAnimasyonBaslat.Name = "btnAnimasyonBaslat";
            this.btnAnimasyonBaslat.Size = new System.Drawing.Size(512, 59);
            this.btnAnimasyonBaslat.TabIndex = 2;
            this.btnAnimasyonBaslat.Text = "START ANIMATION";
            this.btnAnimasyonBaslat.UseVisualStyleBackColor = true;
            this.btnAnimasyonBaslat.Click += new System.EventHandler(this.btnAnimasyonBaslat_Click);
            // 
            // tmrDraw
            // 
            this.tmrDraw.Tick += new System.EventHandler(this.tmrDraw_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 608);
            this.Controls.Add(this.btnAnimasyonBaslat);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.pnlCizim);
            this.Name = "Form1";
            this.Text = "CRAZY LINES";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCizim;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnAnimasyonBaslat;
        private System.Windows.Forms.Timer tmrDraw;
    }
}

