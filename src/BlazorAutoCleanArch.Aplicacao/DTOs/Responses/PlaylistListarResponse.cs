namespace BlazorAutoCleanArch.Aplicacao.DTOs.Responses
{
    public record PlaylistListarResponse(int Id, string Nome, string Descricao, string UsuarioId, IReadOnlyList<MusicaListarResponse> Musicas);
}
