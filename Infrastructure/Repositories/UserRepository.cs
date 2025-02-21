using Application.Interfaces;
using Application.Repositories;
using Domain.Enums;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<Users>, IUserRepositories
    {
        public UserRepository(AppDbContext context, ICurrentTime timeService, IClaimsServices claimsService) : base(context, timeService, claimsService)
        {

        }

        public async Task<Users?> GetUserByEmailAndPassword(string email, string password)
        {
            var user = await _dbSet.FirstOrDefaultAsync(us => us.Email.Equals(email) && us.Password.Equals(password));
            return user;
        }

        public async Task<string> GetNameByEmail(string email)
        {
            var user = await _dbSet.FirstOrDefaultAsync(x => x.Email.Equals(email));
           return user.FullName;
        }

        public async Task<Users> GetUserByEmail(string email)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Email.Equals(email));
        }

        public async Task<List<Users>> GetAllActiveStaffUser()
        {
            return await _dbSet.Where(u => u.isActive == true && u.Role == (int)Role.Staff).ToListAsync();
        }
    }
}
