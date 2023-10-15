using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HelloLibrary.EntityFrameworkCore
{
    public static class HelloLibraryDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HelloLibraryDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HelloLibraryDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
