using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StadiumManagementSys.Models
{
    public class Vendor
    {
        [Key]
        public string RegistrationNo { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationEmail { get; set; }
        public string Phone { get; set; }
        public string OrganizationRegNO { get; set; }
        public DateTime ContactDuration { get; set; }
        public string ServiceType { get; set; }
        public string ServiceComment { get; set; }
    }
}
