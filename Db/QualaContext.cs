using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DB
{
    public class QualaContext : DbContext
    {
        public QualaContext(DbContextOptions<QualaContext> options)
            : base(options)
        {


        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            
        //    modelBuilder.Entity<Branch>().Ignore(a => a.Coin);
        //    base.OnModelCreating(modelBuilder);
        //}
        public DbSet<Branch> Branches { get; set; }
        public DbSet <Coin> Coins { get; set; }

    }
}
