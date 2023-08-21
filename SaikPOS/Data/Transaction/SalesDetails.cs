using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.Transaction
{
    public class SalesDetails
    {
        [Key]
        public long SalesDetailsId { get; set; }
        public long SalesMasterId { get; set; }
        public long DeliveryNoteDetailsId { get; set; }
        public long OrderDetailsId { get; set; }
        public long QuotationDetailsId { get; set; }
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
        public long CompanyId { get; set; }
    }
}
