#pragma checksum "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "856bdafa37ae6e255285e11533f2205554f876db"
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
#line 5 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inventory/productstatics")]
    public partial class ProductStaticsReports : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddMarkupContent(2, @"<ol class=""breadcrumb""><li><a href=""/""><i class=""pe-7s-home""></i> Home</a></li>
                <li><a href=""/"">Inventory Report</a></li>
                <li class=""active"">Product Statics Reports</li></ol>
            
                    
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
#line 28 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
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
#line 30 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
                               foreach(var item in listProductGroup)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", 
#nullable restore
#line 32 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
                                                    item.groupId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 32 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
__builder.AddContent(25, item.groupName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 33 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
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
            __builder.AddMarkupContent(29, "<label class=\"col-sm-4\" for=\"product\">Batch</label>\r\n                            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-sm-8");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "text");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
                                                      batchNo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => batchNo = __value, batchNo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col-sm-7");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col-sm-6");
            __builder.AddMarkupContent(42, " \r\n                            Maximum Level\r\n                            ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "checkbox");
            __builder.AddAttribute(45, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
                                                          rbtnMaximumLevel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rbtnMaximumLevel = __value, rbtnMaximumLevel));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                            Minimum Level\r\n                            ");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "type", "checkbox");
            __builder.AddAttribute(50, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
                                                          rbtnMinimumLevel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rbtnMinimumLevel = __value, rbtnMinimumLevel));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                            Negative Stock\r\n                            ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "checkbox");
            __builder.AddAttribute(55, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
                                                          rbtnNegativeStock

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rbtnNegativeStock = __value, rbtnNegativeStock));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                            Reorder Level\r\n                            ");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "type", "checkbox");
            __builder.AddAttribute(60, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
                                                          rbtnReorderLevel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rbtnReorderLevel = __value, rbtnReorderLevel));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                            Unused\r\n                            ");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "checkbox");
            __builder.AddAttribute(65, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
                                                          rbtnUnused

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rbtnUnused = __value, rbtnUnused));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                            Fast Movings\r\n                            ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "type", "checkbox");
            __builder.AddAttribute(70, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
                                                          rbtnFastMovings

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rbtnFastMovings = __value, rbtnFastMovings));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                            Slow Movings\r\n                            ");
            __builder.OpenElement(73, "input");
            __builder.AddAttribute(74, "type", "checkbox");
            __builder.AddAttribute(75, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
                                                          rbtnSlowMovings

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rbtnSlowMovings = __value, rbtnSlowMovings));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                            ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "col-sm-2");
            __builder.OpenElement(80, "button");
            __builder.AddAttribute(81, "type", "button");
            __builder.AddAttribute(82, "class", "btn btn-success");
            __builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
                                                                                          Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(84, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.AddMarkupContent(86, "<a class=\"btn btn-warning\" onclick=\"printDiv(\'PrintDiv\')\">Print</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\r\n       \r\n\r\n        ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "row");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "col-sm-12");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "panel panel-bd lobidrag");
            __builder.AddMarkupContent(94, "<div class=\"panel-heading\"><div class=\"panel-title\"><span>Product Statics Reports</span></div></div>\r\n                    ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "panel-body");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "id", "PrintDiv");
            __builder.AddAttribute(99, "class", "table-responsive ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "paddin5ps");
            __builder.OpenElement(102, "table");
            __builder.AddAttribute(103, "class", "print-table");
            __builder.AddAttribute(104, "width", "100%");
            __builder.OpenElement(105, "tbody");
            __builder.OpenElement(106, "tr");
            __builder.OpenElement(107, "td");
            __builder.AddAttribute(108, "align", "left");
            __builder.AddAttribute(109, "class", "print-table-tr");
            __builder.OpenElement(110, "img");
            __builder.AddAttribute(111, "src", 
#nullable restore
#line 88 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
                                   convertImageToDisplay(company.LogoPath)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(112, "class", "companyimg");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                    ");
            __builder.OpenElement(114, "td");
            __builder.AddAttribute(115, "align", "center");
            __builder.AddAttribute(116, "class", "print-cominfo");
            __builder.OpenElement(117, "span");
            __builder.AddAttribute(118, "class", "company-txt");
#nullable restore
#line 92 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
__builder.AddContent(119, company.CompanyName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "<br>\r\n                        ");
#nullable restore
#line 94 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
__builder.AddContent(121, company.Address);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(122, "                        <br>\r\n                         ");
#nullable restore
#line 95 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
__builder.AddContent(123, company.Phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                   \r\n                     ");
            __builder.OpenElement(125, "td");
            __builder.AddAttribute(126, "align", "right");
            __builder.AddAttribute(127, "class", "print-table-tr");
            __builder.OpenElement(128, "date");
#nullable restore
#line 100 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
__builder.AddContent(129, DateTime.Now);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n\r\n                            ");
            __builder.OpenElement(131, "div");
            __builder.AddAttribute(132, "class", "table-responsive paddin5ps");
#nullable restore
#line 109 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
                                 if (final == null)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(133, "<div class=\"spinner\"></div>");
#nullable restore
#line 112 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
                                                                 
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(134, "table");
            __builder.AddAttribute(135, "class", "table table-striped");
            __builder.AddMarkupContent(136, @"<tr><th>S.No.</th>
                                        <th>Product Code</th>
                                        <th>Product Name</th>
                                        <th>Batch No</th>
                                        <th>Unit</th>
                                        <th>Rate</th>
                                        <th>Last Sales Rate</th>
                                        <th style>Current Stock</th></tr>");
#nullable restore
#line 128 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
                                      
                                        int sno = 0;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
                                     foreach (var item in final)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(137, "tr");
            __builder.OpenElement(138, "td");
#nullable restore
#line 135 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
                                                  sno++;

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
__builder.AddContent(139, sno);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n                                            ");
            __builder.OpenElement(141, "td");
#nullable restore
#line 138 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
__builder.AddContent(142, item.productCode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                                            ");
            __builder.OpenElement(144, "td");
#nullable restore
#line 139 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
__builder.AddContent(145, item.productName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n                                            ");
            __builder.OpenElement(147, "td");
#nullable restore
#line 140 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
__builder.AddContent(148, item.batchNo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n                                            ");
            __builder.OpenElement(150, "td");
#nullable restore
#line 141 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
__builder.AddContent(151, item.unitName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                                            ");
            __builder.OpenElement(153, "td");
#nullable restore
#line 142 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
__builder.AddContent(154, item.salesRate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n                                            ");
            __builder.OpenElement(156, "td");
#nullable restore
#line 143 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
__builder.AddContent(157, item.rate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n                                            ");
            __builder.OpenElement(159, "td");
#nullable restore
#line 144 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
__builder.AddContent(160, item.CurrentStock);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 146 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(161, "tfoot");
            __builder.OpenElement(162, "tr");
            __builder.AddMarkupContent(163, @"<td>Total</td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            ");
            __builder.OpenElement(164, "td");
#nullable restore
#line 155 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
__builder.AddContent(165, final.Sum(i => i.rate));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n                                            ");
            __builder.OpenElement(167, "td");
#nullable restore
#line 156 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
__builder.AddContent(168, final.Sum(i => i.CurrentStock));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 160 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
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
#line 168 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\ProductStaticsReports.razor"
       
    List<ProductGroupView> listProductGroup = new List<ProductGroupView>();
    List<InventoryViewFinl> final = new List<InventoryViewFinl>();
    string batchNo = string.Empty;
    long GroupId;
    bool rbtnMaximumLevel;
    bool rbtnMinimumLevel;
    bool rbtnNegativeStock;
    bool rbtnReorderLevel;
    bool rbtnUnused;
    bool rbtnFastMovings;
    bool rbtnSlowMovings;
    DateTime FromDate = DateTime.Now;
    DateTime ToDate = DateTime.Now;
    Company company = new Company();
    string myMarkup;
    protected async override void OnInitialized()
    {
        company = icompany.Edit(1);
        listProductGroup = group.ViewAllProductGroup();
    }
    protected void Search()
    {
                string strCriteria = string.Empty;
        if (rbtnMaximumLevel == true)
        {
            strCriteria = "Maximum Level";
        }
        if (rbtnMinimumLevel == true)
        {
            strCriteria = "Minimum Level";
        }
        if (rbtnNegativeStock == true)
        {
            strCriteria = "Negative Stock";
        }
        if (rbtnReorderLevel == true)
        {
            strCriteria = "Reorder Level";
        }
        if (rbtnUnused == true)
        {
            strCriteria = "UnUsed";
        }
        if (rbtnFastMovings == true)
        {
            strCriteria = "Fast Movings";
        }
        if (rbtnSlowMovings == true)
        {
            strCriteria = "Slow Movings";
        }
        final = report.ProductStatisticsFill(GroupId, strCriteria, batchNo, 1);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany icompany { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInventoryReport report { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductGroup group { get; set; }
    }
}
#pragma warning restore 1591