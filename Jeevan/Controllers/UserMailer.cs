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
            var mailMessage = new MailMessage { Subject = "Welcome" };

            mailMessage.To.Add("stemcell@jeevan.org");
            mailMessage.CC.Add("saranya@jeevan.org");
            ViewBag.Data = "Welcome to Jeevan.org";
            ViewData.Model = viewModel;
            PopulateBody(mailMessage, viewName: "Welcome");

            return mailMessage;
        }
    }
}