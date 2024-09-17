namespace UpdatingData
{
    public class Program
    {
        private static readonly PlutoEntities _context = new PlutoEntities();

        public static void Main()
        {
            //ChangeTracker see this as a new existing object.
            Course course = new Course()
            {
                Title = "Python",
                Description = "This is deep course about Python language.",
                FullPrice = 19,
                Level = 1,
                Author = new Author()
                {
                    AuthorID = 5,
                    Name = "Svetlin Nakov"
                }
            };
            _context.Courses.Add(course);
            _context.SaveChanges();
        }
    }
}
