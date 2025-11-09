using BlazorAutoCleanArch.Dominio.Entidades.Base;

namespace BlazorAutoCleanArch.Dominio.Entidades;

public class Playlist : Entity
{
    public string Nome { get; protected set; } = string.Empty;
    public IReadOnlySet<Musica> Musicas { get; protected set; } = new HashSet<Musica>();

    // Relacionamento com usuário do Identity
    public string UsuarioId { get; protected set; } = string.Empty;

    public Playlist() { }

    public Playlist(string nome, string usuarioId, IEnumerable<Musica> musicas)
    {
        SetNome(nome);
        SetUsuarioId(usuarioId);
        SetMusicas(musicas);
    }

    public void SetNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new Exception("Nome obrigatório");

        if (nome.Length > 50)
            throw new Exception("Nome deve ter até 50 caracteres");

        Nome = nome;
    }

    public void SetUsuarioId(string usuarioId)
    {
        if (string.IsNullOrWhiteSpace(usuarioId))
            throw new Exception("Usuário obrigatório");

        UsuarioId = usuarioId;
    }

    public void SetMusicas(IEnumerable<Musica> musicas)
    {
        Musicas = new HashSet<Musica>(musicas);
    }
}
