using BlazorAutoCleanArch.Dominio.Entidades;
using BlazorAutoCleanArch.Dominio.Interfaces;
using BlazorAutoCleanArch.Infra.Contexts;
using BlazorAutoCleanArch.Infra.Repositorios.Base;

namespace BlazorAutoCleanArch.Infra.Repositorios;

public class PlaylistsRepositorio : RepositorioBase<Playlist>, IPlaylistsRepositorio
{
    public PlaylistsRepositorio(ApplicationDbContext dbContext) : base(dbContext){}
}
