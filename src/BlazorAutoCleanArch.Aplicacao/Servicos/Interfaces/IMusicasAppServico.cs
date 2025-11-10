using BlazorAutoCleanArch.Aplicacao.DTOs.Responses;

namespace BlazorAutoCleanArch.Aplicacao.Servicos.Interfaces
{
    public interface IMusicasAppServico
    {
        Task<IReadOnlyList<MusicaListarResponse>> ListarTodasMusicasAsync();
    }
}