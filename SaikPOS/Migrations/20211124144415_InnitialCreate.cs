using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaikPOS.Migrations
{
    public partial class InnitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountGroup",
                columns: table => new
                {
                    AccountGroupId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupUnder = table.Column<long>(type: "bigint", nullable: false),
                    GroupCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    Nature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AffectGrossProfit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountGroup", x => x.AccountGroupId);
                });

            migrationBuilder.CreateTable(
                name: "AccountLedger",
                columns: table => new
                {
                    LedgerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountGroupId = table.Column<long>(type: "bigint", nullable: false),
                    LedgerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LedgerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    OpeningBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    CrOrDr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditPeriod = table.Column<int>(type: "int", nullable: false),
                    CreditLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PricinglevelId = table.Column<long>(type: "bigint", nullable: false),
                    BillByBill = table.Column<bool>(type: "bit", nullable: false),
                    Tin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RouteId = table.Column<long>(type: "bigint", nullable: false),
                    BankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaId = table.Column<long>(type: "bigint", nullable: false),
                    LogoC = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    LogoPathC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkypeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mnucapality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Referfrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Map = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AnniversaryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountLedger", x => x.LedgerId);
                });

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    AreaId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.AreaId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankReconciliation",
                columns: table => new
                {
                    ReconcileId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LedgerPostingId = table.Column<long>(type: "bigint", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    StatementDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankReconciliation", x => x.ReconcileId);
                });

            migrationBuilder.CreateTable(
                name: "Batch",
                columns: table => new
                {
                    BatchId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BatchNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ManufacturingNepali = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiryNepali = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Mrp = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batch", x => x.BatchId);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Web = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoPath = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FinancialYearId = table.Column<long>(type: "bigint", nullable: false),
                    FromNepali = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToNepali = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FiscalYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyId = table.Column<long>(type: "bigint", nullable: false),
                    NoofDecimal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Counter",
                columns: table => new
                {
                    CounterId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CounterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counter", x => x.CounterId);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    CurrencyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencySymbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrencyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    noOfDecimalPlaces = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.CurrencyId);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeRate",
                columns: table => new
                {
                    ExchangeRateId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRate", x => x.ExchangeRateId);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseMaster",
                columns: table => new
                {
                    ExpensiveMasterId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LedgerId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NepaliDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherTypeId = table.Column<long>(type: "bigint", nullable: false),
                    SerialNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuffixPrefixId = table.Column<long>(type: "bigint", nullable: false),
                    FinancialYearId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    Photos = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CashId = table.Column<long>(type: "bigint", nullable: false),
                    BankId = table.Column<long>(type: "bigint", nullable: false),
                    CashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreditAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<long>(type: "bigint", nullable: true),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseMaster", x => x.ExpensiveMasterId);
                });

            migrationBuilder.CreateTable(
                name: "FinancialYear",
                columns: table => new
                {
                    FinancialYearId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    NepaliFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NepaliTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FiscalYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    addedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialYear", x => x.FinancialYearId);
                });

            migrationBuilder.CreateTable(
                name: "IncomeMaster",
                columns: table => new
                {
                    IncomeMasterId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LedgerId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NepaliDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherTypeId = table.Column<long>(type: "bigint", nullable: false),
                    SerialNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuffixPrefixId = table.Column<long>(type: "bigint", nullable: false),
                    FinancialYearId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CashId = table.Column<long>(type: "bigint", nullable: false),
                    BankId = table.Column<long>(type: "bigint", nullable: false),
                    CashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreditAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<long>(type: "bigint", nullable: true),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeMaster", x => x.IncomeMasterId);
                });

            migrationBuilder.CreateTable(
                name: "InventorySetting",
                columns: table => new
                {
                    InventoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MultiCurrency = table.Column<bool>(type: "bit", nullable: false),
                    BillbyBill = table.Column<bool>(type: "bit", nullable: false),
                    Allowzero = table.Column<bool>(type: "bit", nullable: false),
                    ShowCurrency = table.Column<bool>(type: "bit", nullable: false),
                    TickafterPrint = table.Column<bool>(type: "bit", nullable: false),
                    AutomaticproductCode = table.Column<bool>(type: "bit", nullable: false),
                    Barcode = table.Column<bool>(type: "bit", nullable: false),
                    AllowBatch = table.Column<bool>(type: "bit", nullable: false),
                    ShowDisPer = table.Column<bool>(type: "bit", nullable: false),
                    ShowDisAmount = table.Column<bool>(type: "bit", nullable: false),
                    NegativecashTransaction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockvaluecalculationMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NegativestockStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowNetAmount = table.Column<bool>(type: "bit", nullable: false),
                    ShowTax = table.Column<bool>(type: "bit", nullable: false),
                    ShowTaxAmount = table.Column<bool>(type: "bit", nullable: false),
                    DeactiveDate = table.Column<bool>(type: "bit", nullable: false),
                    DateLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Prefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Suffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WidthOfNumericalPart = table.Column<int>(type: "int", nullable: false),
                    StartIndex = table.Column<long>(type: "bigint", nullable: false),
                    VoucherNoAutomatic = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventorySetting", x => x.InventoryId);
                });

            migrationBuilder.CreateTable(
                name: "JournalMaster",
                columns: table => new
                {
                    JournalMasterId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuffixPrefixId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NepaliDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherTypeId = table.Column<long>(type: "bigint", nullable: false),
                    FinancialYearId = table.Column<long>(type: "bigint", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Prepairedby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Checkedby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Checkedbypost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Swikritiby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SwikritibyPost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receivedby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RasidNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiptNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PraptaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rakam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreparedBypost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovedPost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceivePost = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalMaster", x => x.JournalMasterId);
                });

            migrationBuilder.CreateTable(
                name: "LedgerPosting",
                columns: table => new
                {
                    LedgerPostingId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NepaliDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherTypeId = table.Column<long>(type: "bigint", nullable: false),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LedgerId = table.Column<long>(type: "bigint", nullable: false),
                    Debit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Credit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetailsId = table.Column<long>(type: "bigint", nullable: false),
                    YearId = table.Column<long>(type: "bigint", nullable: false),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChequeNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChequeDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    ReferenceN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LedgerPosting", x => x.LedgerPostingId);
                });

            migrationBuilder.CreateTable(
                name: "MailConfigurations",
                columns: table => new
                {
                    MailInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Protocal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Smpthost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Smptport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenderMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sales = table.Column<bool>(type: "bit", nullable: false),
                    Purchase = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailConfigurations", x => x.MailInfoId);
                });

            migrationBuilder.CreateTable(
                name: "PartyBalance",
                columns: table => new
                {
                    PartyBalanceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NepaliDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LedgerId = table.Column<long>(type: "bigint", nullable: false),
                    VoucherTypeId = table.Column<long>(type: "bigint", nullable: false),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgainstVoucherTypeId = table.Column<long>(type: "bigint", nullable: false),
                    AgainstVoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgainstInvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Credit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreditAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetailsId = table.Column<long>(type: "bigint", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditPeriod = table.Column<int>(type: "int", nullable: false),
                    ExchangeRateId = table.Column<long>(type: "bigint", nullable: false),
                    FinancialYearId = table.Column<long>(type: "bigint", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CashId = table.Column<long>(type: "bigint", nullable: false),
                    BankId = table.Column<long>(type: "bigint", nullable: false),
                    Optional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amountused = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyBalance", x => x.PartyBalanceId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMaster",
                columns: table => new
                {
                    PaymentMasterId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuffixPrefixId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NepaliDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LedgerId = table.Column<long>(type: "bigint", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SerialNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CashId = table.Column<long>(type: "bigint", nullable: false),
                    BankId = table.Column<long>(type: "bigint", nullable: false),
                    Optional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetailsId = table.Column<long>(type: "bigint", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherTypeId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinancialYearId = table.Column<long>(type: "bigint", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<long>(type: "bigint", nullable: true),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMaster", x => x.PaymentMasterId);
                });

            migrationBuilder.CreateTable(
                name: "PriceList",
                columns: table => new
                {
                    PricelistId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    PricinglevelId = table.Column<long>(type: "bigint", nullable: false),
                    UnitId = table.Column<long>(type: "bigint", nullable: false),
                    BatchId = table.Column<long>(type: "bigint", nullable: false),
                    PurchaseRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalesRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EffectDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    FromQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ToQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceList", x => x.PricelistId);
                });

            migrationBuilder.CreateTable(
                name: "PricingLevel",
                columns: table => new
                {
                    PricinglevelId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PricinglevelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingLevel", x => x.PricinglevelId);
                });

            migrationBuilder.CreateTable(
                name: "Privilege",
                columns: table => new
                {
                    PrivilegeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormNameNepali = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddAction = table.Column<bool>(type: "bit", nullable: false),
                    EditAction = table.Column<bool>(type: "bit", nullable: false),
                    DeleteAction = table.Column<bool>(type: "bit", nullable: false),
                    ShowAction = table.Column<bool>(type: "bit", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    SettingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privilege", x => x.PrivilegeId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupId = table.Column<long>(type: "bigint", nullable: false),
                    BrandId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    UnitId = table.Column<long>(type: "bigint", nullable: false),
                    SizeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelNoId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxId = table.Column<long>(type: "bigint", nullable: false),
                    PurchaseRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalesRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Mrp = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinimumStock = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaximumStock = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReorderLevel = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GodownId = table.Column<long>(type: "bigint", nullable: false),
                    RackId = table.Column<long>(type: "bigint", nullable: false),
                    IsallowBatch = table.Column<bool>(type: "bit", nullable: false),
                    Ismultipleunit = table.Column<bool>(type: "bit", nullable: false),
                    Isopeningstock = table.Column<bool>(type: "bit", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PartNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoPath = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    AddedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    ProcategoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.ProcategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ProductGroup",
                columns: table => new
                {
                    GroupId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupUnder = table.Column<long>(type: "bigint", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroup", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseMaster",
                columns: table => new
                {
                    PurchaseMasterId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuffixPrefixId = table.Column<long>(type: "bigint", nullable: false),
                    VoucherTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NepaliDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LedgerId = table.Column<long>(type: "bigint", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuedateNepali = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditPeriod = table.Column<int>(type: "int", nullable: false),
                    ExchangeRateId = table.Column<long>(type: "bigint", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseAccount = table.Column<long>(type: "bigint", nullable: false),
                    PurchaseOrderMasterId = table.Column<long>(type: "bigint", nullable: false),
                    MaterialReceiptMasterId = table.Column<long>(type: "bigint", nullable: false),
                    AdditionalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxId = table.Column<long>(type: "bigint", nullable: false),
                    TotalTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DisPer = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BillDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CheckDis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrandTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmounts = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LrNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransportationCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinancialYearId = table.Column<long>(type: "bigint", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    CreditAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BalanceDue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousDue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashId = table.Column<long>(type: "bigint", nullable: false),
                    BankId = table.Column<long>(type: "bigint", nullable: false),
                    Amountused = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<long>(type: "bigint", nullable: true),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseMaster", x => x.PurchaseMasterId);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseReturnDetails",
                columns: table => new
                {
                    PurchaseReturnDetailsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseReturnMasterId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitId = table.Column<long>(type: "bigint", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxId = table.Column<long>(type: "bigint", nullable: false),
                    BatchId = table.Column<long>(type: "bigint", nullable: false),
                    GodownId = table.Column<long>(type: "bigint", nullable: false),
                    UnitConversionId = table.Column<long>(type: "bigint", nullable: false),
                    RackId = table.Column<long>(type: "bigint", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SlNo = table.Column<int>(type: "int", nullable: false),
                    PurchaseDetailsId = table.Column<long>(type: "bigint", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseReturnDetails", x => x.PurchaseReturnDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseReturnMaster",
                columns: table => new
                {
                    PurchaseReturnMasterId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuffixPrefixId = table.Column<long>(type: "bigint", nullable: false),
                    VoucherTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NepaliDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxId = table.Column<long>(type: "bigint", nullable: false),
                    PreviousDue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseMasterId = table.Column<long>(type: "bigint", nullable: false),
                    LedgerId = table.Column<long>(type: "bigint", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseAccount = table.Column<long>(type: "bigint", nullable: false),
                    TotalTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmounts = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DisPer = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BillDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CheckDis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrandTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LrNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransportationCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinancialYearId = table.Column<long>(type: "bigint", nullable: false),
                    ExchangeRateId = table.Column<long>(type: "bigint", nullable: false),
                    CashId = table.Column<long>(type: "bigint", nullable: true),
                    BankId = table.Column<long>(type: "bigint", nullable: true),
                    BalanceDue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DocImages = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AddedBy = table.Column<long>(type: "bigint", nullable: true),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseReturnMaster", x => x.PurchaseReturnMasterId);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptMaster",
                columns: table => new
                {
                    ReceiptMasterId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuffixPrefixId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LedgerId = table.Column<long>(type: "bigint", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SerialNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CashId = table.Column<long>(type: "bigint", nullable: false),
                    BankId = table.Column<long>(type: "bigint", nullable: false),
                    Optional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetailsId = table.Column<long>(type: "bigint", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherTypeId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinancialYearId = table.Column<long>(type: "bigint", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    NepaliDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptMaster", x => x.ReceiptMasterId);
                });

            migrationBuilder.CreateTable(
                name: "Reminder",
                columns: table => new
                {
                    ReminderId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemindAbout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Repeat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CallPurpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CallStarted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LedgerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminder", x => x.ReminderId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoldId);
                });

            migrationBuilder.CreateTable(
                name: "SalesDetails",
                columns: table => new
                {
                    SalesDetailsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesMasterId = table.Column<long>(type: "bigint", nullable: false),
                    DeliveryNoteDetailsId = table.Column<long>(type: "bigint", nullable: false),
                    OrderDetailsId = table.Column<long>(type: "bigint", nullable: false),
                    QuotationDetailsId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitId = table.Column<long>(type: "bigint", nullable: false),
                    UnitConversionId = table.Column<long>(type: "bigint", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxId = table.Column<long>(type: "bigint", nullable: false),
                    BatchId = table.Column<long>(type: "bigint", nullable: false),
                    GodownId = table.Column<long>(type: "bigint", nullable: false),
                    RackId = table.Column<long>(type: "bigint", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SlNo = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesDetails", x => x.SalesDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "SalesMan",
                columns: table => new
                {
                    SalesManId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesmanName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesMan", x => x.SalesManId);
                });

            migrationBuilder.CreateTable(
                name: "SalesMaster",
                columns: table => new
                {
                    SalesMasterId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherTypeId = table.Column<long>(type: "bigint", nullable: false),
                    SuffixPrefixId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NepaliDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDateNep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditPeriod = table.Column<int>(type: "int", nullable: false),
                    LedgerId = table.Column<long>(type: "bigint", nullable: false),
                    PricinglevelId = table.Column<long>(type: "bigint", nullable: false),
                    SalesManId = table.Column<long>(type: "bigint", nullable: false),
                    SalesAccount = table.Column<long>(type: "bigint", nullable: false),
                    DeliveryNoteMasterId = table.Column<long>(type: "bigint", nullable: false),
                    OrderMasterId = table.Column<long>(type: "bigint", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExchangeRateId = table.Column<long>(type: "bigint", nullable: false),
                    TotalTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdditionalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DisPer = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BillDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CheckDis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrandTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmounts = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PreviousDue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreditAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LrNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransportationCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuotationMasterId = table.Column<long>(type: "bigint", nullable: false),
                    POS = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CashId = table.Column<long>(type: "bigint", nullable: false),
                    BankId = table.Column<long>(type: "bigint", nullable: false),
                    BalanceDue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DocImages = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CounterId = table.Column<long>(type: "bigint", nullable: false),
                    FinancialYearId = table.Column<long>(type: "bigint", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    TaxRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesMaster", x => x.SalesMasterId);
                });

            migrationBuilder.CreateTable(
                name: "SalesReturnMaster",
                columns: table => new
                {
                    SalesReturnMasterId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherTypeId = table.Column<long>(type: "bigint", nullable: false),
                    SuffixPrefixId = table.Column<long>(type: "bigint", nullable: false),
                    SalesMasterId = table.Column<long>(type: "bigint", nullable: false),
                    LedgerId = table.Column<long>(type: "bigint", nullable: false),
                    SalesAccount = table.Column<long>(type: "bigint", nullable: false),
                    PricinglevelId = table.Column<long>(type: "bigint", nullable: false),
                    SalesManId = table.Column<long>(type: "bigint", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExchangeRateId = table.Column<long>(type: "bigint", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LrNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransportationCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NepaliDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreditAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PreviousDue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DisPer = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BillDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CheckDis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxId = table.Column<long>(type: "bigint", nullable: false),
                    NetAmounts = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrandTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FinancialYearId = table.Column<long>(type: "bigint", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    CashId = table.Column<long>(type: "bigint", nullable: false),
                    BankId = table.Column<long>(type: "bigint", nullable: false),
                    DocImages = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    BalanceDue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AddedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReturnMaster", x => x.SalesReturnMasterId);
                });

            migrationBuilder.CreateTable(
                name: "StandardRate",
                columns: table => new
                {
                    StandardRateId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicableFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FromNepali = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicableTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToNepali = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    UnitId = table.Column<long>(type: "bigint", nullable: false),
                    BatchId = table.Column<long>(type: "bigint", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandardRate", x => x.StandardRateId);
                });

            migrationBuilder.CreateTable(
                name: "StockPosting",
                columns: table => new
                {
                    StockPostingId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NepaliDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherTypeId = table.Column<long>(type: "bigint", nullable: false),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    BatchId = table.Column<long>(type: "bigint", nullable: false),
                    UnitId = table.Column<long>(type: "bigint", nullable: false),
                    GodownId = table.Column<long>(type: "bigint", nullable: false),
                    RackId = table.Column<long>(type: "bigint", nullable: false),
                    AgainstVoucherTypeId = table.Column<long>(type: "bigint", nullable: false),
                    AgainstInvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgainstVoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InwardQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OutwardQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FinancialYearId = table.Column<long>(type: "bigint", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    DetailsId = table.Column<long>(type: "bigint", nullable: false),
                    LedgerId = table.Column<long>(type: "bigint", nullable: false),
                    StockCalculate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockPosting", x => x.StockPostingId);
                });

            migrationBuilder.CreateTable(
                name: "SuffixPrefix",
                columns: table => new
                {
                    SuffixprefixId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherTypeId = table.Column<long>(type: "bigint", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartIndex = table.Column<long>(type: "bigint", nullable: false),
                    Prefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Suffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WidthOfNumericalPart = table.Column<int>(type: "int", nullable: false),
                    PrefillWithZero = table.Column<bool>(type: "bit", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuffixPrefix", x => x.SuffixprefixId);
                });

            migrationBuilder.CreateTable(
                name: "Tax",
                columns: table => new
                {
                    TaxId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicableOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CalculatingMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tax", x => x.TaxId);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    UnitId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoOfDecimalplaces = table.Column<int>(type: "int", nullable: false),
                    FormalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.UnitId);
                });

            migrationBuilder.CreateTable(
                name: "UnitConvertion",
                columns: table => new
                {
                    UnitconversionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    UnitId = table.Column<long>(type: "bigint", nullable: false),
                    ConversionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantities = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitConvertion", x => x.UnitconversionId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoldId = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "VoucherType",
                columns: table => new
                {
                    VoucherTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfVoucher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MethodOfVoucherNumbering = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsTaxApplicable = table.Column<bool>(type: "bit", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    MasterId = table.Column<long>(type: "bigint", nullable: false),
                    Declaration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Heading1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Heading2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Heading3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Heading4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoucherType", x => x.VoucherTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseDetails",
                columns: table => new
                {
                    ExpensiveDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpensiveMasterId = table.Column<long>(type: "bigint", nullable: false),
                    LedgerId = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxId = table.Column<long>(type: "bigint", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpenseMasterExpensiveMasterId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseDetails", x => x.ExpensiveDetailsId);
                    table.ForeignKey(
                        name: "FK_ExpenseDetails_ExpenseMaster_ExpenseMasterExpensiveMasterId",
                        column: x => x.ExpenseMasterExpensiveMasterId,
                        principalTable: "ExpenseMaster",
                        principalColumn: "ExpensiveMasterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IncomeDetails",
                columns: table => new
                {
                    IncomeDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncomeMasterId = table.Column<long>(type: "bigint", nullable: false),
                    LedgerId = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxId = table.Column<long>(type: "bigint", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeDetails", x => x.IncomeDetailsId);
                    table.ForeignKey(
                        name: "FK_IncomeDetails_IncomeMaster_IncomeMasterId",
                        column: x => x.IncomeMasterId,
                        principalTable: "IncomeMaster",
                        principalColumn: "IncomeMasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JournalDetails",
                columns: table => new
                {
                    JournalDetailsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JournalMasterId = table.Column<long>(type: "bigint", nullable: false),
                    LedgerId = table.Column<long>(type: "bigint", nullable: false),
                    Credit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Debit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExchangeRateId = table.Column<long>(type: "bigint", nullable: false),
                    ChequeNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChequeDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalDetails", x => x.JournalDetailsId);
                    table.ForeignKey(
                        name: "FK_JournalDetails_JournalMaster_JournalMasterId",
                        column: x => x.JournalMasterId,
                        principalTable: "JournalMaster",
                        principalColumn: "JournalMasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseDetails",
                columns: table => new
                {
                    PurchaseDetailsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseMasterId = table.Column<long>(type: "bigint", nullable: false),
                    ReceiptDetailsId = table.Column<long>(type: "bigint", nullable: false),
                    OrderDetailsId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitId = table.Column<long>(type: "bigint", nullable: false),
                    UnitConversionId = table.Column<long>(type: "bigint", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxId = table.Column<long>(type: "bigint", nullable: false),
                    BatchId = table.Column<long>(type: "bigint", nullable: false),
                    GodownId = table.Column<long>(type: "bigint", nullable: false),
                    RackId = table.Column<long>(type: "bigint", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SlNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseDetails", x => x.PurchaseDetailsId);
                    table.ForeignKey(
                        name: "FK_PurchaseDetails_PurchaseMaster_PurchaseMasterId",
                        column: x => x.PurchaseMasterId,
                        principalTable: "PurchaseMaster",
                        principalColumn: "PurchaseMasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseDetails_ExpenseMasterExpensiveMasterId",
                table: "ExpenseDetails",
                column: "ExpenseMasterExpensiveMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeDetails_IncomeMasterId",
                table: "IncomeDetails",
                column: "IncomeMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalDetails_JournalMasterId",
                table: "JournalDetails",
                column: "JournalMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetails_PurchaseMasterId",
                table: "PurchaseDetails",
                column: "PurchaseMasterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountGroup");

            migrationBuilder.DropTable(
                name: "AccountLedger");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BankReconciliation");

            migrationBuilder.DropTable(
                name: "Batch");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Counter");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "ExchangeRate");

            migrationBuilder.DropTable(
                name: "ExpenseDetails");

            migrationBuilder.DropTable(
                name: "FinancialYear");

            migrationBuilder.DropTable(
                name: "IncomeDetails");

            migrationBuilder.DropTable(
                name: "InventorySetting");

            migrationBuilder.DropTable(
                name: "JournalDetails");

            migrationBuilder.DropTable(
                name: "LedgerPosting");

            migrationBuilder.DropTable(
                name: "MailConfigurations");

            migrationBuilder.DropTable(
                name: "PartyBalance");

            migrationBuilder.DropTable(
                name: "PaymentMaster");

            migrationBuilder.DropTable(
                name: "PriceList");

            migrationBuilder.DropTable(
                name: "PricingLevel");

            migrationBuilder.DropTable(
                name: "Privilege");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "ProductGroup");

            migrationBuilder.DropTable(
                name: "PurchaseDetails");

            migrationBuilder.DropTable(
                name: "PurchaseReturnDetails");

            migrationBuilder.DropTable(
                name: "PurchaseReturnMaster");

            migrationBuilder.DropTable(
                name: "ReceiptMaster");

            migrationBuilder.DropTable(
                name: "Reminder");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "SalesDetails");

            migrationBuilder.DropTable(
                name: "SalesMan");

            migrationBuilder.DropTable(
                name: "SalesMaster");

            migrationBuilder.DropTable(
                name: "SalesReturnMaster");

            migrationBuilder.DropTable(
                name: "StandardRate");

            migrationBuilder.DropTable(
                name: "StockPosting");

            migrationBuilder.DropTable(
                name: "SuffixPrefix");

            migrationBuilder.DropTable(
                name: "Tax");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "UnitConvertion");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "VoucherType");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ExpenseMaster");

            migrationBuilder.DropTable(
                name: "IncomeMaster");

            migrationBuilder.DropTable(
                name: "JournalMaster");

            migrationBuilder.DropTable(
                name: "PurchaseMaster");
        }
    }
}
