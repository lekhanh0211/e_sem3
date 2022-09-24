using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eProject.Models.DataModel
{
    public class Policies
    {
        [Key]
        public int PolicyId { get; set; }
        public string PolicyName { get; set; }
        public string PolicyDesc { get; set; }
        public double Amount { get; set; }
        public double Emi { get; set; }
        public int CompanyId { get; set; }
        public string MedicalId { get; set; }
    }
}