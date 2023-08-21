using SaikPOS.Data.Setting;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface IArea
    {
        List<Area> GetAll();
        bool CheckName(string name);
        long CheckNameId(string name);
        Area Edit(long id);
        long Save(Area model);
        void Update(Area model);
        bool Delete(long id);
    }
}
