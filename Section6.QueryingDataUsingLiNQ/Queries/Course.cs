using System.Collections.Generic;

namespace Queries
{
    /// <summary>
    /// Class <c>Course</c> create a new object with additional descriptive properties. 
    /// </summary>
    public class Course
    {
        /// <summary>
        /// Creata a new instance of Course object with Tags.
        /// </summary>
        public Course()
        {
            Tags = new HashSet<Tag>();
        }

        /// <summary>
        /// Gets or sets the Course Id.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the Level.
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// Gets or sets the Full Price.
        /// </summary>
        public float FullPrice { get; set; }
        /// <summary>
        /// Gets or sets the Author
        /// </summary>
        public virtual Author Author { get; set; }
        /// <summary>
        /// Gets or sets the Author Id
        /// </summary>
        public int AuthorId { get; set; }
        /// <summary>
        /// Gets or sets the Tags.
        /// </summary>
        public virtual ICollection<Tag> Tags { get; set; }
        /// <summary>
        /// Gets or sets Cover
        /// </summary>
        public Cover Cover { get; set; }
    }
}
