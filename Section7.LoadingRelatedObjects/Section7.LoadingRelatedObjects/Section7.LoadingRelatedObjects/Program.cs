using System.Linq;
using static System.Console;

namespace Section7.LoadingRelatedObjects
{
    public class Program
    {
        private static readonly Pluto_QueriesEntities _plutoContext = new Pluto_QueriesEntities();

        public static void Main()
        {
            Course course = _plutoContext.Courses.Single(c => c.Id == 2);

            //Lazy loading Tags.
            foreach (Tag tag in course.Tags)
            {
              WriteLine(tag.Name);
            }
        }
    }
}
