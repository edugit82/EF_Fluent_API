using EF_Fluent_API.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EF_Fluent_API.Model.Mapping.Configuration
{
    public class CourseMap : EntityTypeConfiguration<CourseModel>
    {
        public CourseMap()
            : base()
        {
            HasKey(d => d.CourseID);

            Property(p => p.CourseID).
            HasColumnName("CourseID").
            HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).
            IsRequired();

            Property(p => p.Title).HasColumnName("Title");
            Property(p => p.Credits).HasColumnName("Credits");
            Property(p => p.DepartmentID).HasColumnName("DepartmentID");

            //one-to-many
            HasOptional(p => p.Department)
            .WithMany(p => p.Courses)
            .HasForeignKey(p => p.DepartmentID);            

           ToTable("dbo.Course");

        }
    }
}
