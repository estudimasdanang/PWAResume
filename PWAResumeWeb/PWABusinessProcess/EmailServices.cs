using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PWAModel;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace PWABusinessProcess
{
    public static class EmailServices
    {

        public static async Task SendMail(EmailVM emailVM)
        {
            var client = new SendGridClient("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");
            var msg = new SendGridMessage();

            msg.SetFrom(new EmailAddress(emailVM.OriginSenderEmail, emailVM.OriginSenderName));

            var recipients = new List<EmailAddress>
                {
                    new EmailAddress("estudimasdanang@gmail.com")
                };
            msg.AddTos(recipients);

            msg.SetSubject(emailVM.EmailSubject);

            msg.AddContent(MimeType.Html, "<p>" + emailVM.EmailBody + "</p>");
            var response = await client.SendEmailAsync(msg);
        }



    }
}
