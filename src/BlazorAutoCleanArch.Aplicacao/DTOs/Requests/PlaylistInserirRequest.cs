using System.ComponentModel.DataAnnotations;

namespace BlazorAutoCleanArch.Aplicacao.DTOs.Requests;

public class PlaylistInserirRequest
{
    [Required(ErrorMessage = "O nome da playlist é obrigatório")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 50 caracteres")]
    public string Nome { get; set; } = string.Empty;

    public string? Descricao { get; set; } = string.Empty;

    public IEnumerable<int> MusicasId { get; set; } = [];
};
