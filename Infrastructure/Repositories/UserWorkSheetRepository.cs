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
    public class UserWorkSheetRepository : GenericRepository<UserWorkSheet>, IUserWorkSheetRepositories
    {
        public UserWorkSheetRepository(AppDbContext context, ICurrentTime timeService, IClaimsServices claimsService) : base(context, timeService, claimsService)
        {


        }

        public UserWorkSheet GetUserWorkSheetByUserAndWS(int userId, int wsid)
        {
            return _dbSet.FirstOrDefault(x => x.UserId == userId && x.WorkSheetId == wsid);
        }

        public Task<List<UserWorkSheet>> GetUserworkSheetByWSId(int worksheetId)
        {

            return _dbSet.Where(uw => uw.WorkSheetId == worksheetId).ToListAsync();

        }
    }
}
