using System.Collections.Generic;

namespace Section4.BuildingAModelUsingCodeFirst
{
    /// <summary>
    /// Class <c>Author</c> create a new object with additional descriptive properties. 
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Gets or sets the Author Id.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the Courses.
        /// </summary>
        public IList<Course> Courses { get; set; }
    }
}