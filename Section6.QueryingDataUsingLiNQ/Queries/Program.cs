using System;
using System.Linq;
using static System.Console;

namespace Queries
{
    public class Program
    {
        private readonly static PlutoContext _context = new PlutoContext();

        public static void Main()
        {
            string keyword = "c#";

            IOrderedQueryable<Course> cSharpCourses =
                from c in _context.Courses
                where c.Name.Contains(keyword)
                orderby c.Name
                select c;

            foreach (Course course in cSharpCourses)
            {
                WriteLine(course.Name);
            }

            IOrderedQueryable<Course> cSharpCoursesV2 = _context.Courses
                .Where(c => c.Name.Contains(keyword))
                .OrderBy(c => c.Name);


            WriteLine("Version 2 data that was quered.");

            foreach (Course course in cSharpCoursesV2)
            {
                WriteLine(course.Name);
            }
        }
    }
}
