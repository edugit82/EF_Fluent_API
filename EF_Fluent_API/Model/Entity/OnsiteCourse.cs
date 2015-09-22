
namespace EF_Fluent_API.Model.Entity
{
    public partial class OnsiteCourse : CourseModel
    {
        public OnsiteCourse()
        {
            Details = new Details();
        }

        public Details Details { get; set; }
    } 
}
