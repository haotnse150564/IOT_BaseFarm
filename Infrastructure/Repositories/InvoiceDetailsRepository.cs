using Application.Interfaces;
using Application.Repositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class InvoiceDetailsRepository : GenericRepository<InvoiceDetails>, IInvoiceDetailsRepositories
    {
        private readonly AppDbContext _context;
        public InvoiceDetailsRepository(AppDbContext context, ICurrentTime timeService, IClaimsServices claimsService) : base(context, timeService, claimsService)
        {
            _context = context;
        }

        public List<InvoiceDetails> GetInvoiceDetails(int id)
        {
            return _dbSet.Where(x => x.InvoiceId == id).ToList();
        }

        public bool DeleteInvoiceDetail(int id)
        {
            var x = GetInvoiceDetails(id);
            _dbSet.RemoveRange(x);
            return true;
        }
    }
}
