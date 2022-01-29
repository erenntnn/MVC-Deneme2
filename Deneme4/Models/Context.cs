using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deneme4.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-USROO4N;database=student4;integrated security=true;");
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Computer> computers { get; set; }
        public DbSet<Admin> admins { get; set; }

    }
}
