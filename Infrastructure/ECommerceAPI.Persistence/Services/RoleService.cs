using ECommerceAPI.Application.Abstractions.Services;
using ECommerceAPI.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace ECommerceAPI.Persistence.Services
{
    public class RoleService : IRoleService
    {
        readonly RoleManager<AppRole> _roleManager;
        public async Task<bool> CreateRole(string name)
        {
            IdentityResult result = await _roleManager.CreateAsync(new AppRole { Name = name });
            return result.Succeeded;
        }

        public async Task<bool> DeleteRole(string name)
        {
            IdentityResult result = await _roleManager.DeleteAsync(new AppRole { Name = name });
            return result.Succeeded;
        }

        public IDictionary<string, string> GetAllRoles()
        {
            return _roleManager.Roles.ToDictionary(role => role.Id, role => role.Name);
        }

        public async Task<(string id, string name)> GetRoleById(string id)
        {
            string role = await _roleManager.GetRoleIdAsync(new AppRole { Id = id });
            return (id, role);
        }

        public async Task<bool> UpdateRole(string id, string name)
        {
            IdentityResult result = await _roleManager.UpdateAsync(new AppRole { Id = id, Name = name });
            return result.Succeeded;
        }
    }
}
