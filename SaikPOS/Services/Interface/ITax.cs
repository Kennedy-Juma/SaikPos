using SaikPOS.Data.Setting;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface ITax
    {
        List<Tax> GetAll();
        bool CheckName(string name);
        long CheckNameId(string name);
        Tax Edit(long id);
        long Save(Tax model);
        void Update(Tax model);
        bool Delete(long id);
    }
}
