using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eProject.Models.DataModel
{
    public class PoliciesOnEmployee
    {
        public string EmpNo { get; set; }
        public int PolicyId{ get; set; }
        public string PolicyName { get; set; }
        public double PolicyAmount { get; set; }
        public decimal PolicyDuration { get; set; }
        public decimal Emi { get; set; }
        public DateTime PstartDate { get; set; }
        public DateTime PendDate { get; set; }
        public string CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Medical { get; set; }
    }
}