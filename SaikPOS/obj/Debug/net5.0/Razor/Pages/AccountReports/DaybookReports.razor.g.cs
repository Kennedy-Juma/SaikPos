#pragma checksum "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountReports\DaybookReports.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5db6530e9edaef692b586cb99f4b7887f58d2ab1"
// <auto-generated/>
#pragma warning disable 1591
namespace SaikPOS.Pages.AccountReports
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
#line 6 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountReports\DaybookReports.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/account/daybook")]
    public partial class DaybookReports : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddMarkupContent(2, @"<ol class=""breadcrumb""><li><a href=""/""><i class=""pe-7s-home""></i> Home</a></li>
                <li><a href=""/"">Account Report</a></li>
                <li class=""active"">DayBook Reports</li></ol>
            
                    
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
            __builder.AddMarkupContent(13, "<label class=\"col-sm-4\" for=\"product\">Account Ledger</label>\r\n                            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-sm-8");
            __builder.OpenElement(16, "select");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountReports\DaybookReports.razor"
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
#line 31 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountReports\DaybookReports.razor"
                               foreach(var item in listCustomer)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", 
#nullable restore
#line 33 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountReports\DaybookReports.razor"
                                                    item.LedgerId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 33 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountReports\DaybookReports.razor"
__builder.AddContent(25, item.LedgerName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 34 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountReports\DaybookReports.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-sm-7");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-sm-6");
            __builder.AddMarkupContent(31, "<label class=\"col-sm-4\" for=\"from_date\">Start Date</label>\r\n                            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-sm-8");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "date");
            __builder.AddAttribute(36, "class", "form-control datepicker hasDatepicker");
            __builder.AddAttribute(37, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountReports\DaybookReports.razor"
                                                                                                    FromDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(38, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FromDate = __value, FromDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col-sm-6");
            __builder.AddMarkupContent(42, "<label class=\"col-sm-4\" for=\"to_date\">End Date</label>\r\n                            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-sm-8");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "date");
            __builder.AddAttribute(47, "class", "form-control datepicker hasDatepicker");
            __builder.AddAttribute(48, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountReports\DaybookReports.razor"
                                                                                                    ToDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(49, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ToDate = __value, ToDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                            ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "col-sm-2");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "type", "button");
            __builder.AddAttribute(55, "class", "btn btn-success");
            __builder.AddAttribute(56, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountReports\DaybookReports.razor"
                                                                                          Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(57, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.AddMarkupContent(59, "<a class=\"btn btn-warning\" onclick=\"printDiv(\'PrintDiv\')\">Print</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n       \r\n\r\n        ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "row");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "col-sm-12");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "panel panel-bd lobidrag");
            __builder.AddMarkupContent(67, "<div class=\"panel-heading\"><div class=\"panel-title\"><span>DayBook Reports</span></div></div>\r\n                    ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "panel-body");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "id", "PrintDiv");
            __builder.AddAttribute(72, "class", "table-responsive ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "paddin5ps");
            __builder.OpenElement(75, "table");
            __builder.AddAttribute(76, "class", "print-table");
            __builder.AddAttribute(77, "width", "100%");
            __builder.OpenElement(78, "tbody");
            __builder.OpenElement(79, "tr");
            __builder.OpenElement(80, "td");
            __builder.AddAttribute(81, "align", "left");
            __builder.AddAttribute(82, "class", "print-table-tr");
            __builder.OpenElement(83, "img");
            __builder.AddAttribute(84, "src", 
#nullable restore
#line 80 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountReports\DaybookReports.razor"
                                   convertImageToDisplay(company.LogoPath)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(85, "class", "companyimg");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                    ");
            __builder.OpenElement(87, "td");
            __builder.AddAttribute(88, "align", "center");
            __builder.AddAttribute(89, "class", "print-cominfo");
            __builder.OpenElement(90, "span");
            __builder.AddAttribute(91, "class", "company-txt");
#nullable restore
#line 84 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountReports\DaybookReports.razor"
__builder.AddContent(92, company.CompanyName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "<br>\r\n                        ");
#nullable restore
#line 86 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountReports\DaybookReports.razor"
__builder.AddContent(94, company.Address);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(95, "                        <br>\r\n                         ");
#nullable restore
#line 87 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountReports\DaybookReports.razor"
__builder.AddContent(96, company.Phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                   \r\n                     ");
            __builder.OpenElement(98, "td");
            __builder.AddAttribute(99, "align", "right");
            __builder.AddAttribute(100, "class", "print-table-tr");
            __builder.OpenElement(101, "date");
#nullable restore
#line 92 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountReports\DaybookReports.razor"
__builder.AddContent(102, DateTime.Now);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n\r\n                            ");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "table-responsive paddin5ps");
#nullable restore
#line 101 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountReports\DaybookReports.razor"
__builder.AddContent(106, (MarkupString)myMarkup);

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
#line 109 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\AccountReports\DaybookReports.razor"
       
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
        listCustomer = ledger.GetAll(1);
    }
    protected void Search()
    {
                string values = @"<table id='table' class='table table-striped'>
                        <tr>
                            <th style=''></th>
                            <th></th>
                            <th></th>
                            <th></th>
                            <th></th>
                            <th></th>
                            <th></th>
                        </tr> ";

        values += @"<tr>
<th>" + "S.No" + @"</th>
<th>" + "Date" + @"</th>
<th>" + "Voucher Type" + @"</th>
<th>" + "Voucher No" + @"</th>
<th>" + "Ledger Name" + @"</th>
<th>" + "Debit" + @"</th>
<th>" + "Credit" + @"</th>
            </tr>";

        decimal totlDebit = 0;
        decimal totlCredit = 0;
        decimal decInwrd = 0;
        decimal decOutWrd = 0;

        DataTable dtblsub = new DataTable();
        DataSet dset = new DataSet();
        dset = report.DayBook(Convert.ToDateTime(FromDate), Convert.ToDateTime(ToDate), VoucherTypeId, LedgerId);
        int counter = 0;
        dtblsub = dset.Tables[0];
        string strBalance = string.Empty;


        if (dtblsub.Rows.Count > 0)
        {
            for (int i = 0; i < dtblsub.Rows.Count; i++)
            {
                counter++;
                totlDebit = totlDebit + decimal.Parse(dtblsub.Rows[i]["debit"].ToString());
                totlCredit = totlCredit + decimal.Parse(dtblsub.Rows[i]["credit"].ToString());
                decInwrd = decInwrd + decimal.Parse(dtblsub.Rows[i]["InwardQty"].ToString());
                decOutWrd = decOutWrd + decimal.Parse(dtblsub.Rows[i]["OutwardQty"].ToString());
                values += @"<tr>
                    <td style=''>" + counter.ToString() + @"</td>
                    <td style='font-family:Segoe UI;'>" + dtblsub.Rows[i]["Date"].ToString() + @"</td>
                    <td style=''> " + dtblsub.Rows[i]["VoucherType"].ToString() + @"</td>
                    <td>" + dtblsub.Rows[i]["voucherNo"].ToString() + @" </td>
<td>" + dtblsub.Rows[i]["Ledger"].ToString() + @" </td>
                    <td> " + dtblsub.Rows[i]["debit"].ToString() + @"</td>
                    <td> " + dtblsub.Rows[i]["credit"].ToString() + @"</td>
                </tr>";


            }
        }
        decimal decTotlDebitss = totlDebit;
        decimal decTotlCreditss = totlCredit;
        decimal decBlnce = decTotlDebitss - decTotlCreditss;
        values += @"<tr>
<td style=''></td>
<td></td>
<td style=''>Total</td>
<td>" + "" + @"</td>
<td>" + "" + @"</td>
<td style='font-style:bold; color:black; font-size:12px;'>" + decTotlDebitss + @"</td>
<td style='font-style:bold; color:black; font-size:12px;'>" + decTotlCreditss + @"</td>
</tr>";
        values += "</table>";
        myMarkup = values;
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