using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eProject.Models.DataModel
{
    public class CompanyDetails
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string CompanyUrl { get; set; }
    }
}