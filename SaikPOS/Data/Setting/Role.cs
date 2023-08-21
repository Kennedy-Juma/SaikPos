using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class Role
    {
        [Key]
        public long RoldId { get; set; }
        public string RoleName { get; set; }
    }
}
