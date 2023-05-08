using InvoicesAPI.Interfaces;
using InvoicesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Web.Http;

namespace InvoicesAPI.Services
{
    public class InvoiceService: IInvoiceService
    {
        private readonly DataContext _context;

        public InvoiceService(DataContext context) 
        {
            _context = context;
        }

        public async Task<List<Invoice>> GetInvoices(int amount, string company, bool isPaid)
        {
            if (!string.IsNullOrEmpty(company))
            {
                return await _context.Invoices.Where(x => x.Company == company).ToListAsync();
            }

            return await _context.Invoices.ToListAsync();

        }
    }

}
