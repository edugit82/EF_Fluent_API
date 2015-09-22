using EF_Fluent_API.Model.Entity;
using EF_Fluent_API.Model.Mapping.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EF_Fluent_API.Model.Mapping.Context
{
    public class SchoolEntities : DbContext        
    {

        public SchoolEntities()
            : base("SchoolEntities")
        {
        
        }

        public DbSet<CourseModel> Courses { get; set; }
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<InstructorModel> Instructors { get; set; }
        public DbSet<OfficeAssignmentModel> OfficeAssignments { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure Code First to ignore PluralizingTableName convention 
            // If you keep this convention then the generated tables will have pluralized names. 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new DepartmentMap());
            modelBuilder.Configurations.Add(new CourseMap());
            modelBuilder.Configurations.Add(new InstructorMap());
            modelBuilder.Configurations.Add(new OfficeAssignmentMap());
            
            //one-to-many
            modelBuilder.Entity<InstructorModel>()
                   .HasMany<CourseModel>(s => s.Courses)
                   .WithMany(c => c.Instructors)
                   .Map(cs =>
                   {
                       cs.MapLeftKey("InstructorID");
                       cs.MapRightKey("CourseID");
                       cs.ToTable("dbo.InstructorCourse");
                   });
        }
    } 
}
