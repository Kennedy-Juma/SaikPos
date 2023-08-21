using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class BillingReport
    {
        public long BillMasterId { get; set; }
        [Display(Name = "रसिद नं")]
        public string RasidNo { get; set; }
        public string BillingDate { get; set; }
        [Display(Name = "मिति")]
        public string billingdateNepali { get; set; }
        public string UserName { get; set; }
        [Display(Name = "ग्राहक नम्वर")]
        public long CustomerId { get; set; }
        [Display(Name = "ग्राहकको नाम")]
        public string CustomerName { get; set; }
        [Display(Name = "ग्राहकको नाम")]
        public string CustomerNepali { get; set; }
        [Display(Name = "ग्राहक नम्वर")]
        public string CustomerNo { get; set; }
        [Display(Name = "ठेगाना")]
        public string Address { get; set; }
        [Display(Name = "टोल")]
        public string ToleName { get; set; }
        [Display(Name = "मिटर नं")]
        public string MeterNo { get; set; }
        public string fromTomonth { get; set; }
        public string feeHead { get; set; }
        public decimal Amount { get; set; }
        public long ReadingID { get; set; }
        public decimal Fee1 { get; set; }
        public decimal Fee2 { get; set; }
        public decimal Fee3 { get; set; }
        public decimal Fee4 { get; set; }
        public decimal Fee5 { get; set; }
        public decimal Fee6 { get; set; }
        public decimal Fee7 { get; set; }
        public decimal Fee8 { get; set; }
        public decimal Fee9 { get; set; }
        public decimal Fee10 { get; set; }
        public decimal Fee11 { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Fee12 { get; set; }
        public decimal Fee13 { get; set; }
        public decimal Fee14 { get; set; }
        public decimal Fee15 { get; set; }
        public decimal Fee16 { get; set; }
        public decimal Fee17 { get; set; }
        public decimal Fee18 { get; set; }
        public decimal Total { get; set; }
        public string fromDate { get; set; }
        public DateTime fromDateEng { get; set; }
        public string toDate { get; set; }
        public DateTime toDateEng { get; set; }
        public string Result_nepali { get; set; }
        public string Description { get; set; }
        public int SlNo { get; set; }
        public int CountMonthID { get; set; }
        public int MonthID { get; set; }

        //Meter Reading
        public string YearName { get; set; }
        public string MonthName { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public decimal SabikUnit { get; set; }
        public decimal HalkoUnit { get; set; }
        public decimal DueUnit { get; set; }
        public decimal Rate { get; set; }
        public decimal TotalRecord { get; set; }
        public string StatusName { get; set; }
        public string NepaliDate { get; set; }
        public decimal adhiktamRate { get; set; }
        public decimal TotalPayment { get; set; }
        public long AddedUserid { get; set; }
        //
        public int Male { get; set; }
        public int Female { get; set; }
        public int Other { get; set; }
        public int TotalCustomer { get; set; }
    }
}
