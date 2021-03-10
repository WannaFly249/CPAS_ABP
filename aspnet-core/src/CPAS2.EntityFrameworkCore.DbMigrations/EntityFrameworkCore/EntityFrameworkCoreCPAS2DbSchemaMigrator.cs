using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CPAS2.Data;
using Volo.Abp.DependencyInjection;

namespace CPAS2.EntityFrameworkCore
{
    public class EntityFrameworkCoreCPAS2DbSchemaMigrator
        : ICPAS2DbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreCPAS2DbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the CPAS2MigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<CPAS2MigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}