namespace _04EsiniBulBasit
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnYeniden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Location = new System.Drawing.Point(12, 12);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(341, 320);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnYeniden
            // 
            this.btnYeniden.Location = new System.Drawing.Point(94, 107);
            this.btnYeniden.Name = "btnYeniden";
            this.btnYeniden.Size = new System.Drawing.Size(151, 73);
            this.btnYeniden.TabIndex = 0;
            this.btnYeniden.Text = "YENİDEN OYNAMAK İSTER MİSİN?";
            this.btnYeniden.UseVisualStyleBackColor = true;
            this.btnYeniden.Visible = false;
            this.btnYeniden.Click += new System.EventHandler(this.btnYeniden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 347);
            this.Controls.Add(this.btnYeniden);
            this.Controls.Add(this.pnlButtons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnYeniden;
    }
}

