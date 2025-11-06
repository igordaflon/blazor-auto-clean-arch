using BlazorAutoCleanArch.Aplicacao.DTOs.Requests;
using BlazorAutoCleanArch.Aplicacao.Servicos.Interfaces;
using BlazorAutoCleanArch.Dominio.Entidades;
using BlazorAutoCleanArch.Dominio.Interfaces;

namespace BlazorAutoCleanArch.Aplicacao.Servicos;

public class ArtistasAppServico : IArtistasAppServico
{
    private readonly IArtistasRepositorio _artistasRepositorio;
    private readonly IUnitOfWork _unitOfWork;

    public ArtistasAppServico(IArtistasRepositorio artistasRepositorio,
                              IUnitOfWork unitOfWork)
    {
        _artistasRepositorio = artistasRepositorio;
        _unitOfWork = unitOfWork;
    }

    public async Task<int> InserirAsync(ArtistaInserirRequest request)
    {
        try
        {
            await _unitOfWork.BeginTransactionAsync();

            var artista = new Artista(request.Nome, request.GeneroMusical);

            await _artistasRepositorio.InserirAsync(artista);

            //var response = mapper.Map<ArtistaResponse>(artista);

            await _unitOfWork.CommitAsync();

            return artista.Id;
        }
        catch
        {
            await _unitOfWork.RollbackAsync();
            throw;
        }
    }
}
