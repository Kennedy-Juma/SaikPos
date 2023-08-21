using System;

namespace SaikPOS.Data
{
    public class CartItem
    {
        public long ProductId { get; set; }
        public string ProductCode { get; set; }
        public decimal Qty { get; set; }
        public string ProductName { get; set; }
        public long UnitId { get; set; }
        public decimal PurchaseRate { get; set; }
        public decimal SalesRate { get; set; }
        public decimal Mrp { get; set; }
        public string Barcode { get; set; }
        public string UnitName { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public long TaxId { get; set; }
        public long BatchId { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal Amount { get; set; }
        public decimal TaxRate { get; set; }
        public string TaxName { get; set; }
        public string CurrentStock { get; set; }
        public long PurchaseDetailsId { get; set; }
        public string CartStatus { get; set; }
    }
}
