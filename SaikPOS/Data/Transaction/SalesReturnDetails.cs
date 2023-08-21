using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Transaction
{
    public class SalesReturnDetails
    {
        [Key]
        public long SalesReturnDetailsId { get; set; }
        public long SalesReturnMasterId { get; set; }
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
