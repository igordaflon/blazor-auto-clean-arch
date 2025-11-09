using AutoMapper;
using BlazorAutoCleanArch.Aplicacao.DTOs.Responses;
using BlazorAutoCleanArch.Aplicacao.Servicos.Interfaces;
using BlazorAutoCleanArch.Dominio.Interfaces;

namespace BlazorAutoCleanArch.Aplicacao.Servicos;

public class PlaylistsAppServico : IPlaylistsAppServico
{
    private readonly IPlaylistsRepositorio _playlistsRepositorio;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public PlaylistsAppServico(IPlaylistsRepositorio playlistsRepositorio,
                              IUnitOfWork unitOfWork,
                              IMapper mapper)
    {
        _playlistsRepositorio = playlistsRepositorio;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<PlaylistListarResponse>> ListarPlaylistsDoUsuario()
    {
        var playlists = await _playlistsRepositorio.ListarTodosAsync();
        return _mapper.Map<IReadOnlyList<PlaylistListarResponse>>(playlists);
    }
}
