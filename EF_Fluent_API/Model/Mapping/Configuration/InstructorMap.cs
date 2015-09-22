using EF_Fluent_API.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EF_Fluent_API.Model.Mapping.Configuration
{
    public class InstructorMap : EntityTypeConfiguration<InstructorModel>
    {
        public InstructorMap()
            :base()
        {
            HasKey(d => d.InstructorID);

            Property(p => p.InstructorID).
            HasColumnName("InstructorID").
            HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).
            IsRequired();

            Property(p => p.LastName).HasColumnName("LastName");
            Property(p => p.FirstName).HasColumnName("FirstName");
            Property(p => p.HireDate).HasColumnName("HireDate");

            //One-to-Zero-or-One
            HasOptional(p => p.OfficeAssignment)
           .WithRequired(p => p.Instructor);

            //Many-to-Many
            HasMany<CourseModel>(p => p.Courses)
           .WithMany(p => p.Instructors)
           .Map(p =>
             {
                 p.MapLeftKey("InstrutorID");
                 p.MapRightKey("CourseID");
                 p.ToTable("InstrutorCourse");
             });            

            ToTable("dbo.Instructor");
        }
    }
}
