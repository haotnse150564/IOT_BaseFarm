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
    public class WorkSheetRepository : GenericRepository<WorkSheet>, IWorkSheetRepositories
    {
        public WorkSheetRepository(AppDbContext context, ICurrentTime timeService, IClaimsServices claimsService) : base(context, timeService, claimsService)
        {
        }

        public async Task<List<WorkSheet>> GetWorkSheetByDate(DateTime date)
        {
            var workSheets = _dbSet.Where(x => x.Date == date).Include(x => x.UserWorkSheet).ThenInclude(o => o.Users).ToList();

            return workSheets;
        }
    }
}
