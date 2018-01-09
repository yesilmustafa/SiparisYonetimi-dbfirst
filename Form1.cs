using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace A6SiparisYonetimi
{
    public partial class Form1 : Form
    {

        List<SepetModel> sepetList = new List<SepetModel>();
        FormSiparisDetay siparisDetayForm;

        public Form1()
        {
            InitializeComponent();
            ürünüÇıkartToolStripMenuItem.Click += SepetYonetimi;
            azaltToolStripMenuItem.Click += SepetYonetimi;
            arttırToolStripMenuItem.Click += SepetYonetimi;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItem == null) return;
            var seciliUrun = lstUrun.SelectedItem as Product;

            try
            {
                NorthwindEntities db = new NorthwindEntities();
                seciliUrun = db.Products.Find(seciliUrun.ProductID);
                if (seciliUrun == null)
                {
                    MessageBox.Show("Güncellenecek Ürün Bulunamadı");
                    VerileriGetir();
                    return;
                }
                seciliUrun.ProductName = txtUrunAdi.Text;
                seciliUrun.UnitPrice = nFiyat.Value;
                seciliUrun.CategoryID = Convert.ToInt32(cmbKategori.SelectedValue);
                seciliUrun.Discontinued = cbSatistanKaldir.Checked;
                db.SaveChanges();
                VerileriGetir();
                lstUrun.SelectedValue = seciliUrun.ProductID;
                MessageBox.Show("Ürün güncelleme işlemi başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                NorthwindEntities db = new NorthwindEntities();
                Product yeni = new Product()
                {
                    ProductName = txtUrunAdi.Text,
                    UnitPrice = nFiyat.Value,
                    Discontinued = cbSatistanKaldir.Checked,
                    CategoryID = Convert.ToInt32(cmbKategori.SelectedValue)
                };
                db.Products.Add(yeni);
                db.SaveChanges();
                VerileriGetir();
                lstUrun.SelectedValue = yeni.ProductID;
                MessageBox.Show($"{yeni.ProductName} adlı ürün başarıyla eklenmiştir");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItem == null) return;
            var seciliUrun = lstUrun.SelectedItem as Product;

            var model = new SepetModel()
            {
                ProductID = seciliUrun.ProductID,
                ProdutcName = seciliUrun.ProductName,
                UnitPrice = seciliUrun.UnitPrice.HasValue ? seciliUrun.UnitPrice.Value : 0,
                Discount = float.Parse(nIndirim.Value.ToString())
            };
            bool varmi = false;
            sepetList.ForEach(x =>
            {
                if (x.ProductID == model.ProductID)
                {
                    x.Quantity++;
                    varmi = true;
                }
            }
            );
            if (!varmi)
                sepetList.Add(model);

            //lstSepet.DataSource = sepetList;
            SepetiGuncelle();
        }
        private void btnSiparisDetaylar_Click(object sender, EventArgs e)
        {
            if (siparisDetayForm == null || siparisDetayForm.IsDisposed)
            {
                siparisDetayForm = new FormSiparisDetay();
                siparisDetayForm.StartPosition = FormStartPosition.CenterScreen;
                siparisDetayForm.Show();
            }
        }
        private void btnSiparisOlustur_Click(object sender, EventArgs e)
        {
            if (sepetList.Count == 0)
            {
                MessageBox.Show("Önce Sepete Ürün eklemelisiniz");
                return;
            }
            if (cmbCalisan.SelectedItem == null)
            {
                MessageBox.Show("Siparişi veren çalışanı seçiniz");
                return;
            }
            if (cmbMusteri.SelectedItem == null)
            {
                MessageBox.Show("Müşteriyi seçiniz");
                return;
            }

            string mesaj = $"{nFiyat.Value:c2} tutarındaki siparişi onaylıyor musunuz?";
            DialogResult cevap = MessageBox.Show(mesaj, "Sipariş Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes) return;

            NorthwindEntities db = new NorthwindEntities();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var yeniSiparis = new Order()
                    {
                        EmployeeID = (cmbCalisan.SelectedItem as CalisanModel).EmployeeID,
                        CustomerID = (cmbMusteri.SelectedItem as MusteriModel).CustomerID,
                        OrderDate = DateTime.Now,
                        RequiredDate = DateTime.Now.AddDays(3),
                        Freight = 20,
                        ShipVia = 1
                    };
                    db.Orders.Add(yeniSiparis);
                    db.SaveChanges();

                    foreach (var item in sepetList)
                    {
                        var siparisDetay = new Order_Detail()
                        {
                            OrderID = yeniSiparis.OrderID,
                            ProductID = item.ProductID,
                            Quantity = item.Quantity,
                            UnitPrice = item.UnitPrice,
                            Discount = item.Discount
                        };
                        if (item.ProductID == 2) // hata verdirtmek istiyoruz
                            throw new Exception("Chang satamazsın");
                        db.Order_Details.Add(siparisDetay);
                    }
                    db.SaveChanges();
                    tran.Commit();

                    MessageBox.Show("Siparişiniz oluşturulmuştur");
                    Temizle();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Sipariş Oluşturma işleminde hata oluştu.\n" + ex.Message);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void lstUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItem == null) return;
            var seciliUrun = lstUrun.SelectedItem as Product;

            txtUrunAdi.Text = seciliUrun.ProductName;
            nFiyat.Value = seciliUrun.UnitPrice.HasValue ? seciliUrun.UnitPrice.Value : 0;
            cbSatistanKaldir.Checked = seciliUrun.Discontinued;

            cmbKategori.SelectedValue = seciliUrun.Category.CategoryID;
        }

        void SepetHesapla()
        {
            decimal toplam = 0, kdv = 0;
            toplam = sepetList.Sum(x => x.Total);
            kdv = toplam * 0.18m;
            nToplam.Value = toplam;
            nKdv.Value = kdv;
        }

        private void SepetiGuncelle()
        {
            lstSepet.Items.Clear();
            sepetList.ForEach(x => lstSepet.Items.Add(x));
            SepetHesapla();
        }

        private void SepetYonetimi(object sender, EventArgs e)
        {
            if (lstSepet.SelectedItem == null) return;
            var seciliUrun = lstSepet.SelectedItem as SepetModel;
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            if (menuItem.Text == "Ürünü Çıkart")
            {
                sepetList.Remove(seciliUrun);
                SepetiGuncelle();
            }
            else if (menuItem.Text == "Arttır")
            {
                seciliUrun.Quantity++;
                SepetiGuncelle();
            }
            else
            {
                if (seciliUrun.Quantity > 1)
                    seciliUrun.Quantity--;
                else
                    sepetList.Remove(seciliUrun);
                SepetiGuncelle();
            }
        }
        void Temizle()
        {
            sepetList = new List<SepetModel>();
            lstSepet.Items.Clear();
            VerileriGetir();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string arama = txtAra.Text.ToLower();
            try
            {
                NorthwindEntities db = new NorthwindEntities();
                var sonuc = db.Products
                    .Where(x => x.ProductName.ToLower().Contains(arama) || x.Category.CategoryName.ToLower().Contains(arama))
                    .OrderBy(x => x.ProductName)
                    .ToList();
                lstUrun.DataSource = sonuc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void VerileriGetir()
        {
            try
            {
                NorthwindEntities db = new NorthwindEntities();
                cmbKategori.DataSource = db.Categories.ToList();
                cmbKategori.DisplayMember = "CategoryName";
                cmbKategori.ValueMember = "CategoryID";

                lstUrun.DataSource = db.Products.OrderBy(x => x.ProductName).ToList();
                lstUrun.DisplayMember = "ProductName";
                lstUrun.ValueMember = "ProductID";

                cmbCalisan.DataSource = db.Employees
                    .OrderBy(x => x.FirstName)
                    .ThenBy(x => x.LastName)
                    .Select(x => new CalisanModel
                    {
                        EmployeeID = x.EmployeeID,
                        FirstName = x.FirstName,
                        LastName = x.LastName
                    }).ToList();

                cmbMusteri.DataSource = db.Customers
                    .OrderBy(x => x.CompanyName)
                    .Select(x => new MusteriModel
                    {
                        CustomerID = x.CustomerID,
                        CompanyName = x.CompanyName,
                        ContactName = x.ContactName
                    }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
