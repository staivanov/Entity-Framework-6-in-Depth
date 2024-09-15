using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using static System.Console;

namespace Section7.LoadingRelatedObjects
{
    public class Program
    {
        private static readonly Pluto_QueriesEntities _plutoContext = new Pluto_QueriesEntities();

        public static void Main()
        {
            //Demo for Explicit Loading.
            LoadAllCoursesByAuthorId(1);

        }


        /// <summary>
        /// Gets all existing courses by the given author id.
        /// </summary>
        /// <param name="authorId"></param>
        /// <returns></returns>
        private static void LoadAllCoursesByAuthorId(int authorId)
        {   
            Author author = _plutoContext.Authors
                .FirstOrDefault(a => a.Id == authorId);

             _plutoContext.Courses.Where(a => a.AuthorId == author.Id).Load();
        }

        /// <summary>
        /// Prints every course in the given db with his author name with Eager Loading.
        /// </summary>
        private static void PrintEveryCourseWithHisAuthorNameEagerLoading()
        {
            string author = "Author";
            List<Course> courses = _plutoContext.Courses.Include(author).ToList();

            foreach (Course course in courses)
            {
                WriteLine($"{course.Name} by {course.Author.Name}");
            }
        }

        /// <summary>
        /// Prints every course in the given db with his author name.
        /// </summary>
        private static void PrintEveryCourseWithHisAuthorName()
        {   //N+1 problem demo.
            List<Course> courses = _plutoContext.Courses.ToList();

            foreach (Course course in courses)
            {
                WriteLine($"{course.Name} by {course.Author.Name}");
            }
        }

        /// <summary>
        /// Prints all tags for certain course by his id.
        /// </summary>
        /// <param name="courseId"></param>
        private static void PrintAllTagsForCourseId(int courseId)
        {
            Course course = _plutoContext.Courses.Single(c => c.Id == courseId);

            //Lazy loading Tags.
            foreach (Tag tag in course.Tags)
            {
                WriteLine(tag.Name);
            }
        }
    }
}
