// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Dreamer.Pages.IncomePage
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
#line 3 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\IncomePage\Incomevoucheradd.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\IncomePage\Incomevoucheradd.razor"
using Microsoft.EntityFrameworkCore.Storage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\IncomePage\Incomevoucheradd.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\IncomePage\Incomevoucheradd.razor"
using Dapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\IncomePage\Incomevoucheradd.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\IncomePage\Incomevoucheradd.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/income/incomevoucheradd")]
    public partial class Incomevoucheradd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 219 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\IncomePage\Incomevoucheradd.razor"
           [CascadingParameter]    private Task<AuthenticationState> authenticationStateTask { get; set; }    InventorySetting setting = new InventorySetting();    IncomeMaster mster = new IncomeMaster();    IncomeExpenditureView product = new IncomeExpenditureView();    List<AccountLedger> listLedger = new List<AccountLedger>();    List<AccountLedgerView> listSupCus = new List<AccountLedgerView>();    List<AccountLedger> listCash = new List<AccountLedger>();    List<AccountLedger> listBank = new List<AccountLedger>();    //GetSessionInfo    long decIncomeVoucherTypeId = 31;    string strSerialNo;    string strPrefix;    string strSuffix;    long editedID = 0;    public byte[] ImageUploaded { get; set; }    bool showModal = false;    private bool readOnly;    protected async override void OnInitialized()    {        setting = settingRepository.EditInventorySetting(decIncomeVoucherTypeId);        strPrefix = setting.Prefix;        strSuffix = setting.Suffix;        LoadData();        StateHasChanged();    }    protected void LoadData()    {        if (setting.VoucherNoAutomatic == true)        {            strSerialNo = incomeVoucher.GetIncomevoucherNo(1, 1);            mster.VoucherNo = strPrefix + strSerialNo + strSuffix;        }        else        {            mster.VoucherNo = string.Empty;            strSerialNo = "0";        }        mster.Date = DateTime.Now;        mster.Amount = 0;        mster.Narration = string.Empty;        listLedger = incomeVoucher.IncomeComboFill(1);        listSupCus = ledger.ViewAllCustomer(1);        listCash = ledger.GetCashFill();        listBank = ledger.GetBankFill();        mster.CashId = 1;        mster.BankId = 13;        mster.Addresses.Add(new IncomeDetails());    }    protected async void Save()    {            decimal decGrandTotalCshbnk = 0;            decGrandTotalCshbnk = Math.Round(mster.CashAmount + mster.BankAmount + mster.CreditAmount, 2);            if (mster.Addresses == null)            {                Snackbar.Add("Invalid Entry.", Severity.Info);            }            else if (decGrandTotalCshbnk != mster.Amount)            {                Snackbar.Add("Invalid Entry.", Severity.Info);            }            else if (mster.VoucherNo == "")            {                Snackbar.Add("Type voucher no.", Severity.Info);            }            else if (mster.Date == null)            {                Snackbar.Add("Invalid Date.", Severity.Info);            }            else if (mster.CreditAmount > 0 && mster.LedgerId == 0)            {                Snackbar.Add("Choose Customer.", Severity.Info);            }            else if (mster.BankAmount > 0 && mster.BankId == 0)            {                Snackbar.Add("Choose Bank.", Severity.Info);            }            else if (mster.CashAmount > 0 && mster.CashId == 0)            {                Snackbar.Add("Choose Cash.", Severity.Info);            }            else if (mster.Amount == 0)            {                Snackbar.Add("Invalid Entry.", Severity.Info);            }            else            {                var authState = await authenticationStateTask;        var user = authState.User;                SqlConnection sqlcon = new SqlConnection(_conn.DbConn);                sqlcon.Open();                SqlTransaction sql = sqlcon.BeginTransaction();                var strVoucherNo = false;                strVoucherNo = incomeVoucher.EpensiveVouchernoCheckExistence(1, 1, mster.VoucherNo);                if (strVoucherNo == false)                {                    var para = new DynamicParameters();                    para.Add("@SerialNo", strSerialNo);                    para.Add("@VoucherNo", mster.VoucherNo);                    para.Add("@InvoiceNo", mster.VoucherNo);                    para.Add("@SuffixPrefixId", 0);                    para.Add("@Date", mster.Date);                    para.Add("@NepaliDate", mster.NepaliDate);                    para.Add("@Amount", mster.Amount);                    para.Add("@LedgerId", mster.LedgerId);                    para.Add("@CreditAmount", mster.CreditAmount);                    para.Add("@BankId", mster.BankId);                    para.Add("@BankAmount", mster.BankAmount);                    para.Add("@CashId", mster.CashId);                    para.Add("@CashAmount", mster.CashAmount);                    para.Add("@VoucherTypeId", decIncomeVoucherTypeId);                    para.Add("@Narration", mster.Narration);                    para.Add("@SuffixPrefixId", 0);                    para.Add("@UserId", user.Identity.Name);                    para.Add("@FinancialYearId", 1);                    para.Add("@CompanyId", 1);                    para.Add("@AddedDate", DateTime.Now);                    para.Add("@AddedBy", 1);                    para.Add("@MemIDOUT", dbType: DbType.Int64, direction: ParameterDirection.Output);                    sqlcon.Execute("IncomeMasterAdd", para, sql, 0, CommandType.StoredProcedure);                    long MemID = para.Get<long>("MemIDOUT");                    if (MemID > 0)                    {                        foreach (var item in mster.Addresses)                        {                            if (item.LedgerId > 0)                            {                                var paraOpening = new DynamicParameters();                                paraOpening.Add("@IncomeMasterId", MemID);                                paraOpening.Add("@LedgerId", item.LedgerId);                                paraOpening.Add("@Description", item.Description);                                paraOpening.Add("@Amount", item.Amount);                                paraOpening.Add("@TaxId", 1);                                paraOpening.Add("@Rate", 0);                                paraOpening.Add("@JourDId", dbType: DbType.Int64, direction: ParameterDirection.Output);                                sqlcon.Execute("IncomeDetailsAdd", paraOpening, sql, 0, CommandType.StoredProcedure);                                long journaldetId = paraOpening.Get<long>("JourDId");                                //IncomeLedger                                var paraLedger = new DynamicParameters();                                paraLedger.Add("@Date", mster.Date);                                paraLedger.Add("@NepaliDate", mster.NepaliDate);                                paraLedger.Add("@LedgerId", item.LedgerId);                                paraLedger.Add("@Debit", 0);                                paraLedger.Add("@Credit", item.Amount);                                paraLedger.Add("@VoucherNo", mster.VoucherNo);                                paraLedger.Add("@DetailsId", MemID);                                paraLedger.Add("@YearId", 1);                                paraLedger.Add("@InvoiceNo", mster.VoucherNo);                                paraLedger.Add("@VoucherTypeId", decIncomeVoucherTypeId);                                paraLedger.Add("@CompanyId", 1);                                paraLedger.Add("@LongReference", mster.Narration);                                paraLedger.Add("@ReferenceN", item.Description);                                paraLedger.Add("@ChequeNo", string.Empty);                                paraLedger.Add("@ChequeDate", string.Empty);                                paraLedger.Add("@AddedDate", DateTime.Now);                                var value = sqlcon.Query<long>("LedgerPostingInsert", paraLedger, sql, true, 0, commandType: CommandType.StoredProcedure);                            }                        }                    }                    //IncomeLedger                    if (mster.LedgerId > 0)                    {                        var paraScSupplier = new DynamicParameters();                        paraScSupplier.Add("@Date", mster.Date);                        paraScSupplier.Add("@NepaliDate", mster.NepaliDate);                        paraScSupplier.Add("@LedgerId", mster.LedgerId);                        paraScSupplier.Add("@Debit", mster.CreditAmount);                        paraScSupplier.Add("@Credit", 0);                        paraScSupplier.Add("@VoucherNo", mster.VoucherNo);                        paraScSupplier.Add("@DetailsId", MemID);                        paraScSupplier.Add("@YearId", 1);                        paraScSupplier.Add("@InvoiceNo", mster.InvoiceNo);                        paraScSupplier.Add("@VoucherTypeId", decIncomeVoucherTypeId);                        paraScSupplier.Add("@CompanyId", 1);                        paraScSupplier.Add("@LongReference", mster.Narration);                        paraScSupplier.Add("@ReferenceN", mster.Narration);                        paraScSupplier.Add("@ChequeNo", string.Empty);                        paraScSupplier.Add("@ChequeDate", string.Empty);                        paraScSupplier.Add("@AddedDate", DateTime.Now);                        var valueScSupplier = sqlcon.Query<long>("LedgerPostingInsert", paraScSupplier, sql, true, 0, commandType: CommandType.StoredProcedure);                    }                    //Cash                    if (mster.CashAmount > 0)                    {                        var paraCash = new DynamicParameters();                        paraCash.Add("@Date", mster.Date);                        paraCash.Add("@NepaliDate", mster.NepaliDate);                        paraCash.Add("@LedgerId", mster.CashId);                        paraCash.Add("@Debit", mster.CashAmount);                        paraCash.Add("@Credit", 0);                        paraCash.Add("@VoucherNo", mster.VoucherNo);                        paraCash.Add("@DetailsId", MemID);                        paraCash.Add("@YearId", 1);                        paraCash.Add("@InvoiceNo", mster.InvoiceNo);                        paraCash.Add("@VoucherTypeId", decIncomeVoucherTypeId);                        paraCash.Add("@CompanyId", 1);                        paraCash.Add("@LongReference", mster.Narration);                        paraCash.Add("@ReferenceN", mster.Narration);                        paraCash.Add("@ChequeNo", string.Empty);                        paraCash.Add("@ChequeDate", string.Empty);                        paraCash.Add("@AddedDate", DateTime.Now);                        var valueCash = sqlcon.Query<long>("LedgerPostingInsert", paraCash, sql, true, 0, commandType: CommandType.StoredProcedure);                    }                    //Bank                    if (mster.BankAmount > 0)                    {                        var paraBank = new DynamicParameters();                        paraBank.Add("@Date", mster.Date);                        paraBank.Add("@NepaliDate", mster.NepaliDate);                        paraBank.Add("@LedgerId", mster.BankId);                        paraBank.Add("@Debit", mster.BankAmount);                        paraBank.Add("@Credit", 0);                        paraBank.Add("@VoucherNo", mster.VoucherNo);                        paraBank.Add("@DetailsId", MemID);                        paraBank.Add("@YearId", 1);                        paraBank.Add("@InvoiceNo", mster.InvoiceNo);                        paraBank.Add("@VoucherTypeId", decIncomeVoucherTypeId);                        paraBank.Add("@CompanyId", 1);                        paraBank.Add("@LongReference", mster.Narration);                        paraBank.Add("@ReferenceN", mster.Narration);                        paraBank.Add("@ChequeNo", string.Empty);                        paraBank.Add("@ChequeDate", string.Empty);                        paraBank.Add("@AddedDate", DateTime.Now);                        var valueBank = sqlcon.Query<long>("LedgerPostingInsert", paraBank, sql, true, 0, commandType: CommandType.StoredProcedure);                    }                    sql.Commit();                    Snackbar.Add("Saved Successfully.", Severity.Success);                    //LoadData();                    navManager.NavigateTo("/income/incomevoucherlist");                }                else                {                    Snackbar.Add("Already Exists.", Severity.Success);                }            }    }    void Calculate()    {        decimal decAmount = 0;        

#line default
#line hidden
#nullable disable
#nullable restore
#line 465 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\IncomePage\Incomevoucheradd.razor"
         for (var i = 0; i < mster.Addresses.Count; i++)        {            var address = mster.Addresses[i];            decAmount = decAmount + address.Amount;        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 469 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\IncomePage\Incomevoucheradd.razor"
                 mster.Amount = Math.Round(decAmount, 1);    }    void Remove(int index)    {        if (index > 0)        {            mster.Addresses.RemoveAt(index);            decimal decAmount = 0;            

#line default
#line hidden
#nullable disable
#nullable restore
#line 478 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\IncomePage\Incomevoucheradd.razor"
             for (var i = 0; i < mster.Addresses.Count; i++)            {                var address = mster.Addresses[i];                decAmount = decAmount + address.Amount;            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 482 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\IncomePage\Incomevoucheradd.razor"
                         mster.Amount = Math.Round(decAmount, 1);        }        else        {            Snackbar.Add("Default value cannot be delete.", Severity.Info);        }    }    void AddJournal()    {        decimal decAmount = 0;        

#line default
#line hidden
#nullable disable
#nullable restore
#line 493 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\IncomePage\Incomevoucheradd.razor"
         for (var i = 0; i < mster.Addresses.Count; i++)        {            if (mster.Addresses[i].LedgerId == 0)            {                Snackbar.Add("Choose Income.", Severity.Info);            }            else            {                mster.Addresses.Add(new IncomeDetails());                var address = mster.Addresses[i];                decAmount = decAmount + address.Amount;            }        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 506 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\IncomePage\Incomevoucheradd.razor"
                 mster.Amount = Math.Round(decAmount, 1);    }    void CalculateTotal()    {        decimal decGrandTotalCshbnk = 0;        decimal decNetAmount = 0;        decimal decGrandTotal = 0;        decNetAmount = mster.Amount;        decGrandTotal = Math.Round(decNetAmount, 1);        decGrandTotalCshbnk = Math.Round(mster.CashAmount + mster.BankAmount + mster.CreditAmount, 1);        if (mster.Amount >= decGrandTotalCshbnk)        {            //mster.CreditAmount = 0;            //mster.CashAmount = 0;            //mster.BankAmount = 0;        }        else        {            mster.CreditAmount = 0;            mster.CashAmount = 0;            mster.BankAmount = 0;        }    }    async Task HandleSelection(IFileListEntry[] files)    {        var file = files.FirstOrDefault();        if (file != null)        {            var ms = new MemoryStream();            await file.Data.CopyToAsync(ms);            ImageUploaded = ms.ToArray();        }    }    string convertImageToDisplay(byte[] image)    {        if (image != null)        {            var base64 = Convert.ToBase64String(image);            var finalStr = string.Format("data:image/jpg;base64,{0}", base64);            return finalStr;        }        return "";    }    void Cancel()    {        navManager.NavigateTo("/income/incomevoucherlist");    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IncomeVoucherRepository incomeVoucher { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInventorySetting settingRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountLedger ledger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DatabaseConnection _conn { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
