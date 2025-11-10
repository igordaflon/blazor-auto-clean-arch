using AutoMapper;
using BlazorAutoCleanArch.Aplicacao.DTOs.Responses;
using BlazorAutoCleanArch.Dominio.Entidades;

namespace BlazorAutoCleanArch.Aplicacao.Profiles;

public class AlbunsProfile : Profile
{
    public AlbunsProfile()
    {
        CreateMap<Album, AlbumListarResponse>();
    }
}
