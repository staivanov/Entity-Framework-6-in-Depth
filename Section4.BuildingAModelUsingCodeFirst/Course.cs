using CodeFirst;
using System;
using System.Collections.Generic;

namespace Section4.BuildingAModelUsingCodeFirst
{
    /// <summary>
    /// Class <c>Course</c> create a new object with additional descriptive properties. 
    /// </summary>
    public class Course
    {
        /// <summary>
        /// Gets or sets the Course Id.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the Level.
        /// </summary>
        public CourseLevel Level { get; set; }
        /// <summary>
        /// Gets or sets the Full Price.
        /// </summary>
        public float FullPrice { get; set; }
        /// <summary>
        /// Gets or sets the Author
        /// </summary>
        public Author Author { get; set; }
        /// <summary>
        /// Gets or sets the Tags.
        /// </summary>
        public IList<Tag> Tags { get; set; }
    }
}
