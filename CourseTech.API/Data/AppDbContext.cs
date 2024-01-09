using CourseTech.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseTech.API.Data
{
    public class AppDbContext :  DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryDetail> CountryDetails { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "CourseTechDb");
        }
    }
}
