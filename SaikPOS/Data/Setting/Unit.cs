using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.Setting
{
    public class Unit
    {
        [Key]
        public long UnitId { get; set; }
        [Display(Name ="Unit Name")]
        [Required]
        public string UnitName { get; set; }
        [Display(Name ="NoOfDecimalPlaces")]
        [Required]
        public int NoOfDecimalplaces { get; set; }
        [Display(Name ="FormalName")]
        [Required]
        public string FormalName { get; set; }
        public long CompanyId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
