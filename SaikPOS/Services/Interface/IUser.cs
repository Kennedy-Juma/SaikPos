using SaikPOS.Data;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface IUser
    {
        IEnumerable<ApplicationUser> ViewUser();
        ApplicationUser Edit(string id);
        bool Update(ApplicationUser user);
        bool Delete(string userId);
    }
}
