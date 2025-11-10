using BlazorAutoCleanArch.Dominio.Entidades;
using BlazorAutoCleanArch.Infra.Contexts;
using BlazorAutoCleanArch.Infra.Repositorios.Base;

namespace BlazorAutoCleanArch.Infra.Repositorios;

public class MusicasRepositorio : RepositorioBase<Musica>, IMusicasRepositorio
{
    public MusicasRepositorio(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
