using Bokregister_API_Oskar.Models;
using Microsoft.EntityFrameworkCore;

namespace Bokregister_API_Oskar.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
