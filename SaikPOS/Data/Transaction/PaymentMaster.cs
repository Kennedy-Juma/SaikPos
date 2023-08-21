using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.Transaction
{
    public class PaymentMaster
    {
        public long PaymentMasterId { get; set; }
        [Required]
        public string VoucherNo { get; set; }
        public string InvoiceNo { get; set; }
        public long SuffixPrefixId { get; set; }
        [Required]
        public DateTime? Date { get; set; }
        [Required]
        public string NepaliDate { get; set; }
        [Required]
        public long LedgerId { get; set; }
        [Required]
        public decimal TotalAmount { get; set; }
        public string SerialNo { get; set; }
        public long CashId { get; set; }
        public long BankId { get; set; }
        public string Optional { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal CashAmount { get; set; }
        public decimal BankAmount { get; set; }
        public long DetailsId { get; set; }
        public string Narration { get; set; }
        [Required]
        public long VoucherTypeId { get; set; }
        public string UserId { get; set; }
        [Required]
        public long FinancialYearId { get; set; }
        [Required]
        public long CompanyId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public long? AddedBy { get; set; }
        public long? ModifyBy { get; set; }
    }
}
