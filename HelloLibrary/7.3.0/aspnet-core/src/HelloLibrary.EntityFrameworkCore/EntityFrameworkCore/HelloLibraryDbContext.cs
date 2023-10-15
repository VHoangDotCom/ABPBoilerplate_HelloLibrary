using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HelloLibrary.Authorization.Roles;
using HelloLibrary.Authorization.Users;
using HelloLibrary.MultiTenancy;

namespace HelloLibrary.EntityFrameworkCore
{
    public class HelloLibraryDbContext : AbpZeroDbContext<Tenant, Role, User, HelloLibraryDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HelloLibraryDbContext(DbContextOptions<HelloLibraryDbContext> options)
            : base(options)
        {
        }
    }
}
