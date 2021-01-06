namespace IEnumerator_9
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
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstElemanlar = new System.Windows.Forms.ListBox();
            this.lstOyuncuListesi = new System.Windows.Forms.ListBox();
            this.btnOyunculariListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyuncu";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(149, 19);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 22);
            this.txtAdi.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(149, 287);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 25);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstElemanlar
            // 
            this.lstElemanlar.FormattingEnabled = true;
            this.lstElemanlar.ItemHeight = 16;
            this.lstElemanlar.Location = new System.Drawing.Point(38, 75);
            this.lstElemanlar.Name = "lstElemanlar";
            this.lstElemanlar.Size = new System.Drawing.Size(211, 180);
            this.lstElemanlar.TabIndex = 3;
            // 
            // lstOyuncuListesi
            // 
            this.lstOyuncuListesi.FormattingEnabled = true;
            this.lstOyuncuListesi.ItemHeight = 16;
            this.lstOyuncuListesi.Location = new System.Drawing.Point(255, 75);
            this.lstOyuncuListesi.Name = "lstOyuncuListesi";
            this.lstOyuncuListesi.Size = new System.Drawing.Size(211, 180);
            this.lstOyuncuListesi.TabIndex = 4;
            // 
            // btnOyunculariListele
            // 
            this.btnOyunculariListele.Location = new System.Drawing.Point(277, 287);
            this.btnOyunculariListele.Name = "btnOyunculariListele";
            this.btnOyunculariListele.Size = new System.Drawing.Size(189, 25);
            this.btnOyunculariListele.TabIndex = 5;
            this.btnOyunculariListele.Text = "Oyuncuları Listele";
            this.btnOyunculariListele.UseVisualStyleBackColor = true;
            this.btnOyunculariListele.Click += new System.EventHandler(this.btnOyunculariListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 351);
            this.Controls.Add(this.btnOyunculariListele);
            this.Controls.Add(this.lstOyuncuListesi);
            this.Controls.Add(this.lstElemanlar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstElemanlar;
        private System.Windows.Forms.ListBox lstOyuncuListesi;
        private System.Windows.Forms.Button btnOyunculariListele;
    }
}

