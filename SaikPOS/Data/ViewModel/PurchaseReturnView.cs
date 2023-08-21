using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class PurchaseReturnView
    {
        [Key]
        public long PurchaseReturnMasterId { get; set; }
        public string VoucherNo { get; set; }
        public string InvoiceNo { get; set; }
        public long LedgerId { get; set; }
        public string AgainstInvoiceNo { get; set; }
        public DateTime? Date { get; set; }
        public string NepaliDate { get; set; }
        public string VoucherTypeName { get; set; }
        public string LedgerName { get; set; }
        public string Narration { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal CashAmount { get; set; }
        public decimal BankAmount { get; set; }
        public decimal BillDiscount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TaxRate { get; set; }
        public string UserId { get; set; }
        public string address { get; set; }
        public string Pan { get; set; }
        public DateTime? addedDate { get; set; }
        public DateTime? modifyDate { get; set; }
    }
}
