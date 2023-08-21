using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.Setting
{
    public class Branch
    {
        [Key]
        public long BranchId { get; set; }
        [Display(Name = "Branch Name")]
        [Required]
        public string BranchName { get; set; }
        [Display(Name = "Contact Person")]
        [Required]
        public string ContactPerson { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Short Description")]
        public string Description { get; set; }



    }
}
