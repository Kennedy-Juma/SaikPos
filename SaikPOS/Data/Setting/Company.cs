using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.Setting
{
    public class Company
    {
        [Key]
        public long CompanyId { get; set; }
        [Display(Name ="Company")]
        [Required]
        public string CompanyName { get; set; }
        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }
        public string CompanyType { get; set; }
        [Display(Name = "Pan")]
        public string Pan { get; set; }
        [Display(Name = "Phone")]
        [Required]
        public string Phone { get; set; }
        [Display(Name = "Mobile")]
        [Required]
        public string Mobile { get; set; }
        [Display(Name = "Email")]
        [Required]
        public string EmailId { get; set; }
        [Display(Name = "Web")]
        [Required]
        public string Web { get; set; }
        [Display(Name = "Country")]
        [Required]
        public long CountryId { get; set; }
        [Display(Name = "State")]
        [Required]
        public string State { get; set; }
        public string City { get; set; }
        [Display(Name = "Estd")]
        [Required]
        public string Estd { get; set; }
        public byte[] LogoPath { get; set; }
        public long FinancialYearId { get; set; }
        [Display(Name = "Financial From Date")]
        public string FromNepali { get; set; }
        [Display(Name = "Financial To Date")]
        public string ToNepali { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        [Display(Name = "Fiscal Year")]
        public string FiscalYear { get; set; }
        [Display(Name = "Currency")]
        public long CurrencyId { get; set; }
        [Display(Name = "Decimal Place")]
        [Required]
        public int NoofDecimal { get; set; }
    }
}
