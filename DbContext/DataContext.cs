using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoicesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Invoice> Invoices => Set<Invoice>();
    }
}
