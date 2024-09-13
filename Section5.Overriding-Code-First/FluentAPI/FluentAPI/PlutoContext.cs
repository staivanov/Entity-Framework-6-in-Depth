using System.Data.Entity;

namespace DataAnnotations
{
    public class PlutoContext : DbContext
    {
        /// <summary>
        /// Create a new instance of PlutoContext. 
        /// </summary>
        public PlutoContext()
            : base("name=PlutoContext")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
    }
}