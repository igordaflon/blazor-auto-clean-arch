using AutoMapper;
using BlazorAutoCleanArch.Aplicacao.DTOs.Requests;
using BlazorAutoCleanArch.Aplicacao.DTOs.Responses;
using BlazorAutoCleanArch.Aplicacao.Servicos.Interfaces;
using BlazorAutoCleanArch.Dominio.Entidades;
using BlazorAutoCleanArch.Dominio.Interfaces;
using BlazorAutoCleanArch.Infra.Repositorios;

namespace BlazorAutoCleanArch.Aplicacao.Servicos;

public class PlaylistsAppServico : IPlaylistsAppServico
{
    private readonly IPlaylistsRepositorio _playlistsRepositorio;
    private readonly IMusicasRepositorio _musicasRepositorio;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public PlaylistsAppServico(IPlaylistsRepositorio playlistsRepositorio,
                               IUnitOfWork unitOfWork,
                               IMapper mapper,
                               IMusicasRepositorio musicasRepositorio)
    {
        _playlistsRepositorio = playlistsRepositorio;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _musicasRepositorio = musicasRepositorio;
    }

    public async Task<IReadOnlyList<PlaylistListarResponse>> ListarPlaylistsDoUsuarioAsync(string usuarioId)
    {
        var playlists = await _playlistsRepositorio.ListarTodosAsync(c => c.UsuarioId == usuarioId);
        return _mapper.Map<IReadOnlyList<PlaylistListarResponse>>(playlists);
    }

    public async Task<PlaylistListarResponse> ObterPorIdAsync(int id)
    {
        var playlist = await _playlistsRepositorio.ObterPorIdAsync(id);

        return _mapper.Map<PlaylistListarResponse>(playlist);
    }

    public async Task InserirAsync(PlaylistInserirRequest request, string usuarioId)
    {
        try
        {
            await _unitOfWork.BeginTransactionAsync();

            var musicasExistentes = await _musicasRepositorio.ListarTodosAsync(c => request.MusicasId.Contains(c.Id));

            if (musicasExistentes.Count != request.MusicasId.Count())
            {
                var idsEncontrados = musicasExistentes.Select(m => m.Id);
                var idsNaoEncontrados = request.MusicasId.Except(idsEncontrados);
                throw new InvalidOperationException(
                    $"Músicas não encontradas: {string.Join(", ", idsNaoEncontrados)}");
            }

            var playlist = new Playlist(request.Nome, request.Descricao, usuarioId, musicasExistentes);

            await _playlistsRepositorio.InserirAsync(playlist);

            await _unitOfWork.CommitAsync();
        }
        catch (Exception ex)
        {
            await _unitOfWork.RollbackAsync();
            throw;
        }
    }
}
