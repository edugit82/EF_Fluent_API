using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Fluent_API.Model.Entity
{
    public class OfficeAssignmentModel
    {        
        
        // Specifying InstructorID as a primary 
        [Key, ForeignKey("Instructor")]
        public Int32 InstructorID { get; set; }

        public string Location { get; set; }

        // When the Entity Framework sees Timestamp attribute 
        // it configures ConcurrencyCheck and DatabaseGeneratedPattern=Computed. 
        [Timestamp]
        public Byte[] Timestamp { get; set; }

        // Navigation property 
        public virtual InstructorModel Instructor { get; set; }
    }
}
