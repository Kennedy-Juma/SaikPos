using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class InventoryView
    {
        public long groupId { get; set; }
        public string voucherNo { get; set; }
        public long voucherTypeId { get; set; }
        public long ledgerId { get; set; }
        [Display(Name = "Batch No")]
        public string batchNo { get; set; }
        public long productId { get; set; }
        [Display(Name = "Product Code")]
        public string productCode { get; set; }
        [Display(Name = "Product Name")]
        public string productName { get; set; }
        [Display(Name = "Purchase Rate")]
        public decimal purchaseRate { get; set; }
        [Display(Name = "Sales Rate")]
        public decimal salesRate { get; set; }
        [Display(Name = "Current Stock")]
        public decimal CurrentStock { get; set; }
        [Display(Name = "Rate")]
        public decimal rate { get; set; }
        [Display(Name = "Reorder Level")]
        public decimal reorderLevel { get; set; }
        [Display(Name = "Unit Name")]
        public string unitName { get; set; }
        [Display(Name = "Mrp")]
        public decimal mrp { get; set; }
        [Display(Name = "Barcode")]
        public string partNo { get; set; }
        public long pricinglevelId { get; set; }
        public bool isDetails { get; set; }
        //ProductSttics
        [Display(Name= "Maximum Level")]
        public bool rbtnMaximumLevel { get; set; }
        [Display(Name = "Minimum Level")]
        public bool rbtnMinimumLevel { get; set; }
        [Display(Name = "Negative Stock")]
        public bool rbtnNegativeStock { get; set; }
        [Display(Name = "Reorder Level")]
        public bool rbtnReorderLevel { get; set; }
        [Display(Name = "Unused")]
        public bool rbtnUnused { get; set; }
        [Display(Name = "Fast Movings")]
        public bool rbtnFastMovings { get; set; }
        [Display(Name = "Slow Movings")]
        public bool rbtnSlowMovings { get; set; }
        public List<InventoryViewFinl> stockReports { get; set; }
    }
}
