using Microsoft.EntityFrameworkCore;
using Tap2021Demo.Infrastructure.DataAccess;

namespace Tap2021Demo.DomainEntities.Mappings
{
    public class EntityTypeConfigurationRegistrar : IEntityTypeConfigurationRegistrar
    {
        public void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountHolderMapping());
        }
    }
}
