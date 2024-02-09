using KriptoCüzdan.model.entity;
using Microsoft.EntityFrameworkCore;

namespace KriptoCüzdan.repository;

public class BaseDbContext:DbContext
{


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Kriptos;Trusted_Connection=true");
    }


    public DbSet<Cryptio> cryptios { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Kripto_1_> kripto_1s { get; set; }
    public DbSet<Alım> Alım { get; set; }
    public DbSet<Satım> Satım { get; set; }

}
