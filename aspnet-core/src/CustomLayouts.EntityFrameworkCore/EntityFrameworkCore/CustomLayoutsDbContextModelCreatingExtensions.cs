using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace CustomLayouts.EntityFrameworkCore
{
    public static class CustomLayoutsDbContextModelCreatingExtensions
    {
        public static void ConfigureCustomLayouts(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(CustomLayoutsConsts.DbTablePrefix + "YourEntities", CustomLayoutsConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}