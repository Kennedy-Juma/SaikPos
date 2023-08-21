using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class JournlDetilsView
    {
        public long JournalDetailsId { get; set; }
        public DateTime Date { get; set; }
        [Display(Name = "Voucher Type")]
        public string VoucherTypeName { get; set; }
        public long LedgerId { get; set; }
        public long AccountGroupId { get; set; }
        [Display(Name = "Ledger Name")]
        public string LedgerName { get; set; }
        public string AccountGroupName { get; set; }
        [Display(Name = "Credit")]
        public decimal Credit { get; set; }
        [Display(Name = "Debit")]
        public decimal Debit { get; set; }
        [Display(Name = "Closing")]
        public string Closing { get; set; }
        [Display(Name = "Voucher No")]
        public string VoucherNo { get; set; }
        public string MasterId { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Total Amount")]
        public decimal TotalAmount { get; set; }
        public long ExpensiveDetailsId { get; set; }
        public long ExpensiveMasterId { get; set; }
        public long IncomeDetailsId { get; set; }
        public long Id { get; set; }
    }
}
