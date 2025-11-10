using AutoMapper;
using BlazorAutoCleanArch.Aplicacao.DTOs.Responses;
using BlazorAutoCleanArch.Aplicacao.Servicos.Interfaces;
using BlazorAutoCleanArch.Infra.Repositorios;

namespace BlazorAutoCleanArch.Aplicacao.Servicos;

public class MusicasAppServico : IMusicasAppServico
{
    private readonly IMusicasRepositorio _musicasRepositorio;
    private readonly IMapper _mapper;

    public MusicasAppServico(IMusicasRepositorio musicasRepositorio, IMapper mapper)
    {
        _musicasRepositorio = musicasRepositorio;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<MusicaListarResponse>> ListarTodasMusicasAsync()
    {
        var playlists = await _musicasRepositorio.ListarTodosAsync();
        return _mapper.Map<IReadOnlyList<MusicaListarResponse>>(playlists);
    }
}
