namespace BlazorAutoCleanArch.Aplicacao.DTOs.Responses;

public record AlbumListarResponse(int Id, string Nome, string CapaUrl, ArtistaListarResponse Artista);