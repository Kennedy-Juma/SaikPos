using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class AccountGroup
    {
        [Key]
        public long AccountGroupId { get; set; }
        [Required]
        public string AccountGroupName { get; set; }
        public long GroupUnder { get; set; }
        [Required]
        public string GroupCode { get; set; }
        public long CompanyId { get; set; }
        public string Narration { get; set; }
        public bool IsDefault { get; set; }
        public string Nature { get; set; }
        public string AffectGrossProfit { get; set; }
        public long? CreatedBy { get; set; }
        public long? ModifyBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
