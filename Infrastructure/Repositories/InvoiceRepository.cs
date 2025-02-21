using Application.Interfaces;
using Application.Repositories;
using Application.ViewModels.InvoiceViewModels;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class InvoiceRepository : GenericRepository<Invoice>, IInvoiceRepositories
    {
        public InvoiceRepository(AppDbContext context, ICurrentTime timeService, IClaimsServices claimsService) : base(context, timeService, claimsService)
        {
        }

        public override async Task<List<Invoice>> GetAllAsync()
        {
            return await _dbSet.Include(x => x.InvoiceDetails)
                .ThenInclude(x => x.Product)
                .Include(x=>x.Users)
                .ToListAsync();
        }
        public override async Task<Invoice> GetByIdAsync(int id)
        {
            return _dbSet.Include(x => x.InvoiceDetails)
                .ThenInclude(x => x.Product)
                .Include(x=>x.Users)
                .FirstOrDefault(x => x.Id == id); 
        }
    }
}
