﻿using System.Collections.Generic;

namespace DataAnnotations
{
    public class Course
    {
        /// <summary>
        /// Create a new instance of Course object with Tags.
        /// </summary>
        public Course()
        {
            Tags = new HashSet<Tag>();
        }

        /// <summary>
        /// Gets or sets the id of the course. 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the course.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the course.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the level of the course.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Gets or sets the fullprice of the course.
        /// </summary>
        public float FullPrice { get; set; }

        /// <summary>
        /// Gets or sets the author of the course.
        /// </summary>
        public virtual Author Author { get; set; }


        /// <summary>
        /// Gets or sets the author foreign key.
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the tags of the course.
        /// </summary>
        public virtual ICollection<Tag> Tags { get; set; }
    }
}