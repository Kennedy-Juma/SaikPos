using SaikPOS.Data.Setting;
using SaikPOS.Data.Transaction;
using SaikPOS.Data.ViewModel;
using System;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface IPurchaseReturn
    {
        List<PurchaseReturnView> ViewAllPurchseInvoice(long id, DateTime fromDate, DateTime toDate);
        List<PurchaseReturnView> ViewAllPurchaseMasterDetails(long id);
        PurchaseReturnMaster EditPurchaseMaster(long id);
        bool DeletePurchseReturnInvoice(long id, string VoucherNo, long CompanyId, long FinancialYearId);
        bool AccountPurchseInvoiceNoCheckExistence(long CompanyId, long FinancialYearId, string VoucherNo);
        PurchaseReturnView PrintPurchaseMasterView(long PurchaseMasterId);
        List<ProductView> PurchaseInvoiceView(long PurchaseMasterId);
    }
}
