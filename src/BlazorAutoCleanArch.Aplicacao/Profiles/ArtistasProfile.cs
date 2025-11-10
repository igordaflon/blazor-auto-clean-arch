using AutoMapper;
using BlazorAutoCleanArch.Aplicacao.DTOs.Responses;
using BlazorAutoCleanArch.Dominio.Entidades;

namespace BlazorAutoCleanArch.Aplicacao.Profiles;

public class ArtistasProfile : Profile
{
    public ArtistasProfile()
    {
        CreateMap<Artista, ArtistaListarResponse>();
    }
}
