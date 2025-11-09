using AutoMapper;
using BlazorAutoCleanArch.Aplicacao.DTOs.Responses;
using BlazorAutoCleanArch.Dominio.Entidades;

namespace BlazorAutoCleanArch.Aplicacao.Profiles;

public class PlaylistsProfile : Profile
{
    public PlaylistsProfile()
    {
        CreateMap<Playlist, PlaylistListarResponse>();
    }
}
