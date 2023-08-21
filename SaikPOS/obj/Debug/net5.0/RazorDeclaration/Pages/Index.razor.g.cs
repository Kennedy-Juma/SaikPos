// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SaikPOS.Pages
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
#line 3 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Index.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Index.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 185 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Index.razor"
                      
    BillingReport report = new BillingReport();
    BillingReport income = new BillingReport();
    BillingReport reading = new BillingReport();
    List<BillingReport> final = new List<BillingReport>();
    List<SalesMasterView> saleslist;
    List<PurchaseMasterView> purchaselist;

    bool value = true;
    decimal totalCustomer;
    decimal totalSupplier;
    decimal totalSale;
    decimal totalPurchase;
    decimal CashAmount;
    decimal creditAmount;
    decimal customerCredit;
    decimal PymentCashAmount;
    decimal PymentcreditAmount;
    decimal pymentDebit;
    //ReminderStock
    List<FinancialReport> toprecible { get; set; }
    List<FinancialReport> toppyble { get; set; }
    List<FinancialReport> topProduct { get; set; }
    bool smooth = false;

    protected override void OnInitialized()
    {
        LoadData();
        StateHasChanged();

    }
    protected async void LoadData()
    {
        //salesgraph
        saleslist = reportRepository.SalesInvoiceViewGraph(1, 1);
        //purchasegraph
        //purchaselist = reportRepository.ViewAllPurchseInvoiceGraph(1, 1);


        var resultSlesPurchse = reportRepository.SalesPurchaseTotal(1); //GetTotalSales&Purchase
        totalSale = resultSlesPurchse.totalSale;
        totalPurchase = resultSlesPurchse.totalPurchase;

        var resultSales = reportRepository.Receive(1); //GetYouWillReceive
        CashAmount = resultSales.Purchase;

        var resultPyment = reportRepository.Pay(1); //GetYouWillPay
        PymentCashAmount = resultPyment.Payment;

        toprecible = reportRepository.TopReceive(1); //GetTopTenReceiable
        topProduct = reportRepository.GettopProduct(1); //GetTopTenProduct
    }
    public List<ChartSeries> Series = new List<ChartSeries>()
    {
        new ChartSeries() { Name = "Series 1", Data = new double[] { 90, 79, 72, 69, 62, 62, 55, 65, 70 } },
        new ChartSeries() { Name = "Series 2", Data = new double[] { 10, 41, 35, 51, 49, 62, 69, 91, 148 } },
    };
    public string[] XAxisLabels = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep" };

    Random random = new Random();
    public void RandomizeData()
    {
        var new_series = new List<ChartSeries>()
        {
            new ChartSeries() { Name = "Series 1", Data = new double[9] },
            new ChartSeries() { Name = "Series 2", Data = new double[9] },
        };
        for (int i = 0; i < 9; i++)
        {
            new_series[0].Data[i] = random.NextDouble() * 100;
            new_series[1].Data[i] = random.NextDouble() * 100;
        }
        Series = new_series;
        StateHasChanged();
    }
    void OnChange(bool? value, string name)
    {
        value = true;
    }
   string FormatAsUSD(object value)
    {
        return ((double)value).ToString("C0", CultureInfo.CreateSpecificCulture("en-US"));
    }
     

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInventoryReport reportRepository { get; set; }
    }
}
#pragma warning restore 1591
