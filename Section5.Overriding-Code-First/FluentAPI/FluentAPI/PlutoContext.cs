using FluentAPI.EntityConfigurations;
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
        /// <summary>
        /// Table Authors in the Database Pluto_FluentAPI.
        /// </summary>
        public virtual DbSet<Author> Authors { get; set; }
        /// <summary>
        /// Table Courses in the Database Pluto_FluentAPI.
        /// </summary>
        public virtual DbSet<Course> Courses { get; set; }
        /// <summary>
        /// Table Tags in the Database Pluto_FluentAPI.
        /// </summary>
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CourseConfiguration());
        }
    }
}