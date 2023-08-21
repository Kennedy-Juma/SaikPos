using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.Setting
{
    public class PriceList
    {
        [Key]
        public long PricelistId { get; set; }
        public long ProductId { get; set; }
        public long PricinglevelId { get; set; }
        public long UnitId { get; set; }
        public long BatchId { get; set; }
        public decimal PurchaseRate { get; set; }
        public decimal SalesRate { get; set; }
        public DateTime Date { get; set; }
        public string EffectDate { get; set; }
        public long CompanyId { get; set; }
        public decimal FromQty { get; set; }
        public decimal ToQty { get; set; }
        public decimal Discount { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
