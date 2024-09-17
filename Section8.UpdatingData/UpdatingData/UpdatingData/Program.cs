using System.Linq;

namespace UpdatingData
{
    public class Program
    {
        private static readonly PlutoEntities _context = new PlutoEntities();

        public static void Main()
        {
            Author author = _context.Authors.Include("Courses")
                .FirstOrDefault(a => a.AuthorID == 1);
            _context.Courses.RemoveRange(author.Courses);
            _context.Authors.Remove(author);
            _context.SaveChanges();
        }
    }
}
