using BlazorAutoCleanArch.Dominio.Entidades;

namespace BlazorAutoCleanArch.Dominio.Interfaces;

public interface IPlaylistsRepositorio : IRepositorioBase<Playlist>
{
    Task<Playlist?> ObterPorIdAsync(int id);
}
