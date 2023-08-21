using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class ProductCategoryView
    {
        [Key]
        public long ProcategoryId { get; set; }
        [Display(Name ="Category Name")]
        [Required]
        public string CategoryName { get; set; }
        public long CompanyId { get; set; }
        public virtual ICollection<ProductCategory> HotelRoomImages { get; set; }
        public List<string> ImageUrls { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
