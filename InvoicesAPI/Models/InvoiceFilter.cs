using Microsoft.AspNetCore.Mvc;

namespace InvoicesAPI.Models
{
    [BindProperties]
    public class InvoiceFilter
    {
        public string? Company { get; set; }
        public string? Amount { get; set; }
        public string? IsPaid { get; set; }
    }
}
