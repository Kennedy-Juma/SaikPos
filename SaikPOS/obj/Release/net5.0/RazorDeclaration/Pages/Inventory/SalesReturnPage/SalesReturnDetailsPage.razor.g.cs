// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Dreamer.Pages.Inventory.SalesReturnPage
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
#line 7 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SalesReturnPage\SalesReturnDetailsPage.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SalesReturnPage\SalesReturnDetailsPage.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SalesReturnPage\SalesReturnDetailsPage.razor"
using System.Collections.Specialized;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SalesReturnPage\SalesReturnDetailsPage.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SalesReturnPage\SalesReturnDetailsPage.razor"
using Dapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SalesReturnPage\SalesReturnDetailsPage.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sales/salesreturndetails/{id}")]
    public partial class SalesReturnDetailsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 169 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SalesReturnPage\SalesReturnDetailsPage.razor"
       
    [Parameter]
    public string id { get; set; }
    InventorySetting setting = new InventorySetting();
    SalesReturnMasterView master = new SalesReturnMasterView();
    List<ProductView> TodoList = new List<ProductView>();
    ReceiptMaster payment = new ReceiptMaster();
    List<AccountLedger> listCash = new List<AccountLedger>();
    List<AccountLedger> listBank = new List<AccountLedger>();
    List<ReceiptMaster> listPayment = new List<ReceiptMaster>();
    string billtype;
    long decVouchertypeIdSalesInvoice = 20;
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
        billtype = "Sales Return";
        LoadData();
    }
    private void LoadData()
    {
        master = salesInvoice.SalesMasterPrint(Convert.ToInt64(id));
        TodoList = salesInvoice.SalesDetailsPrint(Convert.ToInt64(id));
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISalesReturn salesInvoice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany company { get; set; }
    }
}
#pragma warning restore 1591
