using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AWPS.UI.MAUI.Data.Shared.KeyedEntity;

public static class KeyedEntityConfiguration
{
    extension<TEntity>(EntityTypeBuilder<TEntity> builder) where TEntity : class, IKeyedEntity
    {
        public void ConfigureKeyedEntity()
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).IsRequired();
        }
    }
}