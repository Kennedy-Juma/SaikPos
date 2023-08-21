using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class PaymentReceiveView
    {
        public long ReceiptMasterId { get; set; }
        public long PaymentMasterId { get; set; }
        public string VoucherNo { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime Date { get; set; }
        public string NepaliDate { get; set; }
        public string LedgerName { get; set; }
        public string VoucherTypeName { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal CashAmount { get; set; }
        public decimal BankAmount { get; set; }
        public long DetailsId { get; set; }
        public string UserId { get; set; }
        public string Optional { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
