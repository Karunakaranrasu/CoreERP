using CoreERP.Application.Interfaces;
using CoreERP.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace CoreERP.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // ✅ NO override needed
    public new DbSet<T> Set<T>() where T : BaseEntity
        => base.Set<T>();

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
}
