#pragma checksum "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c525b5ed91e99c58d8163e49cd4e791e744f4be7"
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
#line 6 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
using NPOI.SS.UserModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
using NPOI.XSSF.UserModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/inventory/purchasereports")]
    public partial class PurchaseReports : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddMarkupContent(2, @"<ol class=""breadcrumb""><li><a href=""/""><i class=""pe-7s-home""></i> Home</a></li>
                <li><a href=""/"">Inventory Report</a></li>
                <li class=""active"">Purchase Reports</li></ol>
            
                    
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
            __builder.AddMarkupContent(13, "<label class=\"col-sm-4\" for=\"product\">Supplier</label>\r\n                            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-sm-8");
            __builder.OpenElement(16, "select");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
                                                                LedgerId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => LedgerId = __value, LedgerId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", "0");
            __builder.AddContent(22, "Choose Supplier");
            __builder.CloseElement();
#nullable restore
#line 34 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
                               foreach(var item in listCustomer)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", 
#nullable restore
#line 36 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
                                                    item.LedgerId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 36 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
__builder.AddContent(25, item.LedgerName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 37 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
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
#line 45 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
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
#line 47 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
                               foreach(var item in listVoucherType)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", 
#nullable restore
#line 49 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
                                                    item.VoucherTypeId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 49 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
__builder.AddContent(41, item.VoucherTypeName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 50 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
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
#line 58 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
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
#line 65 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
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
#line 71 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
                                                                                          Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(73, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                                  ");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "type", "button");
            __builder.AddAttribute(77, "class", "btn btn-info");
            __builder.AddAttribute(78, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
                                                                                       (() =>GenerateExcel())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(79, "Excel");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                        ");
            __builder.AddMarkupContent(81, "<a class=\"btn btn-warning\" onclick=\"printDiv(\'PrintDiv\')\">Print</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n\r\n       \r\n\r\n        ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "row");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "col-sm-12");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "panel panel-bd lobidrag");
            __builder.AddMarkupContent(89, "<div class=\"panel-heading\"><div class=\"panel-title\"><span>Purchase Reports</span></div></div>\r\n                    ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "panel-body");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "id", "PrintDiv");
            __builder.AddAttribute(94, "class", "table-responsive ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "paddin5ps");
            __builder.OpenElement(97, "table");
            __builder.AddAttribute(98, "class", "print-table");
            __builder.AddAttribute(99, "width", "100%");
            __builder.OpenElement(100, "tbody");
            __builder.OpenElement(101, "tr");
            __builder.OpenElement(102, "td");
            __builder.AddAttribute(103, "align", "left");
            __builder.AddAttribute(104, "class", "print-table-tr");
            __builder.OpenElement(105, "img");
            __builder.AddAttribute(106, "src", 
#nullable restore
#line 97 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
                                   convertImageToDisplay(company.LogoPath)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(107, "class", "companyimg");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                    ");
            __builder.OpenElement(109, "td");
            __builder.AddAttribute(110, "align", "center");
            __builder.AddAttribute(111, "class", "print-cominfo");
            __builder.OpenElement(112, "span");
            __builder.AddAttribute(113, "class", "company-txt");
#nullable restore
#line 101 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
__builder.AddContent(114, company.CompanyName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "<br>\r\n                        ");
#nullable restore
#line 103 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
__builder.AddContent(116, company.Address);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(117, "                        <br>\r\n                         ");
#nullable restore
#line 104 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
__builder.AddContent(118, company.Phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                   \r\n                     ");
            __builder.OpenElement(120, "td");
            __builder.AddAttribute(121, "align", "right");
            __builder.AddAttribute(122, "class", "print-table-tr");
            __builder.OpenElement(123, "date");
#nullable restore
#line 109 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
__builder.AddContent(124, DateTime.Now);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n\r\n                            ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "table-responsive paddin5ps");
#nullable restore
#line 118 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
                                 if (final == null)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(128, "<div class=\"spinner\"></div>");
#nullable restore
#line 121 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
                                                                 
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(129, "table");
            __builder.AddAttribute(130, "class", "table table-striped");
            __builder.AddMarkupContent(131, @"<tr><th>S.No.</th>
                                        <th style>Date</th>
                                        <th style>Supplier Name</th>
                                        <th style>Voucher Type</th>
                                        <th>Total Amount</th>
                                        <th>User</th>
                                        <th>Narration</th></tr>");
#nullable restore
#line 136 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
                                      
                                        int sno = 0;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
                                     foreach (var item in final)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(132, "tr");
            __builder.OpenElement(133, "td");
#nullable restore
#line 143 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
                                                  sno++;

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
__builder.AddContent(134, sno);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                                            ");
            __builder.OpenElement(136, "td");
#nullable restore
#line 146 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
__builder.AddContent(137, item.Date);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                                            ");
            __builder.OpenElement(139, "td");
#nullable restore
#line 147 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
__builder.AddContent(140, item.LedgerName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                                            ");
            __builder.OpenElement(142, "td");
#nullable restore
#line 148 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
__builder.AddContent(143, item.VoucherTypeName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                                            ");
            __builder.OpenElement(145, "td");
#nullable restore
#line 149 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
__builder.AddContent(146, item.GrandTotal);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n                                            ");
            __builder.OpenElement(148, "td");
#nullable restore
#line 150 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
__builder.AddContent(149, item.UserId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                                            ");
            __builder.OpenElement(151, "td");
#nullable restore
#line 151 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
__builder.AddContent(152, item.Narration);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 153 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(153, "tfoot");
            __builder.OpenElement(154, "tr");
            __builder.AddMarkupContent(155, "<td>Total</td>\r\n                                            <td></td>\r\n                                            <td></td>\r\n                                            <td></td>\r\n                                            ");
            __builder.OpenElement(156, "td");
#nullable restore
#line 160 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
__builder.AddContent(157, final.Sum(i => i.GrandTotal));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 164 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
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
#line 172 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\InventoryReports\PurchaseReports.razor"
       
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
                final = report.PurchaseRepports(Convert.ToDateTime(FromDate), Convert.ToDateTime(ToDate), LedgerId, VoucherTypeId);
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
    protected async Task GenerateExcel()
    {
        IWorkbook workbook = new XSSFWorkbook();
        var dataFormat = workbook.CreateDataFormat();
        var dataStyle = workbook.CreateCellStyle();
        dataStyle.DataFormat = dataFormat.GetFormat("MM/yy/dddd HH:mm:ss");
        ISheet worksheet = workbook.CreateSheet("Sheet1");



        int rowNumber1 = 0;
        IRow row1 = worksheet.CreateRow(rowNumber1++);
        //TbleHeder
        ICell cell1 = row1.CreateCell(3);
        cell1.SetCellValue("PurchaseReport");

        int rowNumber = 1;
        IRow row = worksheet.CreateRow(rowNumber++);
        //TbleHeder
        ICell cell = row.CreateCell(0);
        cell.SetCellValue("Date");

        cell = row.CreateCell(1);
        cell.SetCellValue("Supplier Name");

        cell = row.CreateCell(2);
        cell.SetCellValue("VoucherType");

        cell = row.CreateCell(3);
        cell.SetCellValue("GrandTotal");

        cell = row.CreateCell(4);
        cell.SetCellValue("User");

        cell = row.CreateCell(5);
        cell.SetCellValue("Narration");



        //Tble Body
        foreach (var objDue in final)
        {
            row = worksheet.CreateRow(rowNumber++);

            cell = row.CreateCell(0);
            cell.SetCellValue(objDue.Date);

            cell = row.CreateCell(1);
            cell.SetCellValue(objDue.LedgerName);

            cell = row.CreateCell(2);
            cell.SetCellValue(objDue.VoucherTypeName);

            cell = row.CreateCell(3);
            cell.SetCellValue(objDue.GrandTotal.ToString());

            cell = row.CreateCell(4);
            cell.SetCellValue(objDue.UserId.ToString());

            cell = row.CreateCell(5);
            cell.SetCellValue(objDue.Narration.ToString());


        }
        MemoryStream ms = new MemoryStream();
        workbook.Write(ms);
        byte[] bytes = ms.ToArray();
        ms.Close();

        await JsRuntime.SaveAsFileAsync("PurchaseReport", bytes, "application/vnd.ms-excel");
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