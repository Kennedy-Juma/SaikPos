using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.Setting
{
    public class UnitConvertion
    {
        [Key]
        public long UnitconversionId { get; set; }
        public long ProductId { get; set; }
        public long UnitId { get; set; }
        public decimal ConversionRate { get; set; }
        public int Quantities { get; set; }
        public long CompanyId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
