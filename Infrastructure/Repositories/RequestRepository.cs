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
    public class RequestRepository : GenericRepository<Request>, IRequestRepositories
    {
        public RequestRepository(AppDbContext context, ICurrentTime timeService, IClaimsServices claimsService) : base(context, timeService, claimsService)
        {
        }

        public List<Request> GetListRequestByUserId(int userId)
        {
            return _dbSet.Where(x => x.UserId == userId).ToList();
        }
    }
}
