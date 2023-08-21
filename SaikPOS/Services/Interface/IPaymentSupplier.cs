using SaikPOS.Data.Transaction;
using SaikPOS.Data.ViewModel;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface IPaymentSupplier
    {
        List<PaymentReceiveView> ViewAllPaymentSupplier( long LedgerId, long CompanyId, long FinancialYearId, string VoucherNo);
        PaymentMaster EditPaymentSupplier(long PaymentMasterId);
        bool DeletePaymentSupplier(string VoucherNo, long VoucherTypeId, long FinancialYearId, long CompanyId);
        string GetPaymentVoucherNo(long CompanyId, long FinancialYearId, long VoucherTypeId);
        bool CheckPaymentSupplier(string voucherNo, long companyId, long financialYearId, long VoucherTypeId);
        public List<PurchaseMasterView> GetSupplierPaymentList(long LedgerId);
        PaymentSupplierView PaymentSupplierView(long PaymentMasterId);
    }
}
