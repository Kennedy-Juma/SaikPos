using SaikPOS.Data.Setting;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface ICategory
    {
        List<Category> GetAll();
        bool CheckName(string name);
        long CheckNameId(string name);
        Category Edit(long id);
        long Save(Category model);
        void Update(Category model);
        bool Delete(long id);
    }
}
