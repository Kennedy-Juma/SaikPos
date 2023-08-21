using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class IncomeExpenditureView
    {
        public long IncomeDetailsId { get; set; }
        public long ExpensiveDetailsId { get; set; }
        public int Id { get; set; }
        public long LedgerId { get; set; }
        public string LedgerName { get; set; }
        public string Description { get; set; }
        public long TaxId { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
    }
}
