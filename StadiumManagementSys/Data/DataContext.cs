using Microsoft.EntityFrameworkCore;
using StadiumManagementSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StadiumManagementSys.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Login> Login { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<GameSchedule> GameSchedule { get; set; }
        public DbSet<Vendor>Vendor  { get; set; }
        public DbSet<Audience> Audience { get; set; }
        
        
    }
}
