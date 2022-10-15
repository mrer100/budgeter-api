using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using coresolution.Authorization.Roles;
using coresolution.Authorization.Users;
using coresolution.MultiTenancy;

namespace coresolution.EntityFrameworkCore
{
    public class coresolutionDbContext : AbpZeroDbContext<Tenant, Role, User, coresolutionDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public coresolutionDbContext(DbContextOptions<coresolutionDbContext> options)
            : base(options)
        {
        }
    }
}
