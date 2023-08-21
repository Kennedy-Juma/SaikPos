using SaikPOS.Data.Setting;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface IBatch
    {
        List<Batch> GetAll();
        bool CheckName(string name);
        long CheckNameId(string name);
        Batch Edit(long id);
        long Save(Batch model);
        void Update(Batch model);
        bool Delete(long id);
    }
}
