using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class InventorySetting
    {
        [Key]
        public long InventoryId { get; set; }
        public bool MultiCurrency { get; set; }
        public bool BillbyBill { get; set; }
        public bool Allowzero { get; set; }
        public bool ShowCurrency { get; set; }
        public bool TickafterPrint { get; set; }
        public bool AutomaticproductCode { get; set; }
        public bool Barcode { get; set; }
        public bool AllowBatch { get; set; }
        public bool ShowDisPer { get; set; }
        public bool ShowDisAmount { get; set; }
        public string NegativecashTransaction { get; set; }
        public string StockvaluecalculationMode { get; set; }
        public string NegativestockStatus { get; set; }
        public bool ShowNetAmount { get; set; }
        public bool ShowTax { get; set; }
        public bool ShowTaxAmount { get; set; }
        public bool DeactiveDate { get; set; }
        public string DateLanguage { get; set; }
        public long VoucherTypeId { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public int WidthOfNumericalPart { get; set; }
        public long StartIndex { get; set; }
        public bool VoucherNoAutomatic { get; set; }
    }
}
