using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AWPS.UI.MAUI.Data.Shared.KeyedEntity;

public static class KeyedEntityDbExtensions
{
    extension(DbContext db)
    {
        public void GenerateIdForKeyedEntities()
        {
            foreach(EntityEntry<IKeyedEntity> entry in db.ChangeTracker.Entries<IKeyedEntity>().Where(entry => entry.State is EntityState.Added))
            {
                entry.Entity.Id = Guid.CreateVersion7();
            }
        }
    }
}