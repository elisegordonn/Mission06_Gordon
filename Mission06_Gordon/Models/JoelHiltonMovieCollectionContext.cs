using Microsoft.EntityFrameworkCore;

namespace Mission06_Gordon.Models
{
    public class JoelHiltonMovieCollectionContext : DbContext // liaison from the app to the database
    {
        public JoelHiltonMovieCollectionContext(DbContextOptions<JoelHiltonMovieCollectionContext> options) : base (options) //constructor
        {
        }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Categories> Categories { get; set; }

    }
}
