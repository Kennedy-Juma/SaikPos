using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class CompanyView
    {
        public long companyId { get; set; }
        [Display(Name = "Company Name")]
        public string companyName { get; set; }
        [Display(Name = "Address")]
        public string address { get; set; }
        [Display(Name = "Company Type")]
        public string companyType { get; set; }
        [Display(Name = "Phone")]
        public string phone { get; set; }
        [Display(Name = "Under")]
        public string under { get; set; }
        [Display(Name = "Image")]
        public string logoPath { get; set; }
    }
}
