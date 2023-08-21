using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class SalesMan
    {
        [Key]
        public long SalesManId { get; set; }
        [Display(Name ="SalesMan Name")]
        [Required]
        public string SalesmanName { get; set; }
        [Display(Name = "Narration")]
        public string Narration { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
