using Microsoft.EntityFrameworkCore;
using AWPS.UI.MAUI.Data.Shared.KeyedEntity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWPS.UI.MAUI.Data.Features.IoTDevices;

public sealed class IoTDeviceEntityConfiguration : IEntityTypeConfiguration<IoTDeviceEntity>
{
    #region Interfaces
    public void Configure(EntityTypeBuilder<IoTDeviceEntity> builder)
    {
        builder.ConfigureKeyedEntity();
        builder.HasOne(e => e.Server).WithMany(s => s.IoTDevices).HasForeignKey(e => e.ServerId).IsRequired().OnDelete(DeleteBehavior.Restrict);
    }
    #endregion
}