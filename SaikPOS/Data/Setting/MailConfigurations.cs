using System.ComponentModel.DataAnnotations;

namespace SaikPOS.Data.Setting
{
    public class MailConfigurations
    {
        [Key]
        public int MailInfoId { get; set; }
        public string Protocal { get; set; }
        public string Smpthost { get; set; }
        public string Smptport { get; set; }
        public string SenderMail { get; set; }
        public string Password { get; set; }
        public string MailType { get; set; }
        public bool Sales { get; set; }
        public bool Purchase { get; set; }
    }
}
