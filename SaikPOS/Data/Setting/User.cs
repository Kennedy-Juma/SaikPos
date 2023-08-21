using System;
using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class User
    {
        [Key]
        public long UserId { get; set; }
        public long RoldId { get; set; }
        public long CountryId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string Address { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
        public string Photos { get; set; }
        public string MobileNo { get; set; }
        public bool IsActive { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
