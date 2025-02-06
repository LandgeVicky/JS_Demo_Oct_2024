using Crud_Operation_MVC_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_Operation_MVC_Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

    }
}
