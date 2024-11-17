using ECommerceAPI.Application.DTOs.User;
using ECommerceAPI.Domain.Entities.Identity;

namespace ECommerceAPI.Application.Abstractions.Services
{
    public interface IUserService
    {
        Task<List<ListUser>> GetAllUsersAsync(int page, int size);
        Task<UserDetail> GetUserDetailAsync(string userNameOrId);
        Task<string[]> GetUserRolesAsync(string userIdOrName);
        Task<CreateUserResponse> CreateAsync(CreateUser model);
        Task UpdateRefreshTokenAsync(string refreshToken, DateTime accessTokenDate, int addAccessTokenTime, AppUser user);
        Task UpdatePasswordAsync(string userId, string resetToken, string newPassword);
        Task AssignRoleToUserAsync(string userId, string[] roles);
        Task<bool> HasRolePermissionToEndpointAsync(string userName, string code);
        int TotalUsersCount { get; }
    }
}
