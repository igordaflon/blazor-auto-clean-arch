namespace BlazorAutoCleanArch.Aplicacao.DTOs.Responses
{
    public record MusicaListarResponse(int Id, string Nome, TimeSpan Duracao, AlbumListarResponse Album);
}
