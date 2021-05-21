using Microsoft.EntityFrameworkCore;

namespace Tap2021.Hotel.Infrastructure.DataAccess
{
    public interface IEntityTypeConfigurationRegistrar
    {
        void ApplyConfiguration(ModelBuilder modelBuilder);
    }
}
