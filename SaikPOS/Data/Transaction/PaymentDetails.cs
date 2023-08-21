using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Transaction
{
    public class PaymentDetails
    {
        [Key]
        public long PaymentDetailsId { get; set; }
        public long PaymentMasterId { get; set; }
        public long LedgerId { get; set; }
        public Decimal Amount { get; set; }
        public long ExchangeRateId { get; set; }
        public string ChequeNo { get; set; }
        public DateTime ChequeDate { get; set; }
        public long CompanyId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
