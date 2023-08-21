using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaikPOS.Data.ViewModel
{
    public class BatchView
    {
        public long BatchId { get; set; }
        public long ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string BatchNo { get; set; }
        public string Barcode { get; set; }
        public decimal Rate { get; set; }
        public decimal PurchaseRate { get; set; }
        public string ManufacturingNepali { get; set; }
        public string ExpiryNepali { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
