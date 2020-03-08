using DemoShop.AzureQueueLibrary.Messages;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DemoShop.AzureFunctions.Email
{
    public interface ISendEmailCommandHandler
    {
        Task Handle(SendEmailCommand command);
    }
    class SendEmailCommandHandler : ISendEmailCommandHandler
    {
        private readonly EmailConfig _emailConfig;
        public SendEmailCommandHandler(EmailConfig emailConfig)
        {
            _emailConfig = emailConfig;
        }
        public async Task Handle(SendEmailCommand command)
        {
            using (var client = new SmtpClient(_emailConfig.Host, _emailConfig.Port)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_emailConfig.Sender, _emailConfig.Password),
                EnableSsl = true
            })
            using(var message = new MailMessage(_emailConfig.Sender,command.To,command.Subject,command.Body))
            {
                //await client.SendMailAsync(message);
                await Task.CompletedTask;
            }
        }
    }
}
