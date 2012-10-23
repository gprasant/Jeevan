using System.ComponentModel.DataAnnotations;
using Jeevan.Attributes;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace Jeevan.Models
{
    public class CordBloodUnit
    {
        public int ID { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:D2}")]
        [DisplayName("HLA A1")]
        [DataType(DataType.Text)]
        public int? HLA_A1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:D2}")]
        [DisplayName("HLA A2"),DataType(DataType.Text)]
        public int? HLA_A2 { get; set; }
        [DisplayFormat(DataFormatString = "{0:D2}")]
        [DisplayName("HLA B1"), DataType(DataType.Text)]
        public int? HLA_B1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:D2}")]
        [DisplayName("HLA B2"), DataType(DataType.Text)]
        public int? HLA_B2 { get; set; }

        [DisplayFormat(DataFormatString = "{0:D2}")]
        [DisplayName("DRB 1a"), DataType(DataType.Text)]
        public int DRB_1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:D2}")]
        [DisplayName("DRB 1b"), DataType(DataType.Text)]
        public int DRB_2 { get; set; }

        [DisplayFormat(DataFormatString = "{0:D2}"), DataType(DataType.Text)]
        [DisplayName("HLA C1")]
        public int? HLA_C1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:D2}"), DataType(DataType.Text)]
        [DisplayName("HLA C2")]
        public int? HLA_C2 { get; set; }
        [DisplayFormat(DataFormatString = "{0:D2}"), DataType(DataType.Text)]
        [DisplayName("DQB 1a")]
        public int? DQB_1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:D2}"), DataType(DataType.Text)]
        [DisplayName("DQB 1b")]
        public int? DQB_2 { get; set; }

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