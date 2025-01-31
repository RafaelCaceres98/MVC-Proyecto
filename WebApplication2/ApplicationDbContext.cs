using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
    }
}
