using BlazorAutoCleanArch.Dominio.Entidades.Base;
using BlazorAutoCleanArch.Dominio.Excecoes;

namespace BlazorAutoCleanArch.Dominio.Entidades;

public class Musica : Entity
{
    public string Nome { get; protected set; } = string.Empty;
    public Album Album { get; protected set; } = default!;

    public Musica(string nome, Album album)
    {
        SetNome(nome);
        SetAlbum(album);
    }

    public void SetNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new AtributoObrigatorioExcecao("Nome");

        if (nome.Length > 50)
            throw new TamanhoDeAtributoInvalidoExcecao("Nome", 0, 50);

        Nome = nome;
    }

    public virtual void SetAlbum(Album album)
    {
        if (album is null || album.Id <= 0)
            throw new AtributoObrigatorioExcecao(nameof(Album));

        Album = album;
    }
}
