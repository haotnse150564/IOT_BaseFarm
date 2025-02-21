using Application.Interfaces;
using Application.Repositories;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class InventoryRepository : GenericRepository<Inventory>, IInventoryRepositories
    {
        public InventoryRepository(AppDbContext context, ICurrentTime timeService, IClaimsServices claimsService) : base(context, timeService, claimsService)
        {
        }
        public override Task<List<Inventory>> GetAllAsync()
        {
            return _dbSet.Include(x => x.InventoryCategories).ToListAsync();
        }

        public override async Task<Inventory?> GetByIdAsync(int id)
        {
            return await _dbSet.Include(x => x.InventoryCategories).FirstAsync(x => x.Id == id);
        }
    }
}
