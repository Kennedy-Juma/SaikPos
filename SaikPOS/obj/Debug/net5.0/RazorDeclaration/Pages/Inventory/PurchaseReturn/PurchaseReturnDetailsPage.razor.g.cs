// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SaikPOS.Pages.Inventory.PurchaseReturn
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
#line 6 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Inventory\PurchaseReturn\PurchaseReturnDetailsPage.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Inventory\PurchaseReturn\PurchaseReturnDetailsPage.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Inventory\PurchaseReturn\PurchaseReturnDetailsPage.razor"
using System.Collections.Specialized;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Inventory\PurchaseReturn\PurchaseReturnDetailsPage.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Inventory\PurchaseReturn\PurchaseReturnDetailsPage.razor"
using Dapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Inventory\PurchaseReturn\PurchaseReturnDetailsPage.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Inventory\PurchaseReturn\PurchaseReturnDetailsPage.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/purchase/purchasereturndetails/{id}")]
    public partial class PurchaseReturnDetailsPage : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 163 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Inventory\PurchaseReturn\PurchaseReturnDetailsPage.razor"
       
    [Parameter]
    public string id { get; set; }
    InventorySetting setting = new InventorySetting();
    InventorySetting settingPurchase = new InventorySetting();
    PurchaseReturnView master = new PurchaseReturnView();
    List<ProductView> TodoList = new List<ProductView>();
    List<AccountLedger> listCash = new List<AccountLedger>();
    List<AccountLedger> listBank = new List<AccountLedger>();
    string billtype;
    long decPurchaseInvoiceVoucherType = 14;
    string strSerialNo;
    string strPrefix;
    string strSuffix;
    decimal decTotal = 0;
    decimal paymentMade = 0;
    Company companyView = new Company();

    //SendMail
    private string Message { get; set; } = "";

    protected async override void OnInitialized()
    {
        settingPurchase = settingRepository.EditInventorySetting(decPurchaseInvoiceVoucherType);
        companyView = company.Edit(1);
        billtype = "Purchase Return";
        LoadData();
    }
    private void LoadData()
    {
        master = purchaseInvoiceRepository.PrintPurchaseMasterView(Convert.ToInt64(id));
        TodoList = purchaseInvoiceRepository.PurchaseInvoiceView(Convert.ToInt64(id));
    }
    private void Print()
    {
        JsRuntime.InvokeVoidAsync("Print");
    }
    string convertImageToDisplay(byte[] image)
    {
        if (image != null)
        {
            var base64 = Convert.ToBase64String(image);
            var finalStr = string.Format("data:image/jpg;base64,{0}", base64);
            return finalStr;
        }
        return "";
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPurchaseReturn purchaseInvoiceRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany company { get; set; }
    }
}
#pragma warning restore 1591
