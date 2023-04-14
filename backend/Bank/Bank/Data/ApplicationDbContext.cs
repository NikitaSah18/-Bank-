using Bank.Models;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Bank.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)

        {

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<View> Views { get; set; }
        public DbSet<Statement> Statements { get; set; }

         public DbSet<ChartNumber> ChartNumbers { get; set; }
         public DbSet<NumberOfContract> NumberOfContracts { get; set; }
         public DbSet<Employee> Employees { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}