using Microsoft.EntityFrameworkCore;

namespace Mission06_Gordon.Models
{
    public class FilmCollectionContext : DbContext
    {
        public FilmCollectionContext(DbContextOptions<FilmCollectionContext> options) : base (options) //constructor
        {
        }
        public DbSet<Form> Forms { get; set; }
    }
}
