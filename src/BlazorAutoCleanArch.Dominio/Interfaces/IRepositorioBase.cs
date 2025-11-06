using BlazorAutoCleanArch.Dominio.Entidades.Base;

namespace BlazorAutoCleanArch.Dominio.Interfaces
{
    public interface IRepositorioBase<T> : IDisposable where T : Entity
    {
        Task InserirAsync(T entitidade);
    }
}
