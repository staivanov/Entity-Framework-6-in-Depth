using DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FluentAPI.EntityConfigurations
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        /// <summary>
        /// Configuration instance for Course entity.
        /// </summary>
        public CourseConfiguration()
        {
            ToTable("tbl_Course");

            HasKey(c => c.Id);

            Property(d => d.Description)
            .IsRequired()
            .HasMaxLength(2000);

            Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(50);

            HasRequired(c => c.Author)
            .WithMany(a => a.Courses)
            .HasForeignKey(c => c.AuthorId)
            .WillCascadeOnDelete(false);

            HasRequired(c => c.Cover)
            .WithRequiredPrincipal(c => c.Course);

            HasMany(t => t.Tags)
            .WithMany(c => c.Courses)
            .Map(m =>
                {
                    m.ToTable("CourseTags");
                    m.MapLeftKey("Course_Id");
                    m.MapRightKey("Tag_Id");
                }
            );
        }
    }
}

