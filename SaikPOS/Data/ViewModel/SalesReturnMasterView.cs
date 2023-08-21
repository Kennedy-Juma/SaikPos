using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class SalesReturnMasterView
    {
        [Key]
        public long SalesReturnMasterId { get; set; }
        public long LedgerId { get; set; }
        public long SalesMasterId { get; set; }
        public string VoucherNo { get; set; }
        public string InvoiceNo { get; set; }
        public string AgainstInvoiceNo { get; set; }
        public DateTime? Date { get; set; }
        public string NepaliDate { get; set; }
        public string VoucherTypeName { get; set; }
        public string LedgerName { get; set; }
        public string Narration { get; set; }
        [Display(Name = "Grand Total")]
        public decimal GrandTotal { get; set; }
        public decimal CashAmount { get; set; }
        public decimal BankAmount { get; set; }
        public decimal BillDiscount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TaxRate { get; set; }
        public string UserId { get; set; }
        public string Address { get; set; }
        public string Pan { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}

