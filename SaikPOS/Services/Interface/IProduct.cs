using SaikPOS.Data.Setting;
using SaikPOS.Data.Transaction;
using SaikPOS.Data.ViewModel;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface IProduct
    {
        List<ProductView> ViewAllProduct(long id);
        List<ProductView> ViewCategoryWiseProduct(long id);
        bool CheckName(string name);
        long CheckNameId(string name);
        string GetProductNo(long companyId);
        Product Edit(long id);
        long Save(Product model);
        long SaveOpeningStock(StockPosting posting);
        void Update(Product model);
        bool Delete(long id);
    }
}
