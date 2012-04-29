using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;

namespace Jeevan.Logging
{
    public class LogEvent : WebRequestErrorEvent
    {
        public LogEvent(string message) : base(message, null, 100001, new Exception(message))
        {

        }

        public LogEvent(Exception ex) : base(ex.Message, null, 100001, ex)
        {

        }
    }
}