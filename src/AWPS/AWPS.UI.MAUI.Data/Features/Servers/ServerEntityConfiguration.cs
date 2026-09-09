using Microsoft.EntityFrameworkCore;
using AWPS.UI.MAUI.Data.Shared.KeyedEntity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWPS.UI.MAUI.Data.Features.Servers;

public sealed class ServerEntityConfiguration : IEntityTypeConfiguration<ServerEntity>
{
    #region Interfaces
    public void Configure(EntityTypeBuilder<ServerEntity> builder)
    {
        builder.ConfigureKeyedEntity();
    }
    #endregion
}