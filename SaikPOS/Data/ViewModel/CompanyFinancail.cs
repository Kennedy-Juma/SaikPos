using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class CompanyFinancail
    {
        [Display(Name = "Company")]
        [Required]
        public string companyName { get; set; }
        [Display(Name = "Code")]
        [Required]
        public string code { get; set; }
        [Display(Name = "Address")]
        [Required]
        public string address { get; set; }
        [Display(Name = "Under")]
        [Required]
        public long underCompany { get; set; }
        [Display(Name = "Company Type")]
        public string companyType { get; set; }
        [Display(Name = "Pan")]
        public string pan { get; set; }
        [Display(Name = "Phone")]
        [Required]
        public string phone { get; set; }
        [Display(Name = "Mobile")]
        public string mobile { get; set; }
        [Display(Name = "Email")]
        public string emailId { get; set; }
        [Display(Name = "Web")]
        public string web { get; set; }
        [Display(Name = "Country")]
        public string country { get; set; }
        [Display(Name = "State")]
        public string state { get; set; }
        [Display(Name = "Pin No")]
        public string pinNo { get; set; }
        [Display(Name = "Logo")]
        public string logo { get; set; }
        [Display(Name = "Estd")]
        public string estd { get; set; }
        public string logoPath { get; set; }
        public long financialYearId { get; set; }
        [Display(Name = "Financial From Date")]
        public string fromNepali { get; set; }
        [Display(Name = "Financial To Date")]
        public string toNepali { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        [Display(Name = "Fiscal Year")]
        public string FiscalYear { get; set; }
        [Display(Name = "Currency")]
        public long currencyId { get; set; }
        [Display(Name = "Decimal Place")]
        [Required]
        public int noofDecimal { get; set; }
    }
}
