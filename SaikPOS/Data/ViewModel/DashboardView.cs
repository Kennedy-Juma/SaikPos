using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class DashboardView
    {
        public int totalCustomer { get; set; }
        public int totalSupplier { get; set; }
        public int totalCustomerSupplier { get; set; }
        public decimal totalSale { get; set; }
        public decimal totalPurchase { get; set; }
        public decimal CashAmount { get; set; }
        public decimal BankAmount { get; set; }
        public decimal creditAmount { get; set; }
        public decimal debit { get; set; }
        public decimal credit { get; set; }
        public decimal totalAmount { get; set; }
        public decimal Purchase { get; set; }
        public decimal Payment { get; set; }
        public List<FinancialReport> toprecible { get; set; }
        public List<FinancialReport> toppyble { get; set; }
        public List<FinancialReport> topunit { get; set; }
    }
}
