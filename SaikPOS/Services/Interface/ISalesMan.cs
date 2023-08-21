using SaikPOS.Data.Setting;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface ISalesMan
    {
        List<SalesMan> GetAll();
        bool CheckName(string name);
        long CheckNameId(string name);
        SalesMan Edit(long id);
        long Save(SalesMan model);
        void Update(SalesMan model);
        bool Delete(long id);
    }
}
