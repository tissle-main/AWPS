using Microsoft.EntityFrameworkCore;
using AWPS.UI.MAUI.Data.Shared.KeyedEntity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWPS.UI.MAUI.Data.Features.EventMessages;

public sealed class EventMessageEntityConfiguration : IEntityTypeConfiguration<EventMessageEntity>
{
    #region Interfaces
    public void Configure(EntityTypeBuilder<EventMessageEntity> builder)
    {
        builder.ConfigureKeyedEntity();
        builder.Property(e => e.Timestamp).IsRequired();
        builder.Property(e => e.MessageType).IsRequired();
        builder.Property(e => e.Message).IsRequired().HasMaxLength(EventMessageEntityConstants.MessageMaxLength);
        builder.HasOne(e => e.PlantProfile).WithMany(pp => pp.EventMessages).HasForeignKey(e => e.PlantProfileId).IsRequired().OnDelete(DeleteBehavior.Restrict);
    }
    #endregion
}