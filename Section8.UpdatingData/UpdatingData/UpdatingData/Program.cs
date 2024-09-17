namespace UpdatingData
{
    public class Program
    {
        private static readonly PlutoEntities _context = new PlutoEntities();

        public static void Main()
        {
            Author author = _context.Authors.Find(3);
            _context.Authors.Remove(author);
            _context.SaveChanges();
        }
    }
}
