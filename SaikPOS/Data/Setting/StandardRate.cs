using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.Setting
{
    public class StandardRate
    {
        [Key]
        public long StandardRateId { get; set; }
        public DateTime ApplicableFrom { get; set; }
        public string FromNepali { get; set; }
        public DateTime ApplicableTo { get; set; }
        public string ToNepali { get; set; }
        public long ProductId { get; set; }
        public long UnitId { get; set; }
        public long BatchId { get; set; }
        public Decimal Rate { get; set; }
        public long CompanyId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        //public List<StandardRateInfo> InfoModel { get; set; }
    }
}
