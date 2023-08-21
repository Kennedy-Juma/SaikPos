using SaikPOS.Data.Setting;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface ICompany
    {
        List<Company> GetAll();
        Company Edit(long id);
        void Update(Company model);
    }
}
