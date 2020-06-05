using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StadiumManagementSys.Models
{
    public class Audience
    {
        [Key]
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }
        public string SeatNo { get; set; }
        public string Gameno { get; set; }
    }
}
