using Blazored.LocalStorage;
using SaikPOS.Data;
using SaikPOS.Services.CartService;
using SaikPOS.Services.Interface;
using SaikPOS.Services.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MudBlazor;
using MudBlazor.Services;

namespace SaikPOS
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddMudServices();
            services.AddBlazoredLocalStorage();
            services.AddMudBlazorSnackbar(config =>
            {
                config.PositionClass = Defaults.Classes.Position.BottomLeft;

                config.PreventDuplicates = false;
                config.NewestOnTop = false;
                config.ShowCloseIcon = true;
                config.VisibleStateDuration = 10000;
                config.HideTransitionDuration = 500;
                config.ShowTransitionDuration = 500;
                config.SnackbarVariant = Variant.Filled;
            });
            services.AddSingleton<WeatherForecastService>();
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders().AddDefaultUI();
            services.Configure<IdentityOptions>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 8;

                //opts.SignIn.RequireConfirmedEmail = true;
            });

            // Add services to the container.
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddScoped<IBranch, BranchRepository>();
            services.AddSingleton<WeatherForecastService>();
            services.AddScoped<IUnit, UnitRepository>();
            services.AddScoped<IArea, AreaRepository>();
            services.AddScoped<ITax, TaxRepository>();
            services.AddScoped<ICounter, CounterRepository>();
            services.AddScoped<ISalesMan, SalesRepository>();
            services.AddScoped<ICurrency, CurrencyRepository>();
            services.AddScoped<ICategory, CategoryRepository>();
            services.AddScoped<ICompany, CompanyRepository>();
            services.AddScoped<ICountry, CountryRepository>();
            services.AddScoped<IAccountGroup, AccountGroupRepository>();
            services.AddScoped<IAccountLedger, AccountLedgerRepository>();
            services.AddScoped<IBatch, BatchRepository>();
            services.AddScoped<IProduct, ProductRepository>();
            services.AddScoped<IProductGroup, ProductGroupRepository>();
            services.AddScoped<IPurchaseInvoice, PurchaseInvoiceRepository>();
            services.AddScoped<IInventorySetting, InventorySettingRepository>();
            services.AddScoped<IPaymentSupplier, PaymentSupplierRepository>();
            services.AddScoped<ISalesInvoice, SalesInvoiceRepository>();
            services.AddScoped<IStockPosting, StockPostingRepository>();
            services.AddScoped<IReceiveCustomer, ReceiveCustomerRepository>();
            services.AddScoped<IInventoryReport, InventoryReportRepository>();
            services.AddScoped<IVoucherType, VoucherTypeRepository>();
            services.AddScoped<IJournalVoucher, JournalVoucherRepository>();
            services.AddScoped<IMailConfiguration, MailConfigurationRepository>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IFinancialYear, FinancialYearRepository>();
            services.AddScoped<IRole, RoleRepository>();
            services.AddScoped<IUser, UserRepository>();
            services.AddScoped<IPurchaseReturn, PurchaseReturnRepository>();
            services.AddScoped<ISalesReturn, SalesReturnRepository>();
            services.AddScoped<IncomeVoucherRepository>();
            services.AddScoped<ExpensesVoucherRepository>();
            services.AddScoped<DataAccess>();
            services.AddScoped<DatabaseConnection>();
            services.AddHttpContextAccessor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
