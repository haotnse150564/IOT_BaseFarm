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
    public class PunishmentRepository : GenericRepository<Punishment>, IPunishmentRepositories
    {
        public PunishmentRepository(AppDbContext context, ICurrentTime timeService, IClaimsServices claimsService) : base(context, timeService, claimsService)
        {
        }

        public List<Punishment> GetListPunishmentByUserId(int userId)
        {
            return _dbSet.Where(x => x.UserId == userId).ToList();
        }
    }
}
