using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.ViewModel
{
    public class AccountLedgerView
    {
        [Key]
        public long LedgerId { get; set; }
        [Display(Name = "AccountGroup Name")]
        public string AccountGroupName { get; set; }
        [Display(Name = "Ledger Name")]
        public string LedgerName { get; set; }
        public string LedgerCode { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Display(Name = "Mobile")]
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string LogoPathC { get; set; }
        [Display(Name = "Area Name")]
        public string AreaName { get; set; }
        public decimal OpeningBalance { get; set; } 
        [Display(Name = "PricingLevel Name")]
        public string PricinglevelName { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
