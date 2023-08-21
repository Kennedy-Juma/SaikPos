using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class ProductGroup
    {
        [Key]
        public long GroupId { get; set; }
        [Display(Name = "Group Name")]
        [Required]
        public string GroupName { get; set; }
        [Display(Name = "Group Under")]
        [Required]
        public long GroupUnder { get; set; }
        [Display(Name = "Narration")]
        public string Narration { get; set; }
        public long CompanyId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
