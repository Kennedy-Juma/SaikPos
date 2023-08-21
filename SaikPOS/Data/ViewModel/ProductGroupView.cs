using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class ProductGroupView
    {
        [Key]
        public long groupId { get; set; }
        [Display(Name = "Group Name")]
        public string groupName { get; set; }
        public long groupUnder { get; set; }
        public string Under { get; set; }
        public DateTime addedDate { get; set; }
        public DateTime modifyDate { get; set; }
    }
}
