using SaikPOS.Data.Setting;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface IMailConfiguration
    {
        MailConfigurations Edit(int id);
        void Update(MailConfigurations model);
    }
}
