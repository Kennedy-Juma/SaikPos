// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Dreamer.Pages.Inventory.SalesInvoicePage
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
#line 7 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SalesInvoicePage\SalesInvoiceDetailsPage.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SalesInvoicePage\SalesInvoiceDetailsPage.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SalesInvoicePage\SalesInvoiceDetailsPage.razor"
using System.Collections.Specialized;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SalesInvoicePage\SalesInvoiceDetailsPage.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SalesInvoicePage\SalesInvoiceDetailsPage.razor"
using Dapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SalesInvoicePage\SalesInvoiceDetailsPage.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sales/salesinvoicedetails/{id}")]
    public partial class SalesInvoiceDetailsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 329 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SalesInvoicePage\SalesInvoiceDetailsPage.razor"
       
    [Parameter]
    public string id { get; set; }
    InventorySetting setting = new InventorySetting();
    SalesMasterView master = new SalesMasterView();
    List<ProductView> TodoList = new List<ProductView>();
    ReceiptMaster payment = new ReceiptMaster();
    List<AccountLedger> listCash = new List<AccountLedger>();
    List<AccountLedger> listBank = new List<AccountLedger>();
    List<ReceiptMaster> listPayment = new List<ReceiptMaster>();
    string billtype;
    long decVouchertypeIdSalesInvoice = 19;
    long decVoucherReceiveId = 5;
    bool showPay = false;
    bool showModal = false;
    string strSerialNo;
    string strPrefix;
    string strSuffix;
    decimal decTotal = 0;
    decimal PreviousDue = 0;
    decimal paymentMade = 0;
    decimal balanceDue = 0;
    string companyName;
    string address;
    string phone;

    protected async override void OnInitialized()
    {
        var resultCompany = company.Edit(1);
        companyName = resultCompany.CompanyName;
        address = resultCompany.Address;
        phone = resultCompany.Phone;
        billtype = "Sales Invoice";
        LoadData();
    }
    private void LoadData()
    {
        master = salesInvoice.SalesMasterPrint(Convert.ToInt64(id));
        TodoList = salesInvoice.SalesDetailsPrint(Convert.ToInt64(id));
        LoadPaymentShow();
    }
    void ModalShow()
    {
        showModal = true;
    }
    void ModalShowPay()
    {
        payment.Date = DateTime.Now;
        strSerialNo = receiveCustomer.GetReceiveVoucherNo(1, 1, decVoucherReceiveId);
        payment.VoucherNo = strPrefix + strSerialNo + strSuffix;
        payment.SerialNo = strSerialNo;
        listCash = accountLedger.GetCashFill();
        listBank = accountLedger.GetBankFill();
        payment.CashId = 1;
        payment.BankId = 13;
        payment.TotalAmount = Math.Round(master.GrandTotal - paymentMade, 2);
        payment.CashAmount = 0;
        payment.BankAmount = 0;
        payment.CreditAmount = 0;
        payment.Narration = string.Empty;
        showPay = true;
    }
    void ModalCancelPay()
    {
        showPay = false;
    }
    void OnPay()
    {
        if (master.LedgerId == 0)
        {
            Snackbar.Add("Choose Supplier.", Severity.Info);
        }
        else if (payment.VoucherNo == string.Empty)
        {
            Snackbar.Add("Type VoucherNo.", Severity.Info);
        }
        else
        {
            var isCheck = receiveCustomer.CheckReceiveCustomer(master.VoucherNo, 1, 1, decVoucherReceiveId);
            if (isCheck == true)
            {
                Snackbar.Add("Voucher no already exists.", Severity.Info);
            }
            else
            {
                SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
                sqlcon.Open();
                SqlTransaction sql = sqlcon.BeginTransaction();
                decimal decCredit = payment.CashAmount + payment.BankAmount;

                var paraLedger = new DynamicParameters();
                paraLedger.Add("@SerialNo", strSerialNo);
                paraLedger.Add("@Date", payment.Date);
                paraLedger.Add("@NepaliDate", payment.NepaliDate);
                paraLedger.Add("@LedgerId", master.LedgerId);
                paraLedger.Add("@VoucherNo", payment.VoucherNo);
                paraLedger.Add("@SuffixPrefixId", 0);
                paraLedger.Add("@financialYearId", 1);
                paraLedger.Add("@InvoiceNo", payment.VoucherNo);
                paraLedger.Add("@VoucherTypeId", decVoucherReceiveId);
                paraLedger.Add("@CompanyId", 1);
                paraLedger.Add("@DetailsId", master.SalesMasterId);
                paraLedger.Add("@CashAmount", payment.CashAmount);
                paraLedger.Add("@BankAmount", payment.BankAmount);
                paraLedger.Add("@CreditAmount", payment.CreditAmount);
                paraLedger.Add("@TotalAmount", decCredit);
                paraLedger.Add("@Narration", payment.Narration);
                paraLedger.Add("@UserId", 1);
                paraLedger.Add("@CashId", payment.CashId);
                paraLedger.Add("@BankId", payment.BankId);
                paraLedger.Add("@Optional", "Receive");
                paraLedger.Add("@AddedDate", DateTime.Now);
                paraLedger.Add("@MemOUT", dbType: DbType.Int64, direction: ParameterDirection.Output);
                sqlcon.Execute("ReceiptMasterAdd", paraLedger, sql, 0, CommandType.StoredProcedure);
                long MemID = paraLedger.Get<long>("MemOUT");
                //UpdatePurchaseMaster
                decimal decTotalDuess = master.GrandTotal;
                decimal decPaymentAmount = payment.CashAmount + payment.BankAmount;
                var para = new DynamicParameters();
                para.Add("@SalesMasterId", master.SalesMasterId);
                para.Add("@BalanceDue", payment.CreditAmount);
                para.Add("@CashAmount", payment.CashAmount);
                para.Add("@BankAmount", payment.BankAmount);
                para.Add("@CreditAmount", payment.CreditAmount);
                if (decTotalDuess == decPaymentAmount)
                {
                    para.Add("@Status", "Paid");
                }
                else if (decTotalDuess > decPaymentAmount)
                {
                    para.Add("@Status", "PartialPaid");
                }
                else
                {
                    para.Add("@Status", "Draft");
                }
                sqlcon.Execute("UPDATE SalesMaster SET BalanceDue=@BalanceDue,Status=@Status,CashAmount=@CashAmount,CreditAmount=@CreditAmount,BankAmount=@BankAmount where SalesMasterId=@SalesMasterId", para, sql, 0, CommandType.Text);

                //LedgerPosting
                //Supplier
                decimal decSupplierAmount = payment.BankAmount + payment.CashAmount;
                if (decSupplierAmount > 0)
                {
                    var paraSc = new DynamicParameters();
                    paraSc.Add("@Date", payment.Date);
                    paraSc.Add("@NepaliDate", payment.NepaliDate);
                    paraSc.Add("@LedgerId", master.LedgerId);
                    paraSc.Add("@Debit", 0);
                    paraSc.Add("@Credit", decSupplierAmount);
                    paraSc.Add("@VoucherNo", payment.VoucherNo);
                    paraSc.Add("@DetailsId", master.SalesMasterId);
                    paraSc.Add("@YearId", 1);
                    paraSc.Add("@InvoiceNo", string.Empty);
                    paraSc.Add("@VoucherTypeId", decVoucherReceiveId);
                    paraSc.Add("@CompanyId", 1);
                    paraSc.Add("@LongReference", payment.Narration);
                    paraSc.Add("@ReferenceN", payment.Narration);
                    paraSc.Add("@ChequeNo", string.Empty);
                    paraSc.Add("@ChequeDate", string.Empty);
                    paraSc.Add("@AddedDate", DateTime.Now);
                    var valueSc = sqlcon.Query<long>("LedgerPostingInsert", paraSc, sql, true, 0, commandType: CommandType.StoredProcedure);
                }

                //Cash
                if (payment.CashAmount > 0)
                {
                    var paraCash = new DynamicParameters();
                    paraCash.Add("@Date", payment.Date);
                    paraCash.Add("@NepaliDate", payment.NepaliDate);
                    paraCash.Add("@LedgerId", payment.CashId);
                    paraCash.Add("@Debit", payment.CashAmount);
                    paraCash.Add("@Credit", 0);
                    paraCash.Add("@VoucherNo", payment.VoucherNo);
                    paraCash.Add("@DetailsId", master.SalesMasterId);
                    paraCash.Add("@YearId", 1);
                    paraCash.Add("@InvoiceNo", string.Empty);
                    paraCash.Add("@VoucherTypeId", decVoucherReceiveId);
                    paraCash.Add("@CompanyId", 1);
                    paraCash.Add("@LongReference", payment.Narration);
                    paraCash.Add("@ReferenceN", payment.Narration);
                    paraCash.Add("@ChequeNo", string.Empty);
                    paraCash.Add("@ChequeDate", string.Empty);
                    paraCash.Add("@AddedDate", DateTime.Now);
                    var valueCash = sqlcon.Query<long>("LedgerPostingInsert", paraCash, sql, true, 0, commandType: CommandType.StoredProcedure);
                }
                //Bank
                if (payment.BankAmount > 0)
                {
                    var paraBank = new DynamicParameters();
                    paraBank.Add("@Date", payment.Date);
                    paraBank.Add("@NepaliDate", payment.NepaliDate);
                    paraBank.Add("@LedgerId", payment.BankId);
                    paraBank.Add("@Debit", payment.BankAmount);
                    paraBank.Add("@Credit", 0);
                    paraBank.Add("@VoucherNo", payment.VoucherNo);
                    paraBank.Add("@DetailsId", master.SalesMasterId);
                    paraBank.Add("@YearId", 1);
                    paraBank.Add("@InvoiceNo", string.Empty);
                    paraBank.Add("@VoucherTypeId", decVoucherReceiveId);
                    paraBank.Add("@CompanyId", 1);
                    paraBank.Add("@LongReference", master.Narration);
                    paraBank.Add("@ReferenceN", master.Narration);
                    paraBank.Add("@ChequeNo", string.Empty);
                    paraBank.Add("@ChequeDate", string.Empty);
                    paraBank.Add("@AddedDate", DateTime.Now);
                    var valueBank = sqlcon.Query<long>("LedgerPostingInsert", paraBank, sql, true, 0, commandType: CommandType.StoredProcedure);
                }
                sql.Commit();
                Snackbar.Add("Successfully Saved.", Severity.Success);
                LoadData();
                showPay = false;
            }
        }
    }
    void LoadPaymentShow()
    {
        SalesMaster paymentmaster = new SalesMaster();
        decimal decTotalAmount = 0;
        listPayment = receiveCustomer.GetReceiptMasterView(master.SalesMasterId);
        foreach (var item in listPayment)
        {
            decTotalAmount = decTotalAmount + item.CashAmount;
        }
        paymentMade = decTotalAmount;
        balanceDue = master.GrandTotal - paymentMade;
    }
    void ModalCancel()
    {
        showModal = false;
    }
    void Calculate()
    {
        decimal totalAmount = payment.TotalAmount;
        decimal CashAmount = payment.CashAmount;
        decimal BankAmount = payment.BankAmount;
        decimal creditAmount = payment.CreditAmount;
        decimal decGrandTotal = CashAmount + BankAmount;
        if (totalAmount >= decGrandTotal)
        {
            decimal decTotl = Math.Round(totalAmount - decGrandTotal, 2);
            payment.CreditAmount = decTotl;
        }
        else
        {
            payment.CreditAmount = 0;
            payment.CashAmount = 0;
            payment.BankAmount = 0;
        }
    }
    private void Print()
    {
        JsRuntime.InvokeVoidAsync("Print");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DatabaseConnection _conn { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInventorySetting settingRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountLedger accountLedger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IReceiveCustomer receiveCustomer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISalesInvoice salesInvoice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany company { get; set; }
    }
}
#pragma warning restore 1591
