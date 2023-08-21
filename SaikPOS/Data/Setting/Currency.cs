using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class Currency
    {
        [Key]
        public long CurrencyId { get; set; }
        [Display(Name ="Currency Symbol")]
        [Required]
        public string CurrencySymbol { get; set; }
        [Required]
        [Display(Name ="Currency Name")]
        public string CurrencyName { get; set; }
        public decimal noOfDecimalPlaces { get; set; }
        [Display(Name ="Narration")]
        public string Narration { get; set; }
        public bool IsDefault { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
