namespace DbFirst
{
    public class Program
    {
        private static readonly PlutoDbContext _context = new PlutoDbContext();

        public static void Main()
        {
            Course course = new Course();
            course.Level = (byte?)CourseLevel.Beginner;
        }
    }
}
