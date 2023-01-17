using Metoura.Core.Entities;
using Metoura.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Metoura.Persistence.Contexts;

public class MetouraRWContext : DbContext
{
    public MetouraRWContext(DbContextOptions options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyAllConfigurations<MetouraRWContext>();
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
    
    
    public DbSet<User> Users { get; set; }
    public DbSet<UserRole> UserRoles {get; set;}
    public DbSet<Role> Roles {get;set;}
    public DbSet<Admin> Admins {get;set;}
    public DbSet<Category> Categories { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Package> Packages { get; set; }
    public DbSet<Payment> Payment { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Tour> Tours { get; set; }
    public DbSet<TourCategory> TourCategories { get; set; }
    public DbSet<TourCompany> TourCompanies { get; set; }
    public DbSet<Tourist> Tourists { get; set; }
    public DbSet<TouristCenter> TouristCenters { get; set; }
    public DbSet<TourPlan> TourPlans { get; set; }
    public DbSet<TourTourist> TourTourist { get; set; }
    


}