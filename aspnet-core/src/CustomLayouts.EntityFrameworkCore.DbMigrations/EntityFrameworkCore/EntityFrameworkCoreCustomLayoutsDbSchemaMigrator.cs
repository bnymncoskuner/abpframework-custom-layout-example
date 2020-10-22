﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CustomLayouts.Data;
using Volo.Abp.DependencyInjection;

namespace CustomLayouts.EntityFrameworkCore
{
    public class EntityFrameworkCoreCustomLayoutsDbSchemaMigrator
        : ICustomLayoutsDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreCustomLayoutsDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the CustomLayoutsMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<CustomLayoutsMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}