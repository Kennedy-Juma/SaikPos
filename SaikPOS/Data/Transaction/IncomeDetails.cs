using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Transaction
{
    public class IncomeDetails
    {
        [Key]
        public int IncomeDetailsId { get; set; }
        public long IncomeMasterId { get; set; }
        public long LedgerId { get; set; }
        public string Description { get; set; }
        public long TaxId { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
    }
}
