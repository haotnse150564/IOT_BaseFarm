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
    public class ImportRepository : GenericRepository<Import>, IImportRepositories
    {
        private readonly AppDbContext _context;
        public ImportRepository(AppDbContext context, ICurrentTime timeService, IClaimsServices claimsService) : base(context, timeService, claimsService)
        {
            _context = context;
        }
        public override async Task<List<Import>> GetAllAsync()
        {
            return await _dbSet.Include(x => x.importDetails).ToListAsync();
        }
    }
}
