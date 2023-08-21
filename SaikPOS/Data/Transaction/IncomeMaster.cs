using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Transaction
{
    public class IncomeMaster
    {
        [Key]
        public long IncomeMasterId { get; set; }
        public long LedgerId { get; set; }
        [Required]
        public DateTime? Date { get; set; }
        [Display(Name = "Voucher Date")]
        public string NepaliDate { get; set; }
        public long VoucherTypeId { get; set; }
        [Required]
        public string SerialNo { get; set; }
        [Display(Name = "Payment No")]
        public string VoucherNo { get; set; }
        public string InvoiceNo { get; set; }
        [Display(Name = "Amount")]
        [Required]
        public decimal Amount { get; set; }
        [Display(Name = "Narration")]
        public string Narration { get; set; }
        public long SuffixPrefixId { get; set; }
        public long FinancialYearId { get; set; }
        public string PaymentType { get; set; }
        public long CompanyId { get; set; }
        public string UserId { get; set; }
        public long CashId { get; set; }
        public long BankId { get; set; }
        public decimal CashAmount { get; set; }
        public decimal BankAmount { get; set; }
        public decimal CreditAmount { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public long? AddedBy { get; set; }
        public long? ModifyBy { get; set; }

        public List<IncomeDetails> Addresses { get; set; } = new List<IncomeDetails>();
    }
}
