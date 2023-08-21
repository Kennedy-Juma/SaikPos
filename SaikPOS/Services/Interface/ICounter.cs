using SaikPOS.Data.Setting;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface ICounter
    {
        List<Counter> GetAll();
        bool CheckName(string name);
        long CheckNameId(string name);
        Counter Edit(long id);
        long Save(Counter model);
        void Update(Counter model);
        bool Delete(long id);
    }
}
