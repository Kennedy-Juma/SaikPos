using SaikPOS.Data.Setting;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface IUnit
    {
        List<Unit> GetAll();
        bool CheckName(string name);
        long CheckNameId(string name);
        Unit Edit(long id);
        long Save(Unit model);
        void Update(Unit model);
        bool Delete(long id);
    }
}
