using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jeevan.Models.ViewModels
{
    public class HLASearchResultsViewModel
    {
        public IEnumerable<CordBloodUnit> _5Matches { get; set; }
        public IEnumerable<CordBloodUnit> _6Matches { get; set; }
    }
}