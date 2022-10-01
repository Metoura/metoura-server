using Metoura.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Metoura.Persistence.EntityConfigurations;

public class ReadWriteContext : DbContext
{
    public ReadWriteContext(DbContextOptions options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyAllConfigurations<ReadWriteContext>();
        modelBuilder.ConfigureDeletableEntities();
    }


    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        UpdateSoftDeleteStatuses();
        this.AddAuditInfo();
        return base.SaveChangesAsync(cancellationToken);
    }
    
    private const string IsDeletedProperty = "IsDeleted";

    private void UpdateSoftDeleteStatuses()
    {
        foreach (var entry in ChangeTracker.Entries())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.CurrentValues[IsDeletedProperty] = false;
                    break;
                case EntityState.Modified:
                    entry.CurrentValues[IsDeletedProperty] = false;
                    break;
                case EntityState.Deleted:
                    entry.State = EntityState.Modified;
                    entry.CurrentValues[IsDeletedProperty] = true;
                    break;
            }
        }
    }
    
    
}