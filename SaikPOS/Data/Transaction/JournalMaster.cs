using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Transaction
{
    public class JournalMaster
    {
        [Key]
        public long JournalMasterId { get; set; }
        public string SerialNo { get; set; }
        public string VoucherNo { get; set; }
        public string InvoiceNo { get; set; }
        public long SuffixPrefixId { get; set; }
        public DateTime? Date { get; set; }
        public string NepaliDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string UserId { get; set; }
        public string Narration { get; set; }
        public long VoucherTypeId { get; set; }
        public long FinancialYearId { get; set; }
        public long CompanyId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public long? CreatedBy { get; set; }
        public long? ModifiedBy { get; set; }
        public string Prepairedby { get; set; }
        public string Checkedby { get; set; }
        public string Checkedbypost { get; set; }
        public string Swikritiby { get; set; }
        public string SwikritibyPost { get; set; }
        public string Receivedby { get; set; }
        public string RasidNo { get; set; }
        public string CheckNo { get; set; }
        public string ReceiptNo { get; set; }
        public string PraptaName { get; set; }
        public string Rakam { get; set; }
        public string PreparedBypost { get; set; }
        public string ApprovedPost { get; set; }
        public string ReceivePost { get; set; }

        public List<JournalDetails> Addresses { get; set; } = new List<JournalDetails>();
    }
}
