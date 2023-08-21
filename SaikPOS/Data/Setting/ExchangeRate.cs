using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class ExchangeRate
    {
        [Key]
        public long ExchangeRateId { get; set; }
        public long CurrencyId { get; set; }
        public DateTime Date { get; set; }
        public Decimal Rate { get; set; }
        public string Narration { get; set; }
        public long CompanyId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
