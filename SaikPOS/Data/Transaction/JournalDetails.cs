using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Transaction
{
    public class JournalDetails
    {
        [Key]
        public long JournalDetailsId { get; set; }
        public long JournalMasterId { get; set; }
        public long LedgerId { get; set; }
        public decimal Credit { get; set; }
        public decimal Debit { get; set; }
        public long ExchangeRateId { get; set; }
        public string ChequeNo { get; set; }
        public string ChequeDate { get; set; }
        public string Description { get; set; }
    }
}
