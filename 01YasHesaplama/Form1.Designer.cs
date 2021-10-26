
namespace _01YasHesaplama
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
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblGun = new System.Windows.Forms.Label();
            this.lblBurc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCuma = new System.Windows.Forms.Label();
            this.tmrShow = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(125, 61);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(269, 26);
            this.dtpTarih.TabIndex = 0;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(158, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "DOĞUM TARİHİNİZ";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.White;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(176, 106);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(168, 48);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            this.btnHesapla.MouseHover += new System.EventHandler(this.btnHesapla_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(149, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yaşınız: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(70, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yaşadığınız Gün:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(126, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Burcunuz :";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYas.Location = new System.Drawing.Point(243, 188);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(12, 18);
            this.lblYas.TabIndex = 6;
            this.lblYas.Text = " ";
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGun.Location = new System.Drawing.Point(243, 226);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(12, 18);
            this.lblGun.TabIndex = 7;
            this.lblGun.Text = " ";
            // 
            // lblBurc
            // 
            this.lblBurc.AutoSize = true;
            this.lblBurc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBurc.Location = new System.Drawing.Point(243, 266);
            this.lblBurc.Name = "lblBurc";
            this.lblBurc.Size = new System.Drawing.Size(12, 18);
            this.lblBurc.TabIndex = 8;
            this.lblBurc.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(4, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kaç tane cuma gördün :";
            // 
            // lblCuma
            // 
            this.lblCuma.AutoSize = true;
            this.lblCuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCuma.Location = new System.Drawing.Point(243, 306);
            this.lblCuma.Name = "lblCuma";
            this.lblCuma.Size = new System.Drawing.Size(12, 18);
            this.lblCuma.TabIndex = 12;
            this.lblCuma.Text = " ";
            // 
            // tmrShow
            // 
            this.tmrShow.Interval = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 389);
            this.Controls.Add(this.lblCuma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBurc);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTarih);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Label lblBurc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCuma;
        private System.Windows.Forms.Timer tmrShow;
    }
}

