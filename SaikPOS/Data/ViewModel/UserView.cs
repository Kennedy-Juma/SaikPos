using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModels
{
    public class UserView
    {
        [Key]
        public long userId { get; set; }
        [Display(Name = "User")]
        public string userName { get; set; }
        [Display(Name = "Role Name")]
        public string roleName { get; set; }
        [Display(Name = "Narration")]
        public string narration { get; set; }
        public DateTime addedDate { get; set; }
        public DateTime modifyDate { get; set; }
        public string logoPath { get; set; }
    }
}
