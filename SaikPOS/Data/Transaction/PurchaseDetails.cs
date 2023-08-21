using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Transaction
{
    public class PurchaseDetails
    {
        [Key]
        public long PurchaseDetailsId { get; set; }
        public long PurchaseMasterId { get; set; }
        public long ReceiptDetailsId { get; set; }
        public long OrderDetailsId { get; set; }
        public long ProductId { get; set; }
        public decimal Qty { get; set; }
        public decimal Rate { get; set; }
        public long UnitId { get; set; }
        public long UnitConversionId { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountAmount { get; set; }
        public long TaxId { get; set; }
        public long BatchId { get; set; }
        public long GodownId { get; set; }
        public long RackId { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal Amount { get; set; }
        public int SlNo { get; set; }
    }
}
