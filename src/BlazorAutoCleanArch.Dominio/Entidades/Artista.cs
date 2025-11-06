using BlazorAutoCleanArch.Dominio.Entidades.Base;
using BlazorAutoCleanArch.Dominio.Enumeradores;
using BlazorAutoCleanArch.Dominio.Excecoes;

namespace BlazorAutoCleanArch.Dominio.Entidades;

public class Artista : Entity
{
    public string Nome { get; protected set; } = string.Empty;
    public GeneroMusicalArtistaEnum GeneroMusical { get; protected set; }
    public StatusArtistaEnum Status { get; protected set; }

    public Artista(string nome, GeneroMusicalArtistaEnum generoMusical)
    {
        SetNome(nome);
        SetStatus(StatusArtistaEnum.Ativo);
        SetGeneroMusical(generoMusical);
    }

    public void SetNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new AtributoObrigatorioExcecao("Nome");

        if (nome.Length > 50)
            throw new TamanhoDeAtributoInvalidoExcecao("Nome", 0, 50);

        Nome = nome;
    }

    public virtual void SetGeneroMusical(GeneroMusicalArtistaEnum generoMusical)
    {
        if (!Enum.IsDefined(typeof(GeneroMusicalArtistaEnum), generoMusical))
            throw new AtributoInvalidoExcecao(nameof(GeneroMusical));

        GeneroMusical = generoMusical;
    }

    public void SetStatus(StatusArtistaEnum status)
    {
        Status = status;
    }
}
