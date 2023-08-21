using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class ProductView
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        [Display(Name ="Code")]
        public string ProductCode { get; set; }
        public decimal Qty { get; set; }
        public decimal Rate { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        public long UnitId { get; set; }
        [Display(Name = "Purchase Rate")]
        public decimal PurchaseRate { get; set; }
        [Display(Name = "Sales Rate")]
        public decimal SalesRate { get; set; }
        [Display(Name = "M.R.P")]
        public decimal Mrp { get; set; }
        public decimal MinimumStock { get; set; }
        public decimal MaximumStock { get; set; }
        public decimal ReorderLevel { get; set; }
        public bool IsallowBatch { get; set; }
        public bool Ismultipleunit { get; set; }
        public bool IsBom { get; set; }
        public string Narration { get; set; }
        public bool IsActive { get; set; }
        public string Barcode { get; set; }
        public string UnitConversionId { get; set; }
        public long CategoryId { get; set; }
        public long BatchId { get; set; }
        [Display(Name = "Barcode")]
        public string PartNo { get; set; }
        public string Logo { get; set; }
        public string LogoPath { get; set; }
        [Display(Name = "Unit Name")]
        public string UnitName { get; set; }
        [Display(Name = "Product Group")]
        public string GroupName { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public long TaxId { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal Amount { get; set; }
        public decimal TaxRate { get; set; }
        public string TaxName { get; set; }
        public string BatchNo { get; set; }
        public string CurrentStock { get; set; }
        //PurchaseInvoice
        public long PurchaseDetailsId { get; set; }
        public long ReceiptDetailsId { get; set; }
        public long OrderDetailsId { get; set; }
        //PurchaseReturn
        public long PurchaseReturnDetailsId { get; set; }

        //SalesInvoice
        public long SalesDetailsId { get; set; }
        public long DeliveryNoteDetailsId { get; set; }
        public long QuotationDetailsId { get; set; }

        //SalesReturn
        public long SalesReturnDetailsId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }

        //StockPosting
        public long StockPostingId { get; set; }
    }
}
