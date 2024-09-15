using System.Data.Entity;

namespace CodeFirstDemo
{       
    /// <summary>
    /// Class <c>BlogDbContext</c> is an object representing the database "CodeFirstDemo".
    /// </summary>
    public class BlogDbContext : DbContext
    {
        /// <summary>
        /// Make a new instance of BlogDbContext.
        /// </summary>
        public BlogDbContext() { }

        /// <summary>
        /// Table Posts in the database "CodeFirstDemo".
        /// </summary>
        public DbSet<Post> Posts { get; set; }
    }
}
