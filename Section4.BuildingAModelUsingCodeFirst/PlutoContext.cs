using Section4.BuildingAModelUsingCodeFirst;
using System.Data.Entity;

namespace CodeFirst
{
    /// <summary>
    /// Class <c>PlutoContext</c> is an object representing the database "PlutoFirstDb".
    /// </summary>
    public class PlutoContext : DbContext
    {
        /// <summary>
        /// Table Courses in the database "PlutoFirstDb".
        /// </summary>
        public DbSet<Course> Courses { get; set; }
        /// <summary>
        /// Table Authors in the database "PlutoFirstDb".
        /// </summary>
        public DbSet<Author> Authors { get; set; }
        /// <summary>
        /// Table Tags in the database "PlutoFirstDb".
        /// </summary>
        public DbSet<Tag> Tags { get; set; }
        /// <summary>
        /// Table Categories in the database "PlutoFirstDb".
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        public PlutoContext()
            : base("name=DefaultConnection")
        {
            
        }
    }
}
