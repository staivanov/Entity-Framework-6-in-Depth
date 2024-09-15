using System.Linq;
using static System.Console;

namespace Section7.LoadingRelatedObjects
{
    public class Program
    {
        private static readonly Pluto_QueriesEntities _plutoContext = new Pluto_QueriesEntities();

        public static void Main()
        {
            PrintAllTagsForCourseId(5);

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
