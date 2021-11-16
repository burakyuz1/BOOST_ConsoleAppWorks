namespace _03EsiniBul
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
            this.btnTekrarOyna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTekrarOyna
            // 
            this.btnTekrarOyna.Location = new System.Drawing.Point(69, 73);
            this.btnTekrarOyna.Name = "btnTekrarOyna";
            this.btnTekrarOyna.Size = new System.Drawing.Size(109, 56);
            this.btnTekrarOyna.TabIndex = 0;
            this.btnTekrarOyna.Text = "TEKRAR OYNA";
            this.btnTekrarOyna.UseVisualStyleBackColor = true;
            this.btnTekrarOyna.Visible = false;
            this.btnTekrarOyna.Click += new System.EventHandler(this.btnTekrarOyna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 231);
            this.Controls.Add(this.btnTekrarOyna);
            this.Name = "Form1";
            this.Text = "EsiniBul";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnTekrarOyna;
    }
}

