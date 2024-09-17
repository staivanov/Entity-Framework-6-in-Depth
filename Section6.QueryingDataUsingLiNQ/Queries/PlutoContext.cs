using System.Data.Entity;
using Queries.EntityConfigurations;

namespace Queries
{
    /// <summary>
    /// Class <c>PlutoContext</c> is an object representing the database "Pluto_Queries".
    /// </summary>
    public class PlutoContext : DbContext
    {
        /// <summary>
        /// Create an instance of PlutoContext object with all available entities.
        /// </summary>
        public PlutoContext()
            : base("name=PlutoContext")
        {
        }

        /// <summary>
        /// Table Authors in the database "Pluto_Queries".
        /// </summary>
        public virtual DbSet<Author> Authors { get; set; }
        /// <summary>
        /// Table Courses in the database "Pluto_Queries".
        /// </summary>
        public virtual DbSet<Course> Courses { get; set; }
        /// <summary>
        /// Table Tags in the database "Pluto_Queries".
        /// </summary>
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CourseConfiguration());
        }
    }
}
