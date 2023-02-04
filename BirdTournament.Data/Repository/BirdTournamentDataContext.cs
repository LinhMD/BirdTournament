using BirdTournament.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BirdTournament.Data.Repository;

public class BirdTournamentDataContext : DbContext
{
    private readonly IConfiguration _config;

    public BirdTournamentDataContext(IConfiguration configuration)
    {
        _config = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            _config["ConnectionStrings:Azure_DB"],
            b => b.MigrationsAssembly("BirdTournament.API")
                .UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }


    public DbSet<User> Users { get; set; }
}
