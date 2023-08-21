using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class PricingLevel
    {
        [Key]
        public long PricinglevelId { get; set; }
        [Display(Name ="PricingLevel Name")]
        [Required]
        public string PricinglevelName { get; set; }
        public string Narration { get; set; }
        public long CompanyId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
