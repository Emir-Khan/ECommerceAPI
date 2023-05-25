using ECommerceAPI.Application.Abstractions.Services;
using ECommerceAPI.Application.DTOs.User;
using ECommerceAPI.Application.Exceptions;
using ECommerceAPI.Application.Helpers;
using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Persistence.Services
{
    public class UserService : IUserService
    {
        readonly UserManager<AppUser> _userManager;
        readonly IEndpointReadRepository _endpointReadRepository;

        public UserService(UserManager<AppUser> userManager, IEndpointReadRepository endpointReadRepository)
        {
            _userManager = userManager;
            _endpointReadRepository = endpointReadRepository;
        }

        public async Task<CreateUserResponse> CreateAsync(CreateUser model)
        {
            var result = await _userManager.CreateAsync(new()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = model.UserName,
                Email = model.Email,
                NameSurname = model.NameSurname
            }, model.Password);


            CreateUserResponse response = new() { Succeeded = result.Succeeded };

            if (result.Succeeded)
                response.Message = "User Created Successfully";
            else
                foreach (var error in result.Errors)
                    response.Message += $"{error.Code} - {error.Description}\n";

            return response;
        }

        public async Task<List<ListUser>> GetAllUsersAsync(int page, int size)
        {
            return await _userManager.Users.Skip(page * size).Take(size).Select(u => new ListUser
            {
                Id = u.Id,
                Email = u.Email,
                NameSurname = u.NameSurname,
                UserName = u.UserName,
                TwoFactorEnabled = u.TwoFactorEnabled
            }).ToListAsync();
        }
        public int TotalUsersCount => _userManager.Users.Count();

        public async Task UpdatePasswordAsync(string userId, string resetToken, string newPassword)
        {
            AppUser user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                resetToken = resetToken.UrlDecode();
                IdentityResult result = await _userManager.ResetPasswordAsync(user, resetToken, newPassword);

                if (result.Succeeded)
                    await _userManager.UpdateSecurityStampAsync(user);
                else
                    throw new PasswordChangeFieldException();
            }
            else
                throw new UserNotFoundException();
        }

        public async Task UpdateRefreshTokenAsync(string refreshToken, DateTime accessTokenDate, int addAccessTokenTime, AppUser user)
        {
            user.RefreshToken = refreshToken;
            user.RefreshTokenEndDate = accessTokenDate.AddSeconds(addAccessTokenTime);
            await _userManager.UpdateAsync(user);
        }

        public async Task AssignRoleToUserAsync(string userId, string[] roles)
        {
            AppUser user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                await _userManager.RemoveFromRolesAsync(user, userRoles);

                await _userManager.AddToRolesAsync(user, roles);
            }
            else
                throw new UserNotFoundException();
        }

        public async Task<string[]> GetUserRolesAsync(string userIdOrName)
        {
            AppUser user = await _userManager.FindByIdAsync(userIdOrName);
            user ??= await _userManager.FindByNameAsync(userIdOrName);

            if (user != null)
                return (await _userManager.GetRolesAsync(user)).ToArray();
            else
                throw new UserNotFoundException();
        }

        public async Task<bool> HasRolePermissionToEndpointAsync(string userName, string code)
        {
            var userRoles = await GetUserRolesAsync(userName);

            if (!userRoles.Any())
                return false;

            Endpoint? endpoint = await _endpointReadRepository.Table.Include(e => e.Roles).FirstOrDefaultAsync(e => e.Code == code);

            if (endpoint == null) return false;

            foreach (var role in userRoles)
                if (endpoint.Roles.Any(r => r.Name == role))
                    return true;

            return false;
        }
    }
}
