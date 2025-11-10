using BlazorAutoCleanArch.Dominio.Entidades;
using BlazorAutoCleanArch.Infra.Contexts;
using BlazorAutoCleanArch.Infra.Repositorios.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace BlazorAutoCleanArch.Infra.Repositorios;

public class MusicasRepositorio : RepositorioBase<Musica>, IMusicasRepositorio
{
    public MusicasRepositorio(ApplicationDbContext dbContext) : base(dbContext){}

    public override async Task<IReadOnlyList<Musica>> ListarTodosAsync(Expression<Func<Musica, bool>>? expression = null)
    {
        IQueryable<Musica> query = DbSet
            .Include(m => m.Album)
                .ThenInclude(a => a.Artista)
            .AsNoTracking();

        if (expression is not null)
            query = query.Where(expression);

        return await query.ToListAsync();
    }
}
