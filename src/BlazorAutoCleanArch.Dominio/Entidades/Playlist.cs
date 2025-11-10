using BlazorAutoCleanArch.Dominio.Entidades.Base;
using BlazorAutoCleanArch.Dominio.Excecoes;

namespace BlazorAutoCleanArch.Dominio.Entidades;

public class Playlist : Entity
{
    public string Nome { get; protected set; } = string.Empty;
    public string Descricao { get; protected set; } = string.Empty;
    public IReadOnlySet<Musica> Musicas { get; protected set; } = new HashSet<Musica>();

    // Relacionamento com usuário do Identity
    public string UsuarioId { get; protected set; } = string.Empty;

    public Playlist() { }

    public Playlist(string nome, string? descricao, string usuarioId, IEnumerable<Musica> musicas)
    {
        SetNome(nome);
        SetDescricao(descricao);
        SetUsuarioId(usuarioId);
        SetMusicas(musicas);
    }

    public void SetNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new AtributoObrigatorioExcecao(nameof(Nome));

        if (nome.Length > 50)
            throw new TamanhoDeAtributoInvalidoExcecao(nameof(Nome), 0, 50);

        Nome = nome;
    }

    public void SetDescricao(string? descricao)
    {
        Descricao = descricao ?? string.Empty;

        if (Descricao.Length > 255)
            throw new TamanhoDeAtributoInvalidoExcecao(nameof(Descricao), 0, 255);
    }

    public void SetUsuarioId(string usuarioId)
    {
        if (string.IsNullOrWhiteSpace(usuarioId))
            throw new AtributoObrigatorioExcecao(nameof(UsuarioId));

        UsuarioId = usuarioId;
    }

    public void SetMusicas(IEnumerable<Musica> musicas)
    {
        Musicas = new HashSet<Musica>(musicas);
    }
}
