namespace bolum2uygulama2
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
            this.lblYas = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYas.Location = new System.Drawing.Point(36, 44);
            this.lblYas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(47, 13);
            this.lblYas.TabIndex = 0;
            this.lblYas.Text = "Yaşınız";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(40, 89);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(43, 13);
            this.lblDurum.TabIndex = 1;
            this.lblDurum.Text = "Durum";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(71, 124);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(136, 35);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(91, 44);
            this.txtYas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(116, 20);
            this.txtYas.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 294);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblYas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtYas;
    }
}

