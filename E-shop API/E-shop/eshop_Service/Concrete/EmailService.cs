using eshop_Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Service.Concrete
{
    public class EmailService : IEmailService
    {
        private readonly string _smtpServer = "mail.gmail.com"; // SMTP server
        private readonly int _smtpPort = 587; // SMTP port
        private readonly string _smtpUser = "asafudurgucu1@gmail.com"; // SMTP username
        private readonly string _smtpPass = "Sskab1817"; // SMTP password

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            using (var smtpClient = new SmtpClient(_smtpServer, _smtpPort))
            {
                smtpClient.Credentials = new NetworkCredential(_smtpUser, _smtpPass);
                smtpClient.EnableSsl = true;

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(_smtpUser),
                    Subject = subject,
                    Body = message,
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(email);

                await smtpClient.SendMailAsync(mailMessage);
            }
        }
    }
}
