using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class JournlVoucherView
    {
        [Key]
        public long JournalMasterId { get; set; }
        public long LedgerId { get; set; }
        [Display(Name = "Voucher No")]
        public string VoucherNo { get; set; }
        [Display(Name = "Date")]
        public string NepaliDate { get; set; }
        [Display(Name = "Voucher Type")]
        public string VoucherTypeName { get; set; }
        [Display(Name = "Narration")]
        public string Narration { get; set; }
        [Display(Name = "Total Amount")]
        public decimal TotalAmount { get; set; }
        [Display(Name = "Credit")]
        public decimal Credit { get; set; }
        [Display(Name = "Debit")]
        public decimal Debit { get; set; }
        [Display(Name = "User")]
        public string UserId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }

    }
}
