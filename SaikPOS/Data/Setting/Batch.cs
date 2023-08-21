using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class Batch
    {
        [Key]
        public long BatchId { get; set; }
        [Display(Name ="BatchNo")]
        [Required]
        public string BatchNo { get; set; }
        [Display(Name ="ProductCode")]
        [Required]
        public long ProductId { get; set; }
        [Display(Name ="Barcode")]
        public string Barcode { get; set; }
        [Display(Name = "PartNo")]
        public string PartNo { get; set; }
        [Display(Name = "ManufacturingDate")]
        public DateTime ManufacturingDate { get; set; }
        [Display(Name = "ManufacturingDateNepali")]
        public string ManufacturingNepali { get; set; }
        [Display(Name = "expiryNepali")]
        public string ExpiryNepali { get; set; }
        [Display(Name = "ExpiryDate")]
        public DateTime ExpiryDate { get; set; }
        public string Narration { get; set; }
        public decimal Rate { get; set; }
        public decimal PurchaseRate { get; set; }
        public decimal Mrp { get; set; }
        public long CompanyId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
