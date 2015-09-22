using EF_Fluent_API.Model.Entity;
using System.Data.Entity.ModelConfiguration;

namespace EF_Fluent_API.Model.Mapping.Configuration
{
    public class OfficeAssignmentMap : EntityTypeConfiguration<OfficeAssignmentModel>
    {
        public OfficeAssignmentMap()
            :base()
        {
            HasKey(d => d.InstructorID);

            Property(p => p.Location).HasColumnName("Location");
            Property(p => p.Timestamp).HasColumnName("Timestamp");

            HasOptional(p => p.Instructor)
            .WithRequired(p => p.OfficeAssignment);

            ToTable("dbo.OfficeAssignment");           
        }
    }
}
