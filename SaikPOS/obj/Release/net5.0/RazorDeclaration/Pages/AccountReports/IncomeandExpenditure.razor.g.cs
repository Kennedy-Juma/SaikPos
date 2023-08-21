// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\AccountReports\IncomeandExpenditure.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/account/incomeandexpenditure")]
    public partial class IncomeandExpenditure : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\AccountReports\IncomeandExpenditure.razor"
       
    DateTime FromDate = DateTime.Now;
    DateTime ToDate = DateTime.Now;
    Company company = new Company();
    string myMarkup;
    protected async override void OnInitialized()
    {
        company = icompany.Edit(1);
    }
    protected void Search()
    {
        decimal decgranExTotal = 0;
        decimal decgranIncTotal = 0;
        string calculationMethod = "FIFO";
        DataTable dtblFinancial = new DataTable();
        DataSet DsetProfitAndLoss = new DataSet();

        //LedgerProfitLoss
        DataTable dtblFinancial1 = new DataTable();
        DataSet DsetProfitAndLoss1 = new DataSet();
        DsetProfitAndLoss = report.ProfitAndLossAnalysis(FromDate, ToDate, 1);
        //Ledger
        DsetProfitAndLoss1 = report.ProfitAndLossAnalysisDetailed(FromDate, ToDate, 1);
        //-------------------  -------------------------------//
        decimal dcOpeningStock = 0;
        dcOpeningStock = report.StockValueGetOnDate(FromDate, ToDate, calculationMethod, true, false);

        string values = @"<table class='table-responsive' id='tbldemo'>
                          <tr>
                           <th></th>
                            <th></th>
                            <th></th>
                            <th></th>
                            </tr>";
        values += @"<tr>
<th>" + "Expense" + @"</th>
<th>" + "Amount" + @"</th>
<th>" + "Income" + @"</th>
<th>" + "Amount" + @"</th>
            </tr>";
        if (dcOpeningStock > 0)
        {
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "Opening Stock" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcOpeningStock, 2) + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
                    </tr>";
        }
        else
        {
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "Opening Stock" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcOpeningStock, 2) + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
                    </tr>";
        }
        //Closing Stock
        decimal dcClosingStock = 0;
        dcClosingStock = report.StockValueGetOnDate(ToDate, calculationMethod, false, false);
        values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "Closing Stock" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcClosingStock, 2) + @"</td>
                    </tr>";
        /// ---Purchase Account  - Debit
        dtblFinancial = new DataTable();
        dtblFinancial = DsetProfitAndLoss.Tables[0];
        //PurchaseLedger
        dtblFinancial1 = new DataTable();
        dtblFinancial1 = DsetProfitAndLoss1.Tables[0];
        decimal dcPurchaseAccount = 0m;
        decimal dcPurchaseAccount1 = 0m;
        if (dtblFinancial.Rows.Count > 0)
        {
            foreach (DataRow rw in dtblFinancial.Rows)
            {
                decimal dcBalance = decimal.Parse(rw["Debit"].ToString().ToString());
                dcPurchaseAccount += dcBalance;



            }

        }

        values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "Purchase Accounts" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcPurchaseAccount, 2) + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
                    </tr>";

        //---Sales Account  -Credit
        dtblFinancial = new DataTable();
        dtblFinancial = DsetProfitAndLoss.Tables[1];
        dtblFinancial1 = new DataTable();
        dtblFinancial1 = DsetProfitAndLoss1.Tables[1];
        decimal dcSalesAccount = 0m;
        if (dtblFinancial.Rows.Count > 0)
        {
            foreach (DataRow rw in dtblFinancial.Rows)
            {
                decimal dcBalance = decimal.Parse(rw["Credit"].ToString().ToString());
                dcSalesAccount += dcBalance;
            }
        }
        values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "Sales Accounts" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcSalesAccount, 2) + @"</td>
                    </tr>";
        //---Direct Expense
        dtblFinancial = new DataTable();
        dtblFinancial = DsetProfitAndLoss.Tables[2];
        dtblFinancial1 = new DataTable();
        dtblFinancial1 = DsetProfitAndLoss1.Tables[2];
        decimal dcDirectExpense = 0m;
        if (dtblFinancial.Rows.Count > 0)
        {
            foreach (DataRow rw in dtblFinancial.Rows)
            {
                decimal dcBalance = Convert.ToDecimal(rw["Debit"].ToString());
                dcDirectExpense += dcBalance;
            }
        }
        values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "Direct Expenses" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcDirectExpense, 2) + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
                    </tr>";
        //----Direct Income
        dtblFinancial = new DataTable();
        dtblFinancial = DsetProfitAndLoss.Tables[3];
        dtblFinancial1 = new DataTable();
        dtblFinancial1 = DsetProfitAndLoss1.Tables[3];
        decimal dcDirectIncoome = 0m;
        if (dtblFinancial.Rows.Count > 0)
        {
            foreach (DataRow rw in dtblFinancial.Rows)
            {
                decimal dcBalance = Convert.ToDecimal(rw["Credit"].ToString());
                dcDirectIncoome += dcBalance;
            }
        }
        values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "Direct Incomes" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcDirectIncoome, 2) + @"</td>
                    </tr>";
        values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
                    </tr>";
        values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
                    </tr>";
        values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
                    </tr>";
        values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "_______________________" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "_______________________" + @"</td>
                    </tr>";
        decimal dcTotalExpense = 0;
        decimal dcTotalIncome = 0;
        dcTotalExpense = dcOpeningStock + dcPurchaseAccount + dcDirectExpense;
        dcTotalIncome = dcClosingStock + dcSalesAccount + dcDirectIncoome;
        dcTotalExpense = Math.Round(dcTotalExpense, 2);
        dcTotalIncome = Math.Round(dcTotalIncome, 2);
        values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "Total" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
                    </tr>";
        values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "Total" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
                    </tr>";
        decimal dcGrossProfit = 0;
        decimal dcGrossLoss = 0;
        if (dcTotalExpense > dcTotalIncome)
        {
            dcGrossLoss = dcTotalExpense - dcTotalIncome;
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcTotalExpense, 2) + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcTotalExpense, 2) + @"</td>
                    </tr>";
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "Gross Loss b/d" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcTotalExpense - dcTotalIncome, 2) + @"</td>
                    </tr>";
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "Gross Loss b/d" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcTotalExpense - dcTotalIncome, 2) + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
                    </tr>";
        }
        else
        {
            dcGrossProfit = dcTotalIncome - dcTotalExpense;
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcTotalIncome, 2) + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcTotalIncome, 2) + @"</td>
                    </tr>";
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "Gross Profit c/d" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcTotalIncome - dcTotalExpense, 2) + @"</td>
                    </tr>";

            values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "Gross Profit c/d" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcTotalIncome - dcTotalExpense, 2) + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
                    </tr>";
        }
        ///------Indirect Expense
        dtblFinancial = new DataTable();
        dtblFinancial = DsetProfitAndLoss.Tables[4];
        dtblFinancial1 = new DataTable();
        dtblFinancial1 = DsetProfitAndLoss1.Tables[4];
        decimal dcIndirectExpense = 0;
        if (dtblFinancial.Rows.Count > 0)
        {
            foreach (DataRow rw in dtblFinancial.Rows)
            {
                decimal dcBalance = Convert.ToDecimal(rw["Debit"].ToString());
                dcIndirectExpense += dcBalance;
            }
        }
        values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "Indirect Expenses" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcIndirectExpense, 2) + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
                    </tr>";
        ///---Indirect Income
        dtblFinancial = new DataTable();
        dtblFinancial = DsetProfitAndLoss.Tables[5];
        dtblFinancial1 = new DataTable();
        dtblFinancial1 = DsetProfitAndLoss1.Tables[5];
        decimal dcIndirectIncome = 0m;
        if (dtblFinancial.Rows.Count > 0)
        {
            foreach (DataRow rw in dtblFinancial.Rows)
            {
                decimal dcBalance = Convert.ToDecimal(rw["Credit"].ToString());
                dcIndirectIncome += dcBalance;
            }
        }
        values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "Indirect Incomes" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcIndirectIncome, 2) + @"</td>
                    </tr>";


        //---- Calculating Grand total
        decimal dcGrandTotalExpense = dcGrossLoss + dcIndirectExpense;
        decimal dcGrandTotalIncome = dcGrossProfit + dcIndirectIncome;
        values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
                    </tr>";
        values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "_______________________" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "_______________________" + @"</td>
                    </tr>";
        values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "Grand Total" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + dcGrandTotalExpense + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "Grand Total" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + dcGrandTotalExpense + @"</td>
                    </tr>";

        if (dcGrandTotalExpense > dcGrandTotalIncome)
        {
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "Net Loss" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcGrandTotalExpense - dcGrandTotalIncome, 2) + @"</td>
                    </tr>";
            decgranExTotal = dcGrandTotalExpense;
        }
        else
        {
            values += @"<tr>
<td style='width: 260px;font-style:bold; color:black;text-align: left;'>" + "Net Profit" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + Math.Round(dcGrandTotalIncome - dcGrandTotalExpense, 2) + @"</td>
<td style='width: 260px;font-style:bold; color:black;'>" + "" + @"</td>
<td style='width: 140px;font-style:bold; color:black;'>" + "" + @"</td>
                    </tr>";
            decgranIncTotal = dcGrandTotalIncome;
        }

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany icompany { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInventoryReport report { get; set; }
    }
}
#pragma warning restore 1591
