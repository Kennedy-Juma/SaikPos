using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class Country
    {
        [Key]
        public long CountryId { get; set; }
        public string CountryName { get; set; }
    }
}
