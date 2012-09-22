using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jeevan.Models.ViewModels
{
    public class RequestInfoViewModel
    {
        public PatientInfo PatientInfo { get; set; }
        public CordBloodUnit HLAType { get; set; }
    }
}