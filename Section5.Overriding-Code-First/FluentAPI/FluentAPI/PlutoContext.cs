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
        /// <summary>
        /// Table Authors in the Database Pluto_FluentAPI.
        /// </summary>
        public virtual DbSet<Author> Authors { get; set; }
        /// <summary>
        /// Table Courses in the Database Pluto_FluentAPI.
        /// </summary>
        public virtual DbSet<Course> Courses { get; set; }
        /// <summary>
        /// Table Tags in the Database Pluto_FluentAPI.
        /// </summary>
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
                .Map(m =>
                    {
                        m.ToTable("CourseTags");
                        m.MapLeftKey("Course_Id");
                        m.MapRightKey("Tag_Id");
                    }
                );

            modelBuilder.Entity<Course>()
              .HasRequired(c => c.Cover)
              .WithRequiredPrincipal(c => c.Course);



            base.OnModelCreating(modelBuilder);
        }
    }
}