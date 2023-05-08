namespace InvoicesAPI.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Company { get; set; } = string.Empty;
        public string CompanyAdress { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
        public int Amount { get; set; }
        public bool isPaid { get; set; }
    }
}
