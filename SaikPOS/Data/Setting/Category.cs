using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class Category
    {
        [Key]
        public long CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}
