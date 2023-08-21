using SaikPOS.Data.Transaction;
using SaikPOS.Data.ViewModel;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface IReceiveCustomer
    {
        string GetReceiveVoucherNo(long CompanyId, long FinancialYearId, long VoucherTypeId);
        bool CheckReceiveCustomer(string voucherNo, long companyId, long financialYearId, long VoucherTypeId);
        List<ReceiptMaster> GetReceiptMasterView(long DetailsId);
        List<PaymentReceiveView> ViewAllReceiveCustomer(long LedgerId, long CompanyId, long FinancialYearId, string VoucherNo);
        ReceiptMaster EditReceiveCustomer(long ReceiptMasterId);
        PaymentSupplierView ReceiveCustomerView(long ReceiptMasterId);
        bool ReceiveCustomerDelete(string VoucherNo, long VoucherTypeId, long FinancialYearId, long CompanyId);
    }
}
