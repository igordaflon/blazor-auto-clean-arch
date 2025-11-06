using BlazorAutoCleanArch.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorAutoCleanArch.Infra.Mapeamentos;

public class ArtistaMapeamento : IEntityTypeConfiguration<Artista>
{
    public void Configure(EntityTypeBuilder<Artista> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nome)
            .IsRequired()
            .HasColumnType("varchar(50)");

        builder.ToTable("Artista");
    }
}
