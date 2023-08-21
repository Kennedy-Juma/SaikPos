using SaikPOS.Data.Setting;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface IBranch
    {
        List<Branch> GetAll();
        bool CheckName(string name);
        long CheckNameId(string name);
        Branch Edit(long id);
        long Save(Branch model);
        void Update(Branch model);
        bool Delete(long id);
    }
}
