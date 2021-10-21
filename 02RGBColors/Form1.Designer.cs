
namespace _02RGBColors
{
    partial class frmColor
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
            this.tmrColorChange = new System.Windows.Forms.Timer(this.components);
            this.lblColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrColorChange
            // 
            this.tmrColorChange.Enabled = true;
            this.tmrColorChange.Interval = 10;
            this.tmrColorChange.Tick += new System.EventHandler(this.tmrColorChange_Tick);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblColor.Location = new System.Drawing.Point(215, 159);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(66, 24);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "label1";
            // 
            // frmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(565, 370);
            this.Controls.Add(this.lblColor);
            this.Name = "frmColor";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrColorChange;
        private System.Windows.Forms.Label lblColor;
    }
}

