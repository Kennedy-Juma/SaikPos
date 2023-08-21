using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class Counter
    {
        [Key]
      public long CounterId { get; set; } 
        [Display(Name ="CounterName")]
        [Required]
      public string  CounterName { get; set; }
        [Display(Name ="Narration")]
      public string Narration { get; set; }
      public long CompanyId { get; set; }
      public DateTime? AddedDate { get; set; }
      public DateTime? ModifyDate { get; set; }
    }
}
