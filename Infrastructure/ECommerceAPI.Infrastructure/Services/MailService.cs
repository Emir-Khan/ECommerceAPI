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

        public Task SendCompletedOrderMailAsync(string to, string userName, string orderCode, DateTime orderDate)
        {
            StringBuilder mail = new();
            mail.AppendLine("Merhaba ");
            mail.AppendLine(userName);
            mail.AppendLine("<br>Siparişiniz başarıyla tamamlanmıştır.<br><br>Sipariş Kodu : ");
            mail.AppendLine(orderCode);
            mail.AppendLine("<br>Sipariş Tarihi : ");
            mail.AppendLine(orderDate.ToString("dd.MM.yyyy HH:mm:ss"));
            mail.AppendLine("<br><br>Saygılarımızla...<br><br><br>Emirhan-Commercce");
            mail.AppendLine(
                "<br><br><span style=\"font-size:12px;\">NOT : Eğer ki bu talep tarafınızca gerçekleştirilmemişse lütfen bu maili ciddiye almayınız.</span>");

            return SendMailAsync(to, $"{orderCode} No'lu Siparişiniz Tamamlandı", mail.ToString());
        }

        public async Task SendMailAsync(string to, string subject, string body, bool isBodyHtml = true)
        {
            await SendMailAsync(new[] { to }, subject, body, isBodyHtml);
        }

        public async Task SendMailAsync(string[] toArray, string subject, string body, bool isBodyHtml = true)
        {
            MailMessage mail = new()
            {
                IsBodyHtml = isBodyHtml,
                Subject = subject,
                Body = body,
                From = new(_configuration["Mail:EMail"], "Emirhan-Commerce")
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

        public async Task SendPasswordResetMailAsync(string to, string userId, string resetToken)
        {
            StringBuilder mail = new();
            mail.AppendLine("Merhaba<br>Eğer yeni şifre talebinde bulunduysanız aşağıdaki linkten şifrenizi yenileyebilirsiniz.<br><strong><a target=\"_blank\" href=\"");
            mail.AppendLine(_configuration["AngularClientUrl"]);
            mail.AppendLine("/update-password/");
            mail.AppendLine(userId);
            mail.AppendLine("/");
            mail.AppendLine(resetToken);
            mail.AppendLine("\">Yeni şifre talebi için tıklayınız...</a></strong><br><br><span style=\"font-size:12px;\">NOT : Eğer ki bu talep tarafınızca gerçekleştirilmemişse lütfen bu maili ciddiye almayınız.</span><br>Saygılarımızla...<br><br><br>NG - Mini|E-Ticaret");

            await SendMailAsync(to, "Şifre Yenileme Talebi", mail.ToString());
        }
    }
}