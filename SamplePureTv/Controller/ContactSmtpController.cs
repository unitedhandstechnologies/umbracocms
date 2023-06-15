using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Configuration.Models;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Mail;
using Umbraco.Cms.Core.Models.Email;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Cms.Web.Website.Controllers;


namespace Umbraco.Cms.Web.Common.Controllers
{
    public class ContactSmtpController : SurfaceController
    {
        private readonly IEmailSender _emailSender;
        private readonly ILogger<ContactSmtpController> _logger;
        private readonly IConfiguration _config;

        public ContactSmtpController(
            IUmbracoContextAccessor umbracoContextAccessor,
            IUmbracoDatabaseFactory databaseFactory,
            ServiceContext services,
            AppCaches appCaches,
            IProfilingLogger profilingLogger,
            IPublishedUrlProvider publishedUrlProvider,
            IEmailSender emailSender,
            ILogger<ContactSmtpController> logger, IConfiguration config)

            : base(umbracoContextAccessor, databaseFactory,
                  services, appCaches, profilingLogger,
                  publishedUrlProvider)
        {
            _emailSender = emailSender;
            _logger = logger;
            _config = config;

        }

        [HttpPost]
        public async Task<IActionResult> SubmitForm(ContactForm model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            TempData["Success"] = await SendEmail(model);
            return RedirectToCurrentUmbracoPage();
        }

        public async Task<bool> SendEmail(ContactForm model)
        {
            try
            {
                var message = model.YourQuestion;
                var subject = string.Format("Enquiry from: {0} - {1}", model.FullName, model.Email);

                /*Sending Mail to the Admin*/
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(_config.GetSection("SMTPUser").Value));
                email.To.Add(MailboxAddress.Parse("anitha.k@unitedhands.cc"));
                email.Subject = subject;
                email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = message };

                using var smtp = new SmtpClient();
                smtp.Connect(_config.GetSection("SMTPServer").Value, 587, MailKit.Security.SecureSocketOptions.StartTls);
                smtp.Authenticate(_config.GetSection("SMTPUser").Value, _config.GetSection("SMTPPassword").Value);
                smtp.Send(email);

                _logger.LogInformation("Contact Form Submitted Successfully");

                /*Sending Acknowledgement Mail to the users*/
                var replyEmail = new MimeMessage();
                var replyEmailBody = "Thank you for your interest in our Services";

                replyEmail.From.Add(MailboxAddress.Parse(_config.GetSection("SMTPUser").Value));
                replyEmail.To.Add(MailboxAddress.Parse(model.Email));
                replyEmail.Subject = "Acknowledgement Mail";
                replyEmail.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = replyEmailBody };
                smtp.Send(replyEmail);
 
                smtp.Disconnect(true);              
                return true;
            }
            
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error When Submitting Contact Form");
                return false;
            }
        }
    }
}