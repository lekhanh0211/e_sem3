using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eProject.Models.DataModel
{
    public class PolicyTotalDescription
    {
        public int PolicyId { get; set; }
        public string PolicyName { get; set; }
        public string PolicyDesc { get; set; }
        public double Policyamount { get; set; }
        public double Emi { get; set; }
        public int PolicyDurationInMonths { get; set; }
        public string CompanyName { get; set; }
        public string MedicalId { get; set; }
    }
}