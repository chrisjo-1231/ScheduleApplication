using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleApplication.Models;

namespace ScheduleApplication.Data
{
    public class ScheduleDbContext: DbContext
    {
        public DbSet <Schedule> schedule { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=NotesDB;Trusted_Connection=True;");
        }
    }
}
