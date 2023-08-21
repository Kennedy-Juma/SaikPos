using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Transaction
{
    public class PurchaseReturnDetails
    {
        [Key]
        public long PurchaseReturnDetailsId { get; set; }
        public long PurchaseReturnMasterId { get; set; }
        public long ProductId { get; set; }
        public Decimal Qty { get; set; }
        public Decimal Rate { get; set; }
        public long UnitId { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountAmount { get; set; }
        public long TaxId { get; set; }
        public long BatchId { get; set; }
        public long GodownId { get; set; }
        public long UnitConversionId { get; set; }
        public long RackId { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal Amount { get; set; }
        public int SlNo { get; set; }
        public long PurchaseDetailsId { get; set; }
    }
}
