using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Jeevan.Models
{
    public class PatientInfo
    {
        [Required]
        [DisplayName("Patient's Name")]
        public string PatientName { get; set; }

        [DisplayName("Patient's Date of birth")]
        [DataType(DataType.Date)]
        public DateTime PatientDateOfBirth { get; set; }

        [Required,UIHint("_Gender")]
        [DisplayName("Patient's Gender")]
        public string Gender { get; set; }

        public string Hospital { get; set; }
        [DisplayName("Physician's Name"),Required]
        public string PhysicianName { get; set; }

        [DisplayName("Physician's email address"),Required]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Please Enter a valid Email")]
        public string PhysicianEmail { get; set; }

        [DisplayName("Physician's phone number")]
        [RegularExpression(@"^[+]{0,1}\d+$", ErrorMessage = "Enter a valid phone number")]
        public string PhysicanPhoneNumber { get; set; }

        public string Diagnosis { get; set; }
    }
}