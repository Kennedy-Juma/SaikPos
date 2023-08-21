using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class FinancialYear
    {
        [Key]
        public long FinancialYearId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public long CompanyId { get; set; }
        public string NepaliFrom { get; set; }
        public string NepaliTo { get; set; }
        public string FiscalYear { get; set; }
        public DateTime? addedDate { get; set; }
        public DateTime? modifyDate { get; set; }
    }
}
