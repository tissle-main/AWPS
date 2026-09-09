using Microsoft.EntityFrameworkCore;
using AWPS.UI.MAUI.Data.Shared.KeyedEntity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWPS.UI.MAUI.Data.Features.DeviceSettings;

public sealed class DeviceSettingsEntityConfiguration : IEntityTypeConfiguration<DeviceSettingsEntity>
{
    #region Interfaces
    public void Configure(EntityTypeBuilder<DeviceSettingsEntity> builder)
    {
        builder.ConfigureKeyedEntity();
        builder.Property(e => e.KeepActive).IsRequired();
        builder.Property(e => e.MeasurementPeriod).IsRequired();
        builder.Property(e => e.WateringDuration).IsRequired();
        builder.Property(e => e.WateringCyclePeriod).IsRequired();
        builder.Property(e => e.WateringCycleCount).IsRequired();
        builder.HasOne(e => e.PlantProfile).WithOne(pp => pp.DeviceSettings).HasForeignKey<DeviceSettingsEntity>(e => e.PlantProfileId).IsRequired().OnDelete(DeleteBehavior.Restrict);
    }
    #endregion
}