using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Section7.LoadingRelatedObjects
{
    public class Program
    {
        private static readonly Pluto_QueriesEntities _plutoContext = new Pluto_QueriesEntities();

        public static void Main()
        {
            PrintEveryCourseWithHisAuthorName();


            

        }

        /// <summary>
        /// Print every course in the given db with his author name.
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
        /// Print all tags for certain course by his id.
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
