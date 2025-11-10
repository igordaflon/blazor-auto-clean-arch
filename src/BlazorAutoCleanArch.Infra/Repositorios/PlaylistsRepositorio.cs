using BlazorAutoCleanArch.Dominio.Entidades;
using BlazorAutoCleanArch.Dominio.Interfaces;
using BlazorAutoCleanArch.Infra.Contexts;
using BlazorAutoCleanArch.Infra.Repositorios.Base;
using Microsoft.EntityFrameworkCore;

namespace BlazorAutoCleanArch.Infra.Repositorios;

public class PlaylistsRepositorio : RepositorioBase<Playlist>, IPlaylistsRepositorio
{
    public PlaylistsRepositorio(ApplicationDbContext dbContext) : base(dbContext){}

    public async Task<Playlist?> ObterPorIdAsync(int id)
    {
        return await DbSet
            .Include(p => p.Musicas)
                .ThenInclude(m => m.Album)
                    .ThenInclude(a => a.Artista)
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Id == id);
    }
}
