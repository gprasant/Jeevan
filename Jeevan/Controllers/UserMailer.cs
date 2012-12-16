using Jeevan.Models.ViewModels;
using Mvc.Mailer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;


namespace Jeevan.Controllers
{
    public class UserMailer : MailerBase
    {
        public virtual MailMessage Welcome(RequestInfoViewModel viewModel)
        {
            var mailMessage = new MailMessage { Subject = "[Jeevan] Request for cord blood unit. " };
                        
            mailMessage.To.Add("stemcell@jeevan.org");
            mailMessage.CC.Add("srinivasan@jeevan.org");
            mailMessage.Bcc.Add("nagu89@gmail.com");
            ViewBag.Data = "Welcome to Jeevan.org";
            ViewData.Model = viewModel;
            PopulateBody(mailMessage, viewName: "Welcome");

            return mailMessage;
        }
    }
}