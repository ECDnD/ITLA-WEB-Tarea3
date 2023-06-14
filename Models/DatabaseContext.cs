using Microsoft.EntityFrameworkCore;

namespace Tarea3.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }

        public DbSet<Reportes> Reportes { get; set; }
    }
}