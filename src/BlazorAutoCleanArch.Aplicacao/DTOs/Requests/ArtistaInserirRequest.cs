using BlazorAutoCleanArch.Dominio.Enumeradores;

namespace BlazorAutoCleanArch.Aplicacao.DTOs.Requests;

public record ArtistaInserirRequest(string Nome, GeneroMusicalArtistaEnum GeneroMusical);
