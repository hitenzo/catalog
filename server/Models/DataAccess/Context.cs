using Microsoft.EntityFrameworkCore;
using server.Models.Entities;

namespace server.Models.DataAccess
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}