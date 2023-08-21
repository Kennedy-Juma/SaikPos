using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Transaction
{
    public class LedgerPosting
    {
        [Key]
        public long LedgerPostingId { get; set; }
        public DateTime Date { get; set; }
        public string NepaliDate { get; set; }
        public long VoucherTypeId { get; set; }
        public string VoucherNo { get; set; }
        public long LedgerId { get; set; }
        public Decimal Debit { get; set; }
        public Decimal Credit { get; set; }
        public long DetailsId { get; set; }
        public long YearId { get; set; }
        public string InvoiceNo { get; set; }
        public string ChequeNo { get; set; }
        public string ChequeDate { get; set; }
        public long CompanyId { get; set; }
        public string ReferenceN { get; set; }
        public string LongReference { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
