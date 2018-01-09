using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A6SiparisYonetimi
{
    public partial class FormSiparisDetay : Form
    {
        public FormSiparisDetay()
        {
            InitializeComponent();
            dtpBaslangic.ValueChanged += Filtre_Changed;
            dtpBitis.ValueChanged += Filtre_Changed;
            lvSiparisler.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvDetay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        List<SiparisModel> siparisler = new List<SiparisModel>();
        private void Filtre_Changed(object sender, EventArgs e)
        {
            SiparisleriGetir(dtpBaslangic.Value, dtpBitis.Value);
            lvSiparisler.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void SiparisleriGetir(DateTime baslangic, DateTime bitis)
        {
            baslangic = new DateTime(baslangic.Year, baslangic.Month, baslangic.Day, 0, 0, 0);
            bitis = new DateTime(bitis.Year, bitis.Month, bitis.Day, 23, 59, 59);
            try
            {
                NorthwindEntities db = new NorthwindEntities();
                var siparisler = from siparis in db.Orders
                                 join calisan in db.Employees on siparis.EmployeeID equals calisan.EmployeeID
                                 join musteri in db.Customers on siparis.CustomerID equals musteri.CustomerID
                                 join kargo in db.Shippers on siparis.ShipVia equals kargo.ShipperID
                                 //join sdetay in db.Order_Details on siparis.OrderID equals sdetay.OrderID
                                 where siparis.OrderDate >= baslangic && siparis.OrderDate <= bitis
                                 select new SiparisModel
                                 {
                                     OrderID = siparis.OrderID,
                                     OrderDate = siparis.OrderDate,
                                     Freight = siparis.Freight,
                                     RequiredDate = siparis.RequiredDate,
                                     Customer = musteri.CompanyName,
                                     Employee = calisan.FirstName + " " + calisan.LastName,
                                     Shipper = kargo.CompanyName
                                 };
                lvSiparisler.Items.Clear();
                var siparisdetaylar = db.Order_Details.ToList();
                this.siparisler = new List<SiparisModel>();
                siparisler.ToList().ForEach(x =>
                {
                    x.Total = siparisdetaylar.Where(y => y.OrderID == x.OrderID).Sum(t => t.UnitPrice * t.Quantity);
                    x.Discount = siparisdetaylar.Where(y => y.OrderID == x.OrderID).FirstOrDefault().Discount;
                    ListViewItem viewItem = new ListViewItem(x.OrderID.ToString());
                    viewItem.SubItems.Add($"{x.OrderDate:dd/MM/yy}");
                    viewItem.SubItems.Add($"{x.RequiredDate:dd/MM/yy}");
                    viewItem.SubItems.Add($"{x.Freight:c2}");
                    viewItem.SubItems.Add($"{x.Total * Convert.ToDecimal(1 - x.Discount):c2}");
                    lvSiparisler.Items.Add(viewItem);
                    this.siparisler.Add(x);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvSiparisler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSiparisler.SelectedItems == null || lvSiparisler.SelectedItems.Count == 0) return;

            try
            {
                var id = int.Parse(lvSiparisler.SelectedItems[0].Text);
                NorthwindEntities db = new NorthwindEntities();
                var sonuc = db.Order_Details.Where(x => x.OrderID == id).ToList();
                lvDetay.Items.Clear();
                sonuc.ForEach(x =>
                {
                    ListViewItem viewItem = new ListViewItem(x.Product.ProductName);
                    viewItem.SubItems.Add($"{x.UnitPrice:c2}");
                    viewItem.SubItems.Add($"{x.Quantity}");
                    viewItem.SubItems.Add($"% {x.Discount * 100}");
                    lvDetay.Items.Add(viewItem);
                });
                lvDetay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                txtCalisan.Text = sonuc.FirstOrDefault().Order.Employee.FirstName + " " + sonuc.FirstOrDefault().Order.Employee.LastName;
                txtMusteri.Text = sonuc.FirstOrDefault().Order.Customer.CompanyName;
                txtKargo.Text = sonuc.FirstOrDefault().Order.Shipper.CompanyName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (ExcelPackage pck = new ExcelPackage())
            {
                ExcelWorksheet worksheet = pck.Workbook.Worksheets.Add("Sipariş Raporu");
                worksheet.PrinterSettings.Orientation = eOrientation.Portrait;
                worksheet.PrinterSettings.PaperSize = ePaperSize.A4;
                worksheet.PrinterSettings.FitToPage = true;

                worksheet.Cells[1, 1].Value = "Sipariş No";
                worksheet.Cells[1, 2].Value = "Sipariş Tarihi";
                worksheet.Cells[1, 3].Value = "İstenen Tarih";
                worksheet.Cells[1, 4].Value = "Kargo";
                worksheet.Cells[1, 5].Value = "Toplam Sipariş Tutarı";

                using (var range = worksheet.Cells[1, 1, 1, 5])
                {
                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(Color.Tomato);
                    range.Style.Font.Color.SetColor(Color.RoyalBlue);
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    range.Style.Font.Size = 16;
                }
                for (int i = 0; i < this.siparisler.Count; i++)
                {
                    var siparis = this.siparisler[i];
                    worksheet.Cells[i + 2, 1].Value = siparis.OrderID;
                    worksheet.Cells[i + 2, 2].Value = $"{siparis.OrderDate:dd/MM/yyyy}";
                    worksheet.Cells[i + 2, 3].Value = $"{siparis.RequiredDate:dd/MM/yyyy}";
                    worksheet.Cells[i + 2, 4].Value = $"{siparis.Freight}";
                    worksheet.Cells[i + 2, 5].Value = $"{siparis.Total * Convert.ToDecimal(1 - siparis.Discount)}";
                }

                using (var memoryStream = new MemoryStream())
                {
                    pck.SaveAs(memoryStream);
                    SaveFileDialog dosyaKaydet = new SaveFileDialog();
                    dosyaKaydet.FileName = "SiparişRaporu";
                    dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    dosyaKaydet.Filter = "Excel File | *.xlsx";
                    DialogResult cevap = dosyaKaydet.ShowDialog();
                    if (cevap == DialogResult.OK)
                    {
                        byte[] buffer = new byte[64];
                        using (FileStream stream = File.Create(dosyaKaydet.FileName))
                        {
                            memoryStream.Seek(0, SeekOrigin.Begin);
                            while (memoryStream.Read(buffer, 0, buffer.Length) != 0)
                            {
                                stream.Write(buffer, 0, buffer.Length);
                            }
                        }
                        memoryStream.Close();
                    }
                }
            }
        }
    }
}
