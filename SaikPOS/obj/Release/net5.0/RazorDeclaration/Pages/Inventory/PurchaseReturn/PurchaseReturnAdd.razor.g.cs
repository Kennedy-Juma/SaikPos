// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Dreamer.Pages.Inventory.PurchaseReturn
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Setting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Transaction;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.PdfReport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnAdd.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnAdd.razor"
using Dapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnAdd.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnAdd.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/purchase/purchasereturnadd")]
    public partial class PurchaseReturnAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 263 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnAdd.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    PurchaseReturnMaster master = new PurchaseReturnMaster();
    AccountLedger ledger = new AccountLedger();
    InventorySetting settingView = new InventorySetting();
    ProductView typeheadPro;
    bool open;
    Anchor anchor;
    List<Area> listArea = new List<Area>();
    ProductView product = new ProductView();
    List<ProductView> listProduct = new List<ProductView>();
    List<Unit> listUnit = new List<Unit>();
    List<Batch> listBatch = new List<Batch>();
    List<Tax> listTax = new List<Tax>();
    List<AccountLedgerView> subledger = new List<AccountLedgerView>();
    //TodoTask
    List<ProductView> TodoList = new List<ProductView>();
    ProductView cartItem = new ProductView();
    List<DeleteItem> deleteNo = new List<DeleteItem>();

    //Item
    Product productItem = new Product();
    ProductView productOpening = new ProductView();

    UnitConvertion convertion = new UnitConvertion();
    //GetSessionInfo
    string strSerialNoItem = string.Empty;
    List<ProductGroupView> listgroupItem = new List<ProductGroupView>();
    List<ProductView> listUnitItem = new List<ProductView>();
    List<ProductCategory> listCategoryItem = new List<ProductCategory>();
    List<Tax> listTaxItem;
    //CreateBatch
    Batch batchviewdata = new Batch();
    string strSerialNo;
    string strPrefix;
    string strSuffix;
    long decPurchaseInvoiceVoucherType = 14;

    bool showModal = false;
    bool showItem = false;
    bool showBatch = false;
    long editedID = 0;
    string strNepaliDate;
    string strDate;
    string UnitId { get; set; }
    string BatchId { get; set; }
    string TaxId { get; set; }
    string strProductName = "";
    string strProductCode = "";
    string strUnitName = "";
    string strBatch = "";
    string strTaxName = "";
    private bool readOnly;
    int counter = 1;
    protected async override void OnInitialized()
    {
        //CheckPriviliage
        settingView = settingRepository.EditInventorySetting(decPurchaseInvoiceVoucherType);
        master.CheckDis = "p";
        strPrefix = settingView.Prefix;
        strSuffix = settingView.Suffix;
        LoadData();
    }
    protected void LoadData()
    {
        if (settingView.VoucherNoAutomatic == true)
        {
            strSerialNo = settingRepository.GetVoucherNo(1, 1, decPurchaseInvoiceVoucherType);
            master.VoucherNo = strPrefix + strSerialNo + strSuffix;
        }
        else
        {
            master.VoucherNo = string.Empty;
            strSerialNo = "0";
        }
        master.Date = DateTime.Now;
        master.InvoiceNo = string.Empty;
        master.NetAmounts = 0;
        master.TotalAmount = 0;
        master.TaxRate = 0;
        master.TotalTax = 0;
        master.DisPer = 0;
        master.BillDiscount = 0;
        master.CashAmount = 0;
        master.BankAmount = 0;
        master.CreditAmount = 0;
        master.GrandTotal = 0;
        master.PreviousDue = 0;
        master.Narration = string.Empty;
        TodoList.Clear();
        subledger = ledgerRepository.ViewAllSupplier(1); //1 is companyid
        listProduct = productRepository.ViewAllProduct(1);//1 is companyid
        listUnit = unitRepository.GetAll();
        listTax = taxRepository.GetAll();
        product.TaxId = 1;
        master.TaxId = 1;
        master.CashId = 1;
        master.BankId = 13;
        master.details.Add(new PurchaseReturnDetails());
    }
    private async Task<IEnumerable<ProductView>> SearchProduct(string searchText) 
    {
        return await Task.FromResult(listProduct.Where(x => x.ProductName.ToLower().Contains(searchText.ToLower())).ToList());
    }
    void Calculate()
    {
        decimal decGrossValue = 0;
        decimal decPercentgeDiscount = 0;
        decimal decTtlDiscount = 0;
        decimal decDiscountAmount = 0;
        decimal decNetValue = 0;
        decimal decTaxAmount = 0;
        decimal decTotalTax = 0;
        decimal decGrndTotl = 0;
        if (Convert.ToDecimal(product.Qty) > 0 && Convert.ToDecimal(product.PurchaseRate) > 0)
        {
            decGrossValue = Convert.ToDecimal(product.PurchaseRate) * Convert.ToDecimal(product.Qty);

            if (product.Discount > 0)
            {
                decDiscountAmount = Math.Round(Convert.ToDecimal(decGrossValue) * Convert.ToDecimal(product.Discount) / 100, 2);
                product.DiscountAmount = decDiscountAmount;
            }
            else
            {
                decPercentgeDiscount = Convert.ToDecimal(product.DiscountAmount) * 100 / decGrossValue;
                decTtlDiscount = decPercentgeDiscount;
                product.Discount = decTtlDiscount;
            }

            decNetValue = decGrossValue - Convert.ToDecimal(product.DiscountAmount);

            //ClculteT
            decTaxAmount = decNetValue * product.TaxRate / 100;
            product.TaxAmount = Math.Round(decTaxAmount, 2);


            decGrndTotl = decNetValue + decTaxAmount;
            master.TotalTax = Math.Round(decTotalTax, 2);
            product.NetAmount = Math.Round(decNetValue, 2);
            product.TotalAmount = Math.Round(decGrndTotl, 2);
        }
        else
        {
            product.Discount = 0;
        }
    }
    void ModalAdd()
    {
        if (product.ProductId == 0)
        {
            Snackbar.Add("Please select Product.", Severity.Info);
            return;
        }
        else if (product.UnitId == 0)
        {
            Snackbar.Add("Please select Unit.", Severity.Info);
            return;
        }
        else if (product.Qty == 0)
        {
            Snackbar.Add("Please Enter Qty.", Severity.Info);
            return;
        }

        if (editedID == 0)
        {
            Calculate();
            var myTodoItem = new ProductView()
            {
                Id = TodoList.Count() + 1,
                PurchaseDetailsId = 0,
                ProductId = product.ProductId,
                Barcode = product.Barcode,
                UnitId = product.UnitId,
                Qty = product.Qty,
                PurchaseRate = product.PurchaseRate,
                BatchId = product.BatchId,
                Discount = product.Discount,
                DiscountAmount = product.DiscountAmount,
                TaxId = product.TaxId,
                TaxRate = product.TaxRate,
                TaxAmount = product.TaxAmount,
                NetAmount = product.NetAmount,
                TotalAmount = product.TotalAmount,
                ProductName = product.ProductName,
                UnitName = product.UnitName,
                TaxName = product.TaxName,
                BatchNo = "NA",
                ReceiptDetailsId = 0,
                OrderDetailsId = 0

            };
            TodoList.Add(myTodoItem);
            //CalculateTotal
            CalculateTotal();
            product.ProductId = 0;
            product.Barcode = string.Empty;
            strProductCode = string.Empty;
            strProductName = string.Empty;
            strUnitName = string.Empty;
            strBatch = string.Empty;
            strTaxName = string.Empty;
            product.UnitId = 0;
            product.BatchId = 0;
            product.TaxId = 1;
            product.Qty = 0;
            product.PurchaseRate = 0;
            product.Discount = 0;
            product.DiscountAmount = 0;
            product.TaxRate = 0;
            product.TaxAmount = 0;
            product.NetAmount = 0;
            product.TotalAmount = 0;
        }
        else
        {
            var myTodo = TodoList.FirstOrDefault(x => x.Id == editedID);
            myTodo.ProductId = product.ProductId;
            myTodo.UnitId = product.UnitId;
            myTodo.BatchId = product.BatchId;
            myTodo.TaxId = product.TaxId;
            myTodo.Qty = product.Qty;
            myTodo.PurchaseRate = product.PurchaseRate;
            myTodo.Discount = product.Discount;
            myTodo.DiscountAmount = product.DiscountAmount;
            myTodo.TaxRate = product.TaxRate;
            myTodo.TaxAmount = product.TaxAmount;
            myTodo.NetAmount = product.NetAmount;
            myTodo.TotalAmount = product.TotalAmount;
            CalculateTotal();
            product.ProductId = 0;
            product.Barcode = string.Empty;
            strProductCode = string.Empty;
            strProductName = string.Empty;
            strUnitName = string.Empty;
            strBatch = string.Empty;
            strTaxName = string.Empty;
            product.UnitId = 0;
            product.BatchId = 0;
            product.TaxId = 1;
            product.Qty = 0;
            product.PurchaseRate = 0;
            product.Discount = 0;
            product.DiscountAmount = 0;
            product.TaxRate = 0;
            product.TaxAmount = 0;
            product.NetAmount = 0;
            product.TotalAmount = 0;
            editedID = 0;
        }
    }
    void deleteItem(long id)
    {
        var myTodo = TodoList.FirstOrDefault(x => x.Id == id);
        TodoList.Remove(myTodo);

        product.ProductId = 0;
        product.Barcode = string.Empty;
        strProductCode = string.Empty;
        strProductName = string.Empty;
        strUnitName = string.Empty;
        strBatch = string.Empty;
        strTaxName = string.Empty;
        product.UnitId = 0;
        product.BatchId = 0;
        product.TaxId = 1;
        product.Qty = 0;
        product.PurchaseRate = 0;
        product.Discount = 0;
        product.DiscountAmount = 0;
        product.TaxRate = 0;
        product.TaxAmount = 0;
        product.NetAmount = 0;
        product.TotalAmount = 0;
        editedID = 0;
        CalculateTotal();
    }
    void editItem(long id)
    {
        var myTodo = TodoList.FirstOrDefault(x => x.Id == id);
        product.ProductId = myTodo.ProductId;
        product.Barcode = myTodo.Barcode;
        product.ProductName = myTodo.ProductName;
        product.UnitId = myTodo.UnitId;
        product.UnitName = myTodo.UnitName;
        product.BatchId = myTodo.BatchId;
        product.BatchNo = myTodo.BatchNo;
        product.TaxId = myTodo.TaxId;
        product.TaxName = myTodo.TaxName;
        product.Qty = myTodo.Qty;
        product.PurchaseRate = myTodo.PurchaseRate;
        product.Discount = myTodo.Discount;
        product.DiscountAmount = myTodo.DiscountAmount;
        product.NetAmount = myTodo.NetAmount;
        product.TaxRate = myTodo.TaxRate;
        product.TaxAmount = myTodo.TaxAmount;
        product.TotalAmount = myTodo.TotalAmount;
        editedID = id;
    }
    protected async void ProductClicked(long id)
    {
        var myTodo = listProduct.FirstOrDefault(x => x.ProductId == id);
        product.ProductId = myTodo.ProductId;
        product.Barcode = myTodo.Barcode;
        product.ProductName = myTodo.ProductName;
        product.UnitId = myTodo.UnitId;
        product.UnitName = myTodo.UnitName;
        product.BatchId = 1;
        product.BatchNo = "NA";
        product.TaxId = myTodo.TaxId;
        product.TaxName = myTodo.TaxName;
        product.Qty = 1;
        product.PurchaseRate = myTodo.PurchaseRate;
        product.Discount = 0;
        product.DiscountAmount = 0;
        product.NetAmount = Math.Round(1 * myTodo.PurchaseRate , 2);
        product.TaxRate = 0;
        product.TaxAmount = 0;
        product.TotalAmount = Math.Round(1 * myTodo.PurchaseRate , 2);
    }



    protected async void Save()
    {
            decimal decGrand = 0;
            decimal decCashBankAmount = 0;
            decimal decDue = 0;
            decGrand = master.GrandTotal;
            decCashBankAmount = master.CashAmount + master.BankAmount;
            decDue = decGrand - decCashBankAmount;
            if (TodoList == null)
            {
                Snackbar.Add("Invalid Entry.", Severity.Success);
            }
            else if (master.LedgerId == 0)
            {
                Snackbar.Add("Choose Supplier.", Severity.Success);
            }
            else if (master.VoucherNo == string.Empty)
            {
                Snackbar.Add("Type Voucherno.", Severity.Success);
            }
            else if (master.GrandTotal == 0)
            {
                Snackbar.Add("Invalid Entry.", Severity.Success);
            }
            else
            {
                var authState = await authenticationStateTask;
        var user = authState.User;
                //CheckVoucherNo
                var strVoucherNo = false;
                strVoucherNo = purchaseInvoiceRepository.AccountPurchseInvoiceNoCheckExistence(1, 1, master.VoucherNo);
                if (strVoucherNo == false)
                {
                    SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
                    sqlcon.Open();
                    SqlTransaction sql = sqlcon.BeginTransaction();
                    var para = new DynamicParameters();
                    para.Add("@SerialNo", strSerialNo);
                    para.Add("@VoucherNo", master.VoucherNo);
                    para.Add("@InvoiceNo", master.InvoiceNo);
                    para.Add("@SuffixPrefixId", 0);
                    para.Add("@Date", master.Date);
                    para.Add("@NepaliDate", string.Empty);
                    para.Add("@LedgerId", master.LedgerId);
                    para.Add("@ExchangeRateId", 1);
                    para.Add("@Narration", master.Narration);
                    para.Add("@PurchaseAccount", 11);
                    para.Add("@PurchaseMasterId", master.PurchaseMasterId);
                    para.Add("@CreditAmount", master.CreditAmount);
                    para.Add("@BankAmount", master.BankAmount);
                    para.Add("@CashAmount", master.CashAmount);
                    para.Add("@NetAmounts", master.NetAmounts);
                    para.Add("@TaxId", master.TaxId);
                    para.Add("@TaxRate", master.TaxRate);
                    para.Add("@TotalTax", master.TotalTax);
                    para.Add("@DisPer", master.DisPer);
                    para.Add("@BillDiscount", master.BillDiscount);
                    para.Add("@CheckDis", master.CheckDis);
                    para.Add("@GrandTotal", master.GrandTotal);
                    para.Add("@TotalAmount", master.TotalAmount);
                    para.Add("@PreviousDue", master.PreviousDue);
                    para.Add("@LrNo", master.LrNo);
                    para.Add("@TransportationCompany", master.TransportationCompany);
                    para.Add("@VoucherTypeId", decPurchaseInvoiceVoucherType);
                    para.Add("@CashId", master.CashId);
                    para.Add("@BankId", master.BankId);
                    para.Add("@UserId", user.Identity.Name);
                    para.Add("@BalanceDue", 0);
                    para.Add("@FinancialYearId", 1);
                    para.Add("@CompanyId", 1);
                    para.Add("@AddedDate", DateTime.Now);
                    para.Add("@AddedBy", 1);
                    para.Add("@MemIDOUT", dbType: DbType.Int64, direction: ParameterDirection.Output);
                sqlcon.Execute("PurchaseReturnInsert", para, sql, 0, CommandType.StoredProcedure);
                    long MemID = para.Get<long>("MemIDOUT");
                    if (MemID > 0)
                    {

                        foreach (var item in TodoList)
                        {
                            var paraOpening = new DynamicParameters();
                        paraOpening.Add("@PurchaseReturnMasterId", MemID);
                        paraOpening.Add("@PurchaseDetailsId", 0);
                            paraOpening.Add("@ProductId", item.ProductId);
                            paraOpening.Add("@Qty", item.Qty);
                            paraOpening.Add("@Rate", item.PurchaseRate);
                            paraOpening.Add("@UnitId", item.UnitId);
                            paraOpening.Add("@UnitConversionId", 1);
                            paraOpening.Add("@Discount", item.Discount);
                            paraOpening.Add("@DiscountAmount", item.DiscountAmount);
                            paraOpening.Add("@TaxId", item.TaxId);
                            paraOpening.Add("@BatchId", item.BatchId);
                            paraOpening.Add("@GodownId", 1);
                            paraOpening.Add("@RackId", 1);
                            paraOpening.Add("@TaxAmount", item.TaxAmount);
                            paraOpening.Add("@GrossAmount", 0);
                            paraOpening.Add("@NetAmount", item.NetAmount);
                            paraOpening.Add("@Amount", item.TotalAmount);
                            paraOpening.Add("@SlNo", 0);
                            paraOpening.Add("@JourDId", dbType: DbType.Int64, direction: ParameterDirection.Output);
                        sqlcon.Execute("PurchaseReturnDetailsInsert", paraOpening, sql, 0, CommandType.StoredProcedure);
                            long longdetailsId = paraOpening.Get<long>("JourDId");
                            //StockPosting
                            var parastock = new DynamicParameters();
                            parastock.Add("@BatchId", item.BatchId);
                            parastock.Add("@Date", master.Date);
                            parastock.Add("@NepaliDate", string.Empty);
                            parastock.Add("@CompanyId", 1);
                            parastock.Add("@FinancialYearId", 1);
                            parastock.Add("@LedgerId", master.LedgerId);
                            parastock.Add("@GodownId", 1);
                            parastock.Add("@InwardQty", 0);
                        parastock.Add("@OutwardQty", item.Qty);
                            parastock.Add("@ProductId", item.ProductId);
                            parastock.Add("@RackId", 1);
                            parastock.Add("@Rate", item.PurchaseRate);
                            parastock.Add("@UnitId", item.UnitId);
                            parastock.Add("@DetailsId", longdetailsId);
                                parastock.Add("@InvoiceNo", master.InvoiceNo);
                                parastock.Add("@VoucherNo", master.VoucherNo);
                                parastock.Add("@VoucherTypeId", decPurchaseInvoiceVoucherType);
                                parastock.Add("@AgainstInvoiceNo", "NA");
                                parastock.Add("@AgainstVoucherNo", "NA");
                                parastock.Add("@AgainstVoucherTypeId", 0);
                            parastock.Add("@StockCalculate", "Purchase");
                            parastock.Add("@AddedDate", DateTime.Now);
                            var valuesStock = sqlcon.Query<long>("StockPostingInsert", parastock, sql, true, 0, commandType: CommandType.StoredProcedure);

                        }

                        //LedgerPosting
                        //Supplier
                        var paraSc = new DynamicParameters();
                        paraSc.Add("@Date", master.Date);
                        paraSc.Add("@NepaliDate", string.Empty);
                        paraSc.Add("@LedgerId", master.LedgerId);
                    paraSc.Add("@Debit", master.GrandTotal);
                        paraSc.Add("@Credit", 0);
                        paraSc.Add("@VoucherNo", master.VoucherNo);
                        paraSc.Add("@DetailsId", MemID);
                        paraSc.Add("@YearId", 1);
                        paraSc.Add("@InvoiceNo", master.InvoiceNo);
                        paraSc.Add("@VoucherTypeId", decPurchaseInvoiceVoucherType);
                        paraSc.Add("@CompanyId", 1);
                        paraSc.Add("@LongReference", master.Narration);
                        paraSc.Add("@ReferenceN", master.Narration);
                        paraSc.Add("@ChequeNo", string.Empty);
                        paraSc.Add("@ChequeDate", string.Empty);
                        paraSc.Add("@AddedDate", DateTime.Now);
                        var valueSc = sqlcon.Query<long>("LedgerPostingInsert", paraSc, sql, true, 0, commandType: CommandType.StoredProcedure);

                        //PurchaseAccount Ledger send with out vat
                        decimal decSupplierCustomerAmount = Math.Round(master.NetAmounts - master.BillDiscount, 2);

                        var paraPs = new DynamicParameters();
                        paraPs.Add("@Date", master.Date);
                        paraPs.Add("@NepaliDate", string.Empty);
                        paraPs.Add("@LedgerId", 11);
                        paraPs.Add("@Debit", 0);
                    paraPs.Add("@Credit", decSupplierCustomerAmount);
                        paraPs.Add("@VoucherNo", master.VoucherNo);
                        paraPs.Add("@DetailsId", MemID);
                        paraPs.Add("@YearId", 1);
                        paraPs.Add("@InvoiceNo", master.InvoiceNo);
                        paraPs.Add("@VoucherTypeId", decPurchaseInvoiceVoucherType);
                        paraPs.Add("@CompanyId", 1);
                        paraPs.Add("@LongReference", master.Narration);
                        paraPs.Add("@ReferenceN", master.Narration);
                        paraPs.Add("@ChequeNo", string.Empty);
                        paraPs.Add("@ChequeDate", string.Empty);
                        paraPs.Add("@AddedDate", DateTime.Now);
                        var valuePs = sqlcon.Query<long>("LedgerPostingInsert", paraPs, sql, true, 0, commandType: CommandType.StoredProcedure);

                        //Tax
                        if (master.TotalTax > 0)
                        {
                            var paraTax = new DynamicParameters();
                            paraTax.Add("@Date", master.Date);
                            paraTax.Add("@NepaliDate", string.Empty);
                            paraTax.Add("@LedgerId", 14);
                            paraTax.Add("@Debit", 0);
                        paraTax.Add("@Credit", master.TotalTax);
                            paraTax.Add("@VoucherNo", master.VoucherNo);
                            paraTax.Add("@DetailsId", MemID);
                            paraTax.Add("@YearId", 1);
                            paraTax.Add("@InvoiceNo", master.InvoiceNo);
                            paraTax.Add("@VoucherTypeId", decPurchaseInvoiceVoucherType);
                            paraTax.Add("@CompanyId", 1);
                            paraTax.Add("@LongReference", master.Narration);
                            paraTax.Add("@ReferenceN", master.Narration);
                            paraTax.Add("@ChequeNo", string.Empty);
                            paraTax.Add("@ChequeDate", string.Empty);
                            paraTax.Add("@AddedDate", DateTime.Now);
                            var valueTax = sqlcon.Query<long>("LedgerPostingInsert", paraTax, sql, true, 0, commandType: CommandType.StoredProcedure);
                        }
                        

                    }
                    sql.Commit();
                    Snackbar.Add("Saved Successfully.", Severity.Success);
                    navManager.NavigateTo($"/purchase/purchasereturndetails/{MemID}");
                }
                else
                {
                    Snackbar.Add("Voucher No Already Exit.", Severity.Info);
                }
            }
    }
    void Cancel()
    {
        navManager.NavigateTo("/purchase/purchasereturnlist");
    }
    void CalculateTotal()
    {
        decimal decTotalAmount = 0;
        decimal decAdditionalCost = 0;
        decimal decTaxAmount = 0;
        decimal decTotalDisTax = 0;
        decimal decGrandTotalCshbnk = 0;
        decimal decNetAmount = 0;
        decimal decCheckTax = 0;
        decimal decGrandTotal = 0;
        foreach (var todo in TodoList)
        {
            decTotalAmount = decTotalAmount + todo.TotalAmount;
            decNetAmount = decNetAmount + todo.NetAmount;
            decCheckTax = decCheckTax + todo.TaxAmount;
        }
        master.NetAmounts = Math.Round(decNetAmount, 2);
        master.TotalAmount = Math.Round(decTotalAmount, 2);
        decimal decTotalAmountTax = 0;
        decTotalAmountTax = decTotalAmount + master.TotalTax;
        decTotalDisTax = decTotalAmount;
        if(master.BillDiscount > 0)
        {
            master.DisPer = (master.BillDiscount * 100) / (decTotalAmountTax);
        }
        if(master.TaxRate > 0)
        {
            decTaxAmount = decTotalDisTax * master.TaxRate / 100;
            master.TotalTax = Math.Round(decTaxAmount, 2);
        }
        else
        {
            decTaxAmount = 0;
            master.TotalTax = 0;
        }
        decimal decDiscountAmount = 0;
        decDiscountAmount = master.BillDiscount;
        decGrandTotal = Math.Round((decTotalDisTax + decAdditionalCost + decTaxAmount) - (decDiscountAmount), 2);
        if (decGrandTotal >= 0)
        {
            master.GrandTotal = decGrandTotal;
        }
        else
        {
            master.BillDiscount = 0;
            master.GrandTotal = decGrandTotal;
        }
        decGrandTotalCshbnk = master.CashAmount + master.BankAmount;
        if (master.GrandTotal >= decGrandTotalCshbnk)
        {
            var decTotl = master.GrandTotal - decGrandTotalCshbnk;
            master.CreditAmount = Math.Round(decTotl, 2);
        }
        else
        {
            master.CreditAmount = 0;
            master.CashAmount = 0;
            master.BankAmount = 0;
        }
    }
    protected void LedgerClicked()
    {
        if (master.LedgerId > 0)
        {
            var view = purchaseInvoiceRepository.GetPreviousDuesBalancepurchase(master.LedgerId);
            master.PreviousDue = view.DueBalance;
        }
        else
        {
            master.PreviousDue = 0;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountLedger ledgerRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUnit unitRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArea areaRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITax taxRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProduct productRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInventorySetting settingRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DatabaseConnection _conn { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPurchaseReturn purchaseReturn { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPurchaseInvoice purchaseInvoiceRepository { get; set; }
    }
}
#pragma warning restore 1591