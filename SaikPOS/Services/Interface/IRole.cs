using SaikPOS.Data.Setting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace SaikPOS.Services.Interface
{
    public interface IRole
    {
        List<IdentityRole> ViewRole();
        IdentityRole Edit(string id);
        bool Save(IdentityRole role);
        bool Update(IdentityRole role);
        bool Delete(string id);
    }
}
