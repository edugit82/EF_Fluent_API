using EF_Fluent_API.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EF_Fluent_API.Model.Mapping.Configuration
{
    public class DepartmentMap : EntityTypeConfiguration<DepartmentModel>
    {
        public DepartmentMap() 
            :base()
        {
            HasKey(d => new { d.DepartmentID, d.Name }); 

            Property(p => p.DepartmentID).
            HasColumnName("DepartmentID").
            HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).
            IsRequired();

            Property(p => p.Name).HasColumnName("Name");
            Property(p => p.Budget).HasColumnName("Budget");
            Property(p => p.StartDate).HasColumnName("StartDate");
            Property(p => p.Administrator).HasColumnName("Administrator");            
            
            ToTable("dbo.Department");
        }
    }
}
