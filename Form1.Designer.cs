namespace A6SiparisYonetimi
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
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstUrun = new System.Windows.Forms.ListBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cbSatistanKaldir = new System.Windows.Forms.CheckBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.nFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.nIndirim = new System.Windows.Forms.NumericUpDown();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ürünüÇıkartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arttırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nToplam = new System.Windows.Forms.NumericUpDown();
            this.nKdv = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCalisan = new System.Windows.Forms.ComboBox();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.btnSiparisOlustur = new System.Windows.Forms.Button();
            this.btnSiparisDetaylar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIndirim)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKdv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(16, 15);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(352, 22);
            this.txtAra.TabIndex = 7;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lstUrun
            // 
            this.lstUrun.FormattingEnabled = true;
            this.lstUrun.ItemHeight = 16;
            this.lstUrun.Location = new System.Drawing.Point(16, 47);
            this.lstUrun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(352, 276);
            this.lstUrun.TabIndex = 8;
            this.lstUrun.SelectedIndexChanged += new System.EventHandler(this.lstUrun_SelectedIndexChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(215, 460);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(155, 69);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cbSatistanKaldir
            // 
            this.cbSatistanKaldir.AutoSize = true;
            this.cbSatistanKaldir.Location = new System.Drawing.Point(119, 432);
            this.cbSatistanKaldir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSatistanKaldir.Name = "cbSatistanKaldir";
            this.cbSatistanKaldir.Size = new System.Drawing.Size(121, 21);
            this.cbSatistanKaldir.TabIndex = 15;
            this.cbSatistanKaldir.Text = "Satıştan Kaldır";
            this.cbSatistanKaldir.UseVisualStyleBackColor = true;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(119, 399);
            this.cmbKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(249, 24);
            this.cmbKategori.TabIndex = 11;
            // 
            // nFiyat
            // 
            this.nFiyat.DecimalPlaces = 2;
            this.nFiyat.Location = new System.Drawing.Point(119, 367);
            this.nFiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nFiyat.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nFiyat.Name = "nFiyat";
            this.nFiyat.Size = new System.Drawing.Size(249, 22);
            this.nFiyat.TabIndex = 10;
            this.nFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(120, 335);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(248, 22);
            this.txtUrunAdi.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 335);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 22);
            this.textBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 406);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 373);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 339);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ürün Adı";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(16, 460);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(155, 69);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(379, 47);
            this.btnSepeteEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(155, 69);
            this.btnSepeteEkle.TabIndex = 19;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // nIndirim
            // 
            this.nIndirim.DecimalPlaces = 3;
            this.nIndirim.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nIndirim.Location = new System.Drawing.Point(379, 124);
            this.nIndirim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nIndirim.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nIndirim.Name = "nIndirim";
            this.nIndirim.Size = new System.Drawing.Size(155, 22);
            this.nIndirim.TabIndex = 20;
            this.nIndirim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lstSepet
            // 
            this.lstSepet.ContextMenuStrip = this.contextMenuStrip1;
            this.lstSepet.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 20;
            this.lstSepet.Location = new System.Drawing.Point(543, 47);
            this.lstSepet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(352, 264);
            this.lstSepet.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünüÇıkartToolStripMenuItem,
            this.arttırToolStripMenuItem,
            this.azaltToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 76);
            // 
            // ürünüÇıkartToolStripMenuItem
            // 
            this.ürünüÇıkartToolStripMenuItem.Name = "ürünüÇıkartToolStripMenuItem";
            this.ürünüÇıkartToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.ürünüÇıkartToolStripMenuItem.Text = "Ürünü Çıkart";
            // 
            // arttırToolStripMenuItem
            // 
            this.arttırToolStripMenuItem.Name = "arttırToolStripMenuItem";
            this.arttırToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.arttırToolStripMenuItem.Text = "Arttır";
            // 
            // azaltToolStripMenuItem
            // 
            this.azaltToolStripMenuItem.Name = "azaltToolStripMenuItem";
            this.azaltToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.azaltToolStripMenuItem.Text = "Azalt";
            // 
            // nToplam
            // 
            this.nToplam.DecimalPlaces = 2;
            this.nToplam.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nToplam.Location = new System.Drawing.Point(669, 335);
            this.nToplam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nToplam.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nToplam.Name = "nToplam";
            this.nToplam.ReadOnly = true;
            this.nToplam.Size = new System.Drawing.Size(224, 48);
            this.nToplam.TabIndex = 22;
            this.nToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nKdv
            // 
            this.nKdv.DecimalPlaces = 2;
            this.nKdv.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nKdv.Location = new System.Drawing.Point(669, 388);
            this.nKdv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nKdv.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nKdv.Name = "nKdv";
            this.nKdv.ReadOnly = true;
            this.nKdv.Size = new System.Drawing.Size(224, 48);
            this.nKdv.TabIndex = 23;
            this.nKdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(536, 337);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 34);
            this.label4.TabIndex = 14;
            this.label4.Text = "Toplam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(536, 396);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 34);
            this.label5.TabIndex = 14;
            this.label5.Text = "KDV";
            // 
            // cmbCalisan
            // 
            this.cmbCalisan.FormattingEnabled = true;
            this.cmbCalisan.Location = new System.Drawing.Point(904, 47);
            this.cmbCalisan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCalisan.Name = "cmbCalisan";
            this.cmbCalisan.Size = new System.Drawing.Size(351, 24);
            this.cmbCalisan.TabIndex = 25;
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(904, 85);
            this.cmbMusteri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(351, 24);
            this.cmbMusteri.TabIndex = 25;
            // 
            // btnSiparisOlustur
            // 
            this.btnSiparisOlustur.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisOlustur.ForeColor = System.Drawing.Color.Tomato;
            this.btnSiparisOlustur.Location = new System.Drawing.Point(905, 120);
            this.btnSiparisOlustur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiparisOlustur.Name = "btnSiparisOlustur";
            this.btnSiparisOlustur.Size = new System.Drawing.Size(348, 143);
            this.btnSiparisOlustur.TabIndex = 26;
            this.btnSiparisOlustur.Text = "Siparişi Tamamla";
            this.btnSiparisOlustur.UseVisualStyleBackColor = true;
            this.btnSiparisOlustur.Click += new System.EventHandler(this.btnSiparisOlustur_Click);
            // 
            // btnSiparisDetaylar
            // 
            this.btnSiparisDetaylar.Location = new System.Drawing.Point(739, 460);
            this.btnSiparisDetaylar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSiparisDetaylar.Name = "btnSiparisDetaylar";
            this.btnSiparisDetaylar.Size = new System.Drawing.Size(155, 69);
            this.btnSiparisDetaylar.TabIndex = 27;
            this.btnSiparisDetaylar.Text = "Sipariş Detayları";
            this.btnSiparisDetaylar.UseVisualStyleBackColor = true;
            this.btnSiparisDetaylar.Click += new System.EventHandler(this.btnSiparisDetaylar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 570);
            this.Controls.Add(this.btnSiparisDetaylar);
            this.Controls.Add(this.btnSiparisOlustur);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.cmbCalisan);
            this.Controls.Add(this.nKdv);
            this.Controls.Add(this.nToplam);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.nIndirim);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cbSatistanKaldir);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.nFiyat);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstUrun);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIndirim)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKdv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lstUrun;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.CheckBox cbSatistanKaldir;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.NumericUpDown nFiyat;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.NumericUpDown nIndirim;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.NumericUpDown nToplam;
        private System.Windows.Forms.NumericUpDown nKdv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünüÇıkartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arttırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azaltToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbCalisan;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Button btnSiparisOlustur;
        private System.Windows.Forms.Button btnSiparisDetaylar;
    }
}

