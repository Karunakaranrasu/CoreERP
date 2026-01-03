using CoreERP.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace CoreERP.Application.Interfaces;

public interface IApplicationDbContext
{
    DbSet<T> Set<T>() where T : BaseEntity;
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
