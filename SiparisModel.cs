using System;

namespace A6SiparisYonetimi
{
    public class SiparisModel
    {
        public int OrderID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public decimal? Freight { get; set; }
        public decimal Total { get; set; }
        public float Discount { get; set; }
        public string Employee { get; set; }
        public string Customer { get; set; }
        public string Shipper { get; set; }
    }
}
