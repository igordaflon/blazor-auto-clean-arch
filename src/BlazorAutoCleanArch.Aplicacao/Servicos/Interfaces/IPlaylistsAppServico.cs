using BlazorAutoCleanArch.Aplicacao.DTOs.Requests;
using BlazorAutoCleanArch.Aplicacao.DTOs.Responses;

namespace BlazorAutoCleanArch.Aplicacao.Servicos.Interfaces;

public interface IPlaylistsAppServico
{
    Task InserirAsync(PlaylistInserirRequest request, string usuarioId);
    Task<IReadOnlyList<PlaylistListarResponse>> ListarPlaylistsDoUsuarioAsync(string usuarioId);
    Task<PlaylistListarResponse> ObterPorIdAsync(int id);
}