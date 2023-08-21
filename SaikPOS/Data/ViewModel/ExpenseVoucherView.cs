using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class ExpenseVoucherView
    {
        [Key]
        public long ExpensiveMasterId { get; set; }
        public long LedgerId { get; set; }
        [Display(Name = "Voucher Date")]
        public string NepaliDate { get; set; }
        [Display(Name = "Voucher Type")]
        public string VoucherTypeName { get; set; }
        [Display(Name = "Payment No")]
        public string VoucherNo { get; set; }
        [Display(Name = "Amount")]
        public decimal Amount { get; set; }
        [Display(Name = "Narration")]
        public string Narration { get; set; }
        [Display(Name = "User")]
        public DateTime Date { get; set; }
        [Display(Name = "User")]
        public string UserId { get; set; }
        [Display(Name = "Ledger Name")]
        public string LedgerName { get; set; }
    }
}
