using BlazorAutoCleanArch.Aplicacao.DTOs.Responses;

namespace BlazorAutoCleanArch.Aplicacao.Servicos.Interfaces;

public interface IPlaylistsAppServico
{
    Task<IReadOnlyList<PlaylistListarResponse>> ListarPlaylistsDoUsuario();
}