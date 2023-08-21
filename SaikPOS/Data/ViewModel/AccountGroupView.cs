using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class AccountGroupView
    {
        [Key]
        public long AccountGroupId { get; set; }
        [Display(Name = "AccountGroup Name")]
        [Required]
        public string AccountGroupName { get; set; }
        [Display(Name = "Groupe Under")]
        public string Under { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
