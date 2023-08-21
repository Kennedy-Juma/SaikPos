using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.Setting
{
    public class Area
    {
        [Key]
        public long AreaId { get; set; }
        [Display(Name = "Area Name")]
        [Required]
        public string AreaName { get; set; }
        [Display(Name = "Narration")]
        public string Narration { get; set; }
        public long CompanyId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
