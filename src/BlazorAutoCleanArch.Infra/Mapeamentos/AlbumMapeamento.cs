using BlazorAutoCleanArch.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorAutoCleanArch.Infra.Mapeamentos
{
    public class AlbumMapeamento : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(p => p.CapaUrl)
                .IsRequired();

            builder.HasOne(p => p.Artista)
                .WithMany()
                .IsRequired();

            builder.ToTable("Album");
        }
    }
}
