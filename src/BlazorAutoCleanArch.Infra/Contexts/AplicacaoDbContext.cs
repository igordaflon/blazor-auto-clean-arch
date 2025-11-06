using BlazorAutoCleanArch.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace BlazorAutoCleanArch.Infra.Contexts;

public class AplicacaoDbContext : DbContext
{
    public AplicacaoDbContext(DbContextOptions<AplicacaoDbContext> options) : base(options)
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        ChangeTracker.AutoDetectChangesEnabled = false;
    }

    public DbSet<Artista> Artistas { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Musica> Musicas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AplicacaoDbContext).Assembly);

        foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) 
            relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

        base.OnModelCreating(modelBuilder);
    }
}
