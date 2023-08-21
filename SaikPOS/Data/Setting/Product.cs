using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class Product
    {
        [Key]
        public long ProductId { get; set; }
        public string Sno { get; set; }
        [Display(Name = "Procode Code")]
        [Required]
        public string ProductCode { get; set; }
        [Display(Name = "Product Name")]
        [Required]
        public string ProductName { get; set; }
        [Display(Name = "Product Group")]
        [Required]
        public long GroupId { get; set; }
        [Display(Name = "Brand")]
        public string BrandId { get; set; }
        [Display(Name = "Product Category")]
        [Required]
        public long CategoryId { get; set; }
        [Display(Name = "Unit")]
        [Required]
        public long UnitId { get; set; }
        [Display(Name = "Size")]
        public string SizeId { get; set; }
        [Display(Name = "Model No")]
        public string ModelNoId { get; set; }
        [Display(Name = "Tax")]
        [Required]
        public long TaxId { get; set; }
        [Display(Name = "Purchase Rate")]
        [Required]
        public Decimal PurchaseRate { get; set; }
        [Display(Name = "Sales Rate")]
        [Required]
        public Decimal SalesRate { get; set; }
        [Display(Name = "M.R.P")]
        [Required]
        public Decimal Mrp { get; set; }
        [Display(Name = "Minimum Stock")]
        [Required]
        public Decimal MinimumStock { get; set; }
        [Display(Name = "Maximum Stock")]
        [Required]
        public Decimal MaximumStock { get; set; }
        [Display(Name = "Recorder Level")]
        [Required]
        public Decimal ReorderLevel { get; set; }
        public long GodownId { get; set; }
        public long RackId { get; set; }
        [Display(Name = "Allow Batch")]
        public bool IsallowBatch { get; set; }
        [Display(Name = "Multipul Unit")]
        public bool Ismultipleunit { get; set; }
        [Display(Name = "Opening Stock")]
        public bool Isopeningstock { get; set; }
        [Display(Name = "Narration")]
        public string Narration { get; set; }
        [Display(Name = "Active")]
        public bool IsActive { get; set; }
        [Display(Name = "Barcode")]
        public string PartNo { get; set; }
        public string LogoPath { get; set; }
        public long CompanyId { get; set; }
        public long? AddedUserId { get; set; }
        public long? ModifyUserId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
