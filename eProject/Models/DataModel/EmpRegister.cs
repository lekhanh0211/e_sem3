using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eProject.Models.DataModel
{
    public class EmpRegister
    {
        [Key]
        public int EmpNo { get; set; }
        public string Designation { get; set; }
        public DateTime JoinDate { get; set; }
        public double Salary { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PolicyStatus { get; set; }
        public int PolicyId { get; set; }
    }
}