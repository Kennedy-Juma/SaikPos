using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class PurchaseMasterView
    {
        [Key]
        public long PurchaseMasterId { get; set; }
        [Display(Name = "Voucher No")]
        public string VoucherNo { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime Date { get; set; }
        [Display(Name = "Date")]
        public string NepaliDate { get; set; }
        [Display(Name = "Voucher Type")]
        public string VoucherTypeName { get; set; }
        public long LedgerId { get; set; }
        [Display(Name = "Ledger Name")]
        public string LedgerName { get; set; }
        public string LedgerCode { get; set; }
        [Display(Name = "Narration")]
        public string Narration { get; set; }
        [Display(Name = "Grand Total")]
        public decimal GrandTotal { get; set; }
        [Display(Name = "Cash Amount")]
        public decimal CashAmount { get; set; }
        [Display(Name = "Bank Amount")]
        public decimal BankAmount { get; set; }
        [Display(Name = "Bill Discount")]
        public decimal BillDiscount { get; set; }
        [Display(Name = "TotalAmount")]
        public decimal TotalAmount { get; set; }
        [Display(Name = "Credit Amount")]
        public decimal CreditAmount { get; set; }
        public decimal TotalDue { get; set; }
        public decimal PaymentAmount { get; set; }
        [Display(Name = "Total Tax")]
        public decimal TotalTax { get; set; }
        [Display(Name = "User")]
        public string UserId { get; set; }
        public string Address { get; set; }
        public string Pan { get; set; }
        public decimal BalanceDue { get; set; }
        public decimal TaxRate { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }
        public string DuedateNepali { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public List<PurchaseSales> purchaseSales { get; set; }
    }
}
