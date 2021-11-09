
namespace _01PhoneSounds
{
    partial class DenemeForm
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
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblOkunanDeger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(33, 35);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(194, 127);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "DENEME";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblOkunanDeger
            // 
            this.lblOkunanDeger.AutoSize = true;
            this.lblOkunanDeger.Location = new System.Drawing.Point(398, 108);
            this.lblOkunanDeger.Name = "lblOkunanDeger";
            this.lblOkunanDeger.Size = new System.Drawing.Size(35, 13);
            this.lblOkunanDeger.TabIndex = 1;
            this.lblOkunanDeger.Text = "label1";
            this.lblOkunanDeger.Click += new System.EventHandler(this.lblOkunanDeger_Click);
            // 
            // DenemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOkunanDeger);
            this.Controls.Add(this.btnKapat);
            this.Name = "DenemeForm";
            this.Text = "DenemeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblOkunanDeger;
    }
}