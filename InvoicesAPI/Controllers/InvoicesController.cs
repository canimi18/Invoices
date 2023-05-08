
using InvoicesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Web.Http;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace InvoicesAPI.Controllers   
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoicesController : ControllerBase
    {
        private readonly DataContext _context;

        public InvoicesController(DataContext context)
        {
            _context = context;
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Invoice>>> GetInvoicses()
        {
            return Ok(await _context.Invoices.ToListAsync());
        }
        
        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Route("filter")]
        public async Task<ActionResult<List<Invoice>>> GetInvoicesByFilter([FromUri] string company = "", [FromUri] string amount = "", [FromUri] string  isPaid = "")
        {

            var result = _context.Invoices.ToList();

            if (!string.IsNullOrEmpty(company) && company != "undefined")
            {
                result = result.Where(item => item.Company == company).ToList();
            }

            if (!string.IsNullOrEmpty(amount) && amount != "undefined")
            {
                result = result.Where(result => result.Amount > int.Parse(amount)).ToList();
            }

            if (!string.IsNullOrEmpty(isPaid) && isPaid != "undefined")
            {
                result = result.Where(result => result.isPaid == bool.Parse(isPaid)).ToList();
            }

            return Ok(result);

        }
    }
}