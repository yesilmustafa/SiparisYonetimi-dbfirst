namespace A6SiparisYonetimi
{
    public class MusteriModel
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public override string ToString()
        {
            return CompanyName;
        }
    }
}
