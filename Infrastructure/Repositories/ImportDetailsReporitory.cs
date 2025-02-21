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
    public class ImportDetailsReporitory : GenericRepository<ImportDetails>, IImportDetailsRepositories
    {
        public ImportDetailsReporitory(AppDbContext context, ICurrentTime timeService, IClaimsServices claimsService) : base(context, timeService, claimsService)
        {
        }
    }
}
