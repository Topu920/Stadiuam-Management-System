using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StadiumManagementSys.Models
{
    public class Image
    {

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string ContentType { get; set; }

       
        //public string Tournament { get; set; }
        //public string TourGameNo { get; set; }
        //public DateTime GameTime { get; set; }
        //public string FirstTeam { get; set; }
        //public string SecondTeam { get; set; }
    }
}
