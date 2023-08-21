using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class AccountLedgerCopy
    {
        [Key]
        public long LedgerId { get; set; }
        [Display(Name = "AccountGroup Name")]
        [Required]
        public long AccountGroupId { get; set; }
        [Display(Name = "Ledger Name")]
        [Required]
        public string LedgerName { get; set; }
        [Display(Name = "Alias")]
        [Required]
        public string LedgerCode { get; set; }
        public long CompanyId { get; set; }
        [Display(Name = "OpeningBalance")]
        public Decimal OpeningBalance { get; set; }
        public bool IsDefault { get; set; }
        [Display(Name = "CrOrDr")]
        public string CrOrDr { get; set; }
        public string Narration { get; set; }
        [Display(Name = "MailingName")]
        public string MailingName { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Display(Name = "Mobile")]
        public string Mobile { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "CreditPeriod")]
        public int CreditPeriod { get; set; }
        [Display(Name = "CreditLimit")]
        public Decimal CreditLimit { get; set; }
        [Display(Name = "Pricinglevel Name")]
        public long PricinglevelId { get; set; }
        [Display(Name = "BillByBill")]
        public bool BillByBill { get; set; }
        [Display(Name = "Tin")]
        public string Tin { get; set; }
        [Display(Name = "Cst")]
        public string Cst { get; set; }
        [Display(Name = "Pan")]
        public string Pan { get; set; }
        [Display(Name = "Route Name")]
        public long RouteId { get; set; }
        [Display(Name = "BankAccountNumber")]
        public string BankAccountNumber { get; set; }
        [Display(Name = "BranchName")]
        public string BranchName { get; set; }
        [Display(Name = "BrachCode")]
        public string BranchCode { get; set; }
        [Display(Name = "Area Name")]
        [Required]
        public long AreaId { get; set; }
        public string LogoC { get; set; }
        public string LogoPathC { get; set; }
        [Display(Name = "Skype Id")]
        public string SkypeID { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string instagram { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Mnucapality { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string Website { get; set; }
        [Display(Name = "Refer From")]
        public string Referfrom { get; set; }
        public string Map { get; set; }
        [Display(Name = "D.O.B")]
        public DateTime? Dob { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? AnniversaryDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
