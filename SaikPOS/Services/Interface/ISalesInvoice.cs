using SaikPOS.Data.Transaction;
using SaikPOS.Data.ViewModel;
using System;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface ISalesInvoice
    {
        DashboardView GetCashBankresultCustomerPayment(long CompanyId);
        List<SalesMasterView> ViewAllSalesInvoice(long CompanyId);
        SalesMaster EditsalesMaster(long SalesMasterId);
        bool DeleteSalesInvoice(long SalesMasterId, string VoucherNo, long CompanyId, long FinancialYearId);
        string GetSalesvoucherNo(long CompanyId, long FinancialYearId, long VoucherTypeId);
        List<SalesMasterView> ViewAllSalesInvoice(long id, DateTime fromDate, DateTime toDate);
        bool AccountSalesInvoiceNoCheckExistence(long CompanyId, long FinancialYearId, string VoucherNo);
        PaymentSupplierView CustomerSalesDue(long LedgerId);
        SalesMasterView SalesMasterPrint(long SalesMasterId);
        List<ProductView> SalesDetailsPrint(long SalesMasterId);
        List<ProductView> SalesInvoiceView(long SalesMasterId);
        PaymentSupplierView GetPreviousDuesBalanceSales(long LedgerId);
        List<SalesMasterView> GetCustomerPaymentList(long LedgerId);
    }
}
