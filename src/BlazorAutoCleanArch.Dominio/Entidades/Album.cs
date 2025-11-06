using BlazorAutoCleanArch.Dominio.Entidades.Base;
using BlazorAutoCleanArch.Dominio.Excecoes;

namespace BlazorAutoCleanArch.Dominio.Entidades;

public class Album : Entity
{
    public string Nome { get; protected set; } = string.Empty;
    public DateTime DataLancamento { get; protected set; }
    public Artista Artista { get; protected set; } = default!;

    public Album(string nome, DateTime dataLancamento, Artista artista)
    {
        SetNome(nome);
        SetDataLancamento(dataLancamento);
        SetArtista(artista);
    }

    public void SetNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new AtributoObrigatorioExcecao("Nome");

        if (nome.Length > 50)
            throw new TamanhoDeAtributoInvalidoExcecao("Nome", 0, 50);

        Nome = nome;
    }

    public void SetDataLancamento(DateTime dataLancamento)
    {
        DataLancamento = dataLancamento;
    }

    public virtual void SetArtista(Artista artista)
    {
        if (artista is null || artista.Id <= 0)
            throw new AtributoObrigatorioExcecao(nameof(Artista));

        Artista = artista;
    }
}
