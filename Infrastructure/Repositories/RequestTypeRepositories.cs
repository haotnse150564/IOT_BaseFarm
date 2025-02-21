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
    public class RequestTypeRepositories : GenericRepository<RequestType>, IRequestTypeRepositories
    {
        public RequestTypeRepositories(AppDbContext context, ICurrentTime timeService, IClaimsServices claimsService) : base(context, timeService, claimsService)
        {
        }
    }
}
