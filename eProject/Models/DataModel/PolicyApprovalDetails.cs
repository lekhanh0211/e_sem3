using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eProject.Models.DataModel
{
    public class PolicyApprovalDetails
    {
        [Key]
        public int PolicyId { get; set; }
        public int RequestId { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
    }
}