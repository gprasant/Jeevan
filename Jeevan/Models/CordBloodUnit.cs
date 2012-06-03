using System.ComponentModel.DataAnnotations;
using Jeevan.Attributes;
namespace Jeevan.Models
{
    public class CordBloodUnit
    {
        public int ID { get; set; }
        
        public int? HLA_A1 { get; set; }
        public int? HLA_A2 { get; set; }
        public int? HLA_B1 { get; set; }
        public int? HLA_B2 { get; set; }
        
        public int DRB_1 { get; set; }
        public int DRB_2 { get; set; }

        public int HLA_C1 { get; set; }
        public int HLA_C2 { get; set; }
        public int DQB_1 { get; set; }
        public int DQB_2 { get; set; }
    }
}