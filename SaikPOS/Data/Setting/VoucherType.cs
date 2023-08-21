using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class VoucherType
    {
        [Key]
        public long VoucherTypeId { get; set; }
        public string VoucherTypeName { get; set; }
        public string TypeOfVoucher { get; set; }
        public string MethodOfVoucherNumbering { get; set; }
        public bool IsTaxApplicable { get; set; }
        public string Narration { get; set; }
        public long CompanyId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public long MasterId { get; set; }
        public string Declaration { get; set; }
        public string Heading1 { get; set; }
        public string Heading2 { get; set; }
        public string Heading3 { get; set; }
        public string Heading4 { get; set; }
    }
}
