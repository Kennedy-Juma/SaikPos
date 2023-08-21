using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class InventoryViewFinl
    {
        public long groupId { get; set; }
        [Display(Name = "Group Name")]
        public string groupName { get; set; }
        [Display(Name = "Unit Name")]
        public string unitName { get; set; }
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
        [Display(Name = "Mrp")]
        public decimal mrp { get; set; }
        [Display(Name = "Rate")]
        public decimal rate { get; set; }
        [Display(Name = "PurQty")]
        public decimal purQty { get; set; }
        [Display(Name = "SalesQty")]
        public decimal SalesQty { get; set; }
        [Display(Name = "SalesStockBalance")]
        public decimal SalesStockBalance { get; set; }
        [Display(Name = "PurchaseStockBal")]
        public decimal PurchaseStockBal { get; set; }
        [Display(Name = "stockvalue")]
        public decimal stockvalue { get; set; }
        [Display(Name = "Stock")]
        public decimal Stock { get; set; }
        [Display(Name = "Barcode")]
        public string partNo { get; set; }
        public string voucherTypeName { get; set; }
        public decimal inwardQty { get; set; }
        public decimal outwardQty { get; set; }
        public decimal CurrentStock { get; set; }


        //Ledger
        public string ledgerName { get; set; }
        public string nepaliDate { get; set; }
        public string address { get; set; }
        public string mobile { get; set; }
        public decimal opening { get; set; }
        public decimal debit { get; set; }
        public decimal credit { get; set; }
        public decimal balance { get; set; }
        public string voucherNo { get; set; }
        public string narration { get; set; }
    }
}
