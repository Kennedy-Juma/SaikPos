using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class FinancialReport
    {
        public int ID { get; set; }
        public long CompanyId { get; set; }
        public long FinancialYearId { get; set; }
        public long AccountGroupId { get; set; }
        public long VoucherTypeId { get; set; }
        public long LedgerId { get; set; }
        public long SubledgerId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal OpeningDr { get; set; }
        public decimal OpeningCr { get; set; }
        public decimal ClosingDr { get; set; }
        public decimal ClosingCr { get; set; }
        public string OpeningBalance { get; set; }
        public string Balance { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Totalassects { get; set; }
        public decimal TotalLiabilities { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpen { get; set; }
        public string VoucherTypeName { get; set; }
        public string VoucherNo { get; set; }
        public string NepaliDate { get; set; }
        public DateTime FromDateEng { get; set; }
        public DateTime ToDateEng { get; set; }
        public string LedgerCode { get; set; }
        public string LedgerName { get; set; }
        public decimal Qty { get; set; }
        public string UnitName { get; set; }
        public string ProductName { get; set; }
        public decimal totalSale { get; set; }
        public decimal totalPurchase { get; set; }

        public string UserName { get; set; }
        public string Narration { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }

        //WterElectricity
        public string FeeHead { get; set; }
        public decimal Amount { get; set; }
    }
}
