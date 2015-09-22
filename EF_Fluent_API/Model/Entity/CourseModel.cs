using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Fluent_API.Model.Entity
{
    public class CourseModel
    {
        public CourseModel()
        {
            this.Instructors = new HashSet<InstructorModel>();
        }
        // Primary key 
        public int CourseID { get; set; }

        public string Title { get; set; }
        public int Credits { get; set; }

        // Foreign key 
        public int DepartmentID { get; set; }

        // Navigation properties        
        public virtual DepartmentModel Department { get; set; }
        public virtual ICollection<InstructorModel> Instructors { get; private set; }
    } 
}
