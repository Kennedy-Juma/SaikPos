#pragma checksum "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66bfc7537fe3dbe94eaa76e91ab727c19a361ead"
// <auto-generated/>
#pragma warning disable 1591
namespace SaikPOS.Pages.InventoryReports
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
#line 6 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/inventory/customersalescount")]
    public partial class CustomersalesCount : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddMarkupContent(2, @"<ol class=""breadcrumb""><li><a href=""/""><i class=""pe-7s-home""></i> Home</a></li>
                <li><a href=""/"">Inventory Report</a></li>
                <li class=""active"">Customer Sales Count</li></ol>
            
                    
                                        <div class=""se-pre-con"" style=""display: none;""></div>
                    
                    
                     ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-12");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "panel panel-default");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "panel-body");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-sm-3");
            __builder.AddMarkupContent(13, "<label class=\"col-sm-4\" for=\"product\">Customer</label>\r\n                            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-sm-8");
            __builder.OpenElement(16, "select");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                                                                LedgerId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => LedgerId = __value, LedgerId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", "0");
            __builder.AddContent(22, "Choose Customer");
            __builder.CloseElement();
#nullable restore
#line 31 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                               foreach(var item in listCustomer)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", 
#nullable restore
#line 33 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                                                    item.LedgerId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 33 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
__builder.AddContent(25, item.LedgerName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 34 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-sm-3");
            __builder.AddMarkupContent(29, "<label class=\"col-sm-4\" for=\"product\">Voucher Type</label>\r\n                            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-sm-8");
            __builder.OpenElement(32, "select");
            __builder.AddAttribute(33, "class", "form-control");
            __builder.AddAttribute(34, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                                                                VoucherTypeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => VoucherTypeId = __value, VoucherTypeId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(36, "option");
            __builder.AddAttribute(37, "value", "0");
            __builder.AddContent(38, "Choose VoucherType");
            __builder.CloseElement();
#nullable restore
#line 44 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                               foreach(var item in listVoucherType)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", 
#nullable restore
#line 46 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                                                    item.VoucherTypeId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 46 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
__builder.AddContent(41, item.VoucherTypeName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 47 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-sm-7");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-sm-6");
            __builder.AddMarkupContent(47, "<label class=\"col-sm-4\" for=\"from_date\">Start Date</label>\r\n                            ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-sm-8");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "type", "date");
            __builder.AddAttribute(52, "class", "form-control datepicker hasDatepicker");
            __builder.AddAttribute(53, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                                                                                                    FromDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(54, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FromDate = __value, FromDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "col-sm-6");
            __builder.AddMarkupContent(58, "<label class=\"col-sm-4\" for=\"to_date\">End Date</label>\r\n                            ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-sm-8");
            __builder.OpenElement(61, "input");
            __builder.AddAttribute(62, "type", "date");
            __builder.AddAttribute(63, "class", "form-control datepicker hasDatepicker");
            __builder.AddAttribute(64, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                                                                                                    ToDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(65, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ToDate = __value, ToDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                            ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "col-sm-2");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "type", "button");
            __builder.AddAttribute(71, "class", "btn btn-success");
            __builder.AddAttribute(72, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                                                                                          Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(73, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.AddMarkupContent(75, "<a class=\"btn btn-warning\" onclick=\"printDiv(\'PrintDiv\')\">Print</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n       \r\n\r\n        ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "row");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "col-sm-12");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "panel panel-bd lobidrag");
            __builder.AddMarkupContent(83, "<div class=\"panel-heading\"><div class=\"panel-title\"><span>Customer Sales Count</span></div></div>\r\n                    ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "panel-body");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "id", "PrintDiv");
            __builder.AddAttribute(88, "class", "table-responsive ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "paddin5ps");
            __builder.OpenElement(91, "table");
            __builder.AddAttribute(92, "class", "print-table");
            __builder.AddAttribute(93, "width", "100%");
            __builder.OpenElement(94, "tbody");
            __builder.OpenElement(95, "tr");
            __builder.OpenElement(96, "td");
            __builder.AddAttribute(97, "align", "left");
            __builder.AddAttribute(98, "class", "print-table-tr");
            __builder.OpenElement(99, "img");
            __builder.AddAttribute(100, "src", 
#nullable restore
#line 93 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                                   convertImageToDisplay(company.LogoPath)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(101, "class", "companyimg");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                    ");
            __builder.OpenElement(103, "td");
            __builder.AddAttribute(104, "align", "center");
            __builder.AddAttribute(105, "class", "print-cominfo");
            __builder.OpenElement(106, "span");
            __builder.AddAttribute(107, "class", "company-txt");
#nullable restore
#line 97 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
__builder.AddContent(108, company.CompanyName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "<br>\r\n                        ");
#nullable restore
#line 99 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
__builder.AddContent(110, company.Address);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(111, "                        <br>\r\n                         ");
#nullable restore
#line 100 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
__builder.AddContent(112, company.Phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                   \r\n                     ");
            __builder.OpenElement(114, "td");
            __builder.AddAttribute(115, "align", "right");
            __builder.AddAttribute(116, "class", "print-table-tr");
            __builder.OpenElement(117, "date");
#nullable restore
#line 105 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
__builder.AddContent(118, DateTime.Now);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n\r\n                            ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "table-responsive paddin5ps");
#nullable restore
#line 114 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                                 if (final == null)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(122, "<div class=\"spinner\"></div>");
#nullable restore
#line 117 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                                                                 
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(123, "table");
            __builder.AddAttribute(124, "id", "myTable");
            __builder.AddAttribute(125, "class", "table table-striped");
            __builder.AddMarkupContent(126, @"<tr><th>S.No.</th>
                                        <th style>Customer Name</th>
                                        <th style>Voucher Type</th>
                                        <th>Total Sales (Count)</th>
                                        <th>Grand Total</th></tr>");
#nullable restore
#line 130 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                                      
                                        int sno = 0;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                                     foreach (var item in final)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(127, "tr");
            __builder.OpenElement(128, "td");
#nullable restore
#line 137 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                                                  sno++;

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
__builder.AddContent(129, sno);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                                            ");
            __builder.OpenElement(131, "td");
#nullable restore
#line 140 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
__builder.AddContent(132, item.LedgerName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                                            ");
            __builder.OpenElement(134, "td");
#nullable restore
#line 141 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
__builder.AddContent(135, item.VoucherTypeName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                                            ");
            __builder.OpenElement(137, "td");
#nullable restore
#line 142 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
__builder.AddContent(138, item.TotalSales);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                                            ");
            __builder.OpenElement(140, "td");
#nullable restore
#line 143 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
__builder.AddContent(141, item.GrandTotal);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 145 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(142, "tfoot");
            __builder.OpenElement(143, "tr");
            __builder.AddMarkupContent(144, "<td>Total</td>\r\n                                            <td></td>\r\n                                            <td></td>\r\n                                            ");
            __builder.OpenElement(145, "td");
#nullable restore
#line 151 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
__builder.AddContent(146, final.Sum(i => i.TotalSales));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n                                            ");
            __builder.OpenElement(148, "td");
#nullable restore
#line 152 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
__builder.AddContent(149, final.Sum(i => i.GrandTotal));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 156 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 164 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\CustomersalesCount.razor"
       
    List<AccountLedgerView> listCustomer = new List<AccountLedgerView>();
    List<VoucherType> listVoucherType = new List<VoucherType>();
    List<PurchaseSales> final = new List<PurchaseSales>();
    long LedgerId = 0;
    long VoucherTypeId = 0;
    DateTime FromDate = DateTime.Now;
    DateTime ToDate = DateTime.Now;
    Company company = new Company();
    string myMarkup;
    protected async override void OnInitialized()
    {
        company = icompany.Edit(1);
        listCustomer = ledger.ViewAllCustomer(1);
        listVoucherType = voucherType.GetVoucherType();
    }
    protected void Search()
    {
                final = report.CustomerCountSales(Convert.ToDateTime(FromDate), Convert.ToDateTime(ToDate), LedgerId, VoucherTypeId);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVoucherType voucherType { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany icompany { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInventoryReport report { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountLedger ledger { get; set; }
    }
}
#pragma warning restore 1591