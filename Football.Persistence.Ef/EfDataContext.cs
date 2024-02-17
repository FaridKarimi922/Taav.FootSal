using Librari.Entitis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence.Ef
{
    internal class EfDataContext :DbContext
    {

        public DbSet<player> players { get; set; }
       
        public DbSet<Team> teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=FootballDb;User Id=sa;Password=Farid22922;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EfDataContext).Assembly);
        }

       
    }
}
