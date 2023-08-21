using SaikPOS.Data.Setting;

namespace SaikPOS.Services.Interface
{
    public interface IInventorySetting
    {
        InventorySetting EditInventorySetting(long VoucherTypeId);
        string GetVoucherNo(long CompanyId, long FinancialYearId, long VoucherTypeId);
    }
}
