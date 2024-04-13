using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaConsole.DB
{
    public class DDBContext:DbContext
    {
        public DbSet<PC> PCs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PCdata;Trusted_Connection=True;");
        }
    }
    public class DDBContext2 : DbContext
    {
        public DbSet<LapTop> LTs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LapTopdata;Trusted_Connection=True;");
        }
    }
}
