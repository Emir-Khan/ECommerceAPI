namespace ECommerceAPI.Application.Abstractions.Services
{
    public interface IRoleService
    {
        Task<bool> CreateRole(string name);
        Task<bool> DeleteRole(string name);
        Task<bool> UpdateRole(string id, string name);
        IDictionary<string, string> GetAllRoles();
        Task<(string id, string name)> GetRoleById(string id);
    }
}
