
namespace _01PhoneSounds
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDenemeAc = new System.Windows.Forms.Button();
            this.txtOkunan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abstract -> Soyut (Interface)";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Concrete -> Somut (Class)";
            // 
            // btnDenemeAc
            // 
            this.btnDenemeAc.Location = new System.Drawing.Point(30, 112);
            this.btnDenemeAc.Name = "btnDenemeAc";
            this.btnDenemeAc.Size = new System.Drawing.Size(232, 23);
            this.btnDenemeAc.TabIndex = 2;
            this.btnDenemeAc.Text = "DenemeFormunu Aç";
            this.btnDenemeAc.UseVisualStyleBackColor = true;
            this.btnDenemeAc.Click += new System.EventHandler(this.btnDenemeAc_Click);
            // 
            // txtOkunan
            // 
            this.txtOkunan.Location = new System.Drawing.Point(370, 69);
            this.txtOkunan.Name = "txtOkunan";
            this.txtOkunan.Size = new System.Drawing.Size(100, 20);
            this.txtOkunan.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOkunan);
            this.Controls.Add(this.btnDenemeAc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDenemeAc;
        private System.Windows.Forms.TextBox txtOkunan;
    }
}

