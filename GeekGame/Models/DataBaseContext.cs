using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekGame.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
    : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlServer("Server=.;initial catalog=GeeksGame;Trusted_Connection=True;MultipleActiveResultSets=true");
            //    optionbuilder.UseSqlServer("Server=185.187.51.28;initial catalog=salahiir_Medical;persist security info=True;user id=salahiir_Mohammad;password=r1PL}W*jxcU_;MultipleActiveResultSets=True;App=EntityFramework&quot; ");
        }

        public DbSet<TblNationality> TblNationality { get; set; }
    }
}
