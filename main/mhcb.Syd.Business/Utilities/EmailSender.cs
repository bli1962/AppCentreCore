using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;

namespace mhcb.Syd.Business.Utilities
{
    //https://learn.microsoft.com/en-us/aspnet/core/security/authentication/accconfirm?view=aspnetcore-6.0&tabs=visual-studio
    public class EmailSender : IEmailSender
    {
        private readonly string _smtpServerHost = "";
        private readonly string _emailSendeer = "";
        private readonly string _subject = "";
        private readonly SmtpClient _smtpClient;

        private readonly IConfiguration _Configuration;

        //private readonly ILoggerManager _logger;
        //public EmailSender(IConfiguration config, ILoggerManager logger)
        //{
        //    _Configuration = config;
        //    _smtpServerHost = _Configuration["Email:SmtpServerHost"];
        //    _emailSendeer = _Configuration["Email:EMailSender"];
        //    _subject = _Configuration["Email:Subject"];

        //    _smtpClient = new SmtpClient(_smtpServerHost)
        //    {
        //        EnableSsl = false,
        //    };
        //    _logger = logger;
        //}

        private readonly ILogger<EmailSender> _logger;
        public EmailSender(IConfiguration config, 
                          ILogger<EmailSender> logger)
        {
            _Configuration = config;
            _smtpServerHost = _Configuration["Email:SmtpServerHost"];
            _emailSendeer = _Configuration["Email:EMailSender"];
            _subject = _Configuration["Email:Subject"];

            _smtpClient = new SmtpClient(_smtpServerHost)
            {
                EnableSsl = false,
            };

            _logger = logger;
        }

        public async Task SendEmailAsync(string recipient, string subject, string htmlMessage)
        {
            try
            {
                if (subject == null || subject == "")
                    subject = _subject;

                _logger.LogInformation("Started Sending mail to " + recipient + " ...");
                await Execute(recipient, subject, htmlMessage);
                _logger.LogInformation("Sent email successfully.");
            }
            catch (SmtpException ex)
            {
                string msg = "Mail cannot be sent because of the server problem:";
                msg += ex.Message;
                _logger.LogInformation("Error: Inside catch block of Mail sending");
                _logger.LogInformation("Error msg:" + ex);
                _logger.LogInformation("Stack trace:" + ex.StackTrace);
            }
        }

        public async Task Execute(string recipient, string subject, string htmlMessage)
        {
            if (_smtpClient != null)
                await _smtpClient.SendMailAsync(_emailSendeer, recipient, subject, htmlMessage);
        }
    }
}
