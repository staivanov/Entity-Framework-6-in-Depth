using System.Data.Entity;

namespace Section4.OverridingCodeFirst
{
    public partial class PlutoModel : DbContext
    {
        public PlutoModel()
            : base("name=PlutoModel")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>()
                .HasMany(e => e.Courses)
                .WithOptional(e => e.Authors)
                .HasForeignKey(e => e.Author_Id);

            modelBuilder.Entity<Courses>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Courses)
                .Map(m => m.ToTable("TagCourses").MapLeftKey("Course_Id").MapRightKey("Tag_Id"));
        }
    }
}
