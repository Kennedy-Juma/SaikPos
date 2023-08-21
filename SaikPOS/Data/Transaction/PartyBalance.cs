using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Transaction
{
    public class PartyBalance
    {
        [Key]
        public long PartyBalanceId { get; set; }
        [Required]
        public string SerialNo { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Display(Name = "Date")]
        public string NepaliDate { get; set; }
        [Display(Name = "Ledger Name")]
        public long LedgerId { get; set; }
        public long VoucherTypeId { get; set; }
        [Display(Name = "Voucher No")]
        public string VoucherNo { get; set; }
        public long AgainstVoucherTypeId { get; set; }
        public string AgainstVoucherNo { get; set; }
        public string InvoiceNo { get; set; }
        public string AgainstInvoiceNo { get; set; }
        public string ReferenceType { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal CashAmount { get; set; }
        public decimal BankAmount { get; set; }
        public long DetailsId { get; set; }
        public string Narration { get; set; }
        public int CreditPeriod { get; set; }
        public long ExchangeRateId { get; set; }
        public long FinancialYearId { get; set; }
        public long CompanyId { get; set; }
        public string UserName { get; set; }
        public long CashId { get; set; }
        public long BankId { get; set; }
        public string Optional { get; set; }
        public decimal Amountused { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
