#pragma checksum "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\AccountReports\BalancesheetReports.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cc79f8e389d4a466e95e9f8bf5e71473d4a8048"
// <auto-generated/>
#pragma warning disable 1591
namespace Dreamer.Pages.AccountReports
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
#line 2 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\AccountReports\BalancesheetReports.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/account/balancesheet")]
    public partial class BalancesheetReports : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddMarkupContent(2, @"<ol class=""breadcrumb""><li><a href=""#""><i class=""pe-7s-home""></i> Home</a></li>
                <li><a href=""/"">account</a></li>
                <li class=""active"">BalanceSheet</li></ol>
            
                    
                                        <div class=""se-pre-con"" style=""display: none;""></div>
                    
                    
");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-12 col-md-12");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "panel panel-bd lobidrag");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "panel-body");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.AddAttribute(13, "id");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-sm-6");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-group row");
            __builder.AddMarkupContent(18, "<label for=\"date\" class=\"col-sm-4 col-form-label\">From Date<span class=\"text-danger\">*</span></label>\r\n                            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-sm-8");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "date");
            __builder.AddAttribute(23, "class", "form-control datepicker hasDatepicker");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\AccountReports\BalancesheetReports.razor"
                                                                                                        FromDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FromDate = __value, FromDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n                        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-group row");
            __builder.AddMarkupContent(29, "<label for=\"date\" class=\"col-sm-4 col-form-label\">To Date<span class=\"text-danger\">*</span></label>\r\n                            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-sm-8");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "date");
            __builder.AddAttribute(34, "class", "form-control datepicker hasDatepicker");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\AccountReports\BalancesheetReports.razor"
                                                                                                        ToDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ToDate = __value, ToDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n                        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-group text-right");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "type", "button");
            __builder.AddAttribute(42, "class", "btn btn-success");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\AccountReports\BalancesheetReports.razor"
                                                                                   Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.AddMarkupContent(46, "<a class=\"btn btn-warning\" onclick=\"printDiv(\'PrintDiv\')\">Print</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "row");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-sm-12");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "panel panel-bd lobidrag");
            __builder.AddMarkupContent(54, "<div class=\"panel-heading\"><div class=\"panel-title\"><span>BalanceSheet</span></div></div>\r\n                    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "panel-body");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "id", "PrintDiv");
            __builder.AddAttribute(59, "class", "table-responsive ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "paddin5ps");
            __builder.OpenElement(62, "table");
            __builder.AddAttribute(63, "class", "print-table");
            __builder.AddAttribute(64, "width", "100%");
            __builder.OpenElement(65, "tbody");
            __builder.OpenElement(66, "tr");
            __builder.OpenElement(67, "td");
            __builder.AddAttribute(68, "align", "left");
            __builder.AddAttribute(69, "class", "print-table-tr");
            __builder.OpenElement(70, "img");
            __builder.AddAttribute(71, "src", 
#nullable restore
#line 67 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\AccountReports\BalancesheetReports.razor"
                                   convertImageToDisplay(company.LogoPath)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(72, "class", "companyimg");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.OpenElement(74, "td");
            __builder.AddAttribute(75, "align", "center");
            __builder.AddAttribute(76, "class", "print-cominfo");
            __builder.OpenElement(77, "span");
            __builder.AddAttribute(78, "class", "company-txt");
#nullable restore
#line 71 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\AccountReports\BalancesheetReports.razor"
__builder.AddContent(79, company.CompanyName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "<br>\r\n                        ");
#nullable restore
#line 73 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\AccountReports\BalancesheetReports.razor"
__builder.AddContent(81, company.Address);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(82, "                        <br>\r\n                         ");
#nullable restore
#line 74 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\AccountReports\BalancesheetReports.razor"
__builder.AddContent(83, company.Phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                   \r\n                     ");
            __builder.OpenElement(85, "td");
            __builder.AddAttribute(86, "align", "right");
            __builder.AddAttribute(87, "class", "print-table-tr");
            __builder.OpenElement(88, "date");
#nullable restore
#line 79 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\AccountReports\BalancesheetReports.razor"
__builder.AddContent(89, DateTime.Now);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\r\n                            ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "table-responsive paddin5ps");
#nullable restore
#line 88 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\AccountReports\BalancesheetReports.razor"
__builder.AddContent(93, (MarkupString)myMarkup);

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
#line 97 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\AccountReports\BalancesheetReports.razor"
       
    DateTime FromDate = DateTime.Now;
    DateTime ToDate = DateTime.Now;
        int inCurrenRowIndex = 0;
    int inCurentcolIndex = 0;
    decimal decPrintOrNot = 0;
    decimal decPrintOrNot1 = 0;
    string calculationMethod = string.Empty;
    Company company = new Company();
    FinancialYear year = new FinancialYear();
    string myMarkup;
    protected async override void OnInitialized()
    {
        company = icompany.Edit(1);
        year = _year.Edit(company.FinancialYearId);

    }
    protected void Search()
    {
        string calculationMethod = "FIFO";
        DataSet DsetBalanceSheet = new DataSet();
        DataTable dtbl = new DataTable();
        DsetBalanceSheet = report.BalanceSheet(ToDate, 1);


        //------------------- Asset -------------------------------//
        dtbl = DsetBalanceSheet.Tables[0];
        string values = @"<table class='table-responsive' id='tbldemo'>

                  <tr>
                  <th></th>
                  <th></th>
                  <th></th>
                  <th></th>
                  </tr>";
        values += @"<tr>
<th>" + "Assets" + @"</td>
<th>" + "Amount" + @"</td>
<th>" + "Liabilities" + @"</td>
<th>" + "Amount" + @"</td>
            </tr>";
        foreach (DataRow rw in dtbl.Rows)
        {
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + rw["Name"].ToString() + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + rw["Balance"].ToString() + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
            </tr>";
        }
        decimal dcTotalAsset = 0;
        if (dtbl.Rows.Count > 0)
        {
            dcTotalAsset = decimal.Parse(dtbl.Compute("Sum(Balance)", string.Empty).ToString());
        }
        //------------------------ Liability ---------------------//
        dtbl = new DataTable();
        dtbl = DsetBalanceSheet.Tables[1];
        int index = 0;
        foreach (DataRow rw in dtbl.Rows)
        {
            if (index < dtbl.Rows.Count)
            {
                values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + rw["Name"].ToString() + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + rw["Balance"].ToString() + @"</td>
            </tr>";
            }
            else
            {
                values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + rw["Name"].ToString() + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + rw["Balance"].ToString() + @"</td>
            </tr>";
            }
            index++;
        }
        decimal dcTotalLiability = 0;
        if (dtbl.Rows.Count > 0)
        {
            dcTotalLiability = decimal.Parse(dtbl.Compute("Sum(Balance)", string.Empty).ToString());
        }
        decimal dcClosingStock = 0;
        dcClosingStock = report.StockValueGetOnDate(Convert.ToDateTime(ToDate), calculationMethod, false, false);
        dcClosingStock = Math.Round(dcClosingStock, 2);
        //---------------------Opening Stock---------------------------------------------------------------------------------------------------------------
        decimal dcOpeninggStock = 0;
        dcOpeninggStock = report.StockValueGetOnDate(year.FromDate, calculationMethod, true, true);
        decimal dcProfit = 0;
        DataSet dsetProfitAndLoss = new DataSet();
        dsetProfitAndLoss = report.ProfitAndLossAnalysisUpToaDateForBalansheet(FromDate, FromDate, 1);
        DataTable dtblProfit = new DataTable();
        dtblProfit = dsetProfitAndLoss.Tables[0];
        for (int i = 0; i < dsetProfitAndLoss.Tables.Count; ++i)
        {
            dtbl = dsetProfitAndLoss.Tables[i];
            decimal dcSum = 0;
            if (i == 0 || (i % 2) == 0)
            {
                if (dtbl.Rows.Count > 0)
                {
                    dcSum = decimal.Parse(dtbl.Compute("Sum(Debit)", string.Empty).ToString());
                    dcProfit = dcProfit - dcSum;
                }
            }
            else
            {
                if (dtbl.Rows.Count > 0)
                {
                    dcSum = decimal.Parse(dtbl.Compute("Sum(Credit)", string.Empty).ToString());
                    dcProfit = dcProfit + dcSum;
                }
            }
        }
        decimal decCurrentProfitLoss = 0;
        decCurrentProfitLoss = dcProfit + (dcClosingStock - dcOpeninggStock);
        decimal dcProfitOpening = 0;
        DataSet dsetProfitAndLossOpening = new DataSet();
        dsetProfitAndLossOpening = report.ProfitAndLossAnalysisUpToaDateForPreviousYears(FromDate, 1);
        DataTable dtblProfitOpening = new DataTable();
        dtblProfitOpening = dsetProfitAndLossOpening.Tables[0];
        for (int i = 0; i < dsetProfitAndLossOpening.Tables.Count; ++i)
        {
            dtbl = dsetProfitAndLossOpening.Tables[i];
            decimal dcSum = 0;
            if (i == 0 || (i % 2) == 0)
            {
                if (dtbl.Rows.Count > 0)
                {
                    dcSum = decimal.Parse(dtbl.Compute("Sum(Debit)", string.Empty).ToString());
                    dcProfitOpening = dcProfitOpening - dcSum;
                }
            }
            else
            {
                if (dtbl.Rows.Count > 0)
                {
                    dcSum = decimal.Parse(dtbl.Compute("Sum(Credit)", string.Empty).ToString());
                    dcProfitOpening = dcProfitOpening + dcSum;
                }
            }
        }
        DataTable dtblProfitLedgerOpening = new DataTable();
        dtblProfitLedgerOpening = DsetBalanceSheet.Tables[3];
        decimal decProfitLedgerOpening = 0;
        foreach (DataRow dRow in dtblProfitLedgerOpening.Rows)
        {
            decProfitLedgerOpening += decimal.Parse(dRow["Balance"].ToString());
        }
        DataTable dtblProf = new DataTable();
        dtblProf = DsetBalanceSheet.Tables[2];
        decimal decProfitLedger = 0;
        if (dtblProf.Rows.Count > 0)
        {
            decProfitLedger = decimal.Parse(dtblProf.Compute("Sum(Balance)", string.Empty).ToString());
        }
        decimal decTotalProfitAndLoss = 0;
        if (dcProfitOpening >= 0)
        {
            decTotalProfitAndLoss = decProfitLedger;
        }
        else if (dcProfitOpening < 0)
        {
            decTotalProfitAndLoss = decProfitLedger;
        }
        index = 0;
        if (dcClosingStock >= 0)
        {
            //---------- Asset ----------//
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "Closing Stock" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcClosingStock, 2) + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
            </tr>";
            dcTotalAsset += dcClosingStock;
        }
        else
        {
            //--------- Liability ---------//
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "Closing Stock" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcClosingStock, 2) + @"</td>
            </tr>";
            dcTotalLiability += -dcClosingStock;
        }

        decimal decOpeningOfProfitAndLoss = decProfitLedgerOpening + dcProfitOpening;
        decimal decTotalProfitAndLossOverAll = decTotalProfitAndLoss + decOpeningOfProfitAndLoss + decCurrentProfitLoss;
        if (decTotalProfitAndLossOverAll <= 0)
        {
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "----------------------------------------" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
            </tr>";
            foreach (DataRow dRow in dtblProf.Rows)
            {
                if (dRow["Name"].ToString() == "Profit And Loss Account")
                {
                    values += @"<tr>
<td style='width: 260px;font-style:bold; color:red;text-align: left;'>" + dRow["Name"].ToString() + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
            </tr>";
                    if (decCurrentProfitLoss < 0)
                    {
                        decCurrentProfitLoss = decCurrentProfitLoss * -1;
                    }
                    values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(decTotalProfitAndLoss + decCurrentProfitLoss, 2) + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
            </tr>";
                }
            }
            //-------------- Asset ---------------//
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:DarkSlateGray;text-align: left;'>" + "Profit And Loss (Opening)" + @"</td>
<td style='width: 140px;font-style:bold; color:DarkSlateGray;'>" + Math.Round(decTotalProfitAndLoss, 2) + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
            </tr>";
            //-------------- Asset ---------------//
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:DarkSlateGray;text-align: left;'>" + "Current Period" + @"</td>
<td style='width: 140px;font-style:bold; color:DarkSlateGray;'>" + Math.Round(decCurrentProfitLoss, 2) + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
            </tr>";
            dcTotalAsset = dcTotalAsset + (decCurrentProfitLoss + decTotalProfitAndLoss);
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:Black;text-align: left;'>" + "----------------------------------------" + @"</td>
<td style='width: 140px;font-style:bold; color:Black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
            </tr>";
        }
        else if (decTotalProfitAndLossOverAll > 0)
        {
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:Black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:Black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "----------------------------------------" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
            </tr>";
            foreach (DataRow dRow in dtblProf.Rows)
            {
                if (dRow["Name"].ToString() == "Profit And Loss Account")
                {
                    values += @"<tr>
<td style='width: 260px;font-style:bold; color:Black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:Black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:DarkSlateGray;'>" + dRow[1].ToString() + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(decTotalProfitAndLoss + decCurrentProfitLoss, 2) + @"</td>
            </tr>";
                }
            }
            //------------ Liability ------------//
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:Black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:Black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:DarkSlateGray;'>" + "Profit And Loss (Opening)" + @"</td>
<td style='width: 140px;font-style:bold; color:DarkSlateGray;'>" + Math.Round(decTotalProfitAndLoss, 2) + @"</td>
            </tr>";
            dcTotalLiability += decOpeningOfProfitAndLoss;
            //------------ Liability ------------//

            values += @"<tr>
<td style='width: 260px;font-style:bold; color:Black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:Black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:DarkSlateGray;'>" + "Current Period" + @"</td>
<td style='width: 140px;font-style:bold; color:DarkSlateGray;'>" + Math.Round(decCurrentProfitLoss, 2) + @"</td>
            </tr>";
            dcTotalLiability = dcTotalLiability + (decCurrentProfitLoss + decTotalProfitAndLoss); //dcProfit;
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:Black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:Black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:DarkSlateGray;'>" + "----------------------------------------" + @"</td>
<td style='width: 140px;font-style:bold; color:DarkSlateGray;'>" + "" + @"</td>
            </tr>";
        }
        decimal dcDiffAsset = 0;
        decimal dcDiffLiability = 0;
        decimal dcTotalValue = dcTotalAsset;
        if (dcTotalAsset != dcTotalLiability)
        {
            if (dcTotalAsset > dcTotalLiability)
            {
                //--------------- Liability exceeds so in asset side ----------------//

                values += @"<tr>
<td style='width: 260px;font-style:bold; color:Black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:Black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:DarkRed;'>" + "Difference" + @"</td>
<td style='width: 140px;font-style:bold; color:Black;'>" + Math.Round((dcTotalAsset - dcTotalLiability), 2) + @"</td>
            </tr>";
                dcDiffLiability = dcTotalAsset - dcTotalLiability;
            }
            else
            {
                //--------------- Asset exceeds so in liability side ----------------//
                values += @"<tr>
<td style='width: 260px;font-style:bold; color:Black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:Black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:DarkRed;'>" + "Difference" + @"</td>
<td style='width: 140px;font-style:bold; color:Black;'>" + Math.Round((dcTotalLiability - dcTotalAsset), 2) + @"</td>
            </tr>";
                dcDiffAsset = dcTotalLiability - dcTotalAsset;
            }
        }
        values += @"<tr>
<td style='width: 260px;font-style:bold; color:Black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:Black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:DarkRed;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:Black;'>" + "" + @"</td>
            </tr>";
        values += @"<tr>
<td style='width: 260px;font-style:bold; color:Black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:Black;'>" + "__________________________" + @"</td>
<td style='width: 260px;font-style:bold; color:DarkRed;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:Black;'>" + "__________________________" + @"</td>
            </tr>";
        values += @"<tr>
<td style='width: 260px;font-style:bold; color:Black;text-align: left;'>" + "Total" + @"</td>
<td style='width: 140px;font-style:bold; text-align:right; color:Black;'>" + Math.Round((dcTotalAsset + dcDiffAsset), 2) + @"</td>
<td style='width: 260px;font-style:bold; color:DarkRed;'>" + "Total" + @"</td>
<td style='width: 140px;font-style:bold; text-align:right; color:Black;'>" + Math.Round((dcTotalLiability + dcDiffLiability), 2) + @"</td>
            </tr>";
        decPrintOrNot = dcTotalAsset + dcDiffAsset;
        decPrintOrNot1 = dcTotalLiability + dcDiffLiability;
        if (inCurrenRowIndex >= 0 && dtbl.Rows.Count > 0 && inCurrenRowIndex < dtbl.Rows.Count)
        {
            //if (dtbl.Rows[inCurrenRowIndex].Cells[inCurentcolIndex].Visible)
            //{
            //    dtbl.CurrentCell = dtbl.Rows[inCurrenRowIndex].Cells[inCurentcolIndex];
            //}
            //if (dtbl.CurrentCell != null && dtbl.CurrentCell.Visible)
            //    dtbl.CurrentCell.Selected = true;
        }
        inCurrenRowIndex = 0;
        values += " </table>";
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFinancialYear _year { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany icompany { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInventoryReport report { get; set; }
    }
}
#pragma warning restore 1591
