using InvoicesAPI.Models;

namespace InvoicesAPI.Interfaces
{
    public interface IInvoiceService
    {
        Task<List<Invoice>> GetInvoices(int amount, string company, bool isPaid);
    }
}
