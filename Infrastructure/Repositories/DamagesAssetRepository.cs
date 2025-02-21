using Application.Interfaces;
using Application.Repositories;
using Azure.Storage.Blobs.Models;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class DamagesAssetRepository : GenericRepository<DamagesAsset>, IDamagesAssetRepositories
    {
        private readonly AppDbContext _context;
    public DamagesAssetRepository(AppDbContext context, ICurrentTime timeService, IClaimsServices claimsService) : base(context, timeService, claimsService)
        {
            _context = context;
        }
        public override async Task<List<DamagesAsset>> GetAllAsync()
        {
            return await _dbSet.Include(x => x.Users).ToListAsync();
        }
    }
}
