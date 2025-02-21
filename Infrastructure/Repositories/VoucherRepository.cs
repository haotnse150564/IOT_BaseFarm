using Application.Repositories;
using Domain.Models;
using Application.Interfaces;


namespace Infrastructure.Repositories
{
    public class VoucherRepository : GenericRepository<Voucher>, IVoucherRepositories
    {
        public VoucherRepository(AppDbContext context, ICurrentTime timeService, IClaimsServices claimsService) : base(context, timeService, claimsService)
        {
        }
    }
}
