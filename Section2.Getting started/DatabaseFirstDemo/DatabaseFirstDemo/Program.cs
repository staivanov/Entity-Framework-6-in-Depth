
using System;

namespace DatabaseFirstDemo
{
    public class Program
    {
        private static DbFirstDemoEntities _context = new DbFirstDemoEntities();

        public static void Main()
        {
            Post latestNewsInGaza = new Post()
            {
                PostId = 1,
                Title = "Israeli forces killed 30 Palestinians",
                Body = "The ministry of health has said that since Wednesday," +
                " Israeli soldiers have killed" +
                " 30 people in the occupied West Bank and" +
                " injured at least 130 others.",
                DatePublished = DateTime.Now,
            };
            InsertNewPost(latestNewsInGaza);


        }

        private static void InsertNewPost(Post newPost)
        {
            Post post = new Post()
            {
                PostId = newPost.PostId,
                Title = newPost.Title,
                Body = newPost.Body,
                DatePublished = newPost.DatePublished
            };

            _context.Posts.Add(post);
            _context.SaveChanges();
       }
    }
}
