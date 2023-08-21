// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SaikPOS.Pages.Inventory.SupplierPage
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
#line 3 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Inventory\SupplierPage\SupplierAdd.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Inventory\SupplierPage\SupplierAdd.razor"
using Dapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Inventory\SupplierPage\SupplierAdd.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/purchase/supplieradd")]
    public partial class SupplierAdd : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 220 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Inventory\SupplierPage\SupplierAdd.razor"
       
    AccountLedger master = new AccountLedger();
    List<Area> listArea = new List<Area>();
    protected async override void OnInitialized()
    {
        LoadData();
    }
    private void LoadData()
    {
        var strSerialNo = accountLedger.SerialNoCode(1);
        master.LedgerCode = strSerialNo;
        master.Referfrom = "Previous Customer";
        listArea = area.GetAll();
        master.CrOrDr = "Dr";
        master.AreaId = 1;
    }
    public void HandleValidSubmit()
    {
        var isCheck = area.CheckName(master.LedgerName);
        if (isCheck == true)
        {
            Snackbar.Add("Already Exists.", Severity.Info);
        }
        else
        {
            master.AccountGroupId = 22;
            master.LogoPathC = string.Empty;
            master.PricinglevelId = 1;
            master.RouteId = 1;
            master.SkypeID = string.Empty;
            master.Twitter = string.Empty;
            master.Facebook = string.Empty;
            master.instagram = string.Empty;
            master.MailingName = string.Empty;
            master.BranchCode = string.Empty;
            master.BankAccountNumber = string.Empty;
            master.Street = string.Empty;
            master.ZipCode = string.Empty;
            master.Map = string.Empty;
            master.AddedDate = DateTime.Now;
            master.CompanyId = 1;
            master.CreatedBy = 1;
            long intLedgerId = accountLedger.Save(master);
                if (intLedgerId > 0)
                {
                    if (master.OpeningBalance > 0)
                    {
                        SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
                        sqlcon.Open();
                        var paraSc = new DynamicParameters();
                        paraSc.Add("@Date", DateTime.UtcNow);
                        paraSc.Add("@NepaliDate", string.Empty);
                        paraSc.Add("@LedgerId", intLedgerId);
                        if (master.CrOrDr == "Dr")
                        {
                            paraSc.Add("@Debit", master.OpeningBalance);
                            paraSc.Add("@Credit", 0);
                        }
                        else
                        {
                            paraSc.Add("@Debit", 0);
                            paraSc.Add("@Credit", master.OpeningBalance);
                        }
                        paraSc.Add("@VoucherNo", intLedgerId);
                        paraSc.Add("@DetailsId", intLedgerId);
                        paraSc.Add("@YearId", 1);
                        paraSc.Add("@InvoiceNo", intLedgerId);
                        paraSc.Add("@VoucherTypeId", 1);
                        paraSc.Add("@CompanyId", 1);
                        paraSc.Add("@LongReference", master.Narration);
                        paraSc.Add("@ReferenceN", master.Narration);
                        paraSc.Add("@ChequeNo", string.Empty);
                        paraSc.Add("@ChequeDate", string.Empty);
                        paraSc.Add("@AddedDate", DateTime.Now);
                        var valueSc = sqlcon.Query<long>("LedgerPostingInsert", paraSc, null, true, 0, commandType: CommandType.StoredProcedure);
                        sqlcon.Close();
                    }
                Snackbar.Add("Saved Successfully.", Severity.Success);
                LoadData();
                navManager.NavigateTo("purchase/supplierlist");
            }
            else
            {
                Snackbar.Add("Already Exists.", Severity.Info);
            }
        }
    }
    void Cancel()
    {
        navManager.NavigateTo("purchase/supplierlist");
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArea area { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountGroup accountGroup { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountLedger accountLedger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DatabaseConnection _conn { get; set; }
    }
}
#pragma warning restore 1591
