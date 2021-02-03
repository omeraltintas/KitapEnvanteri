namespace KitapEnvanteri
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
            this.lblKad = new System.Windows.Forms.Label();
            this.lblYad = new System.Windows.Forms.Label();
            this.lblEv = new System.Windows.Forms.Label();
            this.txtYayın = new System.Windows.Forms.TextBox();
            this.txtYad = new System.Windows.Forms.TextBox();
            this.txtKad = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKad
            // 
            this.lblKad.AutoSize = true;
            this.lblKad.Location = new System.Drawing.Point(174, 67);
            this.lblKad.Name = "lblKad";
            this.lblKad.Size = new System.Drawing.Size(52, 13);
            this.lblKad.TabIndex = 0;
            this.lblKad.Text = "Kitap Adı:";
            // 
            // lblYad
            // 
            this.lblYad.AutoSize = true;
            this.lblYad.Location = new System.Drawing.Point(174, 116);
            this.lblYad.Name = "lblYad";
            this.lblYad.Size = new System.Drawing.Size(55, 13);
            this.lblYad.TabIndex = 1;
            this.lblYad.Text = "Yazar Adı:";
            // 
            // lblEv
            // 
            this.lblEv.AutoSize = true;
            this.lblEv.Location = new System.Drawing.Point(177, 158);
            this.lblEv.Name = "lblEv";
            this.lblEv.Size = new System.Drawing.Size(50, 13);
            this.lblEv.TabIndex = 2;
            this.lblEv.Text = "Yayınevi:";
            // 
            // txtYayın
            // 
            this.txtYayın.Location = new System.Drawing.Point(232, 155);
            this.txtYayın.Name = "txtYayın";
            this.txtYayın.Size = new System.Drawing.Size(100, 20);
            this.txtYayın.TabIndex = 3;
            // 
            // txtYad
            // 
            this.txtYad.Location = new System.Drawing.Point(232, 116);
            this.txtYad.Name = "txtYad";
            this.txtYad.Size = new System.Drawing.Size(100, 20);
            this.txtYad.TabIndex = 4;
            // 
            // txtKad
            // 
            this.txtKad.Location = new System.Drawing.Point(232, 67);
            this.txtKad.Name = "txtKad";
            this.txtKad.Size = new System.Drawing.Size(100, 20);
            this.txtKad.TabIndex = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(247, 204);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(380, 204);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(93, 23);
            this.btnAra.TabIndex = 7;
            this.btnAra.Text = "Kitap Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(125, 204);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(12, 204);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 23);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 330);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtKad);
            this.Controls.Add(this.txtYad);
            this.Controls.Add(this.txtYayın);
            this.Controls.Add(this.lblEv);
            this.Controls.Add(this.lblYad);
            this.Controls.Add(this.lblKad);
            this.Name = "Form1";
            this.Text = "Kitap Envanteri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKad;
        private System.Windows.Forms.Label lblYad;
        private System.Windows.Forms.Label lblEv;
        private System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.TextBox txtYayın;
        public System.Windows.Forms.TextBox txtYad;
        public System.Windows.Forms.TextBox txtKad;
        private System.Windows.Forms.Button btnAra;
        public System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

