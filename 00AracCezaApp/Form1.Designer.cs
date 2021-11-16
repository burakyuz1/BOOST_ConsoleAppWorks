namespace _00AracCezaApp
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
            this.nmuAracAnlikHiz = new System.Windows.Forms.NumericUpDown();
            this.txtAracToplamCeza = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmuAracAnlikHiz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(88, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Anlık Hız";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Araç Toplam Ceza Tutarı";
            // 
            // nmuAracAnlikHiz
            // 
            this.nmuAracAnlikHiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmuAracAnlikHiz.Location = new System.Drawing.Point(201, 3);
            this.nmuAracAnlikHiz.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nmuAracAnlikHiz.Name = "nmuAracAnlikHiz";
            this.nmuAracAnlikHiz.Size = new System.Drawing.Size(80, 26);
            this.nmuAracAnlikHiz.TabIndex = 2;
            this.nmuAracAnlikHiz.ValueChanged += new System.EventHandler(this.nmuAracAnlikHiz_ValueChanged);
            // 
            // txtAracToplamCeza
            // 
            this.txtAracToplamCeza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracToplamCeza.Location = new System.Drawing.Point(201, 47);
            this.txtAracToplamCeza.Multiline = true;
            this.txtAracToplamCeza.Name = "txtAracToplamCeza";
            this.txtAracToplamCeza.Size = new System.Drawing.Size(292, 150);
            this.txtAracToplamCeza.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 215);
            this.Controls.Add(this.txtAracToplamCeza);
            this.Controls.Add(this.nmuAracAnlikHiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RADAR";
            ((System.ComponentModel.ISupportInitialize)(this.nmuAracAnlikHiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmuAracAnlikHiz;
        private System.Windows.Forms.TextBox txtAracToplamCeza;
    }
}

