using Microsoft.EntityFrameworkCore;
using AWPS.UI.MAUI.Data.Shared.KeyedEntity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWPS.UI.MAUI.Data.Features.Measurements;

public sealed class MeasurementEntityConfiguration : IEntityTypeConfiguration<MeasurementEntity>
{
    #region Interfaces
    public void Configure(EntityTypeBuilder<MeasurementEntity> builder)
    {
        builder.ConfigureKeyedEntity();
        builder.Property(e => e.Timestamp).IsRequired();
        builder.Property(e => e.LightPercent).IsRequired();
        builder.Property(e => e.MoisturePercent).IsRequired();
        builder.Property(e => e.HumidityPercent).IsRequired();
        builder.Property(e => e.TemperatureCelsium).IsRequired();
        builder.HasOne(e => e.PlantProfile).WithMany(pp => pp.Measurements).HasForeignKey(e => e.PlantProfileId).IsRequired().OnDelete(DeleteBehavior.Restrict);
    }
    #endregion
}