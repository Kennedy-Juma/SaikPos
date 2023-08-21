using SaikPOS.Data.Setting;
using SaikPOS.Data.Transaction;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SaikPOS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<AccountGroup> AccountGroup { get; set; }
        public DbSet<ProductGroup> ProductGroup { get; set; }
        public DbSet<AccountLedger> AccountLedger { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<BankReconciliation> BankReconciliation { get; set; }
        public DbSet<Batch> Batch { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Counter> Counter { get; set; }
        public DbSet<ExchangeRate> ExchangeRate { get; set; }
        public DbSet<ExpenseDetails> ExpenseDetails { get; set; }
        public DbSet<ExpenseMaster> ExpenseMaster { get; set; }
        public DbSet<FinancialYear> FinancialYear { get; set; }
        public DbSet<IncomeDetails> IncomeDetails { get; set; }
        public DbSet<IncomeMaster> IncomeMaster { get; set; }
        public DbSet<JournalDetails> JournalDetails { get; set; }
        public DbSet<JournalMaster> JournalMaster { get; set; }
        public DbSet<LedgerPosting> LedgerPosting { get; set; }
        public DbSet<PartyBalance> PartyBalance { get; set; }
        public DbSet<PaymentMaster> PaymentMaster { get; set; }
        public DbSet<PriceList> PriceList { get; set; }
        public DbSet<PricingLevel> PricingLevel { get; set; }
        public DbSet<Privilege> Privilege { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<PurchaseDetails> PurchaseDetails { get; set; }
        public DbSet<PurchaseMaster> PurchaseMaster { get; set; }
        public DbSet<PurchaseReturnDetails> PurchaseReturnDetails { get; set; }
        public DbSet<PurchaseReturnMaster> PurchaseReturnMaster { get; set; }
        public DbSet<ReceiptMaster> ReceiptMaster { get; set; }
        public DbSet<Reminder> Reminder { get; set; }
        public DbSet<SalesDetails> SalesDetails { get; set; }
        public DbSet<SalesMaster> SalesMaster { get; set; }
        public DbSet<SalesMan> SalesMan { get; set; }
        public DbSet<SalesReturnMaster> SalesReturnMaster { get; set; }
        public DbSet<Tax> Tax { get; set; }
        public DbSet<StandardRate> StandardRate { get; set; }
        public DbSet<SuffixPrefix> SuffixPrefix { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<UnitConvertion> UnitConvertion { get; set; }
        public DbSet<VoucherType> VoucherType { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<StockPosting> StockPosting { get; set; }
        public DbSet<InventorySetting> InventorySetting { get; set; }
        public DbSet<MailConfigurations> MailConfigurations { get; set; }
        public DbSet<Branch> Branch { get; set; }
    }
}
