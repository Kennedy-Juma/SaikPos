#pragma checksum "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\CustomerLedger.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dda2b0bdff3b14578c4281dfc54396a07678df54"
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
#line 5 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\CustomerLedger.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inventory/customerledger")]
    public partial class CustomerLedger : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddMarkupContent(2, @"<ol class=""breadcrumb""><li><a href=""/""><i class=""pe-7s-home""></i> Home</a></li>
                <li><a href=""/"">Inventory Report</a></li>
                <li class=""active"">Customer Ledger</li></ol>
            
                    
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
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\CustomerLedger.razor"
                                                                LedgerId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => LedgerId = __value, LedgerId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", "0");
            __builder.AddContent(22, "Choose Customer");
            __builder.CloseElement();
#nullable restore
#line 34 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\CustomerLedger.razor"
                               foreach(var item in listCustomer)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", 
#nullable restore
#line 36 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\CustomerLedger.razor"
                                                    item.LedgerId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 36 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\CustomerLedger.razor"
__builder.AddContent(25, item.LedgerName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 37 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\CustomerLedger.razor"
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
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\CustomerLedger.razor"
                                                                                                    FromDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FromDate = __value, FromDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
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
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\CustomerLedger.razor"
                                                                                                    ToDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ToDate = __value, ToDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
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
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\CustomerLedger.razor"
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
            __builder.AddMarkupContent(67, "<div class=\"panel-heading\"><div class=\"panel-title\"><span>Customer Ledger</span></div></div>\r\n                    ");
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
#line 83 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\CustomerLedger.razor"
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
#line 87 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\CustomerLedger.razor"
__builder.AddContent(92, company.CompanyName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "<br>\r\n                        ");
#nullable restore
#line 89 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\CustomerLedger.razor"
__builder.AddContent(94, company.Address);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(95, "                        <br>\r\n                         ");
#nullable restore
#line 90 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\CustomerLedger.razor"
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
#line 95 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\CustomerLedger.razor"
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
#line 104 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\CustomerLedger.razor"
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
#line 112 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\InventoryReports\CustomerLedger.razor"
       
    List<AccountLedgerView> listCustomer = new List<AccountLedgerView>();
    long LedgerId = 0;
    DateTime FromDate = DateTime.Now;
    DateTime ToDate = DateTime.Now;
    Company company = new Company();
    string myMarkup;
    protected async override void OnInitialized()
    {
        company = icompany.Edit(1);
        listCustomer = ledger.ViewAllCustomer(1);
    }
    protected void Search()
    {
        string values = @"<table class='table table-striped'>
                <tr>
                    <th style='display:none;'>SN</th>
                    <th>Date</th>
                    <th>Voucher No</th>
                    <th>Particular</th>
                    <th>Dr.Amount / Receive</th>
                    <th>Cr.Amount / Sales</th>
                    <th>Balance</th>
                </tr> ";

            //OpeningBlnce
            DataTable dtblsubOpening = new DataTable();
            DataSet dsetOpening = new DataSet();
            dsetOpening = report.CustomerLedgerOpening(Convert.ToDateTime(FromDate), LedgerId, 1);
            int counter1 = 0;
            dtblsubOpening = dsetOpening.Tables[0];
            decimal decDebit = 0;
            decimal decCredit = 0;
            decimal totlDebit = 0;
            decimal totlCredit = 0;
            if (dtblsubOpening.Rows.Count > 0)
            {
                for (int i = 0; i < dtblsubOpening.Rows.Count; i++)
                {
                    decDebit = Convert.ToDecimal(dtblsubOpening.Rows[i]["debit"].ToString());
                    decCredit = Convert.ToDecimal(dtblsubOpening.Rows[i]["credit"].ToString());
                    counter1++;
                    values += @"<tr>
            <td style='display:none;'>" + counter1.ToString() + @"</td>
            <td>" + @FromDate + @"</td>
            <td>" + "" + @"</td>
            <td style='font-style:bold; color:red; font-size:16px;'>" + "Opening Amount" + @"</td>
            <td>" + dtblsubOpening.Rows[i]["debit"].ToString() + @"</td>
            <td>" + dtblsubOpening.Rows[i]["credit"].ToString() + @"</td>
            <td>" + "" + @"</td>
        </tr>";


                }
            }

            DataTable dtblsub = new DataTable();
            DataSet dset = new DataSet();
            dset = report.CustomerLedger(Convert.ToDateTime(FromDate), Convert.ToDateTime(ToDate), LedgerId, 1);
            int counter = 0;
            dtblsub = dset.Tables[0];
            string strBalance = string.Empty;


            if (dtblsub.Rows.Count > 0)
            {
                for (int i = 0; i < dtblsub.Rows.Count; i++)
                {
                    counter++;
                    if (counter == 1)
                    {
                        strBalance = CalculateBalance(i, decDebit + decimal.Parse(dtblsub.Rows[i]["debit"].ToString()), decimal.Parse(dtblsub.Rows[i]["credit"].ToString()) + decCredit, strBalance);
                    }
                    else
                    {
                        strBalance = CalculateBalance(i, decimal.Parse(dtblsub.Rows[i]["debit"].ToString()), decimal.Parse(dtblsub.Rows[i]["credit"].ToString()), strBalance);
                    }
                    long decVoucherTypeId = Convert.ToInt64(dtblsub.Rows[i]["voucherTypeId"].ToString());
                    totlDebit = totlDebit + decimal.Parse(dtblsub.Rows[i]["debit"].ToString());
                    totlCredit = totlCredit + decimal.Parse(dtblsub.Rows[i]["credit"].ToString());
                    if (decVoucherTypeId == 19)
                    {
                        values += @"<tr>
            <td style='display:none;'>" + counter.ToString() + @"</td>
            <td>" + dtblsub.Rows[i]["Date"].ToString() + @"</td>
            <td>" + dtblsub.Rows[i]["voucherNo"].ToString() + @" </td>
            <td style='font-style:bold; color:black; font-size:16px;'>" + dtblsub.Rows[i]["particular"].ToString() + @"</td>
            <td> " + dtblsub.Rows[i]["debit"].ToString() + @"</td>
            <td> " + dtblsub.Rows[i]["credit"].ToString() + @"</td>
            <td>" + strBalance.ToString() + @"</td>
        </tr>";
                    }
                    else if (decVoucherTypeId == 20)
                    {
                        values += @"<tr>
            <td style='display:none;'>" + counter.ToString() + @"</td>
            <td>" + dtblsub.Rows[i]["Date"].ToString() + @"</td>
            <td>" + dtblsub.Rows[i]["voucherNo"].ToString() + @" </td>
            <td style='font-style:bold; color:black; font-size:16px;'>" + dtblsub.Rows[i]["particular"].ToString() + @"</td>
            <td> " + dtblsub.Rows[i]["debit"].ToString() + @"</td>
            <td> " + dtblsub.Rows[i]["credit"].ToString() + @"</td>
            <td>" + strBalance.ToString() + @"</td>
        </tr>";
                    }
                    else if (decVoucherTypeId == 5)
                    {
                        values += @"<tr>
            <td style='display:none;'>" + counter.ToString() + @"</td>
            <td>" + dtblsub.Rows[i]["Date"].ToString() + @"</td>
            <td>" + dtblsub.Rows[i]["voucherNo"].ToString() + @" </td>
            <td style='font-style:bold; color:black; font-size:16px;'>" + dtblsub.Rows[i]["particular"].ToString() + @"</td>
            <td> " + dtblsub.Rows[i]["debit"].ToString() + @"</td>
            <td> " + dtblsub.Rows[i]["credit"].ToString() + @"</td>
            <td>" + strBalance.ToString() + @"</td>
        </tr>";
                    }

                }
            }
            decimal decTotlDebitss = totlDebit + decDebit;
            decimal decTotlCreditss = totlCredit + decCredit;
            decimal decBlnce = decTotlDebitss - decTotlCreditss;
            values += @"<tr>
<td style='display:none;'></td>
<td></td>
<td style='font-style:bold; color:black; font-size:16px;'>Total</td>
<td>" + "" + @"</td>
<td style='font-style:bold; color:black; font-size:16px;'>" + decTotlDebitss + @"</td>
<td style='font-style:bold; color:black; font-size:16px;'>" + decTotlCreditss + @"</td>
<td>" + decBlnce + @"</td>
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
    private string CalculateBalance(int index, decimal decDebit, decimal decCredit, string strPreviousBalance)
    {
        string strCurrentBalance = string.Empty;
        string strCrOrDr = string.Empty;
        decimal decRowBalance = 0;
        try
        {
            if (index > 0)
            {
                string[] strLastBalance = strPreviousBalance.Split(' ');
                if (strLastBalance.Length >= 2)
                {
                    if ((strLastBalance[1] == null ? "" : strLastBalance[1]) != string.Empty)
                    {
                        if (strLastBalance[1] == "Dr")
                        {
                            decDebit = decimal.Parse(strLastBalance[0]) + decDebit;
                        }
                        if (strLastBalance[1] == "Cr")
                        {
                            decCredit = decimal.Parse(strLastBalance[0]) + decCredit;
                        }
                    }
                }
            }
            decRowBalance = decDebit - decCredit;
            if (decRowBalance > 0)
                strCrOrDr = " Dr";
            else if (decRowBalance < 0)
            {
                decRowBalance = decRowBalance * (-1);
                strCrOrDr = " Cr";
            }
            else
                strCrOrDr = string.Empty;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return strCurrentBalance = Convert.ToString(decRowBalance) + strCrOrDr;
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany icompany { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInventoryReport report { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountLedger ledger { get; set; }
    }
}
#pragma warning restore 1591
