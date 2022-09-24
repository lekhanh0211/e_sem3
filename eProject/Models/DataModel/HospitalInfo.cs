using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eProject.Models.DataModel
{
    public class HospitalInfo
    {
        [Key]
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string PhoneNo { get; set; }
        public string Location { get; set; }
        public string Url { get; set; }
    }
}