using Microsoft.EntityFrameworkCore;
using AWPS.UI.MAUI.Data.Features.Servers;
using AWPS.UI.MAUI.Data.Shared.KeyedEntity;
using AWPS.UI.MAUI.Data.Features.IoTDevices;
using AWPS.UI.MAUI.Data.Features.Measurements;
using AWPS.UI.MAUI.Data.Features.EventMessages;
using AWPS.UI.MAUI.Data.Features.PlantProfiles;
using AWPS.UI.MAUI.Data.Features.DeviceSettings;

namespace AWPS.UI.MAUI.Data;

public sealed class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    #region Instance
    public DbSet<ServerEntity> Servers { get; set; } = null!; //Init by EFCore
    public DbSet<PlantProfileEntity> PlantProfiles { get; set; } = null!; //Init by EFCore
    public DbSet<IoTDeviceEntity> IoTDevices { get; set; } = null!; //Init by EFCore
    public DbSet<MeasurementEntity> Measurements { get; set; } = null!; //Init by EFCore
    public DbSet<EventMessageEntity> EventMessageEntities { get; set; } = null!; //Init by EFCore
    public DbSet<DeviceSettingsEntity> DeviceSettings { get; set; } = null!; //Init by EFCore
    #endregion

    #region Base
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppContext).Assembly);
    }
    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        this.GenerateIdForKeyedEntities();
        return base.SaveChanges(acceptAllChangesOnSuccess);
    }
    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
        this.GenerateIdForKeyedEntities();
        return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }
    #endregion
}