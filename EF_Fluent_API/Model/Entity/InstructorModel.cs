using System.Collections.Generic;

namespace EF_Fluent_API.Model.Entity
{
    public class InstructorModel
    {
        public InstructorModel() 
        {
            this.Courses = new HashSet<CourseModel>();
        }
        
        // Primary key 
        public int InstructorID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public System.DateTime HireDate { get; set; }

        public int? InstructorCourseID { get; set; }

        // Navigation properties         
        public virtual ICollection<CourseModel> Courses { get; set; }
        public virtual OfficeAssignmentModel OfficeAssignment { get; set; }
    } 
}
