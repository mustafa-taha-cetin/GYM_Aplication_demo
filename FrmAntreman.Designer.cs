namespace GYM
{
    partial class FrmAntreman
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHareket = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAgirlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSet = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 143);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 122);
            this.label1.TabIndex = 0;
            this.label1.Text = "Günlük Spor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.label2.Font = new System.Drawing.Font("Corbel", 34.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hareket:";
            // 
            // cmbHareket
            // 
            this.cmbHareket.Font = new System.Drawing.Font("Corbel", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHareket.FormattingEnabled = true;
            this.cmbHareket.Items.AddRange(new object[] {
            "Şınav",
            "Makine",
            "Bench",
            "Kapa-Aç",
            "Hamer Curl",
            "Curl",
            "Düz Curl",
            "Plate Up",
            "Dumble Fly",
            "Askeri Press"});
            this.cmbHareket.Location = new System.Drawing.Point(305, 208);
            this.cmbHareket.Name = "cmbHareket";
            this.cmbHareket.Size = new System.Drawing.Size(210, 72);
            this.cmbHareket.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.label3.Font = new System.Drawing.Font("Corbel", 34.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 69);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ağırlık:";
            // 
            // txtAgirlik
            // 
            this.txtAgirlik.Font = new System.Drawing.Font("Corbel", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgirlik.Location = new System.Drawing.Point(305, 300);
            this.txtAgirlik.Name = "txtAgirlik";
            this.txtAgirlik.Size = new System.Drawing.Size(210, 72);
            this.txtAgirlik.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.label4.Font = new System.Drawing.Font("Corbel", 34.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 69);
            this.label4.TabIndex = 6;
            this.label4.Text = "Set:";
            // 
            // txtSet
            // 
            this.txtSet.Font = new System.Drawing.Font("Corbel", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSet.Location = new System.Drawing.Point(305, 387);
            this.txtSet.Name = "txtSet";
            this.txtSet.Size = new System.Drawing.Size(210, 72);
            this.txtSet.TabIndex = 7;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.btnKaydet.Location = new System.Drawing.Point(187, 492);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(256, 78);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.button1.Location = new System.Drawing.Point(187, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 78);
            this.button1.TabIndex = 9;
            this.button1.Text = "Kaydı Sil";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmAntreman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(639, 734);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAgirlik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbHareket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MaximizeBox = false;
            this.Name = "FrmAntreman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antreman Ekle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHareket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAgirlik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSet;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button button1;
    }
}