using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using static System.Console;

namespace DbFirst
{
    public class Program
    {
        private static readonly PlutoDbContext _context = new PlutoDbContext();

        public static void Main()
        {
            Course course = new Course();
            course.Level = CourseLevel.Beginner;



        }
    }
}
