using System.Collections.Generic;

namespace DataAnnotations
{
    public class Tag
    {
        /// <summary>
        /// Create a new instance of Tag object with Courses.
        /// </summary>
        public Tag()
        {
            Courses = new HashSet<Course>();
        }

        /// <summary>
        /// Gets or sets the id of the tag.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the tag.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the courses of the tag.
        /// </summary>
        public virtual ICollection<Course> Courses { get; set; }
    }
}