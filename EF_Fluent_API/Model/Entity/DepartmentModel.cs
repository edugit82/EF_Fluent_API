using System.Collections.Generic;

namespace EF_Fluent_API.Model.Entity
{
    public class DepartmentModel
    {
        public DepartmentModel()
        {
            this.Courses = new HashSet<CourseModel>();
        }
        // Primary key 
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public System.DateTime StartDate { get; set; }
        public int? Administrator { get; set; }

        // Navigation property 
        public virtual ICollection<CourseModel> Courses { get; private set; }
    } 
}
