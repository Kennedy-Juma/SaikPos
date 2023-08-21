using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.Transaction
{
    public class SalesMaster
    {
        [Key]
        public long SalesMasterId { get; set; }
        [Required]
        public string SerialNo { get; set; }
        [Display(Name = "Voucher No")]
        [Required]
        public string VoucherNo { get; set; }
        public string InvoiceNo { get; set; }
        public long VoucherTypeId { get; set; }
        public long SuffixPrefixId { get; set; }
        public DateTime Date { get; set; }
        [Display(Name = "Date")]
        [Required]
        public string NepaliDate { get; set; }
        public DateTime DueDate { get; set; }
        public string DueDateNep { get; set; }
        public int CreditPeriod { get; set; }
        public long LedgerId { get; set; }
        public long PricinglevelId { get; set; }
        public long SalesManId { get; set; }
        public long SalesAccount { get; set; }
        public long DeliveryNoteMasterId { get; set; }
        public long OrderMasterId { get; set; }
        public string Narration { get; set; }
        public string CustomerName { get; set; }
        public long ExchangeRateId { get; set; }
        public decimal TotalTax { get; set; }
        public decimal AdditionalCost { get; set; }
        public decimal DisPer { get; set; }
        public decimal BillDiscount { get; set; }
        public string CheckDis { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal NetAmounts { get; set; }
        public decimal PreviousDue { get; set; }
        public decimal CashAmount { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal BankAmount { get; set; }
        public string UserId { get; set; }
        public string LrNo { get; set; }
        public string TransportationCompany { get; set; }
        public long QuotationMasterId { get; set; }
        public bool POS { get; set; }
        public string Status { get; set; }
        public long CashId { get; set; }
        public long BankId { get; set; }
        public decimal BalanceDue { get; set; }
        public byte[] DocImages { get; set; }
        public long CounterId { get; set; }
        public long FinancialYearId { get; set; }
        public long CompanyId { get; set; }
        public decimal TaxRate { get; set; }
        
        public long TaxId { get; set; }
        public long CreatedBy { get; set; }
        public long ModifyBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }

        //[NotMapped]
        //public List<AccountLedger> accountLedger { get; set; }
    }
}
