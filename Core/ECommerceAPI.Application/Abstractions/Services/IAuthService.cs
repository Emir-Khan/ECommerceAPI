using ECommerceAPI.Application.Abstractions.Services.Authentication;

namespace ECommerceAPI.Application.Abstractions.Services
{
    public interface IAuthService : IExternalAuthentication, IInternalAuthentication
    {
    }
}
