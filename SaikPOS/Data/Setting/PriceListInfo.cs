using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class PriceListInfo
    {
        [Key]
        public long PricelistId { get; set; }
        public long ProductId { get; set; }
        public long PricinglevelId { get; set; }
        public long UnitId { get; set; }
        public long BatchId { get; set; }
        public decimal PurchaseRate { get; set; }
        public decimal SalesRate { get; set; }
        public string EffectDate { get; set; }
        public string UnitName { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string PricinglevelName { get; set; }
    }
}
