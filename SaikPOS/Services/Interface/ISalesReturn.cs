using SaikPOS.Data.Transaction;
using SaikPOS.Data.ViewModel;
using System;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface ISalesReturn
    {
        List<SalesReturnMasterView> ViewAllSalesInvoice(long CompanyId);
        SalesReturnMaster EditsalesMaster(long SalesMasterId);
        bool DeleteSalesInvoice(long SalesMasterId, string VoucherNo, long CompanyId, long FinancialYearId);
        string GetSalesvoucherNo(long CompanyId, long FinancialYearId, long VoucherTypeId);
        List<SalesReturnMasterView> ViewAllSalesInvoice(long id, DateTime fromDate, DateTime toDate);
        bool AccountSalesInvoiceNoCheckExistence(long CompanyId, long FinancialYearId, string VoucherNo);
        SalesReturnMasterView SalesMasterPrint(long SalesMasterId);
        List<ProductView> SalesDetailsPrint(long SalesMasterId);
        List<ProductView> SalesInvoiceView(long SalesMasterId);
    }
}
