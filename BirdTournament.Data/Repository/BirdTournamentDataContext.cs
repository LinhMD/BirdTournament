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
        foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
                     .SelectMany(e => e.GetForeignKeys()))
        {
            foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
        }
    }


    public DbSet<User> Users { get; set; }

    public DbSet<Article> Articles { get; set; }
    public DbSet<Bird> Birds { get; set; }
    public DbSet<BirdOwner> BirdOwners { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Competition> Competitions { get; set; }
    public DbSet<Moderator> Moderators { get; set; }
    public DbSet<Place> Places { get; set; }
    public DbSet<Rank> Ranks { get; set; }
    public DbSet<VipAccount> VipAccounts { get; set; }
    public DbSet<VipFeature> VipFeatures { get; set; }
}
