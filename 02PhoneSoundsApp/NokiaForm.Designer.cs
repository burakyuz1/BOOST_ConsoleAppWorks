
namespace _02PhoneSoundsApp
{
    partial class NokiaForm
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
            this.lblNokia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNokia
            // 
            this.lblNokia.AutoSize = true;
            this.lblNokia.Location = new System.Drawing.Point(315, 108);
            this.lblNokia.Name = "lblNokia";
            this.lblNokia.Size = new System.Drawing.Size(35, 13);
            this.lblNokia.TabIndex = 0;
            this.lblNokia.Text = "label1";
            // 
            // NokiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNokia);
            this.Name = "NokiaForm";
            this.Text = "NokiaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NokiaForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNokia;
    }
}