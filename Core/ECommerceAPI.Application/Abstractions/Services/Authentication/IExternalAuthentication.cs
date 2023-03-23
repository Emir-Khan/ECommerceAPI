namespace ECommerceAPI.Application.Abstractions.Services.Authentication
{
    public interface IExternalAuthentication
    {
        Task<DTOs.Token> FacebookLoginAsync(string authToken, int accessTokenLifetime);
        Task<DTOs.Token> GoogleLoginAsync(string idToken, int accessTokenLifetime);
    }
}
