using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.Setting
{
    public class Reminder
    {
        [Key]
        public long ReminderId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string RemindAbout { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }
        public string Repeat { get; set; }
        public string CallPurpose { get; set; }
        public string RelatedTo { get; set; }
        public DateTime? CallStarted { get; set; }
        public string LedgerId { get; set; }
        public long CompanyId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
