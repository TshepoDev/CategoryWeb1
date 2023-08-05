using CategoryWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CategoryWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

    }
}
