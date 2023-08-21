using SaikPOS.Data.Setting;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface ICountry
    {
        List<Country> GetAll();
        bool CheckName(string name);
        long CheckNameId(string name);
        Country Edit(long id);
        long Save(Country model);
        void Update(Country model);
        bool Delete(long id);
    }
}
