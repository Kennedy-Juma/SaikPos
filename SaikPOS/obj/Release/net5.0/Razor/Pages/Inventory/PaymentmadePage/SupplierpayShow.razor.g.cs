#pragma checksum "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PaymentmadePage\SupplierpayShow.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "883d710ec558da3c07fbb8bff41bb8c2f523c8a8"
// <auto-generated/>
#pragma warning disable 1591
namespace Dreamer.Pages.Inventory.PaymentmadePage
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/purchase/supplierpayshow/{id}")]
    public partial class SupplierpayShow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddMarkupContent(2, @"<ol class=""breadcrumb""><li><a href=""#""><i class=""pe-7s-home""></i> Home</a></li>
                <li><a href=""#"">purchase</a></li>
                <li class=""active"">Purchase Details</li></ol>
            
                    
                                        <div class=""se-pre-con"" style=""display: none;""></div>
                    
                    
		");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-12");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "panel panel-bd lobidrag");
            __builder.AddMarkupContent(9, @"<div class=""panel-heading""><div class=""panel-title""><span>Purchase Details</span>
							<span class=""print-button""><a onclick=""printDiv('PrintDiv')"" class=""btn btn-warning""><i class=""fa fa-print""></i> 
            Print
          </a>
          <a href target=""_blank"" class=""btn btn-primary""><i class=""fa fa-credit-card""></i> 
            Email
          </a>
          <a href=""/"" class=""btn btn-danger""><i class=""fa  fa-undo""></i> Back to list
          </a></span></div></div>
		            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "panel-body");
            __builder.AddAttribute(12, "id", "PrintDiv");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row purchasedetails-header");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-sm-7 purchasedetails-address");
            __builder.AddMarkupContent(17, "<img src=\"img/logo.png\" class alt height=\"70\" width=\"80\">\r\n                                    <br>  <br>\r\n                                      \r\n                                    ");
            __builder.AddMarkupContent(18, "<span class=\"label label-success-outline m-r-15 p-10\">Billing From</span>\r\n                                    ");
            __builder.OpenElement(19, "address");
            __builder.OpenElement(20, "strong");
            __builder.AddAttribute(21, "class", "companyname");
#nullable restore
#line 57 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PaymentmadePage\SupplierpayShow.razor"
__builder.AddContent(22, companyName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "<br>\r\n                                        ");
#nullable restore
#line 58 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PaymentmadePage\SupplierpayShow.razor"
__builder.AddContent(24, address);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "<br>\r\n                                        ");
            __builder.AddMarkupContent(26, "<abbr><b>Mobile:</b></abbr>");
#nullable restore
#line 59 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PaymentmadePage\SupplierpayShow.razor"
__builder.AddContent(27, phone);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, " <br>\r\n                                        ");
            __builder.AddMarkupContent(29, "<abbr><b>Email:</b></abbr> \r\n                                       dreamerapps@gmail.com <br>\r\n                                        ");
            __builder.AddMarkupContent(30, "<abbr><b>Website:</b></abbr> \r\n                                       dreamerapps.com<br>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                \r\n                                 \r\n                                ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-sm-4 text-left invoice-details-billing");
            __builder.OpenElement(34, "h2");
            __builder.AddAttribute(35, "class", "m-t-0");
#nullable restore
#line 73 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PaymentmadePage\SupplierpayShow.razor"
__builder.AddContent(36, billtype);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                                    ");
            __builder.OpenElement(38, "div");
            __builder.AddContent(39, "Voucher No: ");
#nullable restore
#line 74 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PaymentmadePage\SupplierpayShow.razor"
__builder.AddContent(40, master.VoucherNo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                                    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "m-b-15");
            __builder.AddContent(44, "Billing Date: ");
#nullable restore
#line 75 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PaymentmadePage\SupplierpayShow.razor"
__builder.AddContent(45, master.Date);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                                    ");
            __builder.OpenElement(47, "div");
            __builder.AddContent(48, "Cash: ");
#nullable restore
#line 76 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PaymentmadePage\SupplierpayShow.razor"
__builder.AddContent(49, master.CashAmount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                                    ");
            __builder.OpenElement(51, "div");
            __builder.AddContent(52, "Bank: ");
#nullable restore
#line 77 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PaymentmadePage\SupplierpayShow.razor"
__builder.AddContent(53, master.BankAmount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                    ");
            __builder.OpenElement(55, "div");
            __builder.AddContent(56, "Due: ");
#nullable restore
#line 78 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PaymentmadePage\SupplierpayShow.razor"
__builder.AddContent(57, master.CreditAmount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n                                    ");
            __builder.AddMarkupContent(59, "<span class=\"label label-success-outline m-r-15\">Billing To</span>\r\n\r\n                                    ");
            __builder.OpenElement(60, "address");
            __builder.AddAttribute(61, "class", "details-address");
            __builder.OpenElement(62, "strong");
            __builder.AddAttribute(63, "class", "companyname");
#nullable restore
#line 83 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PaymentmadePage\SupplierpayShow.razor"
__builder.AddContent(64, master.LedgerName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "<br>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, " \r\n\r\n                          <br>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PaymentmadePage\SupplierpayShow.razor"
       
    [Parameter]
    public string id { get; set; }
    PaymentSupplierView master = new PaymentSupplierView();
    string companyName;
    string address;
    string phone;
    string billtype;
    protected async override void OnInitialized()
    {
        var resultCompany = icompany.Edit(1);
        companyName = resultCompany.CompanyName;
        address = resultCompany.Address;
        phone = resultCompany.Phone;
        billtype = "Payment Out";
        master = _payment.PaymentSupplierView(Convert.ToInt64(id));
        StateHasChanged();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPaymentSupplier _payment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPurchaseInvoice purchaseInvoiceRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany icompany { get; set; }
    }
}
#pragma warning restore 1591