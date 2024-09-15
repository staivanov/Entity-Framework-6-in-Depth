using System;

namespace CodeFirstDemo
{
    /// <summary>
    /// Class <c>Post</c> create a new object with additional descriptive properties. 
    /// </summary>
    public class Post
    {
        /// <summary>
        /// Gets or sets the Post Id.
        /// </summary>
        public int PostId { get; set; }
        /// <summary>
        /// Gets or sets the Date Published time.
        /// </summary>
        public DateTime DatePublished { get; set; }
        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the Body.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Create a new instance of a Post object.
        /// </summary>
        public Post() { }

        /// <summary>
        /// Create a new instance of a Post object.
        /// </summary>
        /// <param name="postId">Post Id</param>
        /// <param name="datePublished">Time published</param>
        /// <param name="title">Post title</param>
        /// <param name="body">Post body</param>
        public Post(int postId, DateTime datePublished, string title, string body)
        {
            PostId = postId;
            DatePublished = datePublished;
            Title = title;
            Body = body;
        }
    }
}
