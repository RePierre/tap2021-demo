using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Tap2021.Hotel.Infrastructure.DataAccess
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection SetupDataAccessInfrastructure([NotNull] this IServiceCollection services, string connectionString)
        {
            return services.AddDbContext<DataContext>(opt => opt.UseSqlServer(connectionString))
                .AddScoped<IDataRepository, DataContext>()
                .AddScoped<IUnitOfWork, DataContext>();
        }
    }
}
