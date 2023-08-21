using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.Setting
{
    public class SuffixPrefix
    {
        [Key]
        public long SuffixprefixId { get; set; }
        public long VoucherTypeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public long StartIndex { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public int WidthOfNumericalPart { get; set; }
        public bool PrefillWithZero { get; set; }
        public string Narration { get; set; }
        public long CompanyId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
