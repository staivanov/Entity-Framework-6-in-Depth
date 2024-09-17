using System.Collections.Generic;

namespace Queries
{
    /// <summary>
    /// Class <c>Tag</c> create a new object with additional descriptive properties. 
    /// </summary>
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
        /// Gets or sets Id.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets Courses.
        /// </summary>
        public virtual ICollection<Course> Courses { get; set; }
    }
}
