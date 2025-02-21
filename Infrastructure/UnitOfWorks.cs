using Application;
using Application.Repositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class UnitOfWorks : IUnitOfWorks
    {
        private readonly AppDbContext _context;
        private readonly IDamagesAssetRepositories _damagesAssetRepositories;
        private readonly IImportRepositories _importRepositories;
        private readonly IImportDetailsRepositories _importDetailsRepositories;
        private readonly IInventoryRepositories _inventoryRepositories;
        private readonly IInvoiceRepositories _invoiceRepositories;
        private readonly IInvoiceDetailsRepositories _invoiceDetailsRepositories;
        private readonly IOverTimeWorkSheetRepositories _overTimeWorkSheetRepositories;
        private readonly IProductRepositories _productRepositories;
        private readonly IPunishmentRepositories _punishmentRepositories;
        private readonly IRequestRepositories _requestRepositories;
        private readonly IUserRepositories _userRepositories;
        private readonly IUserWorkSheetRepositories _userWorkSheetRepositories;
        private readonly IVoucherRepositories _voucherRepositories;
        private readonly IWorkSheetRepositories _workSheetRepositories;
        private readonly ISalaryRepository _salaryRepository;
        private readonly IProfitRepositories _profitRepositories;
        private readonly IProductCategoryServicesRepo _productCategoryServicesRepo;
        private readonly IInventoryCatagoryRepositories _inventoryCategoryRepo;
        private readonly IRequestTypeRepositories _requestTypeRepository;
     
        public UnitOfWorks(AppDbContext context, IDamagesAssetRepositories damagesAssetRepositories, IImportRepositories importRepositories, IImportDetailsRepositories importDetailsRepositories, IInventoryRepositories inventoryRepositories, IInvoiceRepositories invoiceRepositories, IInvoiceDetailsRepositories invoiceDetailsRepositories, IOverTimeWorkSheetRepositories overTimeWorkSheetRepositories, IProductRepositories productRepositories, IPunishmentRepositories punishmentRepositories, IRequestRepositories requestRepositories, IUserRepositories userRepositories, IUserWorkSheetRepositories userWorkSheetRepositories, IVoucherRepositories voucherRepositories, IWorkSheetRepositories workSheetRepositories, ISalaryRepository salaryRepository, IProfitRepositories profitRepositories, IProductCategoryServicesRepo productCategoryServicesRepo, IInventoryCatagoryRepositories inventoryCategoryRepo, IRequestTypeRepositories requestTypeRepository)
        {
            _context = context;
            _damagesAssetRepositories = damagesAssetRepositories;
            _importRepositories = importRepositories;
            _importDetailsRepositories = importDetailsRepositories;
            _inventoryRepositories = inventoryRepositories;
            _invoiceRepositories = invoiceRepositories;
            _invoiceDetailsRepositories = invoiceDetailsRepositories;
            _overTimeWorkSheetRepositories = overTimeWorkSheetRepositories;
            _productRepositories = productRepositories;
            _punishmentRepositories = punishmentRepositories;
            _requestRepositories = requestRepositories;
            _userRepositories = userRepositories;
            _userWorkSheetRepositories = userWorkSheetRepositories;
            _voucherRepositories = voucherRepositories;
            _workSheetRepositories = workSheetRepositories;
            _salaryRepository = salaryRepository;
            _profitRepositories = profitRepositories;
            _productCategoryServicesRepo = productCategoryServicesRepo;
            _inventoryCategoryRepo = inventoryCategoryRepo;
            _requestTypeRepository = requestTypeRepository;

        }

        public IImportDetailsRepositories ImportDetailsRepositories => _importDetailsRepositories;
        public IImportRepositories ImportItemsRepositories => _importRepositories;
        public IInventoryRepositories InventoryRepositories => _inventoryRepositories;
        public IInvoiceDetailsRepositories InvoiceDetailsRepositories => _invoiceDetailsRepositories;
        public IInvoiceRepositories InvoiceRepositories => _invoiceRepositories;
        public IProductRepositories ProductRepositories => _productRepositories;
        public IPunishmentRepositories PunishmentRepositories => _punishmentRepositories;
        public IRequestRepositories RequestRepositories => _requestRepositories;
        public IUserRepositories UserRepositories => _userRepositories;
        public IVoucherRepositories VoucherRepositories => _voucherRepositories;
        public IWorkSheetRepositories WorkSheetRepositories => _workSheetRepositories;
        public IDamagesAssetRepositories IDamagesAssetRepositories => _damagesAssetRepositories;

        public IUserWorkSheetRepositories UserWorkSheetRepositories => _userWorkSheetRepositories;
        public IOverTimeWorkSheetRepositories OvertimeWorkSheetRepositories => _overTimeWorkSheetRepositories;

        public IProfitRepositories ProfitRepositories => _profitRepositories;

        public ISalaryRepository SalaryRepositories => _salaryRepository;

        public IProductCategoryServicesRepo ProductCategoryServicesRepositories => _productCategoryServicesRepo;

        public IInventoryCatagoryRepositories InventoryCatagoryRepositories => _inventoryCategoryRepo;

        public IRequestTypeRepositories RequestTypeRepositories => _requestTypeRepository;

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

    }
}
