using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace coresolution.EntityFrameworkCore
{
    public static class coresolutionDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<coresolutionDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<coresolutionDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
