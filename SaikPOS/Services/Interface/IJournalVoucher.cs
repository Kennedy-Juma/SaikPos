using SaikPOS.Data.Transaction;
using SaikPOS.Data.ViewModel;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface IJournalVoucher
    {
        List<JournlVoucherView> ViewJouranlVoucherView(long CompanyId, long FinancialYearId);
        JournalMaster EditJournalVoucher(long JournalMasterId);
        bool JournalVoucherDelete(long JournalMasterId, string VoucherNo, long VoucherTypeId, long YearId, long CompanyId);
        string JournalvoucherNo(long CompanyId, long FinancialYearId);
        bool VouchernoCheckExistence(long CompanyId, long FinancialYearId, string VoucherNo);
        List<JournalDetails> JournalVoucherView(long JournalMasterId);
        List<JournlDetilsView> JournalVoucherPrint(long JournalMasterId);
    }
}
