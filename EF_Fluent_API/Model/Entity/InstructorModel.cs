using System.Collections.Generic;

namespace EF_Fluent_API.Model.Entity
{
    public class InstructorModel
    {
        public InstructorModel()
        {
            this.Courses = new List<CourseModel>();
        }

        // Primary key 
        public int InstructorID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public System.DateTime HireDate { get; set; }

        // Navigation properties         
        public virtual OfficeAssignmentModel OfficeAssignment { get; set; }
        public virtual ICollection<CourseModel> Courses { get; private set; }
    } 
}
