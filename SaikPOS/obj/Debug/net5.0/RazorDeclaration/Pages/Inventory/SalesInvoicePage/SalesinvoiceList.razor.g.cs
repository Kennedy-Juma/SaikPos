// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SaikPOS.Pages.Inventory.SalesInvoicePage
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
#line 2 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Inventory\SalesInvoicePage\SalesinvoiceList.razor"
using NPOI.SS.UserModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Inventory\SalesInvoicePage\SalesinvoiceList.razor"
using NPOI.XSSF.UserModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/sales/salesinvoicelist")]
    public partial class SalesinvoiceList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 153 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\Inventory\SalesInvoicePage\SalesinvoiceList.razor"
       
    private bool dense = true;
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private string searchString2 = "";
    DateTime fromDate = DateTime.Now;
    DateTime toDate = DateTime.Now;
    decimal PymentCashAmount;
    decimal PymentcreditAmount;
    decimal pymentDebit;
    decimal decTotalPurchase;
    List<SalesMasterView> listModel = new List<SalesMasterView>();
    protected override void OnInitialized()
    {
        LoadData();
    }
    private async void LoadData()
    {
        var resultSupplierPyment = salesInvoice.GetCashBankresultCustomerPayment(1);
        PymentCashAmount = resultSupplierPyment.CashAmount;
        PymentcreditAmount = resultSupplierPyment.creditAmount;
        pymentDebit = resultSupplierPyment.debit;
        decTotalPurchase = PymentCashAmount + PymentcreditAmount + pymentDebit;
        
        listModel = salesInvoice.ViewAllSalesInvoice(1);
        
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
        cell1.SetCellValue("SalesInvoice");

        int rowNumber = 1;
        IRow row = worksheet.CreateRow(rowNumber++);
        //TbleHeder
        ICell cell = row.CreateCell(0);
        cell.SetCellValue("Voucher No");

        cell = row.CreateCell(1);
        cell.SetCellValue("Date");

        cell = row.CreateCell(2);
        cell.SetCellValue("Customer Name");

        cell = row.CreateCell(3);
        cell.SetCellValue("Voucher Type");

        cell = row.CreateCell(4);
        cell.SetCellValue("Amount");

        cell = row.CreateCell(5);
        cell.SetCellValue("Balance Due");

        cell = row.CreateCell(6);
        cell.SetCellValue("Status");


        //Tble Body
        foreach (var objDue in listModel)
    {
            row = worksheet.CreateRow(rowNumber++);

            cell = row.CreateCell(0);
            cell.SetCellValue(objDue.VoucherNo);

            cell = row.CreateCell(1);
            cell.SetCellValue(objDue.Date.ToString());

            cell = row.CreateCell(2);
            cell.SetCellValue(objDue.LedgerName);

            cell = row.CreateCell(3);
            cell.SetCellValue(objDue.VoucherTypeName);

            cell = row.CreateCell(4);
            cell.SetCellValue(objDue.GrandTotal.ToString());

            cell = row.CreateCell(5);
            cell.SetCellValue(objDue.CreditAmount.ToString());

            cell = row.CreateCell(6);
            cell.SetCellValue(objDue.Status.ToString());

        }
        MemoryStream ms = new MemoryStream();
        workbook.Write(ms);
        byte[] bytes = ms.ToArray();
        ms.Close();

        await JsRuntime.SaveAsFileAsync("SalesInvoice", bytes, "application/vnd.ms-excel");
    }
    private void GeneratePdf()
    {
        PdfSales pdfExp = new PdfSales();
        JsRuntime.InvokeAsync<SalesMasterView>(
            "saveAsFile",
            "SalesInvoice.pdf",
            Convert.ToBase64String(pdfExp.Report(listModel))
        );
    }
    async Task Delete(long id)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure?");
        if (confirmed)
        {
            SalesMaster view = new SalesMaster();
            view = salesInvoice.EditsalesMaster(id);
            //view = purchaseInvoice.EditPurchaseMaster(id , view.VoucherNo, 1 , 1);
            bool isSave = false;
            isSave = salesInvoice.DeleteSalesInvoice(id , view.VoucherNo, 1 , 1);
            if (isSave == true)
            {
                Snackbar.Add("Delete Successfully.", Severity.Success);
                LoadData();
            }
            else
            {
                Snackbar.Add("Cannot be delete. already in used.", Severity.Info);
            }
        }
    }
    private bool Search(SalesMasterView element)
    {
        if (string.IsNullOrWhiteSpace(searchString1))
            return true;
        if (element.LedgerName.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.VoucherNo.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }
    private async void Search()
    {
        listModel = salesInvoice.ViewAllSalesInvoice(1, fromDate , toDate);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISalesInvoice salesInvoice { get; set; }
    }
}
#pragma warning restore 1591
