using System.Data.Entity;

namespace DataAnnotations
{
    public class PlutoContext : DbContext
    {
        /// <summary>
        /// Create a new instance of PlutoContext. 
        /// </summary>
        public PlutoContext()
            : base("name=PlutoContext")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                        .Property(c => c.Name)
                        .IsRequired()
                        .HasMaxLength(50);

            modelBuilder.Entity<Course>()
                        .Property(d => d.Description)
                        .IsRequired()
                        .HasMaxLength(2000);

            modelBuilder.Entity<Course>()
                .HasRequired(c => c.Author)
                .WithMany(a => a.Courses)
                .HasForeignKey(c => c.AuthorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(t => t.Tags)
                .WithMany(c => c.Courses)
                .Map(m => m.ToTable("CourseTags"));

            base.OnModelCreating(modelBuilder);
        }
    }
}