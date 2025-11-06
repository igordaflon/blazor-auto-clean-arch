using BlazorAutoCleanArch.Aplicacao.DTOs.Requests;

namespace BlazorAutoCleanArch.Aplicacao.Servicos.Interfaces
{
    public interface IArtistasAppServico
    {
        Task<int> InserirAsync(ArtistaInserirRequest request);
    }
}