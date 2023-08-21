using SaikPOS.Data.Setting;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface IFinancialYear
    {
        List<FinancialYear> GetAll();
        bool CheckName(string name);
        long CheckNameId(string name);
        FinancialYear Edit(long id);
        long Save(FinancialYear model);
        void Update(FinancialYear model);
        bool Delete(long id);
    }
}
