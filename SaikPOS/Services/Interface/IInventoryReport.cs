using SaikPOS.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;

namespace SaikPOS.Services.Interface
{
    public interface IInventoryReport
    {
        DataSet CustomerLedgerOpening(DateTime fromDate, long LedgerId, long CompanyId);
        DataSet CustomerLedger(DateTime fromDate, DateTime toDate, long LedgerId, long CompanyId);
        DataSet CustomerLedgerDue(DateTime fromDate, DateTime toDate, long LedgerId);
        DataSet CustomerLedgerDueSingle(DateTime fromDate, DateTime toDate, long LedgerId);
        List<PurchaseSales> CustomerCountSales(DateTime fromDate, DateTime toDate, long LedgerId, long VoucherTypeId);
        List<PurchaseSales> SaleReports(DateTime fromDate, DateTime toDate, long LedgerId, long VoucherTypeId);
        //Supplier
        DataSet SuppllierLedgerDue(DateTime fromDate, DateTime toDate, long ledgerId);
        DataSet SupplierLedgerDueSingle(DateTime fromDate, DateTime toDate, long ledgerId);
        List<PurchaseSales> SupplierCountPurchase(DateTime fromDate, DateTime toDate, long LedgerId, long VoucherTypeId);
        List<PurchaseSales> PurchaseRepports(DateTime fromDate, DateTime toDate, long LedgerId, long VoucherTypeId);
        public List<InventoryViewFinl> StockReport(long GroupId, long ProductId, long CompanyId);
        List<InventoryViewFinl> ProductStatisticsFill(long GroupId, string criteria, string BatchNo, long CompanyId);
        DataSet DayBook(DateTime fromDate, DateTime toDate, long VoucherTypeId, long LedgerId);
        DataSet LedgercountReport(DateTime fromDate, DateTime toDate, long LedgerId, string LedgerName, long CompanyId);
        List<FinancialReport> FillAccountGroup(DateTime fromDate, DateTime toDate, long CompanyId);
        //Dashboard
        DashboardView SalesPurchaseTotal(long CompanyId);
        DashboardView Receive(long CompanyId);
        DashboardView Pay(long CompanyId);
        List<FinancialReport> TopReceive(long CompanyId);
        DataSet ProfitAndLossAnalysis(DateTime fromDate, DateTime toDate, long CompanyId);
        DataSet ProfitAndLossAnalysisDetailed(DateTime fromDate, DateTime toDate, long CompanyId);
        decimal StockValueGetOnDate(DateTime date, DateTime dtToDate, string calculationMethod, bool isOpeningStock, bool isFromBalanceSheet);
        decimal StockValueGetOnDate(DateTime date, string calculationMethod, bool isOpeningStock, bool isFromBalanceSheet);
        DataSet BalanceSheet(DateTime toDate, long CompanyId);
        DataSet ProfitAndLossAnalysisUpToaDateForBalansheet(DateTime fromDate, DateTime toDate, long CompanyId);
        DataSet ProfitAndLossAnalysisUpToaDateForPreviousYears(DateTime toDate, long CompanyId);
        List<SalesMasterView> SalesInvoiceViewGraph(long CompanyId, long FinancialYearId);
        List<PurchaseMasterView> ViewAllPurchseInvoiceGraph(long CompanyId, long FinancialYearId);
        List<FinancialReport> GettopProduct(long CompanyId);
    }
}
