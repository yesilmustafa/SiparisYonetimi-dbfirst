namespace A6SiparisYonetimi
{
    partial class FormSiparisDetay
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
            this.lvSiparisler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDetay = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.txtCalisan = new System.Windows.Forms.TextBox();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.txtKargo = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSiparisler
            // 
            this.lvSiparisler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvSiparisler.Font = new System.Drawing.Font("Monaco", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvSiparisler.FullRowSelect = true;
            this.lvSiparisler.GridLines = true;
            this.lvSiparisler.Location = new System.Drawing.Point(13, 59);
            this.lvSiparisler.Name = "lvSiparisler";
            this.lvSiparisler.Size = new System.Drawing.Size(884, 228);
            this.lvSiparisler.TabIndex = 2;
            this.lvSiparisler.UseCompatibleStateImageBehavior = false;
            this.lvSiparisler.View = System.Windows.Forms.View.Details;
            this.lvSiparisler.SelectedIndexChanged += new System.EventHandler(this.lvSiparisler_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sipariş No";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sipariş Tarihi";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İstenen Tarih";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kargo Fiyatı";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sipariş Toplam Tutar";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 240;
            // 
            // lvDetay
            // 
            this.lvDetay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvDetay.Font = new System.Drawing.Font("Monaco", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvDetay.FullRowSelect = true;
            this.lvDetay.GridLines = true;
            this.lvDetay.Location = new System.Drawing.Point(13, 325);
            this.lvDetay.Name = "lvDetay";
            this.lvDetay.Size = new System.Drawing.Size(583, 228);
            this.lvDetay.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvDetay.TabIndex = 3;
            this.lvDetay.UseCompatibleStateImageBehavior = false;
            this.lvDetay.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ürün Adı";
            this.columnHeader6.Width = 250;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Birim Fiyat";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Adet";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 75;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "İndirim";
            this.columnHeader9.Width = 100;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Font = new System.Drawing.Font("Monaco", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBaslangic.Location = new System.Drawing.Point(13, 13);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(351, 30);
            this.dtpBaslangic.TabIndex = 0;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Font = new System.Drawing.Font("Monaco", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBitis.Location = new System.Drawing.Point(382, 13);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(351, 30);
            this.dtpBitis.TabIndex = 1;
            // 
            // txtCalisan
            // 
            this.txtCalisan.Font = new System.Drawing.Font("Monaco", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCalisan.Location = new System.Drawing.Point(638, 325);
            this.txtCalisan.Name = "txtCalisan";
            this.txtCalisan.ReadOnly = true;
            this.txtCalisan.Size = new System.Drawing.Size(259, 30);
            this.txtCalisan.TabIndex = 4;
            // 
            // txtMusteri
            // 
            this.txtMusteri.Font = new System.Drawing.Font("Monaco", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteri.Location = new System.Drawing.Point(638, 361);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.ReadOnly = true;
            this.txtMusteri.Size = new System.Drawing.Size(259, 30);
            this.txtMusteri.TabIndex = 5;
            // 
            // txtKargo
            // 
            this.txtKargo.Font = new System.Drawing.Font("Monaco", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKargo.Location = new System.Drawing.Point(638, 404);
            this.txtKargo.Name = "txtKargo";
            this.txtKargo.ReadOnly = true;
            this.txtKargo.Size = new System.Drawing.Size(259, 30);
            this.txtKargo.TabIndex = 6;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(740, 13);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(157, 40);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // FormSiparisDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 601);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.txtKargo);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.txtCalisan);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.lvDetay);
            this.Controls.Add(this.lvSiparisler);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSiparisDetay";
            this.Text = "Sipariş Detayları";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSiparisler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvDetay;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.TextBox txtCalisan;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.TextBox txtKargo;
        private System.Windows.Forms.Button btnExcel;
    }
}