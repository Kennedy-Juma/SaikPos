using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.Transaction
{
    public class StockPosting
    {
        [Key]
        public long StockPostingId { get; set; }
        public DateTime Date { get; set; }
        public string NepaliDate { get; set; }
        public long VoucherTypeId { get; set; }
        public string VoucherNo { get; set; }
        public string InvoiceNo { get; set; }
        public long ProductId { get; set; }
        public long BatchId { get; set; }
        public long UnitId { get; set; }
        public long GodownId { get; set; }
        public long RackId { get; set; }
        public long AgainstVoucherTypeId { get; set; }
        public string AgainstInvoiceNo { get; set; }
        public string AgainstVoucherNo { get; set; }
        public Decimal InwardQty { get; set; }
        public Decimal OutwardQty { get; set; }
        public Decimal Rate { get; set; }
        public long FinancialYearId { get; set; }
        public long CompanyId { get; set; }
        public long DetailsId { get; set; }
        public long LedgerId { get; set; }
        public string StockCalculate { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
