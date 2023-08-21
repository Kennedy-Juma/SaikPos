using SaikPOS.Data.Setting;
using SaikPOS.Data.Transaction;
using SaikPOS.Data.ViewModel;
using System;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface IPurchaseInvoice
    {
        List<PurchaseMasterView> ViewAllPurchseInvoice(long id, DateTime fromDate, DateTime toDate);
        List<PurchaseMasterView> ViewAllPurchaseMasterDetails(long id);
        PurchaseMaster EditPurchaseMaster(long id);
        bool DeletePurchseInvoice(long id, string VoucherNo, long CompanyId, long FinancialYearId);
        bool AccountPurchseInvoiceNoCheckExistence(long CompanyId, long FinancialYearId, string VoucherNo);
        PaymentSupplierView GetPreviousDuesBalancepurchase(long LedgerId);
        PurchaseMasterView PrintPurchaseMasterView(long PurchaseMasterId);
        List<ProductView> PurchaseInvoiceView(long PurchaseMasterId);
        List<PaymentMaster> GetPaymentPurchaseView(long DetailsId);
        bool CheckPymentSupplier(string voucherNo, long companyId, long financialYearId, long VoucherTypeId);
    }
}
