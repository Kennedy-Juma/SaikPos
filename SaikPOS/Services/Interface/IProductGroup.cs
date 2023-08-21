using SaikPOS.Data.Setting;
using SaikPOS.Data.ViewModel;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface IProductGroup
    {
        List<ProductGroup> GetAll();
        List<ProductGroupView> ViewAllProductGroup();
        bool CheckName(string name);
        long CheckNameId(string name);
        ProductGroup Edit(long id);
        long Save(ProductGroup model);
        void Update(ProductGroup model);
        bool Delete(long id);
    }
}
