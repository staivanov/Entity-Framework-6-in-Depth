using System.Collections.Generic;

namespace Queries
{
    public class Author
    {
        /// <summary>
        /// Create a new instance of Author object with Courses.
        /// </summary>
        public Author()
        {
            Courses = new HashSet<Course>();
        }

        /// <summary>
        /// Gets or sets the id of the author.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the author.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the courses of the author.
        /// </summary>
        public virtual ICollection<Course> Courses { get; set; }
    }
}
