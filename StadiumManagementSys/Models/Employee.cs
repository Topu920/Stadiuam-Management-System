using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StadiumManagementSys.Models
{
    public class Employee
    {
        [Key]
        public Int64 EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Designation { get; set; }
        public DateTime JoiningDate { get; set; }
        public Int64 Salary { get; set; }
    }
}
