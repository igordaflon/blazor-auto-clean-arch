using BlazorAutoCleanArch.Dominio.Entidades.Base;
using BlazorAutoCleanArch.Dominio.Interfaces;
using BlazorAutoCleanArch.Infra.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BlazorAutoCleanArch.Infra.Repositorios.Base;

public abstract class RepositorioBase<T> : IRepositorioBase<T> where T : Entity, new()
{
    protected readonly AplicacaoDbContext DbContext;
    protected readonly DbSet<T> DbSet;

    protected RepositorioBase(AplicacaoDbContext dbContext)
    {
        DbContext = dbContext;
        DbSet = dbContext.Set<T>();
    }

    public async Task InserirAsync(T entitidade)
    {
        await DbSet.AddAsync(entitidade);
    }

    public void Dispose()
    {
        DbContext?.Dispose();
    }
}
