#pragma checksum "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cbd2d029e9cd13d45aa06c6c9799c01f0447013"
// <auto-generated/>
#pragma warning disable 1591
namespace Dreamer.Pages.InventoryReports
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
#line 6 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inventory/stockreports")]
    public partial class StockReports : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddMarkupContent(2, @"<ol class=""breadcrumb""><li><a href=""/""><i class=""pe-7s-home""></i> Home</a></li>
                <li><a href=""/"">Inventory Report</a></li>
                <li class=""active"">Stock Reports</li></ol>
            
                    
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
            __builder.AddMarkupContent(13, "<label class=\"col-sm-4\" for=\"product\">Product Group</label>\r\n                            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-sm-8");
            __builder.OpenElement(16, "select");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
                                                                GroupId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GroupId = __value, GroupId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", "0");
            __builder.AddContent(22, "Choose ProductGroup");
            __builder.CloseElement();
#nullable restore
#line 31 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
                               foreach(var item in listProductGroup)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", 
#nullable restore
#line 33 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
                                                    item.groupId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 33 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(25, item.groupName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 34 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
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
            __builder.AddMarkupContent(29, "<label class=\"col-sm-4\" for=\"product\">Product</label>\r\n                            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-sm-8");
            __builder.OpenElement(32, "select");
            __builder.AddAttribute(33, "class", "form-control");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
                                                                ProductId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ProductId = __value, ProductId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(36, "option");
            __builder.AddAttribute(37, "value", "0");
            __builder.AddContent(38, "Choose Product");
            __builder.CloseElement();
#nullable restore
#line 44 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
                               foreach(var item in listProduct)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", 
#nullable restore
#line 46 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
                                                    item.ProductId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 46 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(41, item.ProductName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 47 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-sm-2");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "btn btn-success");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
                                                                                          Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.AddMarkupContent(51, "<a class=\"btn btn-warning\" onclick=\"printDiv(\'PrintDiv\')\">Print</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n       \r\n\r\n        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "row");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "col-sm-12");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "panel panel-bd lobidrag");
            __builder.AddMarkupContent(59, "<div class=\"panel-heading\"><div class=\"panel-title\"><span>Stock Reports</span></div></div>\r\n                    ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "panel-body");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "id", "PrintDiv");
            __builder.AddAttribute(64, "class", "table-responsive ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "paddin5ps");
            __builder.OpenElement(67, "table");
            __builder.AddAttribute(68, "class", "print-table");
            __builder.AddAttribute(69, "width", "100%");
            __builder.OpenElement(70, "tbody");
            __builder.OpenElement(71, "tr");
            __builder.OpenElement(72, "td");
            __builder.AddAttribute(73, "align", "left");
            __builder.AddAttribute(74, "class", "print-table-tr");
            __builder.OpenElement(75, "img");
            __builder.AddAttribute(76, "src", 
#nullable restore
#line 77 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
                                   convertImageToDisplay(company.LogoPath)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(77, "class", "companyimg");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                    ");
            __builder.OpenElement(79, "td");
            __builder.AddAttribute(80, "align", "center");
            __builder.AddAttribute(81, "class", "print-cominfo");
            __builder.OpenElement(82, "span");
            __builder.AddAttribute(83, "class", "company-txt");
#nullable restore
#line 81 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(84, company.CompanyName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "<br>\r\n                        ");
#nullable restore
#line 83 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(86, company.Address);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(87, "                        <br>\r\n                         ");
#nullable restore
#line 84 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(88, company.Phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                   \r\n                     ");
            __builder.OpenElement(90, "td");
            __builder.AddAttribute(91, "align", "right");
            __builder.AddAttribute(92, "class", "print-table-tr");
            __builder.OpenElement(93, "date");
#nullable restore
#line 89 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(94, DateTime.Now);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n\r\n                            ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "table-responsive paddin5ps");
#nullable restore
#line 98 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
                                 if (final == null)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(98, "<div class=\"spinner\"></div>");
#nullable restore
#line 101 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
                                                                 
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(99, "table");
            __builder.AddAttribute(100, "class", "table table-striped");
            __builder.AddMarkupContent(101, @"<tr><th>S.No.</th>
                                        <th>Product Code</th>
                                        <th>Product Name</th>
                                        <th>Unit</th>
                                        <th>Pur Rate</th>
                                        <th>Pur Qty</th>
                                        <th>Balance</th>
                                        <th style>Sales Rate</th>
                                        <th>Sales Qty</th>
                                        <th>Balance</th>
                                        <th>Stock Qty</th>
                                        <th>Stock Amount</th></tr>");
#nullable restore
#line 121 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
                                      
                                        int sno = 0;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
                                     foreach (var item in final)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(102, "tr");
            __builder.OpenElement(103, "td");
#nullable restore
#line 128 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
                                                  sno++;

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(104, sno);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                                            ");
            __builder.OpenElement(106, "td");
#nullable restore
#line 131 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(107, item.productCode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                                            ");
            __builder.OpenElement(109, "td");
#nullable restore
#line 132 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(110, item.productName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                                            ");
            __builder.OpenElement(112, "td");
#nullable restore
#line 133 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(113, item.unitName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                                            ");
            __builder.OpenElement(115, "td");
#nullable restore
#line 134 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(116, item.rate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                                            ");
            __builder.OpenElement(118, "td");
#nullable restore
#line 135 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(119, item.purQty);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                                            ");
            __builder.OpenElement(121, "td");
#nullable restore
#line 136 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(122, item.PurchaseStockBal);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                                            ");
            __builder.OpenElement(124, "td");
#nullable restore
#line 137 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(125, item.salesRate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                                            ");
            __builder.OpenElement(127, "td");
#nullable restore
#line 138 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(128, item.SalesQty);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                                            ");
            __builder.OpenElement(130, "td");
#nullable restore
#line 139 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(131, item.SalesStockBalance);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                                            ");
            __builder.OpenElement(133, "td");
#nullable restore
#line 140 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(134, item.Stock);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                                            ");
            __builder.OpenElement(136, "td");
#nullable restore
#line 141 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(137, item.stockvalue);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 143 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(138, "tfoot");
            __builder.OpenElement(139, "tr");
            __builder.AddMarkupContent(140, "<td></td>\r\n                                            ");
            __builder.AddMarkupContent(141, @"<td>Total</td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            ");
            __builder.OpenElement(142, "td");
#nullable restore
#line 156 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(143, final.Sum(i => i.Stock));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                                            ");
            __builder.OpenElement(145, "td");
#nullable restore
#line 157 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
__builder.AddContent(146, final.Sum(i => i.stockvalue));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 161 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
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
#line 169 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\StockReports.razor"
       
    List<ProductGroupView> listProductGroup = new List<ProductGroupView>();
    List<ProductView> listProduct = new List<ProductView>();
    List<InventoryViewFinl> final = new List<InventoryViewFinl>();
    long GroupId = 0;
    long ProductId = 0;
    DateTime FromDate = DateTime.Now;
    DateTime ToDate = DateTime.Now;
    Company company = new Company();
    string myMarkup;
    protected async override void OnInitialized()
    {
        company = icompany.Edit(1);
        listProductGroup = group.ViewAllProductGroup();
        listProduct = product.ViewAllProduct(1);
    }
    protected void Search()
    {
                final = report.StockReport(GroupId, ProductId, 1);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProduct product { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany icompany { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInventoryReport report { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductGroup group { get; set; }
    }
}
#pragma warning restore 1591
