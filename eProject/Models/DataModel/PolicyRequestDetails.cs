using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eProject.Models.DataModel
{
    public class PolicyRequestDetails
    {
        [Key]
        public int RequestId { get; set; }
        public DateTime RequestDate { get; set; }
        public int EmpNo { get; set; }
        public int PolicyId { get; set; }
        public string PolicyName { get; set; }
        public double PolicyAmount { get; set; }
        public double Emi { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Status { get; set; }

    }
}