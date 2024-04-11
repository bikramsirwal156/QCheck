using QCheck.Domain.Entities.DoneTable;
using QCheck.Domain.Entities.Tabelneeded;

namespace QCheck.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
