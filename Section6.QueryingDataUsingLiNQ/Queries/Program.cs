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
            int courseLevel = 1;

            //Restriction
            IQueryable<Course> coursesWithLevel =
                from c in _context.Courses
                where c.Level == courseLevel
                select c;

            //Ordering
            IOrderedQueryable<Course> orderedCourses =
                from c in _context.Courses
                where c.Level == courseLevel
                orderby c.Level ascending
                select c;

            //Grouping
            IQueryable<IGrouping<int, Course>> groupedCourses =
                from c in _context.Courses
                group c by c.Level
                into g
                select g;

            //Joins
            var query =
                from c in _context.Courses
                join a in _context.Authors on c.AuthorId equals a.Id
                select new
                {
                    CourseName = c.Name,
                    AuthorName = a.Name
                };

            //Restriction plus ordering
            IQueryable<Course> coursesWithLevelv2 = _context.Courses
                .Where(c => c.Level == courseLevel)
                .OrderBy(o => o.Level);

            //Projection
            IQueryable<Tag> tags = _context.Courses
                .Where(c => c.Level == courseLevel)
                .OrderByDescending(c => c.Name)
                .ThenByDescending(c => c.Level)
                .SelectMany(c => c.Tags);

            //Set operations
            IQueryable<Tag> tagsV2 = _context.Courses
                .Where(c => c.Level == courseLevel)
                .OrderByDescending(c => c.Name)
                .ThenByDescending(c => c.Level)
                .SelectMany(c => c.Tags)
                .Distinct();

            IQueryable<IGrouping<int, Course>> groups = _context.Courses
                    .GroupBy(c => c.Level);

            foreach (var group in groups)
            {
                WriteLine("Key: " + group.Key);

                foreach (var course in group)
                {
                    WriteLine("\t" + course.Name);
                }
            }
        }
    }
}
