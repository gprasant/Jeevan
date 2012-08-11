using System.ComponentModel.DataAnnotations;
using Jeevan.Attributes;
using System.Linq;
using System.Collections.Generic;

namespace Jeevan.Models
{
    public class CordBloodUnit
    {
        public int ID { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:D2}")]
        public int? HLA_A1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:D2}")]
        public int? HLA_A2 { get; set; }
        [DisplayFormat(DataFormatString = "{0:D2}")]
        public int? HLA_B1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:D2}")]
        public int? HLA_B2 { get; set; }

        [DisplayFormat(DataFormatString = "{0:D2}")]
        public int DRB_1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:D2}")]
        public int DRB_2 { get; set; }

        [DisplayFormat(DataFormatString = "{0:D2}")]
        public int HLA_C1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:D2}")]
        public int HLA_C2 { get; set; }
        [DisplayFormat(DataFormatString = "{0:D2}")]
        public int DQB_1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:D2}")]
        public int DQB_2 { get; set; }

        public int GetMatchCount(CordBloodUnit other)
        {
            int matchCount = 0;
            if (this.HLA_A1 == other.HLA_A1)
                matchCount++;
            if (this.HLA_A2 == other.HLA_A2)
                matchCount++;
            if (this.HLA_B1 == other.HLA_B1)
                matchCount++;
            if (this.HLA_B2 == other.HLA_B2)
                matchCount++;
            if (this.DRB_1 == other.DRB_1)
                matchCount++;
            if (this.DRB_2 == other.DRB_2)
                matchCount++;

            return matchCount;
        }
    }
}