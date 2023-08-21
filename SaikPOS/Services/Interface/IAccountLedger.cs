using SaikPOS.Data.Setting;
using SaikPOS.Data.ViewModel;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface IAccountLedger
    {
        List<AccountLedgerView> GetAll(long id);
        List<AccountLedgerView> ViewAllCustomer(long id);
        List<AccountLedgerView> ViewAllSupplier(long id);
        List<AccountLedger> GetCashFill();
        List<AccountLedger> GetBankFill();
        string SerialNoCode(long id);
        AccountLedger Edit(long id);
        bool CheckName(string name);
        long Save(AccountLedger model);
        bool Update(AccountLedger model);
        bool Delete(long id);
    }
}
