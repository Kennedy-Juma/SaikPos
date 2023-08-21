using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaikPOS.Data.Transaction
{
    public class PurchaseMaster
    {
        [Key]
        public long PurchaseMasterId { get; set; }
        [Required]
        public string SerialNo { get; set; }
        [Display(Name = "Voucher No")]
        [Required]
        public string VoucherNo { get; set; }
        [Display(Name = "Invoice No")]
        public string InvoiceNo { get; set; }
        public long SuffixPrefixId { get; set; }
        public long VoucherTypeId { get; set; }
        
        public DateTime Date { get; set; }
        [Display(Name = "Date")]
        [Required]
        public string NepaliDate { get; set; }
        public long LedgerId { get; set; }
        public DateTime DueDate { get; set; }
        public string DuedateNepali { get; set; }
        [Display(Name = "Credit Period")]
        public int CreditPeriod { get; set; }
        public long ExchangeRateId { get; set; }
        public string Narration { get; set; }
        public long PurchaseAccount { get; set; }
        public long PurchaseOrderMasterId { get; set; }
        public long MaterialReceiptMasterId { get; set; }
        public decimal AdditionalCost { get; set; }
        public long TaxId { get; set; }
        public decimal TotalTax { get; set; }
        public decimal DisPer { get; set; }
        public decimal BillDiscount { get; set; }
        public string CheckDis { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal NetAmounts { get; set; }
        public string UserId { get; set; }
        public string LrNo { get; set; }
        public string TransportationCompany { get; set; }
        public long FinancialYearId { get; set; }
        public long CompanyId { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal CashAmount { get; set; }
        public decimal BankAmount { get; set; }
        public decimal TaxRate { get; set; }
        public decimal BalanceDue { get; set; }
        public string Status { get; set; }
        public decimal PreviousDue { get; set; }
        public long CashId { get; set; }
        public long BankId { get; set; }
        public decimal Amountused { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public long? AddedBy { get; set; }
        public long? ModifyBy { get; set; }
        public List<PurchaseDetails> details { get; set; } = new List<PurchaseDetails>();
    }
}
