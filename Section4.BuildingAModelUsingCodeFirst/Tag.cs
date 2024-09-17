using System.Collections.Generic;

namespace Section4.BuildingAModelUsingCodeFirst
{
    /// <summary>
    /// Class <c>Tag</c> create a new object with additional descriptive properties. 
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// Gets or sets the Tag Id.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets Courses.
        /// </summary>
        public IList<Course> Courses { get; set; }
    }
}