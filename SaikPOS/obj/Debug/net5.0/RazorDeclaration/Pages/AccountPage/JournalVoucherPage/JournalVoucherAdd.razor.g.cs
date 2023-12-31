// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SaikPOS.Pages.AccountPage.JournalVoucherPage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.Data.Setting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.Data.Transaction;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.Data.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.Services.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.PdfReport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountPage\JournalVoucherPage\JournalVoucherAdd.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountPage\JournalVoucherPage\JournalVoucherAdd.razor"
using Dapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountPage\JournalVoucherPage\JournalVoucherAdd.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/account/journalvoucheradd")]
    public partial class JournalVoucherAdd : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 144 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountPage\JournalVoucherPage\JournalVoucherAdd.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    InventorySetting setting = new InventorySetting();
    JournalMaster master = new JournalMaster();
    List<JournlVoucherView> articleModel;
    List<AccountLedgerView> subledger = new List<AccountLedgerView>();
    List<JournlDetilsView> TodoList = new List<JournlDetilsView>();
    JournlDetilsView journldet = new JournlDetilsView();
    List<DeleteItem> deleteNo = new List<DeleteItem>();
    long editedID = 0;
    string strSerialNo;
    string strPrefix;
    string strSuffix;
    decimal decDebit = 0;
    decimal decCredit = 0;
    decimal decTotl = 0;
    protected async override void OnInitialized()
    {
        setting = settingRepository.EditInventorySetting(6);
        strPrefix = setting.Prefix;
        strSuffix = setting.Suffix;
        LoadData();
        StateHasChanged();
    }
    protected void LoadData()
    {
        if (setting.VoucherNoAutomatic == true)
        {
            strSerialNo = voucher.JournalvoucherNo(1, 1);
            master.VoucherNo = strPrefix + strSerialNo + strSuffix;
        }
        else
        {
            master.VoucherNo = string.Empty;
            strSerialNo = "0";
        }
        master.Date = DateTime.Now;
        //TodoList = null;
        subledger = ledger.GetAll(1);
        journldet.AccountGroupId = 0;
        master.Addresses.Add(new JournalDetails());
    }
    protected async void SvejournlVoucher()
    {
            if (TodoList == null)
            {
                Snackbar.Add("Invalid Entry.", Severity.Info);
                return;
            }
            else if (master.VoucherNo == string.Empty)
            {
                Snackbar.Add("Type voucher.", Severity.Info);
            }
            else if (decDebit != decCredit)
            {
                Snackbar.Add("Debit & Credit Amount must be equal.", Severity.Info);
                return;
            }
            else
            {
                var authState = await authenticationStateTask;
        var user = authState.User;
                var strVoucherNo = false;
                strVoucherNo = voucher.VouchernoCheckExistence(1, 1, master.VoucherNo);
                if (strVoucherNo == false)
                {
                    SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
                    sqlcon.Open();
                    SqlTransaction sql = sqlcon.BeginTransaction();
                    var para = new DynamicParameters();
                    para.Add("@SerialNo", strSerialNo);
                    para.Add("@VoucherNo", master.VoucherNo);
                    para.Add("@InvoiceNo", string.Empty);
                    para.Add("@SuffixPrefixId", 0);
                    para.Add("@Date", master.Date);
                    para.Add("@NepaliDate", string.Empty);
                    para.Add("@TotalAmount", decDebit);
                    para.Add("@RasidNo", string.Empty);
                    para.Add("@ReceiptNo", string.Empty);
                    para.Add("@Rakam", 0);
                    para.Add("@Prepairedby", string.Empty);
                    para.Add("@PreparedBypost", string.Empty);
                    para.Add("@Checkedby", string.Empty);
                    para.Add("@Checkedbypost", string.Empty);
                    para.Add("@Receivedby", string.Empty);
                    para.Add("@ReceivePost", string.Empty);
                    para.Add("@Swikritiby", string.Empty);
                    para.Add("@SwikritibyPost", string.Empty);
                    para.Add("@VoucherTypeId", 6);
                    para.Add("@UserId", user.Identity.Name);
                    para.Add("@FinancialYearId", 1);
                    para.Add("@CompanyId", 1);
                    para.Add("@AddedDate", DateTime.Now);
                    para.Add("@CreatedBy", 1);
                    para.Add("@MemIDOUT", dbType: DbType.Int64, direction: ParameterDirection.Output);
                    sqlcon.Execute("JournalMasterInsert", para, sql, 0, CommandType.StoredProcedure);
                    long MemID = para.Get<long>("MemIDOUT");
                    if (MemID > 0)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 246 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountPage\JournalVoucherPage\JournalVoucherAdd.razor"
                         for (var i = 0; i < master.Addresses.Count; i++)
                        {
                            var index = i;
                            var address = master.Addresses[i];

                            var paraOpening = new DynamicParameters();
                            paraOpening.Add("@JournalMasterId", MemID);
                            paraOpening.Add("@LedgerId", address.LedgerId);
                            paraOpening.Add("@Debit", address.Debit);
                            paraOpening.Add("@Credit", address.Credit);
                            paraOpening.Add("@Description", address.Description);
                            paraOpening.Add("@ExchangeRateId", 1);
                            paraOpening.Add("@ChequeNo", string.Empty);
                            paraOpening.Add("@ChequeDate", string.Empty);
                            paraOpening.Add("@JourDId", dbType: DbType.Int64, direction: ParameterDirection.Output);
                            sqlcon.Execute("JournalDetailsInsert", paraOpening, sql, 0, CommandType.StoredProcedure);
                            long journaldetId = paraOpening.Get<long>("JourDId");

                            ////LedgerPosting
                            var paraLedger = new DynamicParameters();
                            paraLedger.Add("@Date", master.Date);
                            paraLedger.Add("@NepaliDate", master.NepaliDate);
                            paraLedger.Add("@LedgerId", address.LedgerId);
                            paraLedger.Add("@Debit", address.Debit);
                            paraLedger.Add("@Credit", address.Credit);
                            paraLedger.Add("@VoucherNo", master.VoucherNo);
                            paraLedger.Add("@DetailsId", journaldetId);
                            paraLedger.Add("@YearId", 1);
                            paraLedger.Add("@InvoiceNo", string.Empty);
                            paraLedger.Add("@VoucherTypeId", 6);
                            paraLedger.Add("@CompanyId", 1);
                            paraLedger.Add("@LongReference", master.Narration);
                            paraLedger.Add("@ReferenceN", address.Description);
                            paraLedger.Add("@ChequeNo", string.Empty);
                            paraLedger.Add("@ChequeDate", string.Empty);
                            paraLedger.Add("@AddedDate", DateTime.Now);
                            var value = sqlcon.Query<long>("LedgerPostingInsert", paraLedger, sql, true, 0, commandType: CommandType.StoredProcedure);
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 283 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountPage\JournalVoucherPage\JournalVoucherAdd.razor"
                         

                    }
                    sql.Commit();
                    Snackbar.Add("Saved Successfully.", Severity.Info);
                    LoadData();
                    JsRuntime.InvokeAsync<object>("open", new object[] { ($"/account/journalvoucherprint/{MemID}"), "_blank" });
                    navManager.NavigateTo("account/journalvoucherlist");
                }
                else
                {
                    Snackbar.Add("Voucher No Already Exit.", Severity.Info);
                }
            }
    }

    void Remove(int index)
    {
        if (index > 1)
        {
            master.Addresses.RemoveAt(index);
            decimal decD = 0;
            decimal decC = 0;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 306 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountPage\JournalVoucherPage\JournalVoucherAdd.razor"
             for (var i = 0; i < master.Addresses.Count; i++)
            {
                var address = master.Addresses[i];
                decD = decD + address.Debit;
                decC = decC + address.Credit;
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 311 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountPage\JournalVoucherPage\JournalVoucherAdd.razor"
             
            decDebit = decD;
            decCredit = decC;
        }
        else
        {
            Snackbar.Add("Default value cannot be delete.", Severity.Info);
        }
    }
    void Calculate()
    {
        decimal decD = 0;
        decimal decC = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 324 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountPage\JournalVoucherPage\JournalVoucherAdd.razor"
         for (var i = 0; i < master.Addresses.Count; i++)
        {
            var address = master.Addresses[i];
            decD = decD + address.Debit;
            decC = decC + address.Credit;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 329 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountPage\JournalVoucherPage\JournalVoucherAdd.razor"
         
        decDebit = decD;
        decCredit = decC;
    }
    void AddJournal()
    {
        decimal decD = 0;
        decimal decC = 0;
        for (var i = 0; i < master.Addresses.Count; i++)
        {

            if (master.Addresses[i].LedgerId == 0)
            {
                Snackbar.Add("Choose Ledger.", Severity.Info);
                //mster.Addresses.RemoveAt(i);
            }
            else
            {
                master.Addresses.Add(new JournalDetails());
                var address = master.Addresses[i];
                decD = decD + address.Debit;
                decC = decC + address.Credit;
            }
        }
        decDebit = decD;
        decCredit = decC;
    }
    void Cancel()
    {
        navManager.NavigateTo("account/journalvoucherlist");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DatabaseConnection _conn { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInventorySetting settingRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountLedger ledger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJournalVoucher voucher { get; set; }
    }
}
#pragma warning restore 1591
