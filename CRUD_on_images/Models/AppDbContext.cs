using Microsoft.EntityFrameworkCore;

namespace CRUD_on_images.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<Speaker>? Speakers { get; set; }
    }
}
