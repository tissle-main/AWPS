using Microsoft.EntityFrameworkCore;
using AWPS.UI.MAUI.Data.Shared.KeyedEntity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWPS.UI.MAUI.Data.Features.PlantProfiles;

public sealed class PlantProfileEntityConfiguration : IEntityTypeConfiguration<PlantProfileEntity>
{
    #region Interfaces
    public void Configure(EntityTypeBuilder<PlantProfileEntity> builder)
    {
        builder.ConfigureKeyedEntity();
        builder.Property(e => e.Name).IsRequired().HasMaxLength(PlantProfileEntityConstants.NameMaxLength);
        builder.HasOne(e => e.Server).WithMany(s => s.PlantProfiles).HasForeignKey(e => e.ServerId).IsRequired().OnDelete(DeleteBehavior.Restrict);
    }
    #endregion
}