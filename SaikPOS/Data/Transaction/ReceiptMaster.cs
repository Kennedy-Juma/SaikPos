using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Transaction
{
    public class ReceiptMaster
    {
        [Key]
        public long ReceiptMasterId { get; set; }
        [Required]
        public string VoucherNo { get; set; }
        public string InvoiceNo { get; set; }
        public long SuffixPrefixId { get; set; }
        [Required]
        public DateTime? Date { get; set; }
        [Required]
        public long LedgerId { get; set; }
        [Required]
        public Decimal TotalAmount { get; set; }
        public string SerialNo { get; set; }
        public long CashId { get; set; }
        public long BankId { get; set; }
        public string Optional { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal CashAmount { get; set; }
        public decimal BankAmount { get; set; }
        public long DetailsId { get; set; }
        public string Narration { get; set; }
        [Required]
        public long VoucherTypeId { get; set; }
        public string UserId { get; set; }
        [Required]
        public long FinancialYearId { get; set; }
        [Required]
        public long CompanyId { get; set; }
        public string NepaliDate { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
