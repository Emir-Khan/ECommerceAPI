using ECommerceAPI.Application.Abstractions.Services.Authentication;
using ECommerceAPI.Application.DTOs.User;

namespace ECommerceAPI.Application.Abstractions.Services
{
    public interface IAuthService : IExternalAuthentication, IInternalAuthentication
    {
        Task PasswordResetAsnyc(string email);
        Task<VerifyUserResetTokenResponse> VerifyResetTokenAsync(string resetToken, string userId);
    }
}
