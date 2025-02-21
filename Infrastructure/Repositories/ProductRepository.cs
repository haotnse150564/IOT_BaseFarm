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
    public class ProductRepository : GenericRepository<Product>, IProductRepositories
    {
        public ProductRepository(AppDbContext context, ICurrentTime timeService, IClaimsServices claimsService) : base(context, timeService, claimsService)
        {
        }

        public async Task<List<Product>> SortByName()
        {
            var list =await _dbSet.OrderBy(o => o.Name).ToListAsync();
            return list;
        }

        public async Task<List<Product>> SortByPrice()
        {
            var list = await _dbSet.OrderBy(o => o.Price).ToListAsync();
            return list;
        }
    }
}
