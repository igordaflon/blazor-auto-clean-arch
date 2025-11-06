using BlazorAutoCleanArch.Dominio.Entidades;
using BlazorAutoCleanArch.Dominio.Interfaces;
using BlazorAutoCleanArch.Infra.Contexts;
using BlazorAutoCleanArch.Infra.Repositorios.Base;

namespace BlazorAutoCleanArch.Infra.Repositorios;

public class ArtistasRepositorio : RepositorioBase<Artista>, IArtistasRepositorio
{
    public ArtistasRepositorio(AplicacaoDbContext dbContext) : base(dbContext){}
}
