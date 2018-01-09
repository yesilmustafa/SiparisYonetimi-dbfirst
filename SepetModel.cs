using System;

namespace A6SiparisYonetimi
{
    public class SepetModel
    {
        public int ProductID { get; set; }
        public string ProdutcName { get; set; }
        public short Quantity { get; set; } = 1;
        public decimal UnitPrice { get; set; } = 0;
        public float Discount { get; set; } = 0;
        public decimal Total
        {
            get
            {
                return Quantity * UnitPrice * Convert.ToDecimal(1 - Discount);
            }
        }
        public override string ToString()
        {
            return $"{this.ProdutcName} {Quantity}x{UnitPrice:c2} = {Quantity * UnitPrice * Convert.ToDecimal(1 - Discount):c2}";
        }
    }
}
