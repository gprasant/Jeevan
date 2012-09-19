﻿using Mvc.Mailer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;


namespace Jeevan.Controllers
{
    public class UserMailer : MailerBase
    {
        public virtual MailMessage Welcome()
        {
            var mailMessage = new MailMessage { Subject = "Welcome" };

            mailMessage.To.Add("nagu89@gmail.com");
            ViewBag.Data = "Welcome to Jeevan.org";
            PopulateBody(mailMessage, viewName: "Welcome");

            return mailMessage;
        }
    }
}