using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace CPAS2.EntityFrameworkCore
{
    public static class CPAS2DbContextModelCreatingExtensions
    {
        public static void ConfigureCPAS2(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(CPAS2Consts.DbTablePrefix + "YourEntities", CPAS2Consts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}