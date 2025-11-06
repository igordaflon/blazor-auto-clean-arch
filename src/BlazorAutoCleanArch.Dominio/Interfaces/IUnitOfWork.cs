namespace BlazorAutoCleanArch.Dominio.Interfaces;

public interface IUnitOfWork : IDisposable
{
    Task BeginTransactionAsync();
    Task CommitAsync();
    Task RollbackAsync();
}
