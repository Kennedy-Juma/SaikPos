using SaikPOS.Data.Setting;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface ICurrency
    {
        List<Currency> GetAll();
        bool CheckName(string name);
        long CheckNameId(string name);
        Currency Edit(long id);
        long Save(Currency model);
        void Update(Currency model);
        bool Delete(long id);
    }
}
