using ECommerceAPI.Application.Abstractions.Services;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace ECommerceAPI.Infrastructure.Services
{
    public class MailService : IMailService
    {
        readonly IConfiguration _configuration;

        public MailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendMessageAsync(string to, string subject, string body, bool isBodyHtml = true)
        {
            await SendMessageAsync(new[] { to }, subject, body, isBodyHtml);
        }

        public async Task SendMessageAsync(string[] toArray, string subject, string body, bool isBodyHtml = true)
        {
            MailMessage mail = new()
            {
                IsBodyHtml = isBodyHtml,
                Subject = subject,
                Body = body,
                From = new(_configuration["Mail:Username"], "Emirhan-Commerce", Encoding.UTF8)
            };

            foreach (var to in toArray)
                mail.To.Add(to);

            SmtpClient smtpClient = new()
            {
                Credentials = new NetworkCredential(_configuration["Mail:Username"], _configuration["Mail:Password"]),
                Port = int.Parse(_configuration["Mail:Port"]),
                EnableSsl = true,
                Host = _configuration["Mail:Host"]
            };
            await smtpClient.SendMailAsync(mail);
        }
    }
}