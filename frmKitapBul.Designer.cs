namespace KitapEnvanteri
{
    partial class frmKitapBul
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ktAd = new System.Windows.Forms.Label();
            this.txtKt = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.txtKt);
            this.groupBox1.Controls.Add(this.ktAd);
            this.groupBox1.Location = new System.Drawing.Point(95, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bul";
            // 
            // ktAd
            // 
            this.ktAd.AutoSize = true;
            this.ktAd.Location = new System.Drawing.Point(81, 44);
            this.ktAd.Name = "ktAd";
            this.ktAd.Size = new System.Drawing.Size(86, 13);
            this.ktAd.TabIndex = 0;
            this.ktAd.Text = "Kitap Adı Giriniz: ";
            // 
            // txtKt
            // 
            this.txtKt.Location = new System.Drawing.Point(84, 88);
            this.txtKt.Name = "txtKt";
            this.txtKt.Size = new System.Drawing.Size(100, 20);
            this.txtKt.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(84, 140);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Kitap Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // frmKitapBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 364);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKitapBul";
            this.Text = "Kitap Arama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtKt;
        private System.Windows.Forms.Label ktAd;
    }
}