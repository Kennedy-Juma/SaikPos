using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.Setting
{
    public class Tax
    {
        [Key]
        public long TaxId { get; set; }
        [Display(Name = "Tax Name")]
        [Required]
        public string TaxName { get; set; }
        public string ApplicableOn { get; set; }
        [Display(Name = "Rate %")]
        [Required]
        public Decimal Rate { get; set; }
        public string CalculatingMode { get; set; }
        [Display(Name = "Narration")]
        public string Narration { get; set; }
        public bool IsActive { get; set; }
        public long CompanyId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
