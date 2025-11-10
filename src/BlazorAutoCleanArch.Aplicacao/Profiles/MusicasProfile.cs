using AutoMapper;
using BlazorAutoCleanArch.Aplicacao.DTOs.Responses;
using BlazorAutoCleanArch.Dominio.Entidades;

namespace BlazorAutoCleanArch.Aplicacao.Profiles;

public class MusicasProfile : Profile
{
    public MusicasProfile()
    {
        CreateMap<Musica, MusicaListarResponse>();
    }
}
