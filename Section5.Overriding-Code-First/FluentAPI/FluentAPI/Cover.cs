using DataAnnotations;

namespace FluentAPI
{
    public class Cover
    {
        /// <summary>
        /// Gets or sets the id of the cover.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets navigation property the course of the cover.
        /// </summary>
        public Course Course { get; internal set; }
    }
}
