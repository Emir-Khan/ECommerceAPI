namespace ECommerceAPI.Application.Abstractions.Services
{
    public interface IMailService
    {
        Task SendMessageAsync(string to, string subject, string body, bool isBodyHtml = true);
        Task SendMessageAsync(string[] toArray, string subject, string body, bool isBodyHtml = true);
    }
}
