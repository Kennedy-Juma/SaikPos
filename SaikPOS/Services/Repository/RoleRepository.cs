using SaikPOS.Data;
using SaikPOS.Data.Setting;
using SaikPOS.Services.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace SaikPOS.Services.Repository
{
    public class RoleRepository : IRole
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public RoleRepository(ApplicationDbContext db, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public bool Delete(string id)
        {
            var objFromDb = _db.Roles.FirstOrDefault(u => u.Id == id);
            if (objFromDb == null)
            {
                //Role Not Found
                return false;
            }
            var userRolesForThisRole = _db.UserRoles.Where(u => u.RoleId == id).Count();
            if (userRolesForThisRole > 0)
            {
                //Cannot delete this role, since there are users assigned to this role.
                return false;
            }
             _roleManager.DeleteAsync(objFromDb);
            //Role deleted successfully.
            return true;
        }

        public IdentityRole Edit(string id)
        {
                //Edit
                var objFromDb = _db.Roles.FirstOrDefault(u => u.Id == id);
                return objFromDb;
        }

        public bool Save(IdentityRole roleObj)
        {

                //create
                _roleManager.CreateAsync(new IdentityRole() { Name = roleObj.Name });
                //TempData[SD.Success] = "Role created successfully";
                return true;
            
        }

        public bool Update(IdentityRole role)
        {
            var objRoleFromDb = _db.Roles.FirstOrDefault(u => u.Id == role.Id);
            if (objRoleFromDb == null)
            {
                //Role not found.
                return false;
            }
            //Role updated successfully
            objRoleFromDb.Name = role.Name;
            objRoleFromDb.NormalizedName = role.Name.ToUpper();
            var result = _roleManager.UpdateAsync(objRoleFromDb);
            return true;
        }

        public List<IdentityRole> ViewRole()
        {
            var roles = _db.Roles.ToList();
            return roles;
        }
    }
}
