using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Transaction
{
    public class BankReconciliation
    {
        [Key]
        public long ReconcileId { get; set; }
        [Display(Name ="LedgerPostingName")]
        [Required]
        public long LedgerPostingId { get; set; }
        public long CompanyId { get; set; }
        public DateTime StatementDate { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
