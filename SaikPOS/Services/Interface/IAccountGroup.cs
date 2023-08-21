using SaikPOS.Data.Setting;
using SaikPOS.Data.ViewModel;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface IAccountGroup
    {
        List<AccountGroup> GetAll();
        List<AccountGroupView> ViewAllAccountGroup();
        bool CheckName(string name);
        long CheckNameId(string name);
        AccountGroup Edit(long id);
        bool Save(AccountGroup model);
        bool Update(AccountGroup model);
        bool Delete(long id);
    }
}
