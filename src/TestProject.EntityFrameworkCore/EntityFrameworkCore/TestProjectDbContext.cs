using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TestProject.Authorization.Roles;
using TestProject.Authorization.Users;
using TestProject.MultiTenancy;
using TestProject.Products;

namespace TestProject.EntityFrameworkCore
{
    public class TestProjectDbContext : AbpZeroDbContext<Tenant, Role, User, TestProjectDbContext>
    {
        public DbSet<Product> Products { get; set; }
        /* Define a DbSet for each entity of the application */
        
        public TestProjectDbContext(DbContextOptions<TestProjectDbContext> options)
            : base(options)
        {
        }
    }
}
