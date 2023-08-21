using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class PaymentSupplierView
    {
        public long PaymentMasterId { get; set; }
        public long ReceiptMasterId { get; set; }

        [Display(Name = "Voucher No")]
        public string VoucherNo { get; set; }
        public DateTime Date { get; set; }
        [Display(Name = "Date")]
        public string NepaliDate { get; set; }
        [Display(Name = "Voucher Type")]
        public string VoucherTypeName { get; set; }
        [Display(Name = "Ledger Name")]
        public string LedgerName { get; set; }
        [Display(Name = "Narration")]
        public string Narration { get; set; }
        [Display(Name = "Debit")]
        public decimal Debit { get; set; }
        [Display(Name = "Credit")]
        public decimal Credit { get; set; }
        [Display(Name = "Credit Amount")]
        public decimal CreditAmount { get; set; }
        [Display(Name = "Cash Amount")]
        public decimal CashAmount { get; set; }
        [Display(Name = "Bank Amount")]
        public decimal BankAmount { get; set; }
        [Display(Name = "Pan")]
        public string Pan { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "User")]
        public string UserId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }

        //Due
        public decimal DueBalance { get; set; }
        public long LedgerId { get; set; }
    }
}
