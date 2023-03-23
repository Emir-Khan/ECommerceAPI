namespace ECommerceAPI.Application.Abstractions.Services.Authentication
{
    public interface IInternalAuthentication
    {
        Task<DTOs.Token> LoginAsync(string userNameOrEmail, string password, int accessTokenLifetime);
    }
}
