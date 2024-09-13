namespace Section4.OverridingCodeFirst
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Courses")]
    public partial class Courses
    {
        /// <summary>
        /// Create a new instance of Course object with Tags.
        /// </summary>
        public Courses()
        {
            Tags = new HashSet<Tags>();
        }
        /// <summary>
        /// Gets or sets the id of the course. 
        /// </summary>
        public int Id { get; set; }

        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the course.
        /// </summary>
        [Required]
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
        /// Gets or sets the author foreign key.
        /// </summary>
        public int? Author_Id { get; set; }
        /// <summary>
        /// Gets or sets the author of the course.
        /// </summary>
        public virtual Authors Authors { get; set; }

        /// <summary>
        /// Gets or sets the tags of the course.
        /// </summary>
        public virtual ICollection<Tags> Tags { get; set; }
    }
}
