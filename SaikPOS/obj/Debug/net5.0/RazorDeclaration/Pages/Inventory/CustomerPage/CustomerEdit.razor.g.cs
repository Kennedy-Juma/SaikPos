// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SaikPOS.Pages.Inventory.CustomerPage
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/sales/customeredit/{id}")]
    public partial class CustomerEdit : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 202 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Inventory\CustomerPage\CustomerEdit.razor"
       
    [Parameter]
    public string id { get; set; }
    AccountLedger master = new AccountLedger();
    List<Area> listArea = new List<Area>();
    protected async override void OnInitialized()
    {
        LoadData();
    }
    private void LoadData()
    {
        master = accountLedger.Edit(Convert.ToInt64(id));
        master.Referfrom = "Previous Customer";
        listArea = area.GetAll();
    }
    public void HandleValidSubmit()
    {
            master.AccountGroupId = 26;
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
            master.ModifyDate = DateTime.Now;
            master.CompanyId = 1;
            master.ModifyBy = 1;
            bool isSave = false;
            isSave = accountLedger.Update(master);
            if (isSave == true)
            {
                Snackbar.Add("Updated Successfully.", Severity.Success);
                LoadData();
                navManager.NavigateTo("sales/customerlist");
            }
            else
            {
                Snackbar.Add("Already Exists.", Severity.Info);
            }
    }
    void Cancel()
    {
        navManager.NavigateTo("sales/customerlist");
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
    }
}
#pragma warning restore 1591